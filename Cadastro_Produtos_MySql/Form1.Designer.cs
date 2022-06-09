namespace Cadastro_Produtos_MySql
{
    partial class AutoPeca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoPeca));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQtd_Estoque = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.Inserir = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbQtd_Estoque = new System.Windows.Forms.Label();
            this.lbCodigoBarra = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.lbCadastros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNome.Location = new System.Drawing.Point(19, 49);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(188, 21);
            this.txtNome.TabIndex = 0;
            // 
            // txtQtd_Estoque
            // 
            this.txtQtd_Estoque.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQtd_Estoque.Location = new System.Drawing.Point(283, 49);
            this.txtQtd_Estoque.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQtd_Estoque.Name = "txtQtd_Estoque";
            this.txtQtd_Estoque.Size = new System.Drawing.Size(188, 21);
            this.txtQtd_Estoque.TabIndex = 1;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPreco.Location = new System.Drawing.Point(19, 113);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(188, 21);
            this.txtPreco.TabIndex = 2;
            // 
            // Inserir
            // 
            this.Inserir.BackColor = System.Drawing.Color.White;
            this.Inserir.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Inserir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Inserir.Location = new System.Drawing.Point(19, 166);
            this.Inserir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(92, 36);
            this.Inserir.TabIndex = 3;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = false;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.Color.White;
            this.Limpar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Limpar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Limpar.Location = new System.Drawing.Point(283, 166);
            this.Limpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(89, 36);
            this.Limpar.TabIndex = 4;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCodigoBarra.Location = new System.Drawing.Point(283, 113);
            this.txtCodigoBarra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(188, 21);
            this.txtCodigoBarra.TabIndex = 5;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.SystemColors.Window;
            this.lbNome.Location = new System.Drawing.Point(17, 26);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(98, 19);
            this.lbNome.TabIndex = 7;
            this.lbNome.Text = "Nome Produto";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.BackColor = System.Drawing.Color.Transparent;
            this.lbPreco.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbPreco.ForeColor = System.Drawing.SystemColors.Window;
            this.lbPreco.Location = new System.Drawing.Point(18, 89);
            this.lbPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(45, 19);
            this.lbPreco.TabIndex = 8;
            this.lbPreco.Text = "Preço";
            // 
            // lbQtd_Estoque
            // 
            this.lbQtd_Estoque.AutoSize = true;
            this.lbQtd_Estoque.BackColor = System.Drawing.Color.Transparent;
            this.lbQtd_Estoque.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbQtd_Estoque.ForeColor = System.Drawing.Color.White;
            this.lbQtd_Estoque.Location = new System.Drawing.Point(280, 28);
            this.lbQtd_Estoque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQtd_Estoque.Name = "lbQtd_Estoque";
            this.lbQtd_Estoque.Size = new System.Drawing.Size(88, 19);
            this.lbQtd_Estoque.TabIndex = 9;
            this.lbQtd_Estoque.Text = "Qtd_Estoque";
            // 
            // lbCodigoBarra
            // 
            this.lbCodigoBarra.AutoSize = true;
            this.lbCodigoBarra.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigoBarra.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbCodigoBarra.ForeColor = System.Drawing.Color.White;
            this.lbCodigoBarra.Location = new System.Drawing.Point(281, 92);
            this.lbCodigoBarra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigoBarra.Name = "lbCodigoBarra";
            this.lbCodigoBarra.Size = new System.Drawing.Size(109, 19);
            this.lbCodigoBarra.TabIndex = 10;
            this.lbCodigoBarra.Text = "Código de Barra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 11;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(24, 265);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.Size = new System.Drawing.Size(552, 180);
            this.dgvProdutos.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(24, 451);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "Buscar Dados";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbCadastros
            // 
            this.lbCadastros.AutoSize = true;
            this.lbCadastros.BackColor = System.Drawing.Color.Transparent;
            this.lbCadastros.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbCadastros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCadastros.Location = new System.Drawing.Point(20, 240);
            this.lbCadastros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCadastros.Name = "lbCadastros";
            this.lbCadastros.Size = new System.Drawing.Size(131, 19);
            this.lbCadastros.TabIndex = 14;
            this.lbCadastros.Text = "Dados Cadastrados";
            // 
            // AutoPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 499);
            this.Controls.Add(this.lbCadastros);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCodigoBarra);
            this.Controls.Add(this.lbQtd_Estoque);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtQtd_Estoque);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AutoPeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Auto Preço";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtQtd_Estoque;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbQtd_Estoque;
        private System.Windows.Forms.Label lbCodigoBarra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbCadastros;
    }
}
