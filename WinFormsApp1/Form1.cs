namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            string lastname;
            name = textFirstName.Text;
            lastname = textLastName.Text;
            lblresult.Text = name + "   " + lastname;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = int.Parse(textBoxAdd1.Text);
            n2 = int.Parse(textBoxAdd2.Text);
            int result = n1 + n2;
            resultcalu.Text = $"n1:{n1} +  n2:{n2}={result}";
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("من بهترین برنامه نویس c# هستم", "پویا", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                label3.Text = ("بله");

            }
            if (dialogResult == DialogResult.No)
            {
                label3.Text = ("خیر");
            }
            if (dialogResult == DialogResult.Cancel)
            {
                label3.Text = ("اصلا");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "";
            string selectedItem=comboBox1.SelectedItem.ToString();
            message += "شهر شما :" + selectedItem +Environment.NewLine;
            string bime=checkBox1.Checked.ToString();
            message += "وضعیت بیمه :" + bime + Environment.NewLine;
            string takhasos = listBox1.SelectedItem.ToString();
            message += "تخصص :" + takhasos + Environment.NewLine;
            MessageBox.Show(message);
        }
    }
}
