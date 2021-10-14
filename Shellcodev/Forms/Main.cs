﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shellcodev.Forms
{
    public partial class Main : Form
    {
        private static Main instance;
        public static Main ReturnInstance()
        {
            return instance;
        }

        public Main()
        {
            InitializeComponent();
            instance = this;
        }

        private void addInstructionBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(instructionTxt.Text))
                return;

            new Instruction(instructionTxt.Text);
        }

        private void instructionTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                addInstructionBtn_Click(sender, e);
                instructionTxt.SelectAll();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
