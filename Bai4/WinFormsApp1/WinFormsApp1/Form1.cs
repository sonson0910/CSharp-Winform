using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        List<Sach1> ls = new List<Sach1>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            string ten, ma, tg, qr;
            int sl;
            ten = txtTenSach.Text;
            ma = txtMaSach.Text;
            tg = txtTacGia.Text;
            qr = txtQRCode.Text;
            sl = int.Parse(txtSoLuong.Text);
            Sach1 s = new Sach1(qr, ma, ten, tg, sl);
            ls.Add(s);
            lstDS.Items.Add(s.ToString());
        }

        private void btnXoaKhoiDS_Click(object sender, EventArgs e)
        {
            lstDS.Items.Clear();
            ls.Clear();

            string ten, ma, tg, qr;
            int sl;
            ten = txtTenSach.Text;
            ma = txtMaSach.Text;
            tg = txtTacGia.Text;
            qr = txtQRCode.Text;
            sl = int.Parse(txtSoLuong.Text);
            Sach1 st = new Sach1(qr, ma, ten, tg, sl);

            foreach (Sach1 s in ls)
            {
                if (s.Ma.Equals(txtMaSach.Text))
                {
                    ls.Remove(s);
                    continue;
                    lstDS.Items.Remove(st.ToString());
                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            lstDS.Items.Clear();
            ls.Clear();
            string ten, ma, tg, qr;
            int sl;
            ten = txtTenSach.Text;
            ma = txtMaSach.Text;
            tg = txtTacGia.Text;
            qr = txtQRCode.Text;
            sl = int.Parse(txtSoLuong.Text);
            Sach1 s = new Sach1(qr, ma, ten, tg, sl);
            ls.Add(s);
            lstDS.Items.Add(s.ToString());
        }
    }
}