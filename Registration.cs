﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolY
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            Units.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void Registr_Click(object sender, EventArgs e)
        {
            if(Teacher.Checked == false && Pupil.Checked == false)
            {

            }
        }
    }
}
