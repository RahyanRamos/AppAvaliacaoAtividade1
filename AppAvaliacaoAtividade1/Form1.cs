﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppAvaliacaoAtividade1.Formularios;

namespace AppAvaliacaoAtividade1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btComissao_Click(object sender, EventArgs e)
        {
            FormCalculo form = new FormCalculo();
            form.ShowDialog();
        }
    }
}
