namespace modul03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string inputUSER;
        public int bil1, bil2;

        private void button2_Click(object sender, EventArgs e)
        {
            inputUSER += "2";
            label1.Text = inputUSER;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputUSER += "9";
            label1.Text = inputUSER;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //====
            bil2 = int.Parse(inputUSER);
            int hasil = bil1 + bil2;
            label1.Text = " " + hasil;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputUSER += "7";
            label1.Text = inputUSER;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputUSER += "1";
            label1.Text = inputUSER;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputUSER += "3";
            label1.Text = inputUSER;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputUSER += "4";
            label1.Text = inputUSER;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputUSER += "5";
            label1.Text = inputUSER;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputUSER += "6";
            label1.Text = inputUSER;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputUSER += "8";
            label1.Text = inputUSER;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            inputUSER += "0";
            label1.Text = inputUSER;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //++++
            bil1 = int.Parse(inputUSER);
            inputUSER = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            inputUSER += "3";
            label1.Text = inputUSER;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            inputUSER += "4";
            label1.Text = inputUSER;
        }
    }
}
