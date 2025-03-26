namespace SayıOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = "";
            button1.Enabled = false;
            this.AcceptButton = button1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            button1.Enabled = true;
            button2.Enabled = false;
            Random r = new Random();
            sayi = r.Next(100);
            label7.Text = "1000";
            label5.Text = "0";
            label3.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int tahmin_sayısı, puan, tahmin;
            try
            {
                tahmin = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Geçersiz sayı");
                return;
            }
            tahmin_sayısı = int.Parse(label5.Text);
            tahmin_sayısı++;
            label5.Text = tahmin_sayısı.ToString();
            puan = int.Parse(label7.Text);
            puan = puan - tahmin_sayısı * 10;
            label7.Text = puan.ToString();

            int sayi = 0;
            if (sayi < tahmin)

                label3.Text = "Sayıyı küçültünüz";

            else if (sayi > tahmin)
                label3.Text = "Sayıyı büyütünüz";
            else
            {
                label3.Text = "Tebrikler. " + label5.Text + " defada bilip " +
                 label7.Text + " puan aldınız.";
                button2.Enabled = true;
                button1.Enabled = false;

            }
            textBox1.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}