﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaKlientow
{
    public partial class Frm_Panel : Form
    {
        public Frm_Panel()
        {
            InitializeComponent();
            Frm_Loguj frm_loguj = new Frm_Loguj();
            frm_loguj.Visible = false;
        }

        private void Frm_Panel_Load(object sender, EventArgs e)
        {
            //Frm_Loguj frm_loguj = new Frm_Loguj();
            //frm_loguj.Close();
        }
    }
}
