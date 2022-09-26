namespace Kalkulyator
{
    public partial class Form1 : Form
    {
        bool ekransil = false;
        double netice = 0;
        string op = "";
        List<double> args = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void reqemler(object sender, EventArgs e)
        {
            if(textBox.Text == "0" || ekransil)
                textBox.Clear();

            ekransil = false;
            Button btn = (Button)sender;
            textBox.Text += btn.Text;

        }

        private void hesapla(object sender, EventArgs e)
        {
            ekransil = true;
            Button btn = (Button)sender;
            string yeniop = btn.Text;
            label.Text = label.Text + " " + textBox.Text + " " + yeniop;
            switch(op)
            {
                case "+":
                    textBox.Text = (netice + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (netice - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (netice * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (netice / Double.Parse(textBox.Text)).ToString();
                    break;
            }
            netice = Double.Parse(textBox.Text);
            textBox.Text = netice.ToString();
            op = yeniop;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            label.Text = "";
            op = "";
            netice = 0;
            ekransil = false;
        }

        private void beraber_Click(object sender, EventArgs e)
        {
            label.Text = "";
            ekransil = true;

            switch (op)
            {
                case "+":
                    textBox.Text = (netice + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (netice - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (netice * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (netice / Double.Parse(textBox.Text)).ToString();
                    break;
            }
            netice = Double.Parse(textBox.Text);
            args.Add(netice);
            for(int i = 0; i < args.Count; i++)
            {
                
                textBox1.Text += args[i].ToString() + "                                                                                                                         ";
                args.RemoveAt(i);
               
            }
            
            textBox.Text = netice.ToString();
            op = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(textBox.Text == "0" || ekransil)
            {
                textBox.Text = "0"; 
            }

            if (!(textBox.Text.Contains(".")))
            {
                textBox.Text += ".";
            }
            ekransil = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            args.Clear();
        }
    }
}