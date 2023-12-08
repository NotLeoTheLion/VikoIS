namespace User_Authentication
{
    partial class frm_Home
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
            this.btn_Edit_Grade = new System.Windows.Forms.Button();
            this.btn_adduseradmin = new System.Windows.Forms.Button();
            this.btn_checkgrade = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_loguser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Edit_Grade
            // 
            this.btn_Edit_Grade.Location = new System.Drawing.Point(25, 166);
            this.btn_Edit_Grade.Name = "btn_Edit_Grade";
            this.btn_Edit_Grade.Size = new System.Drawing.Size(284, 200);
            this.btn_Edit_Grade.TabIndex = 3;
            this.btn_Edit_Grade.Text = "Redaguoti Pazymius";
            this.btn_Edit_Grade.UseVisualStyleBackColor = true;
            this.btn_Edit_Grade.Click += new System.EventHandler(this.btn_Edit_Grade_Click);
            // 
            // btn_adduseradmin
            // 
            this.btn_adduseradmin.Location = new System.Drawing.Point(695, 166);
            this.btn_adduseradmin.Name = "btn_adduseradmin";
            this.btn_adduseradmin.Size = new System.Drawing.Size(286, 200);
            this.btn_adduseradmin.TabIndex = 4;
            this.btn_adduseradmin.Text = "Prideti Vartotoja";
            this.btn_adduseradmin.UseVisualStyleBackColor = true;
            this.btn_adduseradmin.Click += new System.EventHandler(this.btn_adduseradmin_Click);
            // 
            // btn_checkgrade
            // 
            this.btn_checkgrade.Location = new System.Drawing.Point(340, 166);
            this.btn_checkgrade.Name = "btn_checkgrade";
            this.btn_checkgrade.Size = new System.Drawing.Size(324, 200);
            this.btn_checkgrade.TabIndex = 5;
            this.btn_checkgrade.Text = "Perziureti Pazymius";
            this.btn_checkgrade.UseVisualStyleBackColor = true;
            this.btn_checkgrade.Click += new System.EventHandler(this.btn_checkgrade_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(876, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(105, 30);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Atsijungti";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_loguser
            // 
            this.lbl_loguser.AutoSize = true;
            this.lbl_loguser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loguser.Location = new System.Drawing.Point(244, 59);
            this.lbl_loguser.Name = "lbl_loguser";
            this.lbl_loguser.Size = new System.Drawing.Size(119, 36);
            this.lbl_loguser.TabIndex = 7;
            this.lbl_loguser.Text = "Sveiki: ";
            this.lbl_loguser.Click += new System.EventHandler(this.lbl_loguser_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 526);
            this.Controls.Add(this.lbl_loguser);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_checkgrade);
            this.Controls.Add(this.btn_adduseradmin);
            this.Controls.Add(this.btn_Edit_Grade);
            this.Name = "frm_Home";
            this.Text = "Namai";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Edit_Grade;
        private System.Windows.Forms.Button btn_adduseradmin;
        private System.Windows.Forms.Button btn_checkgrade;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_loguser;
    }
}