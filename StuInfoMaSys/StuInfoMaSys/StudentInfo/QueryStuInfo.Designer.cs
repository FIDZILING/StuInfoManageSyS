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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Alterbutton = new System.Windows.Forms.Button();
            this.stuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origincity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origincounty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highschool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.StuPertabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuPerdataGridView)).BeginInit();
            this.StuFamtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuFamdataGridView)).BeginInit();
            this.StuSchtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuSchdataGridView)).BeginInit();
            this.StuAlltabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuAlldataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(1188, 411);
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
            this.QueryStubutton.Location = new System.Drawing.Point(1172, 38);
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
            this.tabControl1.Size = new System.Drawing.Size(1301, 277);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // StuPertabPage
            // 
            this.StuPertabPage.Controls.Add(this.StuPerdataGridView);
            this.StuPertabPage.Location = new System.Drawing.Point(4, 29);
            this.StuPertabPage.Name = "StuPertabPage";
            this.StuPertabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StuPertabPage.Size = new System.Drawing.Size(1293, 244);
            this.StuPertabPage.TabIndex = 0;
            this.StuPertabPage.Text = "个人信息";
            this.StuPertabPage.UseVisualStyleBackColor = true;
            // 
            // StuPerdataGridView
            // 
            this.StuPerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuPerdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuno,
            this.stuname,
            this.sex,
            this.nation,
            this.birthday,
            this.symbo,
            this.telnum,
            this.qq,
            this.idnum,
            this.originpro,
            this.origincity,
            this.origincounty,
            this.highschool});
            this.StuPerdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuPerdataGridView.Location = new System.Drawing.Point(3, 3);
            this.StuPerdataGridView.Name = "StuPerdataGridView";
            this.StuPerdataGridView.RowTemplate.Height = 27;
            this.StuPerdataGridView.Size = new System.Drawing.Size(1287, 238);
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
            this.StuAlltabPage.Controls.Add(this.StuAlldataGridView);
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
            this.StuAlldataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuAlldataGridView.Location = new System.Drawing.Point(3, 3);
            this.StuAlldataGridView.Name = "StuAlldataGridView";
            this.StuAlldataGridView.RowTemplate.Height = 27;
            this.StuAlldataGridView.Size = new System.Drawing.Size(853, 238);
            this.StuAlldataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QueryStubutton);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1297, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // Alterbutton
            // 
            this.Alterbutton.Location = new System.Drawing.Point(1043, 411);
            this.Alterbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Alterbutton.Name = "Alterbutton";
            this.Alterbutton.Size = new System.Drawing.Size(112, 32);
            this.Alterbutton.TabIndex = 10;
            this.Alterbutton.Text = "修改";
            this.Alterbutton.UseVisualStyleBackColor = true;
            this.Alterbutton.Click += new System.EventHandler(this.Alterbutton_Click);
            // 
            // stuno
            // 
            this.stuno.DataPropertyName = "StuNo";
            this.stuno.HeaderText = "学号";
            this.stuno.Name = "stuno";
            // 
            // stuname
            // 
            this.stuname.DataPropertyName = "StuName";
            this.stuname.HeaderText = "姓名";
            this.stuname.Name = "stuname";
            // 
            // sex
            // 
            this.sex.DataPropertyName = "Sex";
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            // 
            // nation
            // 
            this.nation.DataPropertyName = "Nation";
            this.nation.HeaderText = "民族";
            this.nation.Name = "nation";
            // 
            // birthday
            // 
            this.birthday.HeaderText = "出生日期";
            this.birthday.Name = "birthday";
            // 
            // symbo
            // 
            this.symbo.DataPropertyName = "Symbol";
            this.symbo.HeaderText = "政治面貌";
            this.symbo.Name = "symbo";
            // 
            // telnum
            // 
            this.telnum.DataPropertyName = "TelNum";
            this.telnum.HeaderText = "电话号码";
            this.telnum.Name = "telnum";
            // 
            // qq
            // 
            this.qq.DataPropertyName = "QQNum";
            this.qq.HeaderText = "QQ";
            this.qq.Name = "qq";
            // 
            // idnum
            // 
            this.idnum.DataPropertyName = "IDNum";
            this.idnum.HeaderText = "身份证号";
            this.idnum.Name = "idnum";
            // 
            // originpro
            // 
            this.originpro.DataPropertyName = "OriginPro";
            this.originpro.HeaderText = "籍贯-省";
            this.originpro.Name = "originpro";
            // 
            // origincity
            // 
            this.origincity.DataPropertyName = "OriginCity";
            this.origincity.HeaderText = "籍贯-市";
            this.origincity.Name = "origincity";
            // 
            // origincounty
            // 
            this.origincounty.DataPropertyName = "OriginCounty";
            this.origincounty.HeaderText = "籍贯-区/县";
            this.origincounty.Name = "origincounty";
            // 
            // highschool
            // 
            this.highschool.DataPropertyName = "HighSchool";
            this.highschool.HeaderText = "高中学校";
            this.highschool.Name = "highschool";
            // 
            // QueryStuInfoForm
            // 
            this.AcceptButton = this.QueryStubutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(1325, 456);
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
            this.StuAlltabPage.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn stuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn nation;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn qq;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn originpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn origincity;
        private System.Windows.Forms.DataGridViewTextBoxColumn origincounty;
        private System.Windows.Forms.DataGridViewTextBoxColumn highschool;
    }
}