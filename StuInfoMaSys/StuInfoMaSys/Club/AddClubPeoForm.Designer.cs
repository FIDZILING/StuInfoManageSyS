namespace StuInfoMaSys.Club
{
    partial class AddClubPeoForm
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
            this.AddClubPeobutton = new System.Windows.Forms.Button();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StuNumtextBox = new System.Windows.Forms.TextBox();
            this.ClubPosttextBox = new System.Windows.Forms.TextBox();
            this.ClubNamecomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddClubPeobutton
            // 
            this.AddClubPeobutton.Location = new System.Drawing.Point(95, 337);
            this.AddClubPeobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddClubPeobutton.Name = "AddClubPeobutton";
            this.AddClubPeobutton.Size = new System.Drawing.Size(112, 32);
            this.AddClubPeobutton.TabIndex = 3;
            this.AddClubPeobutton.Text = "添加";
            this.AddClubPeobutton.UseVisualStyleBackColor = true;
            this.AddClubPeobutton.Click += new System.EventHandler(this.AddClubPeobutton_Click);
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(261, 337);
            this.Returnbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(112, 32);
            this.Returnbutton.TabIndex = 4;
            this.Returnbutton.Text = "返回";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(43, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "社团名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(43, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "学生学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "团内职务：";
            // 
            // StuNumtextBox
            // 
            this.StuNumtextBox.Location = new System.Drawing.Point(170, 172);
            this.StuNumtextBox.Name = "StuNumtextBox";
            this.StuNumtextBox.Size = new System.Drawing.Size(174, 27);
            this.StuNumtextBox.TabIndex = 1;
            // 
            // ClubPosttextBox
            // 
            this.ClubPosttextBox.Location = new System.Drawing.Point(170, 227);
            this.ClubPosttextBox.Name = "ClubPosttextBox";
            this.ClubPosttextBox.Size = new System.Drawing.Size(174, 27);
            this.ClubPosttextBox.TabIndex = 2;
            // 
            // ClubNamecomboBox
            // 
            this.ClubNamecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClubNamecomboBox.FormattingEnabled = true;
            this.ClubNamecomboBox.Location = new System.Drawing.Point(170, 112);
            this.ClubNamecomboBox.Name = "ClubNamecomboBox";
            this.ClubNamecomboBox.Size = new System.Drawing.Size(174, 28);
            this.ClubNamecomboBox.TabIndex = 0;
            // 
            // AddClubPeoForm
            // 
            this.AcceptButton = this.AddClubPeobutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(480, 462);
            this.Controls.Add(this.ClubNamecomboBox);
            this.Controls.Add(this.ClubPosttextBox);
            this.Controls.Add(this.StuNumtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddClubPeobutton);
            this.Controls.Add(this.Returnbutton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddClubPeoForm";
            this.ShowIcon = false;
            this.Text = "添加社团人员信息";
            this.Load += new System.EventHandler(this.AddClubPeoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddClubPeobutton;
        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StuNumtextBox;
        private System.Windows.Forms.TextBox ClubPosttextBox;
        private System.Windows.Forms.ComboBox ClubNamecomboBox;
    }
}