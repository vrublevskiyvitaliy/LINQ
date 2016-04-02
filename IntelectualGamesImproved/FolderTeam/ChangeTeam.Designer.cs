namespace IntelectualGamesImproved.FolderTeam
{
    partial class ChangeTeam
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
            this.IDTextBox.Location = new System.Drawing.Point(103, 33);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(151, 20);
            this.IDTextBox.TabIndex = 18;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.Aqua;
            this.ChangeButton.Location = new System.Drawing.Point(24, 145);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(230, 53);
            this.ChangeButton.TabIndex = 16;
            this.ChangeButton.Text = "Змінити ";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(103, 106);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(151, 20);
            this.YearTextBox.TabIndex = 15;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(103, 70);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(151, 20);
            this.NameTextBox.TabIndex = 14;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Рік створення";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Назва";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChangeTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(284, 237);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeTeam";
            this.Text = "Змінити команду";
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