namespace Movimentação
{
    partial class CriarConta
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
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Saldo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(15, 73);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(273, 20);
            this.tb_Nome.TabIndex = 3;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(15, 7);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(27, 13);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saldo Inicial :";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(15, 25);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(67, 20);
            this.tb_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome da Conta:";
            // 
            // tb_Saldo
            // 
            this.tb_Saldo.AcceptsTab = true;
            this.tb_Saldo.Location = new System.Drawing.Point(15, 120);
            this.tb_Saldo.Name = "tb_Saldo";
            this.tb_Saldo.Size = new System.Drawing.Size(84, 20);
            this.tb_Saldo.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_Saldo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_ID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelid);
            this.panel1.Controls.Add(this.tb_Nome);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 151);
            this.panel1.TabIndex = 6;
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 157);
            this.Controls.Add(this.panel1);
            this.Name = "CriarConta";
            this.Text = "CriarConta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Saldo;
        private System.Windows.Forms.Panel panel1;
    }
}