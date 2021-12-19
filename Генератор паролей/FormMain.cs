using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Генератор_паролей
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int leng_pass = (int)numericUpDown1.Value;
            int guantity = (int)numericUpDown2.Value;
            bool symbol = checkBox1.Checked;
            Random rand = new Random();
            Random type = new Random();
            for (int j = 0; j < guantity; j ++)
            {
                for (int i = 0; i < leng_pass; i++)
                {
                    int type_num = type.Next(0, 2);
                    if (type_num == 0)
                    {
                        int value = rand.Next(0, 9);
                        richTextBox1.Text += value.ToString();
                        continue;
                    }
                    if (symbol == true)
                    {
                        char value = (char)rand.Next(33, 125);
                        if (value == '\\' || value == '/')
                        {
                            value = (char)rand.Next(33, 91);
                            richTextBox1.Text += value.ToString();
                        }
                        else
                        {
                            richTextBox1.Text += value.ToString();
                        }
                        continue;
                    }
                }
                richTextBox1.Text += "\n";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
