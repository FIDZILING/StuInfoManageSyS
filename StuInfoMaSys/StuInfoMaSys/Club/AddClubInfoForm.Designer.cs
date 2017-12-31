namespace StuInfoMaSys.Club
{
    partial class AddClubInfoForm
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
            this.AddClubInfobutton = new System.Windows.Forms.Button();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClubNametextBox = new System.Windows.Forms.TextBox();
            this.TeachtextBox = new System.Windows.Forms.TextBox();
            this.TeachTeltextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddClubInfobutton
            // 
            this.AddClubInfobutton.Location = new System.Drawing.Point(96, 286);
            this.AddClubInfobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddClubInfobutton.Name = "AddClubInfobutton";
            this.AddClubInfobutton.Size = new System.Drawing.Size(112, 32);
            this.AddClubInfobutton.TabIndex = 3;
            this.AddClubInfobutton.Text = "添加";
            this.AddClubInfobutton.UseVisualStyleBackColor = true;
            this.AddClubInfobutton.Click += new System.EventHandler(this.AddClubInfobutton_Click);
            // 
            // Returnbutton
            // 
            this.Returnbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Returnbutton.Location = new System.Drawing.Point(262, 286);
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
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(102, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "社团名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "指导老师：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "联系电话：";
            // 
            // ClubNametextBox
            // 
            this.ClubNametextBox.Location = new System.Drawing.Point(237, 58);
            this.ClubNametextBox.Name = "ClubNametextBox";
            this.ClubNametextBox.Size = new System.Drawing.Size(100, 27);
            this.ClubNametextBox.TabIndex = 0;
            // 
            // TeachtextBox
            // 
            this.TeachtextBox.Location = new System.Drawing.Point(237, 113);
            this.TeachtextBox.Name = "TeachtextBox";
            this.TeachtextBox.Size = new System.Drawing.Size(100, 27);
            this.TeachtextBox.TabIndex = 1;
            // 
            // TeachTeltextBox
            // 
            this.TeachTeltextBox.Location = new System.Drawing.Point(237, 161);
            this.TeachTeltextBox.Name = "TeachTeltextBox";
            this.TeachTeltextBox.Size = new System.Drawing.Size(100, 27);
            this.TeachTeltextBox.TabIndex = 2;
            // 
            // AddClubInfoForm
            // 
            this.AcceptButton = this.AddClubInfobutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Returnbutton;
            this.ClientSize = new System.Drawing.Size(528, 392);
            this.Controls.Add(this.TeachTeltextBox);
            this.Controls.Add(this.TeachtextBox);
            this.Controls.Add(this.ClubNametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddClubInfobutton);
            this.Controls.Add(this.Returnbutton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddClubInfoForm";
            this.ShowIcon = false;
            this.Text = "添加社团信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddClubInfobutton;
        private System.Windows.Forms.Button Returnbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClubNametextBox;
        private System.Windows.Forms.TextBox TeachtextBox;
        private System.Windows.Forms.TextBox TeachTeltextBox;
    }
}