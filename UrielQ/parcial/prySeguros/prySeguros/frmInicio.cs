﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySeguros
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            lblCarga.Text = progressBar1.Value.ToString() + "%";

            if(progressBar1.Value == progressBar1.Maximum) 
            { 
               timer1.Stop();
                this.Hide();
                FormMenu frmMenu = new FormMenu();
                frmMenu.ShowDialog();
            }
        }
    }
}
