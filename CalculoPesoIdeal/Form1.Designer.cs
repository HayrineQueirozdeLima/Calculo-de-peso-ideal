
namespace CalculoPesoIdeal
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.radiomasculino = new System.Windows.Forms.RadioButton();
            this.radioFeminino = new System.Windows.Forms.RadioButton();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(58, 9);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(49, 17);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura:";
            // 
            // radiomasculino
            // 
            this.radiomasculino.AutoSize = true;
            this.radiomasculino.Location = new System.Drawing.Point(6, 21);
            this.radiomasculino.Name = "radiomasculino";
            this.radiomasculino.Size = new System.Drawing.Size(92, 21);
            this.radiomasculino.TabIndex = 1;
            this.radiomasculino.TabStop = true;
            this.radiomasculino.Text = "Masculino";
            this.radiomasculino.UseVisualStyleBackColor = true;
            this.radiomasculino.CheckedChanged += new System.EventHandler(this.radioMasculino_CheckedChanged);
            // 
            // radioFeminino
            // 
            this.radioFeminino.AutoSize = true;
            this.radioFeminino.Location = new System.Drawing.Point(104, 21);
            this.radioFeminino.Name = "radioFeminino";
            this.radioFeminino.Size = new System.Drawing.Size(86, 21);
            this.radioFeminino.TabIndex = 2;
            this.radioFeminino.TabStop = true;
            this.radioFeminino.Text = "Feminino";
            this.radioFeminino.UseVisualStyleBackColor = true;
            this.radioFeminino.CheckedChanged += new System.EventHandler(this.radioFeminino_CheckedChanged);
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoIdeal.ForeColor = System.Drawing.Color.Red;
            this.lblPesoIdeal.Location = new System.Drawing.Point(116, 97);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(87, 31);
            this.lblPesoIdeal.TabIndex = 3;
            this.lblPesoIdeal.Text = "00.00";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(58, 37);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(101, 22);
            this.txtAltura.TabIndex = 4;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.radiomasculino);
            this.gbxSexo.Controls.Add(this.radioFeminino);
            this.gbxSexo.Location = new System.Drawing.Point(235, 12);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(193, 50);
            this.gbxSexo.TabIndex = 5;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(125, 71);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(74, 17);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Peso Ideal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 146);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.lblAltura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Cálculo do peso ideal";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.RadioButton radiomasculino;
        private System.Windows.Forms.RadioButton radioFeminino;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.Label lblPeso;
    }
}

