namespace ImprimirPreçoCg
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
            this.btnArquivo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArquivo
            // 
            this.btnArquivo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivo.Location = new System.Drawing.Point(72, 142);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(200, 72);
            this.btnArquivo.TabIndex = 0;
            this.btnArquivo.Text = "Selecionar Arquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(352, 142);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(200, 72);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(634, 369);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnArquivo);
            this.Name = "Form1";
            this.Text = "Imprimir ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Button btnImprimir;
    }
}

