
namespace Converter_Moeda
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
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCotacao = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.lblConverter = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCotacao = new System.Windows.Forms.TextBox();
            this.rdbMReal = new System.Windows.Forms.RadioButton();
            this.rdbCReal = new System.Windows.Forms.RadioButton();
            this.rdbMDolar = new System.Windows.Forms.RadioButton();
            this.rdbCDolar = new System.Windows.Forms.RadioButton();
            this.btnConverter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpConverter = new System.Windows.Forms.GroupBox();
            this.gpConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(29, 11);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(64, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor Inicial:";
            // 
            // lblCotacao
            // 
            this.lblCotacao.AutoSize = true;
            this.lblCotacao.Location = new System.Drawing.Point(29, 41);
            this.lblCotacao.Name = "lblCotacao";
            this.lblCotacao.Size = new System.Drawing.Size(50, 13);
            this.lblCotacao.TabIndex = 1;
            this.lblCotacao.Text = "Cotação:";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(19, 79);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(40, 13);
            this.lblMoeda.TabIndex = 2;
            this.lblMoeda.Text = "Moeda";
            // 
            // lblConverter
            // 
            this.lblConverter.AutoSize = true;
            this.lblConverter.Location = new System.Drawing.Point(129, 79);
            this.lblConverter.Name = "lblConverter";
            this.lblConverter.Size = new System.Drawing.Size(67, 13);
            this.lblConverter.TabIndex = 3;
            this.lblConverter.Text = "Converter p/";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(96, 9);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 4;
            // 
            // txtCotacao
            // 
            this.txtCotacao.Location = new System.Drawing.Point(96, 38);
            this.txtCotacao.Name = "txtCotacao";
            this.txtCotacao.Size = new System.Drawing.Size(100, 20);
            this.txtCotacao.TabIndex = 5;
            // 
            // rdbMReal
            // 
            this.rdbMReal.AutoSize = true;
            this.rdbMReal.Location = new System.Drawing.Point(12, 107);
            this.rdbMReal.Name = "rdbMReal";
            this.rdbMReal.Size = new System.Drawing.Size(47, 17);
            this.rdbMReal.TabIndex = 6;
            this.rdbMReal.TabStop = true;
            this.rdbMReal.Text = "Real";
            this.rdbMReal.UseVisualStyleBackColor = true;
            // 
            // rdbCReal
            // 
            this.rdbCReal.AutoSize = true;
            this.rdbCReal.Location = new System.Drawing.Point(3, 12);
            this.rdbCReal.Name = "rdbCReal";
            this.rdbCReal.Size = new System.Drawing.Size(47, 17);
            this.rdbCReal.TabIndex = 7;
            this.rdbCReal.TabStop = true;
            this.rdbCReal.Text = "Real";
            this.rdbCReal.UseVisualStyleBackColor = true;
            // 
            // rdbMDolar
            // 
            this.rdbMDolar.AutoSize = true;
            this.rdbMDolar.Location = new System.Drawing.Point(12, 130);
            this.rdbMDolar.Name = "rdbMDolar";
            this.rdbMDolar.Size = new System.Drawing.Size(50, 17);
            this.rdbMDolar.TabIndex = 8;
            this.rdbMDolar.TabStop = true;
            this.rdbMDolar.Text = "Dolar";
            this.rdbMDolar.UseVisualStyleBackColor = true;
            // 
            // rdbCDolar
            // 
            this.rdbCDolar.AutoSize = true;
            this.rdbCDolar.Location = new System.Drawing.Point(3, 35);
            this.rdbCDolar.Name = "rdbCDolar";
            this.rdbCDolar.Size = new System.Drawing.Size(50, 17);
            this.rdbCDolar.TabIndex = 9;
            this.rdbCDolar.TabStop = true;
            this.rdbCDolar.Text = "Dolar";
            this.rdbCDolar.UseVisualStyleBackColor = true;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(64, 158);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 10;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(56, 62);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // gpConverter
            // 
            this.gpConverter.Controls.Add(this.rdbCReal);
            this.gpConverter.Controls.Add(this.rdbCDolar);
            this.gpConverter.Location = new System.Drawing.Point(132, 95);
            this.gpConverter.Name = "gpConverter";
            this.gpConverter.Size = new System.Drawing.Size(56, 62);
            this.gpConverter.TabIndex = 12;
            this.gpConverter.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 193);
            this.Controls.Add(this.gpConverter);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.rdbMDolar);
            this.Controls.Add(this.rdbMReal);
            this.Controls.Add(this.txtCotacao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblConverter);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.lblCotacao);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpConverter.ResumeLayout(false);
            this.gpConverter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCotacao;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.Label lblConverter;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCotacao;
        private System.Windows.Forms.RadioButton rdbMReal;
        private System.Windows.Forms.RadioButton rdbCReal;
        private System.Windows.Forms.RadioButton rdbMDolar;
        private System.Windows.Forms.RadioButton rdbCDolar;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpConverter;
    }
}

