namespace SAP_ConnectionTest
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
            this.btnClick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerType = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompanyDb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompanyUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompanyPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(72, 193);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(253, 40);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Test";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Type";
            // 
            // txtServerType
            // 
            this.txtServerType.Location = new System.Drawing.Point(100, 10);
            this.txtServerType.Name = "txtServerType";
            this.txtServerType.Size = new System.Drawing.Size(225, 20);
            this.txtServerType.TabIndex = 2;
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(100, 36);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(225, 20);
            this.txtLicense.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "License Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(100, 62);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(225, 20);
            this.txtServer.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server";
            // 
            // txtCompanyDb
            // 
            this.txtCompanyDb.Location = new System.Drawing.Point(100, 88);
            this.txtCompanyDb.Name = "txtCompanyDb";
            this.txtCompanyDb.Size = new System.Drawing.Size(225, 20);
            this.txtCompanyDb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Company DB";
            // 
            // txtCompanyUser
            // 
            this.txtCompanyUser.Location = new System.Drawing.Point(100, 114);
            this.txtCompanyUser.Name = "txtCompanyUser";
            this.txtCompanyUser.Size = new System.Drawing.Size(225, 20);
            this.txtCompanyUser.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Company User";
            // 
            // txtCompanyPass
            // 
            this.txtCompanyPass.Location = new System.Drawing.Point(100, 140);
            this.txtCompanyPass.Name = "txtCompanyPass";
            this.txtCompanyPass.Size = new System.Drawing.Size(225, 20);
            this.txtCompanyPass.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Company Pass";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 270);
            this.Controls.Add(this.txtCompanyPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCompanyUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCompanyDb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "TESTE do SANTOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerType;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompanyDb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompanyUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompanyPass;
        private System.Windows.Forms.Label label6;
    }
}

