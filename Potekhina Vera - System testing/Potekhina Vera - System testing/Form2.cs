using System;
using System.Windows.Forms;

namespace Potekhina_Vera___System_testing
{
    public partial class Form2 : Form
    {
        public Form2(string name)
        {
            InitializeComponent();
            label1.Text = name;
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string DataMethod
        {
            get
            {
                return textBox1.Text;
            }
        }
    }
}