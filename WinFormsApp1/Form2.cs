using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            double sVal = Convert.ToDouble(skalar.Text);

            // Matriks A
            double va = Convert.ToDouble(a.Text); double vb = Convert.ToDouble(b.Text); double vc = Convert.ToDouble(c.Text);
            double vd = Convert.ToDouble(d.Text); double vz = Convert.ToDouble(z.Text); double vf = Convert.ToDouble(f.Text);
            double vg = Convert.ToDouble(g.Text); double vh = Convert.ToDouble(h.Text); double vi = Convert.ToDouble(i.Text);

            // Matriks B
            double vp = Convert.ToDouble(p.Text); double vq = Convert.ToDouble(q.Text); double vr = Convert.ToDouble(r.Text);
            double vs = Convert.ToDouble(s.Text); double vt = Convert.ToDouble(t.Text); double vu = Convert.ToDouble(u.Text);
            double vv = Convert.ToDouble(v.Text); double vw = Convert.ToDouble(w.Text); double vx = Convert.ToDouble(x.Text);

            // Variabel penampung untuk langkah akhir
            double m1_1, m1_2, m1_3, m1_4, m1_5, m1_6, m1_7, m1_8, m1_9; // Matriks Pertama (Kiri)
            double m2_1, m2_2, m2_3, m2_4, m2_5, m2_6, m2_7, m2_8, m2_9; // Matriks Kedua (Kanan)

            if (rbA.Checked)
            {
                label_proses.Text = sVal + "A";
                // Tahap 1: Skalar ke A
                proses1.Text = $"{sVal} * {va}"; hsl_proses1.Text = (sVal * va).ToString();
                proses2.Text = $"{sVal} * {vb}"; hsl_proses2.Text = (sVal * vb).ToString();
                proses3.Text = $"{sVal} * {vc}"; hsl_proses3.Text = (sVal * vc).ToString();
                proses4.Text = $"{sVal} * {vd}"; hsl_proses4.Text = (sVal * vd).ToString();
                proses5.Text = $"{sVal} * {vz}"; hsl_proses5.Text = (sVal * vz).ToString();
                proses6.Text = $"{sVal} * {vf}"; hsl_proses6.Text = (sVal * vf).ToString();
                proses7.Text = $"{sVal} * {vg}"; hsl_proses7.Text = (sVal * vg).ToString();
                proses8.Text = $"{sVal} * {vh}"; hsl_proses8.Text = (sVal * vh).ToString();
                proses9.Text = $"{sVal} * {vi}"; hsl_proses9.Text = (sVal * vi).ToString();

                // Siapkan untuk perkalian akhir (SkalarA x B)
                m1_1 = sVal * va; m1_2 = sVal * vb; m1_3 = sVal * vc;
                m1_4 = sVal * vd; m1_5 = sVal * vz; m1_6 = sVal * vf;
                m1_7 = sVal * vg; m1_8 = sVal * vh; m1_9 = sVal * vi;

                m2_1 = vp; m2_2 = vq; m2_3 = vr;
                m2_4 = vs; m2_5 = vt; m2_6 = vu;
                m2_7 = vv; m2_8 = vw; m2_9 = vx;
            }
            else
            {
                label_proses.Text = sVal + "B";
                // Tahap 1: Skalar ke B
                proses1.Text = $"{sVal} * {vp}"; hsl_proses1.Text = (sVal * vp).ToString();
                proses2.Text = $"{sVal} * {vq}"; hsl_proses2.Text = (sVal * vq).ToString();
                proses3.Text = $"{sVal} * {vr}"; hsl_proses3.Text = (sVal * vr).ToString();
                proses4.Text = $"{sVal} * {vs}"; hsl_proses4.Text = (sVal * vs).ToString();
                proses5.Text = $"{sVal} * {vt}"; hsl_proses5.Text = (sVal * vt).ToString();
                proses6.Text = $"{sVal} * {vu}"; hsl_proses6.Text = (sVal * vu).ToString();
                proses7.Text = $"{sVal} * {vv}"; hsl_proses7.Text = (sVal * vv).ToString();
                proses8.Text = $"{sVal} * {vw}"; hsl_proses8.Text = (sVal * vw).ToString();
                proses9.Text = $"{sVal} * {vx}"; hsl_proses9.Text = (sVal * vx).ToString();

                // Siapkan untuk perkalian akhir (A x SkalarB)
                m1_1 = va; m1_2 = vb; m1_3 = vc;
                m1_4 = vd; m1_5 = vz; m1_6 = vf;
                m1_7 = vg; m1_8 = vh; m1_9 = vi;

                m2_1 = sVal * vp; m2_2 = sVal * vq; m2_3 = sVal * vr;
                m2_4 = sVal * vs; m2_5 = sVal * vt; m2_6 = sVal * vu;
                m2_7 = sVal * vv; m2_8 = sVal * vw; m2_9 = sVal * vx;
            }

            // --- TAHAP AKHIR: PERKALIAN MATRIKS ---
            // Baris 1
            proses_akhir1.Text = $"({m1_1}*{m2_1}) + ({m1_2}*{m2_4}) + ({m1_3}*{m2_7})";
            hsl_jwb1.Text = ((m1_1 * m2_1) + (m1_2 * m2_4) + (m1_3 * m2_7)).ToString();

            proses_akhir2.Text = $"({m1_1}*{m2_2}) + ({m1_2}*{m2_5}) + ({m1_3}*{m2_8})";
            hsl_jwb2.Text = ((m1_1 * m2_2) + (m1_2 * m2_5) + (m1_3 * m2_8)).ToString();

            proses_akhir3.Text = $"({m1_1}*{m2_3}) + ({m1_2}*{m2_6}) + ({m1_3}*{m2_9})";
            hsl_jwb3.Text = ((m1_1 * m2_3) + (m1_2 * m2_6) + (m1_3 * m2_9)).ToString();

            // Baris 2
            proses_akhir4.Text = $"({m1_4}*{m2_1}) + ({m1_5}*{m2_4}) + ({m1_6}*{m2_7})";
            hsl_jwb4.Text = ((m1_4 * m2_1) + (m1_5 * m2_4) + (m1_6 * m2_7)).ToString();

            proses_akhir5.Text = $"({m1_4}*{m2_2}) + ({m1_5}*{m2_5}) + ({m1_6}*{m2_8})";
            hsl_jwb5.Text = ((m1_4 * m2_2) + (m1_5 * m2_5) + (m1_6 * m2_8)).ToString();

            proses_akhir6.Text = $"({m1_4}*{m2_3}) + ({m1_5}*{m2_6}) + ({m1_6}*{m2_9})";
            hsl_jwb6.Text = ((m1_4 * m2_3) + (m1_5 * m2_6) + (m1_6 * m2_9)).ToString();

            // Baris 3
            proses_akhir7.Text = $"({m1_7}*{m2_1}) + ({m1_8}*{m2_4}) + ({m1_9}*{m2_7})";
            hsl_jwb7.Text = ((m1_7 * m2_1) + (m1_8 * m2_4) + (m1_9 * m2_7)).ToString();

            proses_akhir8.Text = $"({m1_7}*{m2_2}) + ({m1_8}*{m2_5}) + ({m1_9}*{m2_8})";
            hsl_jwb8.Text = ((m1_7 * m2_2) + (m1_8 * m2_5) + (m1_9 * m2_8)).ToString();

            proses_akhir9.Text = $"({m1_7}*{m2_3}) + ({m1_8}*{m2_6}) + ({m1_9}*{m2_9})";
            hsl_jwb9.Text = ((m1_7 * m2_3) + (m1_8 * m2_6) + (m1_9 * m2_9)).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 1. Kosongkan Input Matriks A
            a.Clear(); b.Clear(); c.Clear();
            d.Clear(); z.Clear(); f.Clear();
            g.Clear(); h.Clear(); i.Clear();

            // 2. Kosongkan Input Matriks B
            p.Clear(); q.Clear(); r.Clear();
            s.Clear(); t.Clear(); u.Clear();
            v.Clear(); w.Clear(); x.Clear();

            // 3. Kosongkan Input Skalar dan Reset Pilihan
            skalar.Clear();
            rbA.Checked = true; // Kembalikan default ke A
            label_proses.Text = "...";

            // 4. Kosongkan Tahap 1 (Skalar)
            proses1.Clear(); proses2.Clear(); proses3.Clear();
            proses4.Clear(); proses5.Clear(); proses6.Clear();
            proses7.Clear(); proses8.Clear(); proses9.Clear();

            hsl_proses1.Clear(); hsl_proses2.Clear(); hsl_proses3.Clear();
            hsl_proses4.Clear(); hsl_proses5.Clear(); hsl_proses6.Clear();
            hsl_proses7.Clear(); hsl_proses8.Clear(); hsl_proses9.Clear();

            // 5. Kosongkan Tahap 2 (Proses Akhir)
            proses_akhir1.Clear(); proses_akhir2.Clear(); proses_akhir3.Clear();
            proses_akhir4.Clear(); proses_akhir5.Clear(); proses_akhir6.Clear();
            proses_akhir7.Clear(); proses_akhir8.Clear(); proses_akhir9.Clear();

            // 6. Kosongkan Hasil Akhir
            hsl_jwb1.Clear(); hsl_jwb2.Clear(); hsl_jwb3.Clear();
            hsl_jwb4.Clear(); hsl_jwb5.Clear(); hsl_jwb6.Clear();
            hsl_jwb7.Clear(); hsl_jwb8.Clear(); hsl_jwb9.Clear();

            // 7. Kembalikan Fokus ke Textbox pertama
            skalar.Focus();
        }

        private void label_proses_Click(object sender, EventArgs e)
        {

        }



        private void HanyaAngka(object sender, KeyPressEventArgs e)
        {
            // 1. Izinkan: Angka (0-9), Backspace (Control), dan Minus (-)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true; // Tolak karakter selain itu
            }

            // 2. Aturan khusus tanda Minus (-)
            if (e.KeyChar == '-')
            {
                // Hanya boleh satu tanda minus DAN harus berada di posisi paling depan
                if (((sender as TextBox).Text.Contains("-")) || (sender as TextBox).SelectionStart != 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }
    }


}
