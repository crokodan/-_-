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
    public partial class Form5 : Form
    {
        public static int Answers = 0;
            
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 & comboBox2.SelectedIndex == 2 & comboBox3.SelectedIndex == 3 & comboBox4.SelectedIndex == 0) 
            {
                MessageBox.Show("Вы ответили правильно");
                Answers++;
            }
            else if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 2 || comboBox1.SelectedIndex == 3 || comboBox2.SelectedIndex == 1 || comboBox2.SelectedIndex == 1 || comboBox2.SelectedIndex == 3 || comboBox3.SelectedIndex == 0 || comboBox3.SelectedIndex == 1 || comboBox3.SelectedIndex == 2 || comboBox4.SelectedIndex == 1 || comboBox4.SelectedIndex == 2 || comboBox4.SelectedIndex == 3)
            {
                MessageBox.Show("Вы ответили неправильно");
            }

            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Вы не ответили на вопрос");
            }
            MessageBox.Show($"{Answers} правильных ответов");
        }
    }
}
