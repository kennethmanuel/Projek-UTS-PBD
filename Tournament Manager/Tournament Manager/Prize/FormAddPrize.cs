﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tournament_Manager.Prize
{
    public partial class FormAddPrize : Form
    {
        public FormAddPrize()
        {
            InitializeComponent();
        }

        private void FormAddPrize_Load(object sender, EventArgs e)
        {
            textBoxPrizeId.Enabled = false;
        }
    }
}
