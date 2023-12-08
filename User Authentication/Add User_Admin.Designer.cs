namespace User_Authentication
{
    partial class frm_Add_User_Admin
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
            this.components = new System.ComponentModel.Container();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.tbllogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new User_Authentication.AppData();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_adminuser = new System.Windows.Forms.DataGridView();
            this.tbllogTableAdapter = new User_Authentication.AppDataTableAdapters.tbllogTableAdapter();
            this.tbllogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adminuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(44, 161);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(311, 31);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "Naujas vartotojas";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(44, 216);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(311, 31);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Redaguoti";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(44, 271);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(311, 31);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Issaugoti";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(44, 326);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(311, 31);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Pasalinti";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(44, 381);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(311, 31);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Atsaukti";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_userName
            // 
            this.txt_userName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "Username", true));
            this.txt_userName.Location = new System.Drawing.Point(181, 25);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(174, 22);
            this.txt_userName.TabIndex = 5;
            // 
            // tbllogBindingSource
            // 
            this.tbllogBindingSource.DataMember = "tbllog";
            this.tbllogBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_password
            // 
            this.txt_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "Password", true));
            this.txt_password.Location = new System.Drawing.Point(181, 61);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(174, 22);
            this.txt_password.TabIndex = 6;
            // 
            // cb_role
            // 
            this.cb_role.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tbllogBindingSource, "role", true));
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Admin",
            "Destytojas",
            "Studentas"});
            this.cb_role.Location = new System.Drawing.Point(181, 97);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(174, 24);
            this.cb_role.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vardas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pavarde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Role";
            // 
            // dgv_adminuser
            // 
            this.dgv_adminuser.AutoGenerateColumns = false;
            this.dgv_adminuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_adminuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.Id});
            this.dgv_adminuser.DataSource = this.tbllogBindingSource;
            this.dgv_adminuser.Location = new System.Drawing.Point(384, 12);
            this.dgv_adminuser.Name = "dgv_adminuser";
            this.dgv_adminuser.RowHeadersWidth = 51;
            this.dgv_adminuser.RowTemplate.Height = 24;
            this.dgv_adminuser.Size = new System.Drawing.Size(616, 426);
            this.dgv_adminuser.TabIndex = 11;
            this.dgv_adminuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_adminuser_CellContentClick);
            // 
            // tbllogTableAdapter
            // 
            this.tbllogTableAdapter.ClearBeforeFill = true;
            // 
            // tbllogBindingSource1
            // 
            this.tbllogBindingSource1.DataMember = "tbllog";
            this.tbllogBindingSource1.DataSource = this.appData;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Pavarde";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 35;
            // 
            // frm_Add_User_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.dgv_adminuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_new);
            this.Name = "frm_Add_User_Admin";
            this.Text = "Prideti Vartotoja";
            this.Load += new System.EventHandler(this.frm_Add_User_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adminuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_adminuser;
        private AppData appData;
        private System.Windows.Forms.BindingSource tbllogBindingSource;
        private AppDataTableAdapters.tbllogTableAdapter tbllogTableAdapter;
        private System.Windows.Forms.BindingSource tbllogBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}