namespace IntelectualGamesImproved.TypeOfQuestion
{
    partial class AddType
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(64, 22);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(195, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Aqua;
            this.AddButton.Location = new System.Drawing.Point(22, 76);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(237, 41);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddType";
            this.Text = "Додати Тип Запитання";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}