namespace IntelectualGamesImproved.FolderPerson
{
    partial class Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Рік";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(84, 23);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(151, 20);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(84, 59);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(151, 20);
            this.YearTextBox.TabIndex = 3;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Aqua;
            this.AddButton.Location = new System.Drawing.Point(26, 99);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(209, 53);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(269, 185);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}