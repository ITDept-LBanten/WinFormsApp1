namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            a = new TextBox();
            panel1 = new Panel();
            i = new TextBox();
            h = new TextBox();
            g = new TextBox();
            f = new TextBox();
            z = new TextBox();
            d = new TextBox();
            c = new TextBox();
            b = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            x = new TextBox();
            w = new TextBox();
            v = new TextBox();
            u = new TextBox();
            t = new TextBox();
            s = new TextBox();
            r = new TextBox();
            q = new TextBox();
            p = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            hsl9 = new TextBox();
            hsl8 = new TextBox();
            hsl7 = new TextBox();
            hsl6 = new TextBox();
            hsl5 = new TextBox();
            hsl4 = new TextBox();
            hsl2 = new TextBox();
            hsl1 = new TextBox();
            hsl3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            jwb9 = new TextBox();
            jwb8 = new TextBox();
            jwb7 = new TextBox();
            jwb6 = new TextBox();
            jwb5 = new TextBox();
            jwb4 = new TextBox();
            jwb3 = new TextBox();
            jwb2 = new TextBox();
            jwb1 = new TextBox();
            btnHitung = new Button();
            btnClear = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // a
            // 
            a.Font = new Font("Segoe UI", 15.75F);
            a.Location = new Point(71, 39);
            a.Name = "a";
            a.Size = new Size(35, 35);
            a.TabIndex = 0;
            a.KeyPress += HanyaAngka;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(i);
            panel1.Controls.Add(h);
            panel1.Controls.Add(g);
            panel1.Controls.Add(f);
            panel1.Controls.Add(z);
            panel1.Controls.Add(d);
            panel1.Controls.Add(c);
            panel1.Controls.Add(b);
            panel1.Controls.Add(a);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(116, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 188);
            panel1.TabIndex = 2;
            // 
            // i
            // 
            i.Font = new Font("Segoe UI", 15.75F);
            i.Location = new Point(153, 121);
            i.Name = "i";
            i.Size = new Size(35, 35);
            i.TabIndex = 8;
            i.KeyPress += HanyaAngka;
            // 
            // h
            // 
            h.Font = new Font("Segoe UI", 15.75F);
            h.Location = new Point(112, 121);
            h.Name = "h";
            h.Size = new Size(35, 35);
            h.TabIndex = 7;
            h.KeyPress += HanyaAngka;
            // 
            // g
            // 
            g.Font = new Font("Segoe UI", 15.75F);
            g.Location = new Point(71, 121);
            g.Name = "g";
            g.Size = new Size(35, 35);
            g.TabIndex = 6;
            g.KeyPress += HanyaAngka;
            // 
            // f
            // 
            f.Font = new Font("Segoe UI", 15.75F);
            f.Location = new Point(153, 80);
            f.Name = "f";
            f.Size = new Size(35, 35);
            f.TabIndex = 5;
            f.KeyPress += HanyaAngka;
            // 
            // z
            // 
            z.Font = new Font("Segoe UI", 15.75F);
            z.Location = new Point(112, 80);
            z.Name = "z";
            z.Size = new Size(35, 35);
            z.TabIndex = 4;
            z.KeyPress += HanyaAngka;
            // 
            // d
            // 
            d.Font = new Font("Segoe UI", 15.75F);
            d.Location = new Point(71, 80);
            d.Name = "d";
            d.Size = new Size(35, 35);
            d.TabIndex = 3;
            d.KeyPress += HanyaAngka;
            // 
            // c
            // 
            c.Font = new Font("Segoe UI", 15.75F);
            c.Location = new Point(153, 39);
            c.Name = "c";
            c.Size = new Size(35, 35);
            c.TabIndex = 2;
            c.KeyPress += HanyaAngka;
            // 
            // b
            // 
            b.Font = new Font("Segoe UI", 15.75F);
            b.Location = new Point(112, 39);
            b.Name = "b";
            b.Size = new Size(35, 35);
            b.TabIndex = 1;
            b.KeyPress += HanyaAngka;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(22, 79);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 0;
            label2.Text = "A =";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 30);
            label1.TabIndex = 3;
            label1.Text = "MATRIKS PERKALIAN ORDO 3X3";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(x);
            panel2.Controls.Add(w);
            panel2.Controls.Add(v);
            panel2.Controls.Add(u);
            panel2.Controls.Add(t);
            panel2.Controls.Add(s);
            panel2.Controls.Add(r);
            panel2.Controls.Add(q);
            panel2.Controls.Add(p);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(426, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 188);
            panel2.TabIndex = 9;
            // 
            // x
            // 
            x.Font = new Font("Segoe UI", 15.75F);
            x.Location = new Point(153, 121);
            x.Name = "x";
            x.Size = new Size(35, 35);
            x.TabIndex = 8;
            x.KeyPress += HanyaAngka;
            // 
            // w
            // 
            w.Font = new Font("Segoe UI", 15.75F);
            w.Location = new Point(112, 121);
            w.Name = "w";
            w.Size = new Size(35, 35);
            w.TabIndex = 7;
            w.KeyPress += HanyaAngka;
            // 
            // v
            // 
            v.Font = new Font("Segoe UI", 15.75F);
            v.Location = new Point(71, 121);
            v.Name = "v";
            v.Size = new Size(35, 35);
            v.TabIndex = 6;
            v.KeyPress += HanyaAngka;
            // 
            // u
            // 
            u.Font = new Font("Segoe UI", 15.75F);
            u.Location = new Point(153, 80);
            u.Name = "u";
            u.Size = new Size(35, 35);
            u.TabIndex = 5;
            u.KeyPress += HanyaAngka;
            // 
            // t
            // 
            t.Font = new Font("Segoe UI", 15.75F);
            t.Location = new Point(112, 80);
            t.Name = "t";
            t.Size = new Size(35, 35);
            t.TabIndex = 4;
            t.KeyPress += HanyaAngka;
            // 
            // s
            // 
            s.Font = new Font("Segoe UI", 15.75F);
            s.Location = new Point(71, 80);
            s.Name = "s";
            s.Size = new Size(35, 35);
            s.TabIndex = 3;
            s.KeyPress += HanyaAngka;
            // 
            // r
            // 
            r.Font = new Font("Segoe UI", 15.75F);
            r.Location = new Point(153, 39);
            r.Name = "r";
            r.Size = new Size(35, 35);
            r.TabIndex = 2;
            r.KeyPress += HanyaAngka;
            // 
            // q
            // 
            q.Font = new Font("Segoe UI", 15.75F);
            q.Location = new Point(112, 39);
            q.Name = "q";
            q.Size = new Size(35, 35);
            q.TabIndex = 1;
            q.KeyPress += HanyaAngka;
            // 
            // p
            // 
            p.Font = new Font("Segoe UI", 15.75F);
            p.Location = new Point(71, 39);
            p.Name = "p";
            p.Size = new Size(35, 35);
            p.TabIndex = 0;
            p.KeyPress += HanyaAngka;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(22, 79);
            label3.Name = "label3";
            label3.Size = new Size(34, 21);
            label3.TabIndex = 0;
            label3.Text = "B =";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Controls.Add(hsl9);
            panel3.Controls.Add(hsl8);
            panel3.Controls.Add(hsl7);
            panel3.Controls.Add(hsl6);
            panel3.Controls.Add(hsl5);
            panel3.Controls.Add(hsl4);
            panel3.Controls.Add(hsl2);
            panel3.Controls.Add(hsl1);
            panel3.Controls.Add(hsl3);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(48, 265);
            panel3.Name = "panel3";
            panel3.Size = new Size(798, 211);
            panel3.TabIndex = 9;
            // 
            // hsl9
            // 
            hsl9.Font = new Font("Segoe UI", 14.25F);
            hsl9.Location = new Point(545, 145);
            hsl9.Name = "hsl9";
            hsl9.ReadOnly = true;
            hsl9.Size = new Size(231, 33);
            hsl9.TabIndex = 8;
            // 
            // hsl8
            // 
            hsl8.Font = new Font("Segoe UI", 14.25F);
            hsl8.Location = new Point(308, 145);
            hsl8.Name = "hsl8";
            hsl8.ReadOnly = true;
            hsl8.Size = new Size(231, 33);
            hsl8.TabIndex = 7;
            // 
            // hsl7
            // 
            hsl7.Font = new Font("Segoe UI", 14.25F);
            hsl7.Location = new Point(71, 145);
            hsl7.Name = "hsl7";
            hsl7.ReadOnly = true;
            hsl7.Size = new Size(231, 33);
            hsl7.TabIndex = 6;
            // 
            // hsl6
            // 
            hsl6.Font = new Font("Segoe UI", 14.25F);
            hsl6.Location = new Point(545, 93);
            hsl6.Name = "hsl6";
            hsl6.ReadOnly = true;
            hsl6.Size = new Size(231, 33);
            hsl6.TabIndex = 5;
            // 
            // hsl5
            // 
            hsl5.Font = new Font("Segoe UI", 14.25F);
            hsl5.Location = new Point(308, 93);
            hsl5.Name = "hsl5";
            hsl5.ReadOnly = true;
            hsl5.Size = new Size(231, 33);
            hsl5.TabIndex = 4;
            // 
            // hsl4
            // 
            hsl4.Font = new Font("Segoe UI", 14.25F);
            hsl4.Location = new Point(71, 93);
            hsl4.Name = "hsl4";
            hsl4.ReadOnly = true;
            hsl4.Size = new Size(231, 33);
            hsl4.TabIndex = 3;
            // 
            // hsl2
            // 
            hsl2.Font = new Font("Segoe UI", 14.25F);
            hsl2.Location = new Point(308, 41);
            hsl2.Name = "hsl2";
            hsl2.ReadOnly = true;
            hsl2.Size = new Size(231, 33);
            hsl2.TabIndex = 1;
            // 
            // hsl1
            // 
            hsl1.Font = new Font("Segoe UI", 14.25F);
            hsl1.Location = new Point(71, 41);
            hsl1.Name = "hsl1";
            hsl1.ReadOnly = true;
            hsl1.Size = new Size(231, 33);
            hsl1.TabIndex = 0;
            // 
            // hsl3
            // 
            hsl3.Font = new Font("Segoe UI", 14.25F);
            hsl3.Location = new Point(545, 41);
            hsl3.Name = "hsl3";
            hsl3.ReadOnly = true;
            hsl3.Size = new Size(231, 33);
            hsl3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(6, 110);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 0;
            label4.Text = "A x B =";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(294, 586);
            label5.Name = "label5";
            label5.Size = new Size(25, 25);
            label5.TabIndex = 10;
            label5.Text = "=";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 192, 255);
            panel4.Controls.Add(jwb9);
            panel4.Controls.Add(jwb8);
            panel4.Controls.Add(jwb7);
            panel4.Controls.Add(jwb6);
            panel4.Controls.Add(jwb5);
            panel4.Controls.Add(jwb4);
            panel4.Controls.Add(jwb3);
            panel4.Controls.Add(jwb2);
            panel4.Controls.Add(jwb1);
            panel4.Location = new Point(352, 504);
            panel4.Name = "panel4";
            panel4.Size = new Size(235, 187);
            panel4.TabIndex = 10;
            // 
            // jwb9
            // 
            jwb9.Font = new Font("Segoe UI", 15.75F);
            jwb9.Location = new Point(142, 123);
            jwb9.Name = "jwb9";
            jwb9.ReadOnly = true;
            jwb9.Size = new Size(35, 35);
            jwb9.TabIndex = 8;
            // 
            // jwb8
            // 
            jwb8.Font = new Font("Segoe UI", 15.75F);
            jwb8.Location = new Point(101, 123);
            jwb8.Name = "jwb8";
            jwb8.ReadOnly = true;
            jwb8.Size = new Size(35, 35);
            jwb8.TabIndex = 7;
            // 
            // jwb7
            // 
            jwb7.Font = new Font("Segoe UI", 15.75F);
            jwb7.Location = new Point(60, 123);
            jwb7.Name = "jwb7";
            jwb7.ReadOnly = true;
            jwb7.Size = new Size(35, 35);
            jwb7.TabIndex = 6;
            // 
            // jwb6
            // 
            jwb6.Font = new Font("Segoe UI", 15.75F);
            jwb6.Location = new Point(142, 82);
            jwb6.Name = "jwb6";
            jwb6.ReadOnly = true;
            jwb6.Size = new Size(35, 35);
            jwb6.TabIndex = 5;
            // 
            // jwb5
            // 
            jwb5.Font = new Font("Segoe UI", 15.75F);
            jwb5.Location = new Point(101, 82);
            jwb5.Name = "jwb5";
            jwb5.ReadOnly = true;
            jwb5.Size = new Size(35, 35);
            jwb5.TabIndex = 4;
            // 
            // jwb4
            // 
            jwb4.Font = new Font("Segoe UI", 15.75F);
            jwb4.Location = new Point(60, 82);
            jwb4.Name = "jwb4";
            jwb4.ReadOnly = true;
            jwb4.Size = new Size(35, 35);
            jwb4.TabIndex = 3;
            // 
            // jwb3
            // 
            jwb3.Font = new Font("Segoe UI", 15.75F);
            jwb3.Location = new Point(142, 41);
            jwb3.Name = "jwb3";
            jwb3.ReadOnly = true;
            jwb3.Size = new Size(35, 35);
            jwb3.TabIndex = 2;
            // 
            // jwb2
            // 
            jwb2.Font = new Font("Segoe UI", 15.75F);
            jwb2.Location = new Point(101, 41);
            jwb2.Name = "jwb2";
            jwb2.ReadOnly = true;
            jwb2.Size = new Size(35, 35);
            jwb2.TabIndex = 1;
            // 
            // jwb1
            // 
            jwb1.Font = new Font("Segoe UI", 15.75F);
            jwb1.Location = new Point(60, 41);
            jwb1.Name = "jwb1";
            jwb1.ReadOnly = true;
            jwb1.Size = new Size(35, 35);
            jwb1.TabIndex = 0;
            // 
            // btnHitung
            // 
            btnHitung.BackColor = Color.FromArgb(0, 64, 0);
            btnHitung.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHitung.ForeColor = SystemColors.ControlLightLight;
            btnHitung.Location = new Point(683, 56);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(86, 46);
            btnHitung.TabIndex = 11;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = false;
            btnHitung.Click += btnHitung_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 64, 64);
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(683, 108);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 41);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(64, 0, 0);
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(683, 155);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 41);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 749);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnHitung);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox a;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox d;
        private TextBox c;
        private TextBox b;
        private TextBox i;
        private TextBox h;
        private TextBox g;
        private TextBox f;
        private TextBox z;
        private Panel panel2;
        private TextBox x;
        private TextBox w;
        private TextBox v;
        private TextBox u;
        private TextBox t;
        private TextBox s;
        private TextBox r;
        private TextBox q;
        private TextBox p;
        private Label label3;
        private Panel panel3;
        private TextBox hsl9;
        private TextBox hsl8;
        private TextBox hsl7;
        private TextBox hsl6;
        private TextBox hsl5;
        private TextBox hsl4;
        private TextBox hsl3;
        private TextBox hsl2;
        private TextBox hsl1;
        private Label label4;
        private Label label5;
        private Panel panel4;
        private TextBox jwb9;
        private TextBox jwb8;
        private TextBox jwb7;
        private TextBox jwb6;
        private TextBox jwb5;
        private TextBox jwb4;
        private TextBox jwb3;
        private TextBox jwb2;
        private TextBox jwb1;
        private Button btnHitung;
        private Button btnClear;
        private Button btnExit;
    }
}
