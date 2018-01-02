namespace StuInfoMaSys.StudentInfo
{
    partial class QueryStuInfoForm
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
            this.Returnbutton = new System.Windows.Forms.Button();
            this.QueryStubutton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StuPertabPage = new System.Windows.Forms.TabPage();
            this.StuPerdataGridView = new System.Windows.Forms.DataGridView();
            this.StuFamtabPage = new System.Windows.Forms.TabPage();
            this.StuFamdataGridView = new System.Windows.Forms.DataGridView();
            this.StuSchtabPage = new System.Windows.Forms.TabPage();
            this.StuSchdataGridView = new System.Windows.Forms.DataGridView();
            this.StuAlltabPage = new System.Windows.Forms.TabPage();
            this.StuAlldataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Alterbutton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.StuPertabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuPerdataGridView)).BeginInit();
            this.StuFamtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuFamdataGridView)).BeginInit();
            this.StuSchtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuSchdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuAlldataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(747, 411);
            this.Returnbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(112, 32);
            this.Returnbutton.TabIndex = 7;
            this.Returnbutton.Text = "返回";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // QueryStubutton
            // 
            this.QueryStubutton.Location = new System.Drawing.Point(731, 42);
            this.QueryStubutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QueryStubutton.Name = "QueryStubutton";
            this.QueryStubutton.Size = new System.Drawing.Size(112, 32);
            this.QueryStubutton.TabIndex = 8;
            this.QueryStubutton.Text = "查询";
            this.QueryStubutton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StuPertabPage);
            this.tabControl1.Controls.Add(this.StuFamtabPage);
            this.tabControl1.Controls.Add(this.StuSchtabPage);
            this.tabControl1.Controls.Add(this.StuAlltabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 127);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 277);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // StuPertabPage
            // 
            this.StuPertabPage.Controls.Add(this.StuPerdataGridView);
            this.StuPertabPage.Location = new System.Drawing.Point(4, 29);
            this.StuPertabPage.Name = "StuPertabPage";
            this.StuPertabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StuPertabPage.Size = new System.Drawing.Size(859, 244);
            this.StuPertabPage.TabIndex = 0;
            this.StuPertabPage.Text = "个人信息";
            this.StuPertabPage.UseVisualStyleBackColor = true;
            // 
            // StuPerdataGridView
            // 
            this.StuPerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuPerdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuPerdataGridView.Location = new System.Drawing.Point(3, 3);
            this.StuPerdataGridView.Name = "StuPerdataGridView";
            this.StuPerdataGridView.RowTemplate.Height = 27;
            this.StuPerdataGridView.Size = new System.Drawing.Size(853, 238);
            this.StuPerdataGridView.TabIndex = 0;
            // 
            // StuFamtabPage
            // 
            this.StuFamtabPage.Controls.Add(this.StuFamdataGridView);
            this.StuFamtabPage.Location = new System.Drawing.Point(4, 29);
            this.StuFamtabPage.Name = "StuFamtabPage";
            this.StuFamtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StuFamtabPage.Size = new System.Drawing.Size(859, 244);
            this.StuFamtabPage.TabIndex = 1;
            this.StuFamtabPage.Text = "家庭信息";
            this.StuFamtabPage.UseVisualStyleBackColor = true;
            // 
            // StuFamdataGridView
            // 
            this.StuFamdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuFamdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuFamdataGridView.Location = new System.Drawing.Point(3, 3);
            this.StuFamdataGridView.Name = "StuFamdataGridView";
            this.StuFamdataGridView.RowTemplate.Height = 27;
            this.StuFamdataGridView.Size = new System.Drawing.Size(853, 238);
            this.StuFamdataGridView.TabIndex = 0;
            // 
            // StuSchtabPage
            // 
            this.StuSchtabPage.Controls.Add(this.StuSchdataGridView);
            this.StuSchtabPage.Location = new System.Drawing.Point(4, 29);
            this.StuSchtabPage.Name = "StuSchtabPage";
            this.StuSchtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StuSchtabPage.Size = new System.Drawing.Size(859, 244);
            this.StuSchtabPage.TabIndex = 2;
            this.StuSchtabPage.Text = "在校信息";
            this.StuSchtabPage.UseVisualStyleBackColor = true;
            // 
            // StuSchdataGridView
            // 
            this.StuSchdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuSchdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuSchdataGridView.Location = new System.Drawing.Point(3, 3);
            this.StuSchdataGridView.Name = "StuSchdataGridView";
            this.StuSchdataGridView.RowTemplate.Height = 27;
            this.StuSchdataGridView.Size = new System.Drawing.Size(853, 238);
            this.StuSchdataGridView.TabIndex = 0;
            // 
            // StuAlltabPage
            // 
            this.StuAlltabPage.Location = new System.Drawing.Point(4, 29);
            this.StuAlltabPage.Name = "StuAlltabPage";
            this.StuAlltabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StuAlltabPage.Size = new System.Drawing.Size(859, 244);
            this.StuAlltabPage.TabIndex = 3;
            this.StuAlltabPage.Text = "总信息";
            this.StuAlltabPage.UseVisualStyleBackColor = true;
            // 
            // StuAlldataGridView
            // 
            this.StuAlldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuAlldataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.StuAlldataGridView.Location = new System.Drawing.Point(403, -5);
            this.StuAlldataGridView.Name = "StuAlldataGridView";
            this.StuAlldataGridView.RowTemplate.Height = 27;
            this.StuAlldataGridView.Size = new System.Drawing.Size(295, 143);
            this.StuAlldataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StuAlldataGridView);
            this.groupBox1.Controls.Add(this.QueryStubutton);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // Alterbutton
            // 
            this.Alterbutton.Location = new System.Drawing.Point(602, 411);
            this.Alterbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Alterbutton.Name = "Alterbutton";
            this.Alterbutton.Size = new System.Drawing.Size(112, 32);
            this.Alterbutton.TabIndex = 10;
            this.Alterbutton.Text = "修改";
            this.Alterbutton.UseVisualStyleBackColor = true;
            this.Alterbutton.Click += new System.EventHandler(this.Alterbutton_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // QueryStuInfoForm
            // 
            this.AcceptButton = this.QueryStubutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(891, 456);
            this.Controls.Add(this.Alterbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Returnbutton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "QueryStuInfoForm";
            this.ShowIcon = false;
            this.Text = "查询本科生信息";
            this.Load += new System.EventHandler(this.QueryStuInfoForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.StuPertabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StuPerdataGridView)).EndInit();
            this.StuFamtabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StuFamdataGridView)).EndInit();
            this.StuSchtabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StuSchdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuAlldataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.Button QueryStubutton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StuPertabPage;
        private System.Windows.Forms.TabPage StuFamtabPage;
        private System.Windows.Forms.TabPage StuSchtabPage;
        private System.Windows.Forms.TabPage StuAlltabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView StuPerdataGridView;
        private System.Windows.Forms.DataGridView StuFamdataGridView;
        private System.Windows.Forms.DataGridView StuSchdataGridView;
        private System.Windows.Forms.DataGridView StuAlldataGridView;
        private System.Windows.Forms.Button Alterbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}