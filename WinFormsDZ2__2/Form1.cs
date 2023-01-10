namespace WinFormsDZ2__2
{
    public partial class Form1 : Form
    {

        private string D;
        private string N1;
        private bool N2;
        
        public Form1()
        {
            N2 = false;
            InitializeComponent();
        }

        private void c_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter pressed");
            }
            if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("Escape pressed");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void n0_Click_1(object sender, EventArgs e)
        {
            if (N2)
            {
                N2 = false;
                textBox1.Text = "0";
            }

            Button B = (Button)sender;
            if(textBox1.Text == "0")
            {
                textBox1.Text = B.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + B.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double DN1, DN2 ,res;
            res = 0;
            DN1 = Convert.ToDouble(N1);
            DN2 = Convert.ToDouble(textBox1.Text);
            
            if(D == "+")
            {
                res = DN1 + DN2;
            }
            if (D == "-")
            {
                res = DN1 - DN2;
            }
            if (D == "*")
            {
                res = DN1 * DN2;
            }
            if (D == "/")
            {
                res = DN1 / DN2;
            }
            D = "=";
            N2 = true;
            textBox1.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double DN, res;

            DN = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(DN);
            textBox1.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double DN, res;

            DN = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(DN,2);
            textBox1.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double DN, res;

            DN = Convert.ToDouble(textBox1.Text);
            res = - DN;
            textBox1.Text = res.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        

    }
}