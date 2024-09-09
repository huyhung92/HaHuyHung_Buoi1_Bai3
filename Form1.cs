using System.Windows.Forms.Design.Behavior;

namespace HaHuyHung_Buoi1_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n;
        private void txtn_TextChanged(object sender, EventArgs e)
        {
            n = Convert.ToInt32(txtn.Text);
            if (SNT(n))
                txtkt.Text = n + "là số nguyên tố";
            else txtkt.Text = n + "Không phải là số nguyên tố";

            List<int> list = new List<int>();
            string chuoi = " ";

            for (int i = 2; i < n; i++)
            {
                if (SNT(i))
                    list.Add(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                chuoi += list[i].ToString() + " ";
            }
            txtnhn.Text = chuoi;
        }

        private void txtkt_TextChanged(object sender, EventArgs e)
        {

        }

        private bool SNT(int n)
        {
            if (n < 2)
                return false;
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
