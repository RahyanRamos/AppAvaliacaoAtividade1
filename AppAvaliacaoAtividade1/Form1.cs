using System;
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
            FormComissao form = new FormComissao();
            form.ShowDialog();
        }

        private void btMeta_Click(object sender, EventArgs e)
        {
            FormMeta form = new FormMeta();
            form.ShowDialog();
        }
    }
}
