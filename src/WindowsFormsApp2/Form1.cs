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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BFS_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            DFS_checkbox.Checked = false;
        }

        private void DFS_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            BFS_checkbox.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        // memilih file dan menampilkan visualisasinya
        private void visualize_button_Click(object sender, EventArgs e)
        {
            // object OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // default file extension and filter
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";

            // menampilkan OpenFileDialog box
            DialogResult result = openFileDialog1.ShowDialog();

            // memproses respons pengguna
            if (result == DialogResult.OK)
            {
                // Mendapatkan path file yang dipilih
                string filePath = openFileDialog1.FileName;
             

                // Membaca isi file menjadi array string
                string[] lines = File.ReadAllLines(filePath);

                // Memecah setiap baris menjadi nilai-nilai individu dan menambahkannya ke DataTable
                DataTable dt = new DataTable();

                // Menambahkan Column pada DataTable
                string[] firstRow = lines[0].Split(' ');
                for (int i = 0; i < firstRow.Length; i++)
                {
                    dt.Columns.Add("Column " + (i + 1));
                }
                // Menambahkan Row pada DataTable
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(' ');
                    DataRow row = dt.NewRow();
                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j];
                    }
                    dt.Rows.Add(row);
                }

                // Mengatur visualisasi DataTable
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);

                int cellSize = 50;
                dataGridView1.RowTemplate.Height = cellSize;
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.Width = cellSize;
                }

                // Menampilkan DataTable
                dataGridView1.DataSource = dt;
                txt_label.Text = Path.GetFileName(filePath);
            }
        }

    }
}
