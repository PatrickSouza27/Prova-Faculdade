
namespace AvalicaoPOO1.Telas
{
    partial class TelaCadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroProdutos));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttbDescricao = new System.Windows.Forms.TextBox();
            this.cbbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbValorUnitario = new System.Windows.Forms.TextBox();
            this.bbtVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ttbDescricao
            // 
            this.ttbDescricao.Location = new System.Drawing.Point(14, 144);
            this.ttbDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttbDescricao.Name = "ttbDescricao";
            this.ttbDescricao.Size = new System.Drawing.Size(387, 27);
            this.ttbDescricao.TabIndex = 0;
            // 
            // cbbUnidadeMedida
            // 
            this.cbbUnidadeMedida.FormattingEnabled = true;
            this.cbbUnidadeMedida.Location = new System.Drawing.Point(14, 215);
            this.cbbUnidadeMedida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbUnidadeMedida.Name = "cbbUnidadeMedida";
            this.cbbUnidadeMedida.Size = new System.Drawing.Size(198, 28);
            this.cbbUnidadeMedida.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(223, 279);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 31);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(315, 279);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(86, 31);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Preço Unitário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unidade de Medida";
            // 
            // ttbValorUnitario
            // 
            this.ttbValorUnitario.Location = new System.Drawing.Point(223, 215);
            this.ttbValorUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttbValorUnitario.Name = "ttbValorUnitario";
            this.ttbValorUnitario.Size = new System.Drawing.Size(178, 27);
            this.ttbValorUnitario.TabIndex = 2;
            // 
            // bbtVoltar
            // 
            this.bbtVoltar.Location = new System.Drawing.Point(15, 279);
            this.bbtVoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bbtVoltar.Name = "bbtVoltar";
            this.bbtVoltar.Size = new System.Drawing.Size(96, 31);
            this.bbtVoltar.TabIndex = 10;
            this.bbtVoltar.Text = "Voltar";
            this.bbtVoltar.UseVisualStyleBackColor = true;
            this.bbtVoltar.Click += new System.EventHandler(this.bbtVoltar_Click);
            // 
            // TelaCadastroProdutos
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 352);
            this.Controls.Add(this.bbtVoltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cbbUnidadeMedida);
            this.Controls.Add(this.ttbValorUnitario);
            this.Controls.Add(this.ttbDescricao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaCadastroProdutos";
            this.Text = "Minha Loja - Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ttbDescricao;
        private System.Windows.Forms.ComboBox cbbUnidadeMedida;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ttbValorUnitario;
        private System.Windows.Forms.Button bbtVoltar;
    }
}