namespace AppAvaliacaoAtividade1.Formularios
{
    partial class FormCalculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbVenda = new System.Windows.Forms.Label();
            this.tbVenda = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.lbSalario = new System.Windows.Forms.Label();
            this.tbConcessionaria = new System.Windows.Forms.TextBox();
            this.lbConcessionaria = new System.Windows.Forms.Label();
            this.tbMetaFunc = new System.Windows.Forms.TextBox();
            this.lbMetaFunc = new System.Windows.Forms.Label();
            this.tbMetaConc = new System.Windows.Forms.TextBox();
            this.lbMetaConc = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbComissao = new System.Windows.Forms.TextBox();
            this.lbComissao = new System.Windows.Forms.Label();
            this.tbPorcentagem = new System.Windows.Forms.TextBox();
            this.lbPorcentagem = new System.Windows.Forms.Label();
            this.tbSalarioFinal = new System.Windows.Forms.TextBox();
            this.lbSalarioFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCargo
            // 
            this.cbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Vendedor Júnior",
            "Vendedor Padrão",
            "Vendedor Master",
            "Supervisor de Vendas",
            "Gerente"});
            this.cbCargo.Location = new System.Drawing.Point(12, 117);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(340, 28);
            this.cbCargo.TabIndex = 0;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calcular Valores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cargo do funcionário";
            // 
            // lbVenda
            // 
            this.lbVenda.AutoSize = true;
            this.lbVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenda.Location = new System.Drawing.Point(12, 171);
            this.lbVenda.Name = "lbVenda";
            this.lbVenda.Size = new System.Drawing.Size(147, 20);
            this.lbVenda.TabIndex = 3;
            this.lbVenda.Text = "Valor das vendas";
            // 
            // tbVenda
            // 
            this.tbVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVenda.Location = new System.Drawing.Point(12, 194);
            this.tbVenda.Name = "tbVenda";
            this.tbVenda.Size = new System.Drawing.Size(340, 26);
            this.tbVenda.TabIndex = 4;
            // 
            // tbSalario
            // 
            this.tbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalario.Location = new System.Drawing.Point(12, 273);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(340, 26);
            this.tbSalario.TabIndex = 6;
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario.Location = new System.Drawing.Point(12, 250);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(65, 20);
            this.lbSalario.TabIndex = 5;
            this.lbSalario.Text = "Salário";
            // 
            // tbConcessionaria
            // 
            this.tbConcessionaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConcessionaria.Location = new System.Drawing.Point(12, 362);
            this.tbConcessionaria.Name = "tbConcessionaria";
            this.tbConcessionaria.Size = new System.Drawing.Size(340, 26);
            this.tbConcessionaria.TabIndex = 8;
            // 
            // lbConcessionaria
            // 
            this.lbConcessionaria.AutoSize = true;
            this.lbConcessionaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConcessionaria.Location = new System.Drawing.Point(12, 339);
            this.lbConcessionaria.Name = "lbConcessionaria";
            this.lbConcessionaria.Size = new System.Drawing.Size(220, 20);
            this.lbConcessionaria.TabIndex = 7;
            this.lbConcessionaria.Text = "Vendas da concessionária";
            // 
            // tbMetaFunc
            // 
            this.tbMetaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMetaFunc.Location = new System.Drawing.Point(448, 119);
            this.tbMetaFunc.Name = "tbMetaFunc";
            this.tbMetaFunc.Size = new System.Drawing.Size(340, 26);
            this.tbMetaFunc.TabIndex = 10;
            // 
            // lbMetaFunc
            // 
            this.lbMetaFunc.AutoSize = true;
            this.lbMetaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMetaFunc.Location = new System.Drawing.Point(448, 96);
            this.lbMetaFunc.Name = "lbMetaFunc";
            this.lbMetaFunc.Size = new System.Drawing.Size(168, 20);
            this.lbMetaFunc.TabIndex = 9;
            this.lbMetaFunc.Text = "Meta do funcionário";
            // 
            // tbMetaConc
            // 
            this.tbMetaConc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMetaConc.Location = new System.Drawing.Point(448, 194);
            this.tbMetaConc.Name = "tbMetaConc";
            this.tbMetaConc.Size = new System.Drawing.Size(340, 26);
            this.tbMetaConc.TabIndex = 12;
            // 
            // lbMetaConc
            // 
            this.lbMetaConc.AutoSize = true;
            this.lbMetaConc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMetaConc.Location = new System.Drawing.Point(448, 171);
            this.lbMetaConc.Name = "lbMetaConc";
            this.lbMetaConc.Size = new System.Drawing.Size(199, 20);
            this.lbMetaConc.TabIndex = 11;
            this.lbMetaConc.Text = "Meta da concessionária";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(657, 371);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(109, 40);
            this.btCalcular.TabIndex = 13;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(538, 371);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(109, 40);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbComissao
            // 
            this.tbComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComissao.Location = new System.Drawing.Point(435, 333);
            this.tbComissao.Name = "tbComissao";
            this.tbComissao.ReadOnly = true;
            this.tbComissao.Size = new System.Drawing.Size(97, 26);
            this.tbComissao.TabIndex = 16;
            // 
            // lbComissao
            // 
            this.lbComissao.AutoSize = true;
            this.lbComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComissao.Location = new System.Drawing.Point(435, 310);
            this.lbComissao.Name = "lbComissao";
            this.lbComissao.Size = new System.Drawing.Size(87, 20);
            this.lbComissao.TabIndex = 15;
            this.lbComissao.Text = "Comissão";
            // 
            // tbPorcentagem
            // 
            this.tbPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPorcentagem.Location = new System.Drawing.Point(553, 333);
            this.tbPorcentagem.Name = "tbPorcentagem";
            this.tbPorcentagem.ReadOnly = true;
            this.tbPorcentagem.Size = new System.Drawing.Size(97, 26);
            this.tbPorcentagem.TabIndex = 18;
            // 
            // lbPorcentagem
            // 
            this.lbPorcentagem.AutoSize = true;
            this.lbPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcentagem.Location = new System.Drawing.Point(553, 310);
            this.lbPorcentagem.Name = "lbPorcentagem";
            this.lbPorcentagem.Size = new System.Drawing.Size(94, 20);
            this.lbPorcentagem.TabIndex = 17;
            this.lbPorcentagem.Text = "% da Meta";
            // 
            // tbSalarioFinal
            // 
            this.tbSalarioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalarioFinal.Location = new System.Drawing.Point(669, 333);
            this.tbSalarioFinal.Name = "tbSalarioFinal";
            this.tbSalarioFinal.ReadOnly = true;
            this.tbSalarioFinal.Size = new System.Drawing.Size(97, 26);
            this.tbSalarioFinal.TabIndex = 20;
            // 
            // lbSalarioFinal
            // 
            this.lbSalarioFinal.AutoSize = true;
            this.lbSalarioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalarioFinal.Location = new System.Drawing.Point(669, 310);
            this.lbSalarioFinal.Name = "lbSalarioFinal";
            this.lbSalarioFinal.Size = new System.Drawing.Size(109, 20);
            this.lbSalarioFinal.TabIndex = 19;
            this.lbSalarioFinal.Text = "Salário Final";
            // 
            // FormCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSalarioFinal);
            this.Controls.Add(this.lbSalarioFinal);
            this.Controls.Add(this.tbPorcentagem);
            this.Controls.Add(this.lbPorcentagem);
            this.Controls.Add(this.tbComissao);
            this.Controls.Add(this.lbComissao);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.tbMetaConc);
            this.Controls.Add(this.lbMetaConc);
            this.Controls.Add(this.tbMetaFunc);
            this.Controls.Add(this.lbMetaFunc);
            this.Controls.Add(this.tbConcessionaria);
            this.Controls.Add(this.lbConcessionaria);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.lbSalario);
            this.Controls.Add(this.tbVenda);
            this.Controls.Add(this.lbVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCargo);
            this.Name = "FormCalculo";
            this.Text = "FormComissao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbVenda;
        private System.Windows.Forms.TextBox tbVenda;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.TextBox tbConcessionaria;
        private System.Windows.Forms.Label lbConcessionaria;
        private System.Windows.Forms.TextBox tbMetaFunc;
        private System.Windows.Forms.Label lbMetaFunc;
        private System.Windows.Forms.TextBox tbMetaConc;
        private System.Windows.Forms.Label lbMetaConc;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox tbComissao;
        private System.Windows.Forms.Label lbComissao;
        private System.Windows.Forms.TextBox tbPorcentagem;
        private System.Windows.Forms.Label lbPorcentagem;
        private System.Windows.Forms.TextBox tbSalarioFinal;
        private System.Windows.Forms.Label lbSalarioFinal;
    }
}