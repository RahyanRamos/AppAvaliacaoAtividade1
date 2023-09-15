using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAvaliacaoAtividade1.Formularios
{
    public partial class FormCalculo : Form
    {
        public FormCalculo()
        {
            InitializeComponent();
            tbConcessionaria.Visible = false;
            tbMetaConc.Visible = false;
            tbMetaFunc.Visible = false;
            tbSalario.Visible = false;
            tbVenda.Visible = false;
            tbComissao.Visible = false;
            tbPorcentagem.Visible = false;
            tbSalarioFinal.Visible = false;
            lbConcessionaria.Visible = false;
            lbMetaConc.Visible = false;
            lbMetaFunc.Visible = false;
            lbSalario.Visible = false;
            lbVenda.Visible = false;
            lbComissao.Visible = false;
            lbPorcentagem.Visible = false;
            lbSalarioFinal.Visible = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cbCargo.SelectedIndex = -1;
            tbConcessionaria.Clear();
            tbMetaConc.Clear();
            tbMetaFunc.Clear();
            tbSalario.Clear();
            tbVenda.Clear();
            tbComissao.Clear();
            tbPorcentagem.Clear();
            tbSalarioFinal.Clear();
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cargoSelecionado = cbCargo.SelectedIndex;
            if (cargoSelecionado == 3 || cargoSelecionado == 4)
            {
                tbConcessionaria.Visible = true;
                tbMetaConc.Visible = true;
                tbMetaFunc.Visible = true;
                tbSalario.Visible = true;
                tbVenda.Visible = true;
                lbConcessionaria.Visible = true;
                lbMetaConc.Visible = true;
                lbMetaFunc.Visible = true;
                lbSalario.Visible = true;
                lbVenda.Visible = true;
            }
            else
            {
                tbConcessionaria.Visible = false;
                tbMetaConc.Visible = false;
                tbMetaFunc.Visible = true;
                tbSalario.Visible = true;
                tbVenda.Visible = true;
                lbConcessionaria.Visible = false;
                lbMetaConc.Visible = false;
                lbMetaFunc.Visible = true;
                lbSalario.Visible = true;
                lbVenda.Visible = true;
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            lbComissao.Visible = true;
            lbPorcentagem.Visible = true;
            lbSalarioFinal.Visible = true;
            tbComissao.Visible = true;
            tbPorcentagem.Visible = true;
            tbSalarioFinal.Visible = true;

            int cargoSelecionado = cbCargo.SelectedIndex;
            double venda, salario, concessionaria, metaFunc, metaConc;
            double bonificacao, comissao, salarioFinal, porcentagem, metaNecessaria, metaNescConcessionaria, comissaoConc;

            switch (cargoSelecionado)
            {
                case 0:
                    venda = Convert.ToDouble(tbVenda.Text);
                    salario = Convert.ToDouble(tbSalario.Text);
                    metaFunc = Convert.ToDouble(tbMetaFunc.Text);

                    metaNecessaria = 0.65 * metaFunc;

                    comissao = 0;
                    bonificacao = salario * 0.02;
                    porcentagem = 0;

                    if (venda >= metaNecessaria)
                    {
                        comissao = venda * 0.04;
                    }

                    if (venda <= metaFunc)
                    {
                        porcentagem = ((metaFunc - venda) * 100) / metaFunc;
                    }

                    salarioFinal = comissao + bonificacao + salario;

                    tbComissao.Text = Convert.ToString(comissao);
                    tbPorcentagem.Text = porcentagem.ToString("F2");
                    tbSalarioFinal.Text = Convert.ToString(salarioFinal);
                    break;
                case 1:
                    venda = Convert.ToDouble(tbVenda.Text);
                    salario = Convert.ToDouble(tbSalario.Text);
                    metaFunc = Convert.ToDouble(tbMetaFunc.Text);

                    metaNecessaria = 0.65 * metaFunc;

                    comissao = 0;
                    bonificacao = salario * 0.02;
                    porcentagem = 0;

                    if (venda >= metaNecessaria)
                    {
                        comissao = venda * 0.06;
                    }

                    if (venda <= metaFunc)
                    {
                        porcentagem = ((metaFunc - venda) * 100) / metaFunc;
                    }

                    salarioFinal = comissao + bonificacao + salario;

                    tbComissao.Text = Convert.ToString(comissao);
                    tbPorcentagem.Text = porcentagem.ToString("F2");
                    tbSalarioFinal.Text = Convert.ToString(salarioFinal);
                    break;
                case 2:
                    venda = Convert.ToDouble(tbVenda.Text);
                    salario = Convert.ToDouble(tbSalario.Text);
                    metaFunc = Convert.ToDouble(tbMetaFunc.Text);

                    metaNecessaria = 0.65 * metaFunc;

                    comissao = 0;
                    bonificacao = salario * 0.02;
                    porcentagem = 0;

                    if (venda >= metaNecessaria)
                    {
                        comissao = venda * 0.08;
                    }

                    if (venda <= metaFunc)
                    {
                        porcentagem = ((metaFunc - venda) * 100) / metaFunc;
                    }

                    salarioFinal = comissao + bonificacao + salario;

                    tbComissao.Text = Convert.ToString(comissao);
                    tbPorcentagem.Text = porcentagem.ToString("F2");
                    tbSalarioFinal.Text = Convert.ToString(salarioFinal);
                    break;
                case 3:
                    venda = Convert.ToDouble(tbVenda.Text);
                    salario = Convert.ToDouble(tbSalario.Text);
                    metaFunc = Convert.ToDouble(tbMetaFunc.Text);
                    concessionaria = Convert.ToDouble(tbConcessionaria.Text);
                    metaConc = Convert.ToDouble(tbMetaConc.Text);

                    metaNecessaria = 0.65 * metaFunc;
                    metaNescConcessionaria = 0.85 * metaConc;

                    comissao = 0;
                    bonificacao = salario * 0.02;
                    porcentagem = 0;
                    comissaoConc = 0;

                    if (venda >= metaNecessaria)
                    {
                        comissao = venda * 0.1;
                    }

                    if (concessionaria >= metaNescConcessionaria)
                    {
                        comissaoConc = concessionaria * 0.01;
                    }

                    if (venda <= metaFunc)
                    {
                        porcentagem = ((metaFunc - venda) * 100) / metaFunc;
                    }

                    salarioFinal = comissao + bonificacao + comissaoConc + salario;

                    tbComissao.Text = Convert.ToString(comissao);
                    tbPorcentagem.Text = porcentagem.ToString("F2");
                    tbSalarioFinal.Text = Convert.ToString(salarioFinal);
                    break;
                case 4:
                    venda = Convert.ToDouble(tbVenda.Text);
                    salario = Convert.ToDouble(tbSalario.Text);
                    metaFunc = Convert.ToDouble(tbMetaFunc.Text);
                    concessionaria = Convert.ToDouble(tbConcessionaria.Text);
                    metaConc = Convert.ToDouble(tbMetaConc.Text);

                    metaNecessaria = 0.65 * metaFunc;
                    metaNescConcessionaria = 0.85 * metaConc;

                    comissao = 0;
                    bonificacao = salario * 0.02;
                    porcentagem = 0;
                    comissaoConc = 0;

                    if (venda >= metaNecessaria)
                    {
                        comissao = venda * 0.1;
                    }

                    if (concessionaria >= metaNescConcessionaria)
                    {
                        comissaoConc = concessionaria * 0.02;
                    }

                    if (venda <= metaFunc)
                    {
                        porcentagem = ((metaFunc - venda) * 100) / metaFunc;
                    }

                    salarioFinal = comissao + bonificacao + comissaoConc + salario;

                    tbComissao.Text = Convert.ToString(comissao);
                    tbPorcentagem.Text = porcentagem.ToString("F2");
                    tbSalarioFinal.Text = Convert.ToString(salarioFinal);
                    break;
            }
        }
    }
}
