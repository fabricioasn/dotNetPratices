namespace Calculadora_de_Média
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
            this.lblGrade1 = new System.Windows.Forms.Label();
            this.lblGrade2 = new System.Windows.Forms.Label();
            this.lblGrade3 = new System.Windows.Forms.Label();
            this.txtBoxGrade1 = new System.Windows.Forms.TextBox();
            this.txtBoxGrade2 = new System.Windows.Forms.TextBox();
            this.txtBoxGrade3 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.btnCalculateAvg = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGrade1
            // 
            this.lblGrade1.AutoSize = true;
            this.lblGrade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade1.Location = new System.Drawing.Point(12, 21);
            this.lblGrade1.Name = "lblGrade1";
            this.lblGrade1.Size = new System.Drawing.Size(210, 25);
            this.lblGrade1.TabIndex = 0;
            this.lblGrade1.Text = "DIGITE A 1ª NOTA: ";
            // 
            // lblGrade2
            // 
            this.lblGrade2.AutoSize = true;
            this.lblGrade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade2.Location = new System.Drawing.Point(12, 69);
            this.lblGrade2.Name = "lblGrade2";
            this.lblGrade2.Size = new System.Drawing.Size(210, 25);
            this.lblGrade2.TabIndex = 1;
            this.lblGrade2.Text = "DIGITE A 2ª NOTA: ";
            // 
            // lblGrade3
            // 
            this.lblGrade3.AutoSize = true;
            this.lblGrade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade3.Location = new System.Drawing.Point(12, 113);
            this.lblGrade3.Name = "lblGrade3";
            this.lblGrade3.Size = new System.Drawing.Size(210, 25);
            this.lblGrade3.TabIndex = 2;
            this.lblGrade3.Text = "DIGITE A 3ª NOTA: ";
            // 
            // txtBoxGrade1
            // 
            this.txtBoxGrade1.Location = new System.Drawing.Point(229, 21);
            this.txtBoxGrade1.Name = "txtBoxGrade1";
            this.txtBoxGrade1.Size = new System.Drawing.Size(156, 26);
            this.txtBoxGrade1.TabIndex = 3;
            // 
            // txtBoxGrade2
            // 
            this.txtBoxGrade2.Location = new System.Drawing.Point(229, 68);
            this.txtBoxGrade2.Name = "txtBoxGrade2";
            this.txtBoxGrade2.Size = new System.Drawing.Size(156, 26);
            this.txtBoxGrade2.TabIndex = 4;
            // 
            // txtBoxGrade3
            // 
            this.txtBoxGrade3.Location = new System.Drawing.Point(229, 112);
            this.txtBoxGrade3.Name = "txtBoxGrade3";
            this.txtBoxGrade3.Size = new System.Drawing.Size(156, 26);
            this.txtBoxGrade3.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(64, 190);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(93, 25);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "MÉDIA: ";
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(229, 191);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(156, 26);
            this.txtBoxResult.TabIndex = 7;
            // 
            // btnCalculateAvg
            // 
            this.btnCalculateAvg.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCalculateAvg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalculateAvg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalculateAvg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalculateAvg.Location = new System.Drawing.Point(229, 309);
            this.btnCalculateAvg.Name = "btnCalculateAvg";
            this.btnCalculateAvg.Size = new System.Drawing.Size(156, 75);
            this.btnCalculateAvg.TabIndex = 8;
            this.btnCalculateAvg.Text = "CALCULAR MÉDIA";
            this.btnCalculateAvg.UseVisualStyleBackColor = false;
            this.btnCalculateAvg.Click += new System.EventHandler(this.btnCalculateAvg_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PowderBlue;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.Location = new System.Drawing.Point(443, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 75);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "SAIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PowderBlue;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Location = new System.Drawing.Point(33, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 75);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "LIMPAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 409);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateAvg);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtBoxGrade3);
            this.Controls.Add(this.txtBoxGrade2);
            this.Controls.Add(this.txtBoxGrade1);
            this.Controls.Add(this.lblGrade3);
            this.Controls.Add(this.lblGrade2);
            this.Controls.Add(this.lblGrade1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrade1;
        private System.Windows.Forms.Label lblGrade2;
        private System.Windows.Forms.Label lblGrade3;
        private System.Windows.Forms.TextBox txtBoxGrade1;
        private System.Windows.Forms.TextBox txtBoxGrade2;
        private System.Windows.Forms.TextBox txtBoxGrade3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Button btnCalculateAvg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

