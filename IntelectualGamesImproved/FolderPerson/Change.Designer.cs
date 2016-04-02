namespace IntelectualGamesImproved.FolderPerson
{
    partial class Change
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.Aqua;
            this.ChangeButton.Location = new System.Drawing.Point(32, 139);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(209, 53);
            this.ChangeButton.TabIndex = 9;
            this.ChangeButton.Text = "Змінити";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(90, 99);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(151, 20);
            this.YearTextBox.TabIndex = 8;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(90, 63);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(151, 20);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Рік";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ім\'я";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(90, 26);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(151, 20);
            this.IDTextBox.TabIndex = 11;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(273, 225);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Change";
            this.Text = "Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDTextBox;
    }
}