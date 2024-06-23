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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked & !radioButton2.Checked & !radioButton3.Checked & !radioButton4.Checked & !radioButton5.Checked)
            {
                MessageBox.Show("Вы не ответили на ворпос");
            } 
            else if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton5.Checked)
            {
                MessageBox.Show("Вы ответили неправильно");
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }

            if (radioButton4.Checked)
            {
                MessageBox.Show("Вы ответили правильно");
                Form5.Answers++;
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
        }
    }
}
