namespace calcularnotas
{
    partial class Form1
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.nota1 = new System.Windows.Forms.Label();
            this.nota2 = new System.Windows.Forms.Label();
            this.nota3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nota4 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota4 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(267, 352);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(100, 36);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(435, 352);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(100, 36);
            this.btnsair.TabIndex = 1;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // nota1
            // 
            this.nota1.AutoSize = true;
            this.nota1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nota1.Location = new System.Drawing.Point(217, 147);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(43, 16);
            this.nota1.TabIndex = 2;
            this.nota1.Text = "nota1:";
            // 
            // nota2
            // 
            this.nota2.AutoSize = true;
            this.nota2.Location = new System.Drawing.Point(217, 194);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(43, 16);
            this.nota2.TabIndex = 3;
            this.nota2.Text = "nota2:";
            // 
            // nota3
            // 
            this.nota3.AutoSize = true;
            this.nota3.Location = new System.Drawing.Point(217, 250);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(43, 16);
            this.nota3.TabIndex = 4;
            this.nota3.Text = "nota3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 81);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(1);
            this.label5.Size = new System.Drawing.Size(472, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Calcule 4 notas e descubra sua média: ";
            // 
            // nota4
            // 
            this.nota4.AutoSize = true;
            this.nota4.Location = new System.Drawing.Point(217, 302);
            this.nota4.Name = "nota4";
            this.nota4.Size = new System.Drawing.Size(43, 16);
            this.nota4.TabIndex = 6;
            this.nota4.Text = "nota4:";
            this.nota4.Click += new System.EventHandler(this.txtnota4_Click);
            // 
            // txtnota1
            // 
            this.txtnota1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtnota1.Location = new System.Drawing.Point(267, 141);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 22);
            this.txtnota1.TabIndex = 7;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(267, 191);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 22);
            this.txtnota2.TabIndex = 8;
            // 
            // txtnota4
            // 
            this.txtnota4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtnota4.Location = new System.Drawing.Point(267, 299);
            this.txtnota4.Name = "txtnota4";
            this.txtnota4.Size = new System.Drawing.Size(100, 22);
            this.txtnota4.TabIndex = 9;
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(267, 247);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(100, 22);
            this.txtnota3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Média";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota4);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.nota4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncalcular);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label nota1;
        private System.Windows.Forms.Label nota2;
        private System.Windows.Forms.Label nota3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nota4;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota4;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.Label label6;
    }
}

