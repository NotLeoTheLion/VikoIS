namespace User_Authentication
{
    partial class frm_viewgrade
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
            this.lbl_loguser = new System.Windows.Forms.Label();
            this.dgv_gradeview = new System.Windows.Forms.DataGridView();
            this.uaDBDataSet = new User_Authentication.uaDBDataSet();
            this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTableAdapter = new User_Authentication.uaDBDataSetTableAdapters.gradeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paskaitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pazimysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gradeview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_loguser
            // 
            this.lbl_loguser.AutoSize = true;
            this.lbl_loguser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loguser.Location = new System.Drawing.Point(200, 30);
            this.lbl_loguser.Name = "lbl_loguser";
            this.lbl_loguser.Size = new System.Drawing.Size(105, 25);
            this.lbl_loguser.TabIndex = 0;
            this.lbl_loguser.Text = "Ivertinimai:";
            // 
            // dgv_gradeview
            // 
            this.dgv_gradeview.AutoGenerateColumns = false;
            this.dgv_gradeview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gradeview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.paskaitaDataGridViewTextBoxColumn,
            this.pazimysDataGridViewTextBoxColumn});
            this.dgv_gradeview.DataSource = this.gradeBindingSource;
            this.dgv_gradeview.Location = new System.Drawing.Point(12, 70);
            this.dgv_gradeview.Name = "dgv_gradeview";
            this.dgv_gradeview.RowHeadersWidth = 51;
            this.dgv_gradeview.RowTemplate.Height = 24;
            this.dgv_gradeview.Size = new System.Drawing.Size(776, 368);
            this.dgv_gradeview.TabIndex = 1;
            // 
            // uaDBDataSet
            // 
            this.uaDBDataSet.DataSetName = "uaDBDataSet";
            this.uaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
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
            // frm_viewgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_gradeview);
            this.Controls.Add(this.lbl_loguser);
            this.Name = "frm_viewgrade";
            this.Text = "Perziureti Pazymius";
            this.Load += new System.EventHandler(this.frm_viewgrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gradeview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_loguser;
        private System.Windows.Forms.DataGridView dgv_gradeview;
        private uaDBDataSet uaDBDataSet;
        private System.Windows.Forms.BindingSource gradeBindingSource;
        private uaDBDataSetTableAdapters.gradeTableAdapter gradeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paskaitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pazimysDataGridViewTextBoxColumn;
    }
}