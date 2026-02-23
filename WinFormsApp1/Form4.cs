using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CbA.Items.AddRange(new string[] {
                "2x2", "2x3", "3x2", "3x3"
            });

            CbB.Items.AddRange(new string[] {
                "2x2", "2x3", "3x2", "3x3"
            });

            CbA.SelectedIndex = 0;
            CbB.SelectedIndex = 0;
        }

        // ===============================
        // GENERATE MATRIX
        // ===============================
        private void GenerateMatrix(TableLayoutPanel panel, int rows, int cols)
        {
            panel.Controls.Clear();
            panel.RowStyles.Clear();
            panel.ColumnStyles.Clear();

            panel.RowCount = rows;
            panel.ColumnCount = cols;

            panel.Width = cols * 50;
            panel.Height = rows * 40;

            for (int i = 0; i < rows; i++)
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));

            for (int j = 0; j < cols; j++)
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / cols));

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    TextBox txt = new TextBox();
                    txt.Dock = DockStyle.Fill;
                    txt.TextAlign = HorizontalAlignment.Center;
                    txt.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
                    panel.Controls.Add(txt, j, i);
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string[] sizeA = CbA.SelectedItem.ToString().Split('x');
            string[] sizeB = CbB.SelectedItem.ToString().Split('x');

            int rowA = int.Parse(sizeA[0]);
            int colA = int.Parse(sizeA[1]);

            int rowB = int.Parse(sizeB[0]);
            int colB = int.Parse(sizeB[1]);

            if (colA != rowB)
            {
                MessageBox.Show("Kolom Matrix A harus sama dengan Baris Matrix B!");
                return;
            }

            GenerateMatrix(panelMatrixA, rowA, colA);
            GenerateMatrix(panelMatrixB, rowB, colB);
            GenerateMatrix(panelHasil, rowA, colB);
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int rowA = panelMatrixA.RowCount;
            int colA = panelMatrixA.ColumnCount;
            int rowB = panelMatrixB.RowCount;
            int colB = panelMatrixB.ColumnCount;

            int[,] A = new int[rowA, colA];
            int[,] B = new int[rowB, colB];
            int[,] C = new int[rowA, colB];

            // Ambil nilai Matrix A
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colA; j++)
                {
                    A[i, j] = int.Parse(panelMatrixA.GetControlFromPosition(j, i).Text);
                }
            }

            // Ambil nilai Matrix B
            for (int i = 0; i < rowB; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    B[i, j] = int.Parse(panelMatrixB.GetControlFromPosition(j, i).Text);
                }
            }

            // Perkalian Matrix
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < colA; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            // Tampilkan hasil
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    panelHasil.GetControlFromPosition(j, i).Text = C[i, j].ToString();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
