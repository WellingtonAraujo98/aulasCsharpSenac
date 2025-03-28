namespace windowsForms2603
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
            this.botao = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonDateTime = new System.Windows.Forms.Button();
            this.buttonTimeSpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botao
            // 
            this.botao.Location = new System.Drawing.Point(118, 333);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(75, 23);
            this.botao.TabIndex = 0;
            this.botao.Text = "Aperte aqui";
            this.botao.UseVisualStyleBackColor = true;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResultado.Location = new System.Drawing.Point(95, 49);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(50, 13);
            this.labelResultado.TabIndex = 1;
            this.labelResultado.Text = "resultado";
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(249, 332);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonRandom.TabIndex = 2;
            this.buttonRandom.Text = "randomico";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonDateTime
            // 
            this.buttonDateTime.Location = new System.Drawing.Point(363, 332);
            this.buttonDateTime.Name = "buttonDateTime";
            this.buttonDateTime.Size = new System.Drawing.Size(75, 23);
            this.buttonDateTime.TabIndex = 3;
            this.buttonDateTime.Text = "data";
            this.buttonDateTime.UseVisualStyleBackColor = true;
            this.buttonDateTime.Click += new System.EventHandler(this.buttonDateTime_Click);
            // 
            // buttonTimeSpan
            // 
            this.buttonTimeSpan.Location = new System.Drawing.Point(465, 332);
            this.buttonTimeSpan.Name = "buttonTimeSpan";
            this.buttonTimeSpan.Size = new System.Drawing.Size(75, 23);
            this.buttonTimeSpan.TabIndex = 4;
            this.buttonTimeSpan.Text = "dataSpan";
            this.buttonTimeSpan.UseVisualStyleBackColor = true;
            this.buttonTimeSpan.Click += new System.EventHandler(this.buttonTimeSpan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTimeSpan);
            this.Controls.Add(this.buttonDateTime);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.botao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonDateTime;
        private System.Windows.Forms.Button buttonTimeSpan;
    }
}

