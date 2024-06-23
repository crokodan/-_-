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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 & comboBox2.SelectedIndex == 1)
            {
                MessageBox.Show("Вы ответили правильно");
                 Form5.Answers++;
                Form5 frm5 = new Form5();
                frm5.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2  || comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 2)
            {
                MessageBox.Show("Вы ответили неправильно");
                Form5 frm5 = new Form5();
                frm5.Show();
                this.Hide();
            }

            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Вы не ответили на вопрос");
            }
        }
    }
}
