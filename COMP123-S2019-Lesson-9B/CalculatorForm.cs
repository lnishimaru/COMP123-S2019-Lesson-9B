﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson_9B
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void ButtonEq_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            int result = int.Parse(TheButton.Text);
            ResultLabel.Text = TheButton.Text;
        }
    }
}
