namespace Arrays
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
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnTextos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(157, 118);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(128, 70);
            this.btnTeste.TabIndex = 0;
            this.btnTeste.Text = "Teste Valor";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTextos
            // 
            this.btnTextos.Location = new System.Drawing.Point(157, 223);
            this.btnTextos.Name = "btnTextos";
            this.btnTextos.Size = new System.Drawing.Size(128, 63);
            this.btnTextos.TabIndex = 1;
            this.btnTextos.Text = "Vetor Textos";
            this.btnTextos.UseVisualStyleBackColor = true;
            this.btnTextos.Click += new System.EventHandler(this.btnTextos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 437);
            this.Controls.Add(this.btnTextos);
            this.Controls.Add(this.btnTeste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnTextos;
    }
}

