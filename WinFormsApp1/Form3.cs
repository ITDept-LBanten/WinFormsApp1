using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            // 1. Ambil Nilai Skalar
            double s1 = Convert.ToDouble(skalar1.Text);
            double s2 = Convert.ToDouble(skalar2.Text);
            double sTotal = s1 * s2;

            // 2. Update Label Proses secara dinamis
            label_proses.Text = $"{s1}A x {s2}B = {sTotal}(AxB) =";

            // 3. Ambil Nilai Matriks A
            double va = Convert.ToDouble(a.Text); double vb = Convert.ToDouble(b.Text); double vc = Convert.ToDouble(c.Text);
            double vd = Convert.ToDouble(d.Text); double vz = Convert.ToDouble(z.Text); double vf = Convert.ToDouble(f.Text);
            double vg = Convert.ToDouble(g.Text); double vh = Convert.ToDouble(h.Text); double vi = Convert.ToDouble(i.Text);

            // 4. Ambil Nilai Matriks B
            double vp = Convert.ToDouble(p.Text); double vq = Convert.ToDouble(q.Text); double vr = Convert.ToDouble(r.Text);
            double vs = Convert.ToDouble(s.Text); double vt = Convert.ToDouble(t.Text); double vu = Convert.ToDouble(u.Text);
            double vv = Convert.ToDouble(v.Text); double vw = Convert.ToDouble(w.Text); double vx = Convert.ToDouble(x.Text);


            // --- TAHAP 1: Perkalian Matriks Murni (AxB) ---
            // Baris 1
            proses1.Text = $"({va}*{vp}) + ({vb}*{vs}) + ({vc}*{vv})";
            double res1 = (va * vp) + (vb * vs) + (vc * vv);
            hsl_proses1.Text = res1.ToString();

            proses2.Text = $"({va}*{vq}) + ({vb}*{vt}) + ({vc}*{vw})";
            double res2 = (va * vq) + (vb * vt) + (vc * vw);
            hsl_proses2.Text = res2.ToString();

            proses3.Text = $"({va}*{vr}) + ({vb}*{vu}) + ({vc}*{vx})";
            double res3 = (va * vr) + (vb * vu) + (vc * vx);
            hsl_proses3.Text = res3.ToString();

            // Baris 2
            proses4.Text = $"({vd}*{vp}) + ({vz}*{vs}) + ({vf}*{vv})";
            double res4 = (vd * vp) + (vz * vs) + (vf * vv);
            hsl_proses4.Text = res4.ToString();

            proses5.Text = $"({vd}*{vq}) + ({vz}*{vt}) + ({vf}*{vw})";
            double res5 = (vd * vq) + (vz * vt) + (vf * vw);
            hsl_proses5.Text = res5.ToString();

            proses6.Text = $"({vd}*{vr}) + ({vz}*{vu}) + ({vf}*{vx})";
            double res6 = (vd * vr) + (vz * vu) + (vf * vx);
            hsl_proses6.Text = res6.ToString();

            // Baris 3
            proses7.Text = $"({vg}*{vp}) + ({vh}*{vs}) + ({vi}*{vv})";
            double res7 = (vg * vp) + (vh * vs) + (vi * vv);
            hsl_proses7.Text = res7.ToString();

            proses8.Text = $"({vg}*{vq}) + ({vh}*{vt}) + ({vi}*{vw})";
            double res8 = (vg * vq) + (vh * vt) + (vi * vw);
            hsl_proses8.Text = res8.ToString();

            proses9.Text = $"({vg}*{vr}) + ({vh}*{vu}) + ({vi}*{vx})";
            double res9 = (vg * vr) + (vh * vu) + (vi * vx);
            hsl_proses9.Text = res9.ToString();


            // --- TAHAP 2: Perkalian Akhir (sTotal * Hasil AxB) ---
            // Baris 1
            proses_akhir1.Text = $"{sTotal} * {res1}";
            hsl_jwb1.Text = (sTotal * res1).ToString();

            proses_akhir2.Text = $"{sTotal} * {res2}";
            hsl_jwb2.Text = (sTotal * res2).ToString();

            proses_akhir3.Text = $"{sTotal} * {res3}";
            hsl_jwb3.Text = (sTotal * res3).ToString();

            // Baris 2
            proses_akhir4.Text = $"{sTotal} * {res4}";
            hsl_jwb4.Text = (sTotal * res4).ToString();

            proses_akhir5.Text = $"{sTotal} * {res5}";
            hsl_jwb5.Text = (sTotal * res5).ToString();

            proses_akhir6.Text = $"{sTotal} * {res6}";
            hsl_jwb6.Text = (sTotal * res6).ToString();

            // Baris 3
            proses_akhir7.Text = $"{sTotal} * {res7}";
            hsl_jwb7.Text = (sTotal * res7).ToString();

            proses_akhir8.Text = $"{sTotal} * {res8}";
            hsl_jwb8.Text = (sTotal * res8).ToString();

            proses_akhir9.Text = $"{sTotal} * {res9}";
            hsl_jwb9.Text = (sTotal * res9).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 1. Kosongkan Skalar
            skalar1.Clear();
            skalar2.Clear();
            label_proses.Text = "...";

            // 2. Kosongkan Matriks A (a-i)
            a.Clear(); b.Clear(); c.Clear();
            d.Clear(); z.Clear(); f.Clear();
            g.Clear(); h.Clear(); i.Clear();

            // 3. Kosongkan Matriks B (p-x)
            p.Clear(); q.Clear(); r.Clear();
            s.Clear(); t.Clear(); u.Clear();
            v.Clear(); w.Clear(); x.Clear();

            // 4. Kosongkan Tahap 1: AxB (proses & hsl_proses)
            proses1.Clear(); proses2.Clear(); proses3.Clear();
            proses4.Clear(); proses5.Clear(); proses6.Clear();
            proses7.Clear(); proses8.Clear(); proses9.Clear();

            hsl_proses1.Clear(); hsl_proses2.Clear(); hsl_proses3.Clear();
            hsl_proses4.Clear(); hsl_proses5.Clear(); hsl_proses6.Clear();
            hsl_proses7.Clear(); hsl_proses8.Clear(); hsl_proses9.Clear();

            // 5. Kosongkan Tahap 2: Skalar * Hasil (proses_akhir & hsl_jwb)
            proses_akhir1.Clear(); proses_akhir2.Clear(); proses_akhir3.Clear();
            proses_akhir4.Clear(); proses_akhir5.Clear(); proses_akhir6.Clear();
            proses_akhir7.Clear(); proses_akhir8.Clear(); proses_akhir9.Clear();

            hsl_jwb1.Clear(); hsl_jwb2.Clear(); hsl_jwb3.Clear();
            hsl_jwb4.Clear(); hsl_jwb5.Clear(); hsl_jwb6.Clear();
            hsl_jwb7.Clear(); hsl_jwb8.Clear(); hsl_jwb9.Clear();

            // 6. Kembalikan fokus ke skalar pertama
            skalar1.Focus();
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
