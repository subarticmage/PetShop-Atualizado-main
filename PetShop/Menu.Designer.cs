namespace PetShop
{
    partial class Menu
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
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnServico = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(141, 278);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(101, 61);
            this.btnVendas.TabIndex = 0;
            this.btnVendas.Text = "Listar Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnServico
            // 
            this.btnServico.Location = new System.Drawing.Point(141, 91);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(101, 61);
            this.btnServico.TabIndex = 1;
            this.btnServico.Text = "Serviços";
            this.btnServico.UseVisualStyleBackColor = true;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Location = new System.Drawing.Point(141, 182);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(101, 61);
            this.btnCaixa.TabIndex = 2;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(392, 443);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnServico);
            this.Controls.Add(this.btnVendas);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnServico;
        private System.Windows.Forms.Button btnCaixa;
    }
}