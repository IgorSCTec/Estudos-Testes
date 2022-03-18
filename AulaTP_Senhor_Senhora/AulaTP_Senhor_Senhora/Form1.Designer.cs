
namespace AulaTP_Senhor_Senhora
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
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.lblMasculino = new System.Windows.Forms.Label();
            this.lblFeminino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(43, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 1;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(46, 68);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 2;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(155, 68);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 3;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // btnMensagem
            // 
            this.btnMensagem.Location = new System.Drawing.Point(61, 91);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(140, 23);
            this.btnMensagem.TabIndex = 4;
            this.btnMensagem.Text = "Enviar Mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // lblMasculino
            // 
            this.lblMasculino.AutoSize = true;
            this.lblMasculino.Location = new System.Drawing.Point(43, 122);
            this.lblMasculino.Name = "lblMasculino";
            this.lblMasculino.Size = new System.Drawing.Size(35, 13);
            this.lblMasculino.TabIndex = 5;
            this.lblMasculino.Text = "label1";
            this.lblMasculino.Visible = false;
            // 
            // lblFeminino
            // 
            this.lblFeminino.AutoSize = true;
            this.lblFeminino.Location = new System.Drawing.Point(43, 122);
            this.lblFeminino.Name = "lblFeminino";
            this.lblFeminino.Size = new System.Drawing.Size(35, 13);
            this.lblFeminino.TabIndex = 6;
            this.lblFeminino.Text = "label2";
            this.lblFeminino.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 144);
            this.Controls.Add(this.lblFeminino);
            this.Controls.Add(this.lblMasculino);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.Label lblMasculino;
        private System.Windows.Forms.Label lblFeminino;
    }
}

