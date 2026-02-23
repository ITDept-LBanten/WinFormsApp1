namespace WinFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            CbA = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            CbB = new ComboBox();
            panelMatrixA = new TableLayoutPanel();
            panelMatrixB = new TableLayoutPanel();
            panelHasil = new TableLayoutPanel();
            label4 = new Label();
            btnGenerate = new Button();
            btnHitung = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(356, 30);
            label1.TabIndex = 16;
            label1.Text = "MATRIKS PERKALIAN PILIH ORDO";
            // 
            // CbA
            // 
            CbA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbA.FormattingEnabled = true;
            CbA.Items.AddRange(new object[] { "2x2", "2x3", "3x2", "3x3" });
            CbA.Location = new Point(75, 92);
            CbA.Name = "CbA";
            CbA.Size = new Size(110, 33);
            CbA.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 64);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 18;
            label2.Text = "Matrix A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(218, 64);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 20;
            label3.Text = "Matrix B";
            // 
            // CbB
            // 
            CbB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbB.FormattingEnabled = true;
            CbB.Items.AddRange(new object[] { "2x2", "2x3", "3x2", "3x3" });
            CbB.Location = new Point(204, 92);
            CbB.Name = "CbB";
            CbB.Size = new Size(110, 33);
            CbB.TabIndex = 19;
            // 
            // panelMatrixA
            // 
            panelMatrixA.BackColor = SystemColors.ActiveCaption;
            panelMatrixA.ColumnCount = 2;
            panelMatrixA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelMatrixA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelMatrixA.Location = new Point(37, 63);
            panelMatrixA.Name = "panelMatrixA";
            panelMatrixA.RowCount = 2;
            panelMatrixA.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelMatrixA.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelMatrixA.Size = new Size(265, 196);
            panelMatrixA.TabIndex = 21;
            // 
            // panelMatrixB
            // 
            panelMatrixB.ColumnCount = 2;
            panelMatrixB.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelMatrixB.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelMatrixB.Location = new Point(330, 63);
            panelMatrixB.Name = "panelMatrixB";
            panelMatrixB.RowCount = 2;
            panelMatrixB.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelMatrixB.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelMatrixB.Size = new Size(281, 196);
            panelMatrixB.TabIndex = 22;
            // 
            // panelHasil
            // 
            panelHasil.ColumnCount = 2;
            panelHasil.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelHasil.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelHasil.Location = new Point(718, 63);
            panelHasil.Name = "panelHasil";
            panelHasil.RowCount = 2;
            panelHasil.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelHasil.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelHasil.Size = new Size(254, 196);
            panelHasil.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(650, 137);
            label4.Name = "label4";
            label4.Size = new Size(37, 40);
            label4.TabIndex = 24;
            label4.Text = "=";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Teal;
            btnGenerate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(340, 88);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(104, 39);
            btnGenerate.TabIndex = 25;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnHitung
            // 
            btnHitung.BackColor = Color.FromArgb(0, 64, 0);
            btnHitung.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHitung.ForeColor = SystemColors.ControlLightLight;
            btnHitung.Location = new Point(461, 88);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(104, 39);
            btnHitung.TabIndex = 27;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = false;
            btnHitung.Click += btnHitung_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(63, 35);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 28;
            label5.Text = "Matrix A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(362, 35);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 29;
            label6.Text = "Matrix B";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(754, 35);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 30;
            label7.Text = "Hasil";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(64, 0, 0);
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(571, 88);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 39);
            btnExit.TabIndex = 31;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelMatrixA);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(panelMatrixB);
            groupBox1.Controls.Add(panelHasil);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(994, 299);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 450);
            Controls.Add(btnExit);
            Controls.Add(btnHitung);
            Controls.Add(btnGenerate);
            Controls.Add(label3);
            Controls.Add(CbB);
            Controls.Add(label2);
            Controls.Add(CbA);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CbA;
        private Label label2;
        private Label label3;
        private ComboBox CbB;
        private TableLayoutPanel panelMatrixA;
        private TableLayoutPanel panelMatrixB;
        private TableLayoutPanel panelHasil;
        private Label label4;
        private Button btnGenerate;
        private Button btnHitung;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnExit;
        private GroupBox groupBox1;
    }
}