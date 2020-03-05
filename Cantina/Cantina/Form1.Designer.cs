namespace Cantina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbnValor = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lstCaixa = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA CANTINA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CÓDIGO DO PRODUTO";
            // 
            // lbnValor
            // 
            this.lbnValor.AutoSize = true;
            this.lbnValor.Location = new System.Drawing.Point(102, 353);
            this.lbnValor.Name = "lbnValor";
            this.lbnValor.Size = new System.Drawing.Size(84, 13);
            this.lbnValor.TabIndex = 2;
            this.lbnValor.Text = "VALOR TOTAL:";
            // 
            // picImage
            // 
            this.picImage.Image = global::Cantina.Properties.Resources._001;
            this.picImage.Location = new System.Drawing.Point(12, 146);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(160, 151);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 111);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(160, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lstCaixa
            // 
            this.lstCaixa.FormattingEnabled = true;
            this.lstCaixa.Location = new System.Drawing.Point(277, 107);
            this.lstCaixa.Name = "lstCaixa";
            this.lstCaixa.Size = new System.Drawing.Size(171, 186);
            this.lstCaixa.TabIndex = 5;
            this.lstCaixa.SelectedIndexChanged += new System.EventHandler(this.lstCaixa_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 457);
            this.Controls.Add(this.lstCaixa);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lbnValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbnValor;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ListBox lstCaixa;
    }
}

