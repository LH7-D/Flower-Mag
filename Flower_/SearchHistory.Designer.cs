namespace Flower_
{
    partial class SearchHistory
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
            this.flower_DataSet = new Flower_.Flower_DataSet();
            this.repertoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repertoryTableAdapter = new Flower_.Flower_DataSetTableAdapters.RepertoryTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbCk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.DateTimePicker();
            this.flower_DataSet1 = new Flower_.Flower_DataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Flower_.Flower_DataSet1TableAdapters.ProductTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productTableAdapter1 = new Flower_.Flower_DataSet1TableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.flower_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repertoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flower_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flower_DataSet
            // 
            this.flower_DataSet.DataSetName = "Flower_DataSet";
            this.flower_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repertoryBindingSource
            // 
            this.repertoryBindingSource.DataMember = "Repertory";
            this.repertoryBindingSource.DataSource = this.flower_DataSet;
            // 
            // repertoryTableAdapter
            // 
            this.repertoryTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.tbCk);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tbTime);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(993, 495);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbCk
            // 
            this.tbCk.DataSource = this.repertoryBindingSource;
            this.tbCk.DisplayMember = "仓库名称";
            this.tbCk.FormattingEnabled = true;
            this.tbCk.Location = new System.Drawing.Point(588, 49);
            this.tbCk.Margin = new System.Windows.Forms.Padding(4);
            this.tbCk.Name = "tbCk";
            this.tbCk.Size = new System.Drawing.Size(161, 26);
            this.tbCk.TabIndex = 30;
            this.tbCk.Text = "--所属仓库--";
            this.tbCk.ValueMember = "仓库名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "所属仓库";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "购货日期";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(217, 47);
            this.tbTime.Name = "tbTime";
            this.tbTime.ShowCheckBox = true;
            this.tbTime.Size = new System.Drawing.Size(200, 28);
            this.tbTime.TabIndex = 27;
            // 
            // flower_DataSet1
            // 
            this.flower_DataSet1.DataSetName = "Flower_DataSet1";
            this.flower_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.flower_DataSet1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(796, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 33;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(993, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // SearchHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 495);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SearchHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "鲜花绿植种子管理系统";
            this.Load += new System.EventHandler(this.SearchHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flower_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repertoryBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flower_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Flower_DataSet flower_DataSet;
        private System.Windows.Forms.BindingSource repertoryBindingSource;
        private Flower_DataSetTableAdapters.RepertoryTableAdapter repertoryTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox tbCk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tbTime;
        private Flower_DataSet1 flower_DataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Flower_DataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Flower_DataSet1TableAdapters.ProductTableAdapter productTableAdapter1;
    }
}