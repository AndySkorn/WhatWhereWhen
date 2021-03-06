﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace W3
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected void ShowNextForm(BaseForm nextForm, bool isClose = true)
        {
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.Location = this.Location;

            this.Hide();
            nextForm.ShowDialog();
            if (isClose)
            {
                this.Close();
            }
            else
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = nextForm.Location;
                this.Show();
            }
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
