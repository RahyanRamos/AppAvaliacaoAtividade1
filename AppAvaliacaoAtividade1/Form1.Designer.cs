namespace AppAvaliacaoAtividade1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btComissao = new System.Windows.Forms.Button();
            this.btMeta = new System.Windows.Forms.Button();
            this.btSalario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME COMPLETO: Rahyan Ramos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "ATIVIDADE 1";
            // 
            // btComissao
            // 
            this.btComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComissao.Location = new System.Drawing.Point(45, 149);
            this.btComissao.Name = "btComissao";
            this.btComissao.Size = new System.Drawing.Size(108, 54);
            this.btComissao.TabIndex = 3;
            this.btComissao.Text = "Comissão";
            this.btComissao.UseVisualStyleBackColor = true;
            this.btComissao.Click += new System.EventHandler(this.btComissao_Click);
            // 
            // btMeta
            // 
            this.btMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMeta.Location = new System.Drawing.Point(278, 149);
            this.btMeta.Name = "btMeta";
            this.btMeta.Size = new System.Drawing.Size(108, 54);
            this.btMeta.TabIndex = 4;
            this.btMeta.Text = "Meta";
            this.btMeta.UseVisualStyleBackColor = true;
            // 
            // btSalario
            // 
            this.btSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalario.Location = new System.Drawing.Point(518, 149);
            this.btSalario.Name = "btSalario";
            this.btSalario.Size = new System.Drawing.Size(108, 54);
            this.btSalario.TabIndex = 5;
            this.btSalario.Text = "Salário";
            this.btSalario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 366);
            this.Controls.Add(this.btSalario);
            this.Controls.Add(this.btMeta);
            this.Controls.Add(this.btComissao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btComissao;
        private System.Windows.Forms.Button btMeta;
        private System.Windows.Forms.Button btSalario;
    }
}

