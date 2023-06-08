namespace Ders_Gecen_Kalan_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rbtnGecti.Checked)
            {
                lsbGecenler.Items.Add(txtAd.Text + " " + txtSoyad.Text);
                txtAd.Clear();
                txtSoyad.Clear();
            }

            else if (rbtnKaldý.Checked)
            {
                lsbKalanlar.Items.Add(txtAd.Text + " " + txtSoyad.Text);
                txtAd.Clear();
                txtSoyad.Clear();
            }
        }
    }
}