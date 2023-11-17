namespace practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.141593;
            double radio1, area1, volumen1;
            radio1 = double.Parse(textBox1.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3);
            textBox3.Text = area1.ToString();
            textBox2.Text = volumen1.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double base2, area2, altura2;
            base2 = double.Parse(textBox4.Text);
            altura2 = double.Parse(textBox5.Text);
            area2 = base2 * altura2 / 2;

            textBox6.Text = area2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double lado3, area3, volumen3;
            lado3 = double.Parse(textBox7.Text);
            volumen3 = Math.Pow(lado3, 3);
            area3 = 6 * Math.Pow(lado3, 2);

            textBox8.Text = area3.ToString();
            textBox9.Text = volumen3.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio4, area4, volumen4, altura4;
            radio4 = double.Parse(textBox10.Text);

            altura4 = double.Parse(textBox11.Text);
            area4 = 2 * pi * radio4 * altura4 + 2 * pi * Math.Pow(radio4, 2);
            volumen4 = altura4 * pi * Math.Pow(radio4, 2);

            textBox12.Text = area4.ToString();
            textBox13.Text = volumen4.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox10.Text = " ";
            textBox11.Text = " ";
            textBox12.Text = " ";
            textBox13.Text = " ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double DiagonalMayor, diagonalmenor, area5;
            DiagonalMayor = double.Parse(textBox14.Text);
            diagonalmenor = double.Parse(textBox15.Text);
            area5 = DiagonalMayor * diagonalmenor / 2;

            textBox16.Text = area5.ToString();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox14.Text = " ";
            textBox15.Text = " ";
            textBox16.Text = " ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double lado6, volumen6, area6;
            lado6 = double.Parse(textBox17.Text);
            volumen6 = Math.Pow(lado6, 3) * Math.Pow(2, (1 / 2)) / 3;
            area6 = Math.Pow(3, (1 / 2)) * Math.Pow(lado6, 2);

            textBox18.Text = area6.ToString();
            textBox19.Text = volumen6.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox17.Text = " ";
            textBox18.Text = " ";
            textBox19.Text = " ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}