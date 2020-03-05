namespace Shop
{
    partial class Cadastro_usuario
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPswd = new System.Windows.Forms.TextBox();
            this.txtBoxReg = new System.Windows.Forms.TextBox();
            this.cboSituation = new System.Windows.Forms.ComboBox();
            this.cboProfile = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE USUÁRIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Register:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Situation:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Profile:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(118, 35);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(361, 26);
            this.txtBoxName.TabIndex = 8;
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(118, 73);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(221, 26);
            this.txtBoxLogin.TabIndex = 9;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(118, 111);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(361, 26);
            this.txtBoxEmail.TabIndex = 10;
            // 
            // txtBoxPswd
            // 
            this.txtBoxPswd.Location = new System.Drawing.Point(118, 150);
            this.txtBoxPswd.Name = "txtBoxPswd";
            this.txtBoxPswd.Size = new System.Drawing.Size(148, 26);
            this.txtBoxPswd.TabIndex = 11;
            // 
            // txtBoxReg
            // 
            this.txtBoxReg.Location = new System.Drawing.Point(118, 191);
            this.txtBoxReg.Name = "txtBoxReg";
            this.txtBoxReg.Size = new System.Drawing.Size(148, 26);
            this.txtBoxReg.TabIndex = 12;
            this.txtBoxReg.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cboSituation
            // 
            this.cboSituation.FormattingEnabled = true;
            this.cboSituation.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboSituation.Location = new System.Drawing.Point(118, 233);
            this.cboSituation.Name = "cboSituation";
            this.cboSituation.Size = new System.Drawing.Size(148, 28);
            this.cboSituation.TabIndex = 13;
            this.cboSituation.SelectedIndexChanged += new System.EventHandler(this.cboSituation_SelectedIndexChanged);
            // 
            // cboProfile
            // 
            this.cboProfile.FormattingEnabled = true;
            this.cboProfile.Items.AddRange(new object[] {
            "Administrador",
            "Operador",
            "Gerencial"});
            this.cboProfile.Location = new System.Drawing.Point(118, 271);
            this.cboProfile.Name = "cboProfile";
            this.cboProfile.Size = new System.Drawing.Size(148, 28);
            this.cboProfile.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(475, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cadastro_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 586);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboProfile);
            this.Controls.Add(this.cboSituation);
            this.Controls.Add(this.txtBoxReg);
            this.Controls.Add(this.txtBoxPswd);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro_usuario";
            this.Text = "Cadastro_usuario";
            this.Load += new System.EventHandler(this.Cadastro_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPswd;
        private System.Windows.Forms.TextBox txtBoxReg;
        private System.Windows.Forms.ComboBox cboSituation;
        private System.Windows.Forms.ComboBox cboProfile;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}