namespace StuInfoMaSys.Club
{
    partial class QueryClubPeoForm
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
            this.QueryClubPeobutton = new System.Windows.Forms.Button();
            this.AlterClubPeobutton = new System.Windows.Forms.Button();
            this.AddClubPeobutton = new System.Windows.Forms.Button();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StuNumtextBox = new System.Windows.Forms.TextBox();
            this.ClubNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubpost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteClubPeobutton = new System.Windows.Forms.Button();
            this.Exportbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryClubPeobutton
            // 
            this.QueryClubPeobutton.Location = new System.Drawing.Point(425, 38);
            this.QueryClubPeobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QueryClubPeobutton.Name = "QueryClubPeobutton";
            this.QueryClubPeobutton.Size = new System.Drawing.Size(112, 32);
            this.QueryClubPeobutton.TabIndex = 0;
            this.QueryClubPeobutton.Text = "查询";
            this.QueryClubPeobutton.UseVisualStyleBackColor = true;
            this.QueryClubPeobutton.Click += new System.EventHandler(this.QueryClubPeobutton_Click);
            // 
            // AlterClubPeobutton
            // 
            this.AlterClubPeobutton.Location = new System.Drawing.Point(257, 428);
            this.AlterClubPeobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AlterClubPeobutton.Name = "AlterClubPeobutton";
            this.AlterClubPeobutton.Size = new System.Drawing.Size(112, 32);
            this.AlterClubPeobutton.TabIndex = 3;
            this.AlterClubPeobutton.Text = "修改";
            this.AlterClubPeobutton.UseVisualStyleBackColor = true;
            this.AlterClubPeobutton.Click += new System.EventHandler(this.AlterClubPeobutton_Click);
            // 
            // AddClubPeobutton
            // 
            this.AddClubPeobutton.Location = new System.Drawing.Point(139, 428);
            this.AddClubPeobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddClubPeobutton.Name = "AddClubPeobutton";
            this.AddClubPeobutton.Size = new System.Drawing.Size(112, 32);
            this.AddClubPeobutton.TabIndex = 2;
            this.AddClubPeobutton.Text = "添加";
            this.AddClubPeobutton.UseVisualStyleBackColor = true;
            this.AddClubPeobutton.Click += new System.EventHandler(this.AddClubPeobutton_Click);
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(493, 428);
            this.Returnbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(112, 32);
            this.Returnbutton.TabIndex = 6;
            this.Returnbutton.Text = "返回";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StuNumtextBox);
            this.groupBox1.Controls.Add(this.ClubNametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.QueryClubPeobutton);
            this.groupBox1.Location = new System.Drawing.Point(30, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // StuNumtextBox
            // 
            this.StuNumtextBox.Location = new System.Drawing.Point(197, 53);
            this.StuNumtextBox.Name = "StuNumtextBox";
            this.StuNumtextBox.Size = new System.Drawing.Size(164, 27);
            this.StuNumtextBox.TabIndex = 2;
            // 
            // ClubNametextBox
            // 
            this.ClubNametextBox.Location = new System.Drawing.Point(197, 20);
            this.ClubNametextBox.Name = "ClubNametextBox";
            this.ClubNametextBox.Size = new System.Drawing.Size(164, 27);
            this.ClubNametextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "学生学号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "社团名称：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.clubname,
            this.StuNum,
            this.clubpost});
            this.dataGridView1.Location = new System.Drawing.Point(30, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(557, 262);
            this.dataGridView1.TabIndex = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "序号";
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // clubname
            // 
            this.clubname.DataPropertyName = "ClubName";
            this.clubname.HeaderText = "社团名称";
            this.clubname.Name = "clubname";
            this.clubname.Width = 200;
            // 
            // StuNum
            // 
            this.StuNum.DataPropertyName = "StuNo";
            this.StuNum.HeaderText = "学生学号";
            this.StuNum.Name = "StuNum";
            this.StuNum.Width = 130;
            // 
            // clubpost
            // 
            this.clubpost.DataPropertyName = "ClubPost";
            this.clubpost.HeaderText = "团内职务";
            this.clubpost.Name = "clubpost";
            // 
            // DeleteClubPeobutton
            // 
            this.DeleteClubPeobutton.Location = new System.Drawing.Point(375, 428);
            this.DeleteClubPeobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteClubPeobutton.Name = "DeleteClubPeobutton";
            this.DeleteClubPeobutton.Size = new System.Drawing.Size(112, 32);
            this.DeleteClubPeobutton.TabIndex = 4;
            this.DeleteClubPeobutton.Text = "删除";
            this.DeleteClubPeobutton.UseVisualStyleBackColor = true;
            this.DeleteClubPeobutton.Click += new System.EventHandler(this.DeleteClubPeobutton_Click);
            // 
            // Exportbutton
            // 
            this.Exportbutton.Location = new System.Drawing.Point(21, 428);
            this.Exportbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exportbutton.Name = "Exportbutton";
            this.Exportbutton.Size = new System.Drawing.Size(112, 32);
            this.Exportbutton.TabIndex = 1;
            this.Exportbutton.Text = "导出";
            this.Exportbutton.UseVisualStyleBackColor = true;
            this.Exportbutton.Click += new System.EventHandler(this.Exportbutton_Click);
            // 
            // QueryClubPeoForm
            // 
            this.AcceptButton = this.QueryClubPeobutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(634, 477);
            this.Controls.Add(this.Exportbutton);
            this.Controls.Add(this.DeleteClubPeobutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AlterClubPeobutton);
            this.Controls.Add(this.AddClubPeobutton);
            this.Controls.Add(this.Returnbutton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "QueryClubPeoForm";
            this.ShowIcon = false;
            this.Text = "查询社团人员信息";
            this.Load += new System.EventHandler(this.QueryClubPeoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QueryClubPeobutton;
        private System.Windows.Forms.Button AlterClubPeobutton;
        private System.Windows.Forms.Button AddClubPeobutton;
        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox StuNumtextBox;
        private System.Windows.Forms.TextBox ClubNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubpost;
        private System.Windows.Forms.Button DeleteClubPeobutton;
        private System.Windows.Forms.Button Exportbutton;
    }
}