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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         if (checkedListBox1.GetItemChecked(2) == true)
         {
                MessageBox.Show("Вы ответили правильно");
                Form5.Answers++;
                Form4 frm4 = new Form4();
                frm4.Show();
                this.Hide();
            }
         else if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true || checkedListBox1.GetItemChecked(3) == true) 
         {
                MessageBox.Show("Вы ответили неправильно");
                Form4 frm4 = new Form4();
                frm4.Show();
                this.Hide();
            }

         if (checkedListBox1.GetItemChecked(0) == false & checkedListBox1.GetItemChecked(1) == false & checkedListBox1.GetItemChecked(2) == false & checkedListBox1.GetItemChecked(3) == false)
         {
                MessageBox.Show("Вы не ответили на вопрос");
         }
        }
    }
}
