namespace WindowsFormsApp1
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
            this.btn_sortear = new System.Windows.Forms.Button();
            this.lblNumeroAtual = new System.Windows.Forms.Label();
            this.lblNumeroAnterior = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sortear
            // 
            this.btn_sortear.Location = new System.Drawing.Point(335, 2);
            this.btn_sortear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sortear.Name = "btn_sortear";
            this.btn_sortear.Size = new System.Drawing.Size(111, 19);
            this.btn_sortear.TabIndex = 1;
            this.btn_sortear.Text = "Sortear Número";
            this.btn_sortear.UseVisualStyleBackColor = true;
            this.btn_sortear.Click += new System.EventHandler(this.btn_sortear_Click);
            // 
            // lblNumeroAtual
            // 
            this.lblNumeroAtual.AutoSize = true;
            this.lblNumeroAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAtual.Location = new System.Drawing.Point(374, 43);
            this.lblNumeroAtual.Name = "lblNumeroAtual";
            this.lblNumeroAtual.Size = new System.Drawing.Size(51, 20);
            this.lblNumeroAtual.TabIndex = 78;
            this.lblNumeroAtual.Text = "label1";
            this.lblNumeroAtual.Click += new System.EventHandler(this.lblNumeroAtual_Click);
            // 
            // lblNumeroAnterior
            // 
            this.lblNumeroAnterior.AutoSize = true;
            this.lblNumeroAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAnterior.Location = new System.Drawing.Point(374, 107);
            this.lblNumeroAnterior.Name = "lblNumeroAnterior";
            this.lblNumeroAnterior.Size = new System.Drawing.Size(51, 20);
            this.lblNumeroAnterior.TabIndex = 79;
            this.lblNumeroAnterior.Text = "label2";
            this.lblNumeroAnterior.Click += new System.EventHandler(this.lblNumeroAnterior_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Número Atual";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Número Anterior";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(826, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumeroAnterior);
            this.Controls.Add(this.lblNumeroAtual);
            this.Controls.Add(this.btn_sortear);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_sortear;
        private System.Windows.Forms.Label lblNumeroAtual;
        private System.Windows.Forms.Label lblNumeroAnterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

