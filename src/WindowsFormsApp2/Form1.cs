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
        Running,
        Finished
    }

    public partial class Form1 : Form
    {
        private InputUtils inputUtils;
        private VisualizeState visualizeState;
        private readonly Dictionary<VisualizeState, string> searchButtonText =
            new()
        {
                {VisualizeState.Normal, "Search!" },
                {VisualizeState.Running, "Wait..." },
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

            waitTime = 5000;
            SpeedBar.TickStyle = TickStyle.None;
        }


        // memilih file dan menampilkan visualisasinya
        private void visualize_button_Click(object sender, EventArgs e)
        {
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    inputUtils = null;
                }




            }
        }
        private Thread StartVisualize(List<Pair<int, int>> searchPath, string directPath = "")
        {
            var visThread = new Thread(() => Visualize(searchPath, directPath));
            visThread.Start();
            return visThread;
        }
        private void Visualize(List<Pair<int, int>> searchPath, string directPath = "")
        {
            // visualize search path with trail
            for (int i = 0; i < searchPath.Count; i++)
            {
                var pos = searchPath[i];
                var prevPos = i < 1 ? null : searchPath[i - 1];
                var fivePrevPos = i < 5 ? null : searchPath[i - 5];
                dataGridView1.Rows[pos.first].Cells[pos.second].Style.BackColor =
                    GridColor.ColorList["SearchHead"];
                if (prevPos != null)
                {
                    dataGridView1.Rows[prevPos.first].Cells[prevPos.second].Style.BackColor =
                        GridColor.ColorList["SearchTrailFive"];
                }
                if (fivePrevPos != null)
                {
                    dataGridView1.Rows[fivePrevPos.first].Cells[fivePrevPos.second].Style.BackColor =
                        GridColor.ColorList["SearchTrailElse"];
                }
                Thread.CurrentThread.Join(waitTime);
            }


            Pair<int, int> position = inputUtils.startCoordinate;
            dataGridView1.Rows[position.first].Cells[position.second].Style.BackColor = GridColor.ColorList["PathHead"];
            var prevColor = GridColor.ColorList["Default"];


            foreach (char c in directPath)
            {
                // change previous position color
                dataGridView1.Rows[position.first].Cells[position.second].Style.BackColor = GridColor.NextColor(prevColor);

                position += TraverseRule.moveDirection[c.ToString()];
                // record current color; then change it
                prevColor = dataGridView1.Rows[position.first].Cells[position.second].Style.BackColor;
                dataGridView1.Rows[position.first].Cells[position.second].Style.BackColor = GridColor.ColorList["PathHead"];
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
                    dataGridView1.ReadOnly = false;
                    break;
                case VisualizeState.Running:
                    dataGridView1.ReadOnly = true;
                    break;
                case VisualizeState.Finished:
                    dataGridView1.ReadOnly = true;
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
                        if (dfsButton.Checked)
                        {
                            DFS dfs = new DFS(inputUtils);
                            var watch = new Stopwatch();
                            watch.Start();
                            var result = dfs.Solve();
                            watch.Stop();

                            execution_time_ans_label.Text = watch.ElapsedMilliseconds + " ms";

                            // TODO move visualize outside if to reduce redundancy

                            visualizeState = VisualizeState.Running;
                            RefreshVisualizeState();

                            var visThread = StartVisualize(result.Item1, result.Item2);
                        }
                        else if (bfsButton.Checked)
                        {

                        }
                        else
                        {
                            throw new Exception("No button checked");
                        }
                        break;
                    case VisualizeState.Running:
                        break;
                    case VisualizeState.Finished:
                        visualizeState = VisualizeState.Normal;
                        RefreshVisualizeState();

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                cell.Style.BackColor = GridColor.ColorList["Default"];
                            }
                        }

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
