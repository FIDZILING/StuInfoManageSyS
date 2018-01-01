namespace StuInfoMaSys.RewardPunishment
{
    partial class QueryRPForm
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
            this.AddRPbutton = new System.Windows.Forms.Button();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.QueryRPbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LevelcomboBox = new System.Windows.Forms.ComboBox();
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StuNumtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddRPbutton
            // 
            this.AddRPbutton.Location = new System.Drawing.Point(320, 453);
            this.AddRPbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddRPbutton.Name = "AddRPbutton";
            this.AddRPbutton.Size = new System.Drawing.Size(112, 32);
            this.AddRPbutton.TabIndex = 5;
            this.AddRPbutton.Text = "添加";
            this.AddRPbutton.UseVisualStyleBackColor = true;
            this.AddRPbutton.Click += new System.EventHandler(this.AddRPbutton_Click);
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(467, 453);
            this.Returnbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(112, 32);
            this.Returnbutton.TabIndex = 6;
            this.Returnbutton.Text = "返回";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // QueryRPbutton
            // 
            this.QueryRPbutton.Location = new System.Drawing.Point(455, 45);
            this.QueryRPbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QueryRPbutton.Name = "QueryRPbutton";
            this.QueryRPbutton.Size = new System.Drawing.Size(112, 32);
            this.QueryRPbutton.TabIndex = 7;
            this.QueryRPbutton.Text = "查询";
            this.QueryRPbutton.UseVisualStyleBackColor = true;
            this.QueryRPbutton.Click += new System.EventHandler(this.QueryRPbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LevelcomboBox);
            this.groupBox1.Controls.Add(this.TypecomboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StuNumtextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.QueryRPbutton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "奖惩类型：";
            // 
            // LevelcomboBox
            // 
            this.LevelcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelcomboBox.FormattingEnabled = true;
            this.LevelcomboBox.Location = new System.Drawing.Point(179, 108);
            this.LevelcomboBox.Name = "LevelcomboBox";
            this.LevelcomboBox.Size = new System.Drawing.Size(145, 28);
            this.LevelcomboBox.TabIndex = 14;
            this.LevelcomboBox.SelectedIndexChanged += new System.EventHandler(this.LevelcomboBox_SelectedIndexChanged);
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Location = new System.Drawing.Point(179, 62);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(145, 28);
            this.TypecomboBox.TabIndex = 13;
            this.TypecomboBox.SelectedIndexChanged += new System.EventHandler(this.TypecomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "奖惩等级：";
            // 
            // StuNumtextBox
            // 
            this.StuNumtextBox.Location = new System.Drawing.Point(179, 23);
            this.StuNumtextBox.Name = "StuNumtextBox";
            this.StuNumtextBox.Size = new System.Drawing.Size(145, 27);
            this.StuNumtextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "学生学号：";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 168);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 267);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // QueryRPForm
            // 
            this.AcceptButton = this.QueryRPbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(639, 514);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddRPbutton);
            this.Controls.Add(this.Returnbutton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "QueryRPForm";
            this.ShowIcon = false;
            this.Text = "查询奖惩信息";
            this.Load += new System.EventHandler(this.QueryRPForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddRPbutton;
        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.Button QueryRPbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox StuNumtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LevelcomboBox;
        private System.Windows.Forms.ComboBox TypecomboBox;
        private System.Windows.Forms.Label label3;
    }
}