namespace Perhitungan
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}

		private void bttn_tambah_Click(object sender, EventArgs e)
		{
			int bil1, bil2, hasil;
			bil1 = int.Parse(txt_bil1.Text);
			bil2 = int.Parse(txt_bil2.Text);
			hasil = bil1 + bil2;
			txt_hasil.Text = hasil.ToString();
		}

		private void bttn_kurang_Click(object sender, EventArgs e)
		{
			int bil1, bil2, hasil;
			bil1 = int.Parse(txt_bil1.Text);
			bil2 = int.Parse(txt_bil2.Text);
			hasil = bil1 - bil2;
			txt_hasil.Text = hasil.ToString();
		}

		private void bttn_kali_Click(object sender, EventArgs e)
		{
			int bil1, bil2, hasil;
			bil1 = int.Parse(txt_bil1.Text);
			bil2 = int.Parse(txt_bil2.Text);
			hasil = bil1 * bil2;
			txt_hasil.Text = hasil.ToString();
		}

		private void bttn_bagi_Click(object sender, EventArgs e)
		{
			int bil1;
			double bil2, hasil;
			bil1 = int.Parse(txt_bil1.Text);
			bil2 = int.Parse(txt_bil2.Text);
			hasil = bil1 / bil2;
			txt_hasil.Text = hasil.ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			txt_bil1.Text = "";
			txt_bil2.Text = "";
			txt_hasil.Text = "";
		}
	}
}