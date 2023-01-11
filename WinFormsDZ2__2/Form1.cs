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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Button[] btns = new Button[] { n0, n1, n2, n3, n4, n5, n6, n7, n8, n9, c, Sqrt, x2, PlusMinus, div, multiplic, Plus, dot, equal, Minus };
            List<Button> list = btns.ToList();
            var numbersCopy = new List<Button>(list);

            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < btns.Length; i++)
                {
                    btns[i].Visible = false;
                    Thread.Sleep(10);
                }
                Warning.Visible = false;
                Solving.Visible = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                for (int i = 0; i < btns.Length; i++)
                {
                    btns[i].Visible = true;
                }
                Warning.Visible = true;
                Solving.Visible = false;
            }
        }
        
        private void c_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void action_Click(object sender, EventArgs e)
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

        private void equal_Click(object sender, EventArgs e)
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

        private void Sqrt_Click(object sender, EventArgs e)
        {
            double DN, res;

            DN = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(DN);
            textBox1.Text = res.ToString();
        }

        private void x2_Click(object sender, EventArgs e)
        {
            double DN, res;

            DN = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(DN,2);
            textBox1.Text = res.ToString();
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            double DN, res;

            DN = Convert.ToDouble(textBox1.Text);
            res = - DN;
            textBox1.Text = res.ToString();
        }

        private void dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}