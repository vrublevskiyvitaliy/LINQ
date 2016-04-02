namespace IntelectualGamesImproved.FolderContest
{
    partial class ChangeContest
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
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(97, 27);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(151, 20);
            this.IDTextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID";
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.Aqua;
            this.ChangeButton.Location = new System.Drawing.Point(39, 140);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(209, 53);
            this.ChangeButton.TabIndex = 23;
            this.ChangeButton.Text = "Змінити";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(97, 100);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(151, 20);
            this.YearTextBox.TabIndex = 22;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(97, 64);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(151, 20);
            this.NameTextBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Рік";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Назва";
            // 
            // ChangeContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeContest";
            this.Text = "Змінити Змагання";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}