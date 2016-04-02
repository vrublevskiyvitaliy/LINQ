namespace IntelectualGamesImproved.TypeOfQuestion
{
    partial class UpdateType
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.Aqua;
            this.ChangeButton.Location = new System.Drawing.Point(25, 138);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(237, 41);
            this.ChangeButton.TabIndex = 5;
            this.ChangeButton.Text = "Змінити";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(92, 84);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(170, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(92, 34);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(170, 20);
            this.IDTextBox.TabIndex = 7;
            // 
            // UpdateType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(284, 214);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "UpdateType";
            this.Text = "Змінити Тип Запитання";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTextBox;
    }
}