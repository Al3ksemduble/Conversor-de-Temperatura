namespace Conversor_de_Temperatura
{
    partial class FrmTemp
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblInstrucao1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.rbCel = new System.Windows.Forms.RadioButton();
            this.rbFahr = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitulo.Location = new System.Drawing.Point(225, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(179, 17);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conversor de Temperatura";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(230, 71);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(152, 20);
            this.txtTemp.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResult.Location = new System.Drawing.Point(6, 43);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(179, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Conversor de Temperatura";
            // 
            // lblInstrucao1
            // 
            this.lblInstrucao1.AutoSize = true;
            this.lblInstrucao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInstrucao1.Location = new System.Drawing.Point(68, 71);
            this.lblInstrucao1.Name = "lblInstrucao1";
            this.lblInstrucao1.Size = new System.Drawing.Size(156, 17);
            this.lblInstrucao1.TabIndex = 5;
            this.lblInstrucao1.Text = "Digite uma temperatura";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConvert.Location = new System.Drawing.Point(269, 244);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(135, 45);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Location = new System.Drawing.Point(12, 393);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(135, 45);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // rbCel
            // 
            this.rbCel.AutoSize = true;
            this.rbCel.Location = new System.Drawing.Point(230, 119);
            this.rbCel.Name = "rbCel";
            this.rbCel.Size = new System.Drawing.Size(152, 17);
            this.rbCel.TabIndex = 9;
            this.rbCel.TabStop = true;
            this.rbCel.Text = "De Fahrenheit para Celsius";
            this.rbCel.UseVisualStyleBackColor = true;
            // 
            // rbFahr
            // 
            this.rbFahr.AutoSize = true;
            this.rbFahr.Location = new System.Drawing.Point(230, 154);
            this.rbFahr.Name = "rbFahr";
            this.rbFahr.Size = new System.Drawing.Size(152, 17);
            this.rbFahr.TabIndex = 10;
            this.rbFahr.TabStop = true;
            this.rbFahr.Text = "De Celsius para Fahrenheit";
            this.rbFahr.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.Location = new System.Drawing.Point(128, 244);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 45);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.rbFahr);
            this.Controls.Add(this.rbCel);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInstrucao1);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmTemp";
            this.Text = "Temperatura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblInstrucao1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.RadioButton rbCel;
        private System.Windows.Forms.RadioButton rbFahr;
        private System.Windows.Forms.Button btnLimpar;
    }
}

