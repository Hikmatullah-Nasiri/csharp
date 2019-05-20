namespace DCAP505PracticeApp
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dCAP505DataSet = new DCAP505PracticeApp.DCAP505DataSet();
            this.signupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.signupTableAdapter = new DCAP505PracticeApp.DCAP505DataSetTableAdapters.signupTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCAP505DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.emailidDataGridViewTextBoxColumn,
            this.phnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.signupBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(58, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dCAP505DataSet
            // 
            this.dCAP505DataSet.DataSetName = "DCAP505DataSet";
            this.dCAP505DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // signupBindingSource
            // 
            this.signupBindingSource.DataMember = "signup";
            this.signupBindingSource.DataSource = this.dCAP505DataSet;
            // 
            // signupTableAdapter
            // 
            this.signupTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // emailidDataGridViewTextBoxColumn
            // 
            this.emailidDataGridViewTextBoxColumn.DataPropertyName = "emailid";
            this.emailidDataGridViewTextBoxColumn.HeaderText = "emailid";
            this.emailidDataGridViewTextBoxColumn.Name = "emailidDataGridViewTextBoxColumn";
            // 
            // phnoDataGridViewTextBoxColumn
            // 
            this.phnoDataGridViewTextBoxColumn.DataPropertyName = "phno";
            this.phnoDataGridViewTextBoxColumn.HeaderText = "phno";
            this.phnoDataGridViewTextBoxColumn.Name = "phnoDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 311);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCAP505DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DCAP505DataSet dCAP505DataSet;
        private System.Windows.Forms.BindingSource signupBindingSource;
        private DCAP505DataSetTableAdapters.signupTableAdapter signupTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phnoDataGridViewTextBoxColumn;
    }
}