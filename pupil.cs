using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class pupil : Form
    {
        public pupil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedItem.ToString() == "Русский язык")
            {
                textBox1.Text = "Допишите букву : Р*бочий стол";
                radioButton1.Text = "А";
                radioButton2.Text = "О";
                textBox1.Text = "Допишите букву : М*ракасы";
                radioButton3.Text = "А";
                radioButton4.Text = "О";
                textBox1.Text = "Допишите букву : Синхрофаз*трон";
                radioButton5.Text = "А";
                radioButton6.Text = "О";
                textBox1.Text = "Допишите букву : Ученик";
                radioButton7.Text = "А";
                radioButton8.Text = "О";
                textBox1.Text = "Допишите букву : Р*бочий стол";
                radioButton9.Text = "А";
                radioButton10.Text = "О";
            }
        }
    }
}
