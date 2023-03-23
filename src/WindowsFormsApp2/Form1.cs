using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public enum VisualizeState
    {
        Normal,
        Traverse,
        TraverseFinish,
        ShowingResult,
        Finished
    }

    public partial class Form1 : Form
    {
        private InputUtils inputUtils;
        private VisualizeState visualizeState;
        private (List<(PathAction, Pair<int, int>)>, string, int, int) result;

        private readonly Dictionary<VisualizeState, string> searchButtonText =
            new()
        {
                {VisualizeState.Normal, "Search!" },
                {VisualizeState.Traverse, "Wait..." },
                {VisualizeState.TraverseFinish, "Show Path!" },
                {VisualizeState.ShowingResult, "Wait..." },
                {VisualizeState.Finished, "Clear" }
        };

        private int waitTime = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputUtils = null;
            visualizeState = VisualizeState.Normal;

            dataGridView1.DoubleBuffered(true);
            dataGridView1.ReadOnly = true;

            waitTime = 5000;
            SpeedBar.TickStyle = TickStyle.None;
        }


        // memilih file dan menampilkan visualisasinya
        private void visualize_button_Click(object sender, EventArgs e)
        {
            // check state
            if (visualizeState == VisualizeState.Traverse || visualizeState == VisualizeState.ShowingResult)
            {
                MessageBox.Show("Wait for current process to finish");
                return;
            }
            // object OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // default file extension and filter
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.InitialDirectory = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\..");

            // menampilkan OpenFileDialog box
            DialogResult result = openFileDialog1.ShowDialog();

            // memproses respons pengguna
            if (result == DialogResult.OK)
            {
                // Mendapatkan path file yang dipilih
                string filePath = openFileDialog1.FileName;
                try
                {
                    inputUtils = new InputUtils(filePath);

                    // Memecah setiap baris menjadi nilai-nilai individu dan menambahkannya ke DataTable
                    DataTable dt = new DataTable();

                    // Menambahkan Column pada DataTable
                    string[] firstRow = inputUtils.lines[0].Split(' ');
                    for (int i = 0; i < firstRow.Length; i++)
                    {
                        dt.Columns.Add("Column " + (i + 1));
                    }
                    // Menambahkan Row pada DataTable
                    for (int i = 0; i < inputUtils.lines.Length; i++)
                    {
                        string[] values = inputUtils.lines[i].Trim().Split(' ');
                        DataRow row = dt.NewRow();
                        for (int j = 0; j < values.Length; j++)
                        {
                            row[j] = values[j];
                        }


                        dt.Rows.Add(row);
                    }

                    // Mengatur visualisasi DataTable
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                    dataGridView1.ColumnHeadersVisible = false;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);


                    // resize dataTable
                    int cellSize = 20;
                    dataGridView1.RowTemplate.MinimumHeight = cellSize;

                    // Menampilkan DataTable
                    dataGridView1.DataSource = dt;
                    txt_label.Text = Path.GetFileName(filePath);

                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        col.MinimumWidth = cellSize;
                    }

                    ResetDGVColor();
                    visualizeState = VisualizeState.Normal;
                    RefreshVisualizeState();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    inputUtils = null;
                }




            }
        }
        private Thread StartVisualize(List<(PathAction, Pair<int, int>)> searchPath)
        {
            var visThread = new Thread(() => Visualize(searchPath));
            visThread.Start();
            return visThread;
        }
        private void Visualize(List<(PathAction, Pair<int, int>)> searchPath)
        {
            // visualize search path with trail
            foreach (var itr in searchPath)
            {
                switch (itr.Item1)
                {
                    case PathAction.ProcessStart:
                        dataGridView1.Rows[itr.Item2.first].Cells[itr.Item2.second].Style.BackColor =
                            GridColor.Processing;
                        break;
                    case PathAction.ProcessFinish:
                        dataGridView1.Rows[itr.Item2.first].Cells[itr.Item2.second].Style.BackColor =
                            GridColor.ProcessFinished;
                        break;
                    case PathAction.Reset:
                        ResetDGVColor();
                        break;
                }
                Thread.CurrentThread.Join(waitTime);
            }

            visualizeState = VisualizeState.TraverseFinish;
            this.Invoke(RefreshVisualizeState);
        }
        private Thread StartVisualizePath(string directPath)
        {
            var visThread = new Thread(() => VisualizePath(directPath));
            visThread.Start();
            return visThread;
        }
        private void VisualizePath(string directPath)
        {
            ResetDGVColor();
            Pair<int, int> position = inputUtils.startCoordinate;
            dataGridView1.Rows[position.first].Cells[position.second].Style.BackColor = GridColor.PathHead;
            var prevColor = GridColor.Default;


            foreach (char c in directPath)
            {
                // change previous position color
                dataGridView1.Rows[position.first].Cells[position.second].Style.BackColor = GridColor.NextColor(prevColor);

                position += TraverseRule.moveDirection[c.ToString()];
                // record current color; then change it
                prevColor = dataGridView1.Rows[position.first].Cells[position.second].Style.BackColor;
                dataGridView1.Rows[position.first].Cells[position.second].Style.BackColor = GridColor.PathHead;
                Thread.CurrentThread.Join(waitTime);
            }
            // change last grid color
            dataGridView1.Rows[position.first].Cells[position.second].Style.BackColor = GridColor.NextColor(prevColor);

            visualizeState = VisualizeState.Finished;
            this.Invoke(RefreshVisualizeState);
        }
        private void RefreshVisualizeState()
        {
            search_button.Text = searchButtonText[visualizeState];
            switch (visualizeState)
            {
                case VisualizeState.Normal:
                    ResetDGVColor();
                    algorithm_panel.Enabled = true;
                    break;
                case VisualizeState.Traverse:
                    algorithm_panel.Enabled = false;
                    break;
                case VisualizeState.TraverseFinish:
                    algorithm_panel.Enabled = false;
                    break;
                case VisualizeState.ShowingResult:
                    algorithm_panel.Enabled = false;
                    break;
                case VisualizeState.Finished:
                    algorithm_panel.Enabled = false;
                    break;
            }
        }
        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                switch (visualizeState)
                {
                    case VisualizeState.Normal:
                        inputUtils = new InputUtils((DataTable)dataGridView1.DataSource);
                        var watch = new Stopwatch();
                        watch.Start();
                        if (dfsButton.Checked)
                        {
                            DFS dfs = new DFS(inputUtils);
                            result = dfs.Solve();
                        }
                        else if (bfsButton.Checked)
                        {
                            BFS bfs = new BFS(inputUtils);
                            result = bfs.Solve();
                        }
                        else if (tspButton.Checked)
                        {

                        }
                        else
                        {
                            throw new Exception("No button checked");
                        }
                        watch.Stop();
                        execution_time_ans_label.Text = watch.ElapsedMilliseconds + " ms";
                        nodes_ans_label.Text = result.Item3.ToString();
                        steps_ans_label.Text = result.Item4.ToString();

                        if (dfsButton.Checked || bfsButton.Checked)
                        {
                            var visThread = StartVisualize(result.Item1);
                            visualizeState = VisualizeState.Traverse;
                            RefreshVisualizeState();
                        }
                        else if (tspButton.Checked)
                        {
                            StartVisualizePath(result.Item2);
                            visualizeState = VisualizeState.ShowingResult;
                            RefreshVisualizeState();
                        }


                        break;
                    case VisualizeState.Traverse:
                        break;
                    case VisualizeState.TraverseFinish:
                        var visPathThread = StartVisualizePath(result.Item2);
                        visualizeState = VisualizeState.ShowingResult;
                        RefreshVisualizeState();
                        break;
                    case VisualizeState.ShowingResult:
                        break;
                    case VisualizeState.Finished:
                        visualizeState = VisualizeState.Normal;
                        RefreshVisualizeState();

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ResetDGVColor()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString() == "X")
                        cell.Style.BackColor = GridColor.Obstacle;
                    else if (cell.Value != null && cell.Value.ToString() == "K")
                        cell.Style.BackColor = GridColor.KrustyKrab;
                    else
                        cell.Style.BackColor = GridColor.Default;
                }
            }
        }

        private void SpeedBar_Scroll(object sender, EventArgs e)
        {
            if (SpeedBar.Value == SpeedBar.Maximum)
            {
                SpeedLabel.Text = "Max speed";
                waitTime = 0;
            }
            else
            {
                SpeedLabel.Text = ((float)(1 + SpeedBar.Value) / 5) + "/second";
                waitTime = 5000 / (1 + SpeedBar.Value);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
