using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olympic_heroes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked & checkBox3.Checked)
            {
                MessageBox.Show("Вы ответили правильно");
                Form5.Answers++;
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }
            else if (!checkBox1.Checked & !checkBox2.Checked & !checkBox3.Checked & !checkBox4.Checked) 
            {
                MessageBox.Show("Вы не ответили на вопрос");
            }

            if (checkBox1.Checked || checkBox4.Checked)
            {
                MessageBox.Show("Вы ответили неправильно");
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }
        }
    }
}
