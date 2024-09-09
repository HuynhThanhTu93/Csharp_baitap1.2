namespace Csharp_baitap1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool ktraSNT(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        private void txt_n_TextChanged(object sender, EventArgs e)
        {
            string kq = string.Empty;
            if (txt_n.Text != string.Empty)
            {
                if (ktraSNT(int.Parse(txt_n.Text)))
                {
                    txt_kq.Text = "Là SNT";
                }
                else
                {
                    txt_kq.Text = "Không phải SNT";
                }
                for (int i = 2; i < int.Parse(txt_n.Text); i++)
                {
                    if (ktraSNT(i))
                    {
                        kq += " " + i;
                    }
                    txt_sntN.Text = kq;
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
