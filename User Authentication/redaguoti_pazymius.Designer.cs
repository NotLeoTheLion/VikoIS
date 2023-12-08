namespace User_Authentication
{
    partial class frm_Edit_Grade
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.cb_paskaita = new System.Windows.Forms.ComboBox();
            this.cb_pazymys = new System.Windows.Forms.ComboBox();
            this.dgv_grades = new System.Windows.Forms.DataGridView();
            this.paskaitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pazimysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uaDBDataSet = new User_Authentication.uaDBDataSet();
            this.cb_vardai = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTableAdapter = new User_Authentication.uaDBDataSetTableAdapters.gradeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vardas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paskaita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pazimys";
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(25, 209);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(260, 27);
            this.btn_new.TabIndex = 3;
            this.btn_new.Text = "Prideti";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(23, 263);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(260, 29);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Issaugoti";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(25, 319);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(260, 28);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Redaguoti";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // cb_paskaita
            // 
            this.cb_paskaita.FormattingEnabled = true;
            this.cb_paskaita.Items.AddRange(new object[] {
            "Teise",
            "Vadyba",
            "Skaitiniai ir optimizavimo metodai",
            "Objektinis programavimas",
            "Informacijos sistemos",
            "Duomenu baziu projektavimas",
            "Antroji programavimo praktika"});
            this.cb_paskaita.Location = new System.Drawing.Point(87, 92);
            this.cb_paskaita.Name = "cb_paskaita";
            this.cb_paskaita.Size = new System.Drawing.Size(198, 24);
            this.cb_paskaita.TabIndex = 8;
            // 
            // cb_pazymys
            // 
            this.cb_pazymys.FormattingEnabled = true;
            this.cb_pazymys.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_pazymys.Location = new System.Drawing.Point(87, 133);
            this.cb_pazymys.Name = "cb_pazymys";
            this.cb_pazymys.Size = new System.Drawing.Size(198, 24);
            this.cb_pazymys.TabIndex = 9;
            // 
            // dgv_grades
            // 
            this.dgv_grades.AutoGenerateColumns = false;
            this.dgv_grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paskaitaDataGridViewTextBoxColumn,
            this.pazimysDataGridViewTextBoxColumn});
            this.dgv_grades.DataSource = this.gradeBindingSource1;
            this.dgv_grades.Location = new System.Drawing.Point(315, 12);
            this.dgv_grades.Name = "dgv_grades";
            this.dgv_grades.RowHeadersWidth = 51;
            this.dgv_grades.RowTemplate.Height = 24;
            this.dgv_grades.Size = new System.Drawing.Size(473, 426);
            this.dgv_grades.TabIndex = 12;
            this.dgv_grades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_grades_CellContentClick);
            // 
            // paskaitaDataGridViewTextBoxColumn
            // 
            this.paskaitaDataGridViewTextBoxColumn.DataPropertyName = "Paskaita";
            this.paskaitaDataGridViewTextBoxColumn.HeaderText = "Paskaita";
            this.paskaitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paskaitaDataGridViewTextBoxColumn.Name = "paskaitaDataGridViewTextBoxColumn";
            this.paskaitaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pazimysDataGridViewTextBoxColumn
            // 
            this.pazimysDataGridViewTextBoxColumn.DataPropertyName = "Pazimys";
            this.pazimysDataGridViewTextBoxColumn.HeaderText = "Pazimys";
            this.pazimysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pazimysDataGridViewTextBoxColumn.Name = "pazimysDataGridViewTextBoxColumn";
            this.pazimysDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradeBindingSource1
            // 
            this.gradeBindingSource1.DataMember = "grade";
            this.gradeBindingSource1.DataSource = this.uaDBDataSet;
            // 
            // uaDBDataSet
            // 
            this.uaDBDataSet.DataSetName = "uaDBDataSet";
            this.uaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_vardai
            // 
            this.cb_vardai.FormattingEnabled = true;
            this.cb_vardai.Items.AddRange(new object[] {
            "Teise",
            "Vadyba",
            "Skaitiniai ir optimizavimo metodai",
            "Objektinis programavimas",
            "Informacijos sistemos",
            "Duomenu baziu projektavimas",
            "Antroji programavimo praktika"});
            this.cb_vardai.Location = new System.Drawing.Point(87, 53);
            this.cb_vardai.Name = "cb_vardai";
            this.cb_vardai.Size = new System.Drawing.Size(198, 24);
            this.cb_vardai.TabIndex = 13;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(25, 374);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(260, 32);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Pasalinti";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // gradeBindingSource
            // 
            this.gradeBindingSource.DataMember = "grade";
            this.gradeBindingSource.DataSource = this.uaDBDataSet;
            // 
            // gradeTableAdapter
            // 
            this.gradeTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Edit_Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cb_vardai);
            this.Controls.Add(this.dgv_grades);
            this.Controls.Add(this.cb_pazymys);
            this.Controls.Add(this.cb_paskaita);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Edit_Grade";
            this.Text = "Pazymiu Redagavimas";
            this.Load += new System.EventHandler(this.frm_Edit_Grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox cb_paskaita;
        private System.Windows.Forms.ComboBox cb_pazymys;
        private System.Windows.Forms.DataGridView dgv_grades;
        private System.Windows.Forms.ComboBox cb_vardai;
        private System.Windows.Forms.Button btn_delete;
        private uaDBDataSet uaDBDataSet;
        private System.Windows.Forms.BindingSource gradeBindingSource;
        private uaDBDataSetTableAdapters.gradeTableAdapter gradeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paskaitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pazimysDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gradeBindingSource1;
    }
}