namespace AvalicaoPOO1.Telas
{
    partial class CadastrarUnidadeDeMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarUnidadeDeMedia));
            this.bbtCadastrar = new System.Windows.Forms.Button();
            this.bbtLimpar = new System.Windows.Forms.Button();
            this.bbtVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttbDescricaoMedida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bbtCadastrar
            // 
            this.bbtCadastrar.Location = new System.Drawing.Point(324, 262);
            this.bbtCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bbtCadastrar.Name = "bbtCadastrar";
            this.bbtCadastrar.Size = new System.Drawing.Size(86, 31);
            this.bbtCadastrar.TabIndex = 0;
            this.bbtCadastrar.Text = "Cadastrar";
            this.bbtCadastrar.UseVisualStyleBackColor = true;
            this.bbtCadastrar.Click += new System.EventHandler(this.bbtCadastrar_Click);
            // 
            // bbtLimpar
            // 
            this.bbtLimpar.Location = new System.Drawing.Point(231, 262);
            this.bbtLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bbtLimpar.Name = "bbtLimpar";
            this.bbtLimpar.Size = new System.Drawing.Size(86, 31);
            this.bbtLimpar.TabIndex = 1;
            this.bbtLimpar.Text = "Limpar";
            this.bbtLimpar.UseVisualStyleBackColor = true;
            this.bbtLimpar.Click += new System.EventHandler(this.bbtLimpar_Click);
            // 
            // bbtVoltar
            // 
            this.bbtVoltar.Location = new System.Drawing.Point(23, 262);
            this.bbtVoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bbtVoltar.Name = "bbtVoltar";
            this.bbtVoltar.Size = new System.Drawing.Size(96, 31);
            this.bbtVoltar.TabIndex = 2;
            this.bbtVoltar.Text = "Voltar";
            this.bbtVoltar.UseVisualStyleBackColor = true;
            this.bbtVoltar.Click += new System.EventHandler(this.bbtVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro Unidade De Medida";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ttbDescricaoMedida
            // 
            this.ttbDescricaoMedida.Location = new System.Drawing.Point(23, 186);
            this.ttbDescricaoMedida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttbDescricaoMedida.Name = "ttbDescricaoMedida";
            this.ttbDescricaoMedida.Size = new System.Drawing.Size(387, 27);
            this.ttbDescricaoMedida.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Unidade De Medida";
            // 
            // CadastrarUnidadeDeMedia
            // 
            this.AcceptButton = this.bbtCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ttbDescricaoMedida);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bbtVoltar);
            this.Controls.Add(this.bbtLimpar);
            this.Controls.Add(this.bbtCadastrar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CadastrarUnidadeDeMedia";
            this.Text = "Cadastrar Unidade De Media";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bbtCadastrar;
        private System.Windows.Forms.Button bbtLimpar;
        private System.Windows.Forms.Button bbtVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ttbDescricaoMedida;
        private System.Windows.Forms.Label label2;
    }
}