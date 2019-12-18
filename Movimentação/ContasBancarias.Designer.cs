namespace Movimentação
{
    partial class ContasBancarias
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
            this.btnSaque = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.TodasContas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(234, 103);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(123, 52);
            this.btnSaque.TabIndex = 2;
            this.btnSaque.Text = "Saque dinheiro";
            this.btnSaque.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(398, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(106, 103);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(122, 52);
            this.btnDeposito.TabIndex = 1;
            this.btnDeposito.Text = "Deposito Dinheiro";
            this.btnDeposito.UseVisualStyleBackColor = true;
            // 
            // TodasContas
            // 
            this.TodasContas.FormattingEnabled = true;
            this.TodasContas.Location = new System.Drawing.Point(45, 63);
            this.TodasContas.Name = "TodasContas";
            this.TodasContas.Size = new System.Drawing.Size(398, 21);
            this.TodasContas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contas:";
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Location = new System.Drawing.Point(162, 161);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(135, 26);
            this.btnCriarConta.TabIndex = 5;
            this.btnCriarConta.Text = "Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // ContasBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 212);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TodasContas);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnSaque);
            this.Name = "ContasBancarias";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.ComboBox TodasContas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriarConta;
    }
}

