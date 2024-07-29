namespace CS_bangcuuchuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(txtchon.Text);
            for (int i = 1; i <= 10; i++)
            {
                lblKQ.Text += Environment.NewLine + so.ToString() + "x" + i.ToString() + "=" + (so * i);
                listBox1.Items.Add(so.ToString() + "x" + i.ToString() + "=" + (so * i).ToString());
            }

        }


        private void NumericUpdown1_ValueChanged(object sender, EventArgs e)
        {
            txtchon.Text = NumericUpdown1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtchon.Text = trackBar1.Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblKQ_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblKQ.Text = " ";
            if (rdo2.Checked)
            {
                int so = 2;
                for (int i = 1; i <= 10; i++)
                {
                    lblKQ.Text += Environment.NewLine + so.ToString() + "x" + i.ToString() + "=" + (so * i);
                    listBox1.Items.Add(so.ToString() + "x" + i.ToString() + "=" + (so * i).ToString());
                }

            } 
    }
        private void kiemtrardo(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblKQ.Text = " ";
            RadioButton r = (RadioButton)sender;
            int so = Convert.ToInt32( r.Text);
            for (int i = 1; i <= 10; i++)
            {
                lblKQ.Text += Environment.NewLine + so.ToString() + "x" + i.ToString() + "=" + (so * i);
                listBox1.Items.Add(so.ToString() + "x" + i.ToString() + "=" + (so * i).ToString());
            }
        }

    }
}
