namespace StuInfoMaSys.Club
{
    partial class QueryClubInfoForm
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
            this.QueryClubInfobutton = new System.Windows.Forms.Button();
            this.AddClubInfobutton = new System.Windows.Forms.Button();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClubNametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlterClubInfobutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryClubInfobutton
            // 
            this.QueryClubInfobutton.Location = new System.Drawing.Point(418, 36);
            this.QueryClubInfobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QueryClubInfobutton.Name = "QueryClubInfobutton";
            this.QueryClubInfobutton.Size = new System.Drawing.Size(112, 32);
            this.QueryClubInfobutton.TabIndex = 2;
            this.QueryClubInfobutton.Text = "查询";
            this.QueryClubInfobutton.UseVisualStyleBackColor = true;
            this.QueryClubInfobutton.Click += new System.EventHandler(this.QueryClubInfobutton_Click);
            // 
            // AddClubInfobutton
            // 
            this.AddClubInfobutton.Location = new System.Drawing.Point(175, 448);
            this.AddClubInfobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddClubInfobutton.Name = "AddClubInfobutton";
            this.AddClubInfobutton.Size = new System.Drawing.Size(112, 32);
            this.AddClubInfobutton.TabIndex = 2;
            this.AddClubInfobutton.Text = "添加";
            this.AddClubInfobutton.UseVisualStyleBackColor = true;
            this.AddClubInfobutton.Click += new System.EventHandler(this.AddClubInfobutton_Click);
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(444, 448);
            this.Returnbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(112, 32);
            this.Returnbutton.TabIndex = 4;
            this.Returnbutton.Text = "返回";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClubNametextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.QueryClubInfobutton);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // ClubNametextBox
            // 
            this.ClubNametextBox.Location = new System.Drawing.Point(118, 39);
            this.ClubNametextBox.Name = "ClubNametextBox";
            this.ClubNametextBox.Size = new System.Drawing.Size(209, 27);
            this.ClubNametextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "社团名称：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.name,
            this.teach,
            this.teachTel});
            this.dataGridView1.Location = new System.Drawing.Point(26, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(585, 274);
            this.dataGridView1.TabIndex = 1;
            // 
            // num
            // 
            this.num.DataPropertyName = "ClubNum";
            this.num.HeaderText = "序号";
            this.num.Name = "num";
            this.num.Width = 75;
            // 
            // name
            // 
            this.name.DataPropertyName = "ClubName";
            this.name.HeaderText = "社团名称";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // teach
            // 
            this.teach.DataPropertyName = "ClubTeach";
            this.teach.HeaderText = "指导老师";
            this.teach.Name = "teach";
            // 
            // teachTel
            // 
            this.teachTel.DataPropertyName = "TeacherTel";
            this.teachTel.HeaderText = "指导老师联系电话";
            this.teachTel.Name = "teachTel";
            this.teachTel.Width = 160;
            // 
            // AlterClubInfobutton
            // 
            this.AlterClubInfobutton.Location = new System.Drawing.Point(303, 448);
            this.AlterClubInfobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AlterClubInfobutton.Name = "AlterClubInfobutton";
            this.AlterClubInfobutton.Size = new System.Drawing.Size(112, 32);
            this.AlterClubInfobutton.TabIndex = 3;
            this.AlterClubInfobutton.Text = "修改";
            this.AlterClubInfobutton.UseVisualStyleBackColor = true;
            this.AlterClubInfobutton.Click += new System.EventHandler(this.AlterClubInfobutton_Click);
            // 
            // QueryClubInfoForm
            // 
            this.AcceptButton = this.QueryClubInfobutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(679, 530);
            this.Controls.Add(this.AlterClubInfobutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddClubInfobutton);
            this.Controls.Add(this.Returnbutton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "QueryClubInfoForm";
            this.ShowIcon = false;
            this.Text = "查询社团信息";
            this.Load += new System.EventHandler(this.QueryClubInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QueryClubInfobutton;
        private System.Windows.Forms.Button AddClubInfobutton;
        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ClubNametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn teach;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachTel;
        private System.Windows.Forms.Button AlterClubInfobutton;
    }
}