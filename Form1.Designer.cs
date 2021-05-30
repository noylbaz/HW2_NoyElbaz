//NOY ELBAZ 315073122
namespace HW2_NoyElbaz
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
            this.components = new System.ComponentModel.Container();
            this.buttonDialog = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new HW2_NoyElbaz.Database1DataSet();
            this.tblStudentsTableAdapter = new HW2_NoyElbaz.Database1DataSetTableAdapters.TblStudentsTableAdapter();
            this.tblLecturesStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLecturesStudentsTableAdapter = new HW2_NoyElbaz.Database1DataSetTableAdapters.TblLecturesStudentsTableAdapter();
            this.tblStudentsCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudents_CoursesTableAdapter = new HW2_NoyElbaz.Database1DataSetTableAdapters.TblStudents_CoursesTableAdapter();
            this.tblLecturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLecturersTableAdapter = new HW2_NoyElbaz.Database1DataSetTableAdapters.TblLecturersTableAdapter();
            this.tblCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCoursesTableAdapter = new HW2_NoyElbaz.Database1DataSetTableAdapters.TblCoursesTableAdapter();
            this.toolTipDialog = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDelStud = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLecturesStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLecturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoursesBindingSource)).BeginInit();
            this.SuspendLayout();
     
            this.buttonDialog.Location = new System.Drawing.Point(12, 12);
            this.buttonDialog.Name = "buttonDialog";
            this.buttonDialog.Size = new System.Drawing.Size(159, 54);
            this.buttonDialog.TabIndex = 0;
            this.buttonDialog.Text = "Dialog";
            this.toolTipDialog.SetToolTip(this.buttonDialog, "Open Dialog for more options");
            this.buttonDialog.UseVisualStyleBackColor = true;
            this.buttonDialog.Click += new System.EventHandler(this.Dialog_Click);

            this.buttonDelete.Location = new System.Drawing.Point(12, 81);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(159, 54);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "DeleteStudent";
            this.toolTipDelStud.SetToolTip(this.buttonDelete, "Delete selected student");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeleteStudent_Click);

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 178);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
   
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
   
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;

            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;

            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
   
            this.tblStudentsBindingSource.DataMember = "TblStudents";
            this.tblStudentsBindingSource.DataSource = this.database1DataSet;
  
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
     
            this.tblStudentsTableAdapter.ClearBeforeFill = true;
    
            this.tblLecturesStudentsTableAdapter.ClearBeforeFill = true;

            this.tblStudents_CoursesTableAdapter.ClearBeforeFill = true;

            this.tblLecturersTableAdapter.ClearBeforeFill = true;

            this.tblCoursesTableAdapter.ClearBeforeFill = true;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Shift_Esc);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLecturesStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLecturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoursesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDialog;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tblStudentsBindingSource;
        private Database1DataSetTableAdapters.TblStudentsTableAdapter tblStudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblLecturesStudentsBindingSource;
        private Database1DataSetTableAdapters.TblLecturesStudentsTableAdapter tblLecturesStudentsTableAdapter;
        private System.Windows.Forms.BindingSource tblStudentsCoursesBindingSource;
        private Database1DataSetTableAdapters.TblStudents_CoursesTableAdapter tblStudents_CoursesTableAdapter;
        private System.Windows.Forms.BindingSource tblLecturersBindingSource;
        private Database1DataSetTableAdapters.TblLecturersTableAdapter tblLecturersTableAdapter;
        private System.Windows.Forms.BindingSource tblCoursesBindingSource;
        private Database1DataSetTableAdapters.TblCoursesTableAdapter tblCoursesTableAdapter;
        private System.Windows.Forms.ToolTip toolTipDialog;
        private System.Windows.Forms.ToolTip toolTipDelStud;
    }
}

