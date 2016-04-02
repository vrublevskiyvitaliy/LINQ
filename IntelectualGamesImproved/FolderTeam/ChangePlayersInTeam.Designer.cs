namespace IntelectualGamesImproved.FolderTeam
{
    partial class ChangePlayersInTeam
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
            this.PlayersDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayersDataGridView
            // 
            this.PlayersDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.PlayersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayersDataGridView.Location = new System.Drawing.Point(261, 44);
            this.PlayersDataGridView.Name = "PlayersDataGridView";
            this.PlayersDataGridView.Size = new System.Drawing.Size(515, 360);
            this.PlayersDataGridView.TabIndex = 13;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Aqua;
            this.DeleteButton.Location = new System.Drawing.Point(12, 381);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(221, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Aqua;
            this.AddButton.Location = new System.Drawing.Point(12, 170);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(221, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Видалити гравця з команди";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Додати гравця до команди";
            // 
            // AddDataGridView
            // 
            this.AddDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.AddDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddDataGridView.Location = new System.Drawing.Point(12, 44);
            this.AddDataGridView.Name = "AddDataGridView";
            this.AddDataGridView.Size = new System.Drawing.Size(221, 120);
            this.AddDataGridView.TabIndex = 14;
            // 
            // DeleteDataGridView
            // 
            this.DeleteDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.DeleteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DeleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteDataGridView.Location = new System.Drawing.Point(12, 225);
            this.DeleteDataGridView.Name = "DeleteDataGridView";
            this.DeleteDataGridView.Size = new System.Drawing.Size(221, 150);
            this.DeleteDataGridView.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(462, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Гравці у команді";
            // 
            // ChangePlayersInTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(808, 419);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteDataGridView);
            this.Controls.Add(this.AddDataGridView);
            this.Controls.Add(this.PlayersDataGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePlayersInTeam";
            this.Text = "Змінити гравців у команді";
            ((System.ComponentModel.ISupportInitialize)(this.PlayersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayersDataGridView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AddDataGridView;
        private System.Windows.Forms.DataGridView DeleteDataGridView;
        private System.Windows.Forms.Label label3;
    }
}