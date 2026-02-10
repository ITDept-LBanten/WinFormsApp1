namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            // Matrix A
            double va = Convert.ToDouble(a.Text);
            double vb = Convert.ToDouble(b.Text);
            double vc = Convert.ToDouble(c.Text);
            double vd = Convert.ToDouble(d.Text);
            double ve = Convert.ToDouble(z.Text);
            double vf = Convert.ToDouble(f.Text);
            double vg = Convert.ToDouble(g.Text);
            double vh = Convert.ToDouble(h.Text);
            double vi = Convert.ToDouble(i.Text);

            // Matrix B
            double vp = Convert.ToDouble(p.Text);
            double vq = Convert.ToDouble(q.Text);
            double vr = Convert.ToDouble(r.Text);
            double vs = Convert.ToDouble(s.Text);
            double vt = Convert.ToDouble(t.Text);
            double vu = Convert.ToDouble(u.Text);
            double vv = Convert.ToDouble(v.Text);
            double vw = Convert.ToDouble(w.Text);
            double vx = Convert.ToDouble(x.Text);

            // --- BARIS 1 ---
            hsl1.Text = $"({va}*{vp}) + ({vb}*{vs}) + ({vc}*{vv})";
            jwb1.Text = ((va * vp) + (vb * vs) + (vc * vv)).ToString();

            hsl2.Text = $"({va}*{vq}) + ({vb}*{vt}) + ({vc}*{vw})";
            jwb2.Text = ((va * vq) + (vb * vt) + (vc * vw)).ToString();

            hsl3.Text = $"({va}*{vr}) + ({vb}*{vu}) + ({vc}*{vx})";
            jwb3.Text = ((va * vr) + (vb * vu) + (vc * vx)).ToString();

            // --- BARIS 2 ---
            hsl4.Text = $"({vd}*{vp}) + ({ve}*{vs}) + ({vf}*{vv})";
            jwb4.Text = ((vd * vp) + (ve * vs) + (vf * vv)).ToString();

            hsl5.Text = $"({vd}*{vq}) + ({ve}*{vt}) + ({vf}*{vw})";
            jwb5.Text = ((vd * vq) + (ve * vt) + (vf * vw)).ToString();

            hsl6.Text = $"({vd}*{vr}) + ({ve}*{vu}) + ({vf}*{vx})";
            jwb6.Text = ((vd * vr) + (ve * vu) + (vf * vx)).ToString();

            // --- BARIS 3 ---
            hsl7.Text = $"({vg}*{vp}) + ({vh}*{vs}) + ({vi}*{vv})";
            jwb7.Text = ((vg * vp) + (vh * vs) + (vi * vv)).ToString();

            hsl8.Text = $"({vg}*{vq}) + ({vh}*{vt}) + ({vi}*{vw})";
            jwb8.Text = ((vg * vq) + (vh * vt) + (vi * vw)).ToString();

            hsl9.Text = $"({vg}*{vr}) + ({vh}*{vu}) + ({vi}*{vx})";
            jwb9.Text = ((vg * vr) + (vh * vu) + (vi * vx)).ToString();

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Mengosongkan Matriks A
            a.Clear(); b.Clear(); c.Clear();
            d.Clear(); z.Clear(); f.Clear();
            g.Clear(); h.Clear(); i.Clear();

            // Mengosongkan Matriks B
            p.Clear(); q.Clear(); r.Clear();
            s.Clear(); t.Clear(); u.Clear();
            v.Clear(); w.Clear(); x.Clear();

            // Mengosongkan Semua Proses (hsl)
            hsl1.Clear(); hsl2.Clear(); hsl3.Clear();
            hsl4.Clear(); hsl5.Clear(); hsl6.Clear();
            hsl7.Clear(); hsl8.Clear(); hsl9.Clear();

            // Mengosongkan Semua Hasil Akhir (jwb)
            jwb1.Clear(); jwb2.Clear(); jwb3.Clear();
            jwb4.Clear(); jwb5.Clear(); jwb6.Clear();
            jwb7.Clear(); jwb8.Clear(); jwb9.Clear();

            // Mengembalikan fokus kursor ke textbox pertama
            a.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
