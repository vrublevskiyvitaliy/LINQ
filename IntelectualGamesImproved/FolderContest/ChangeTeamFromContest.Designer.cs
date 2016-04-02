namespace IntelectualGamesImproved.FolderContest
{
    partial class ChangeTeamFromContest
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
            this.DeleteDataGridView = new System.Windows.Forms.DataGridView();
            this.AddDataGridView = new System.Windows.Forms.DataGridView();
            this.TeamDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteDataGridView
            // 
            this.DeleteDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.DeleteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DeleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteDataGridView.Location = new System.Drawing.Point(13, 224);
            this.DeleteDataGridView.Name = "DeleteDataGridView";
            this.DeleteDataGridView.Size = new System.Drawing.Size(221, 150);
            this.DeleteDataGridView.TabIndex = 22;
            // 
            // AddDataGridView
            // 
            this.AddDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.AddDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddDataGridView.Location = new System.Drawing.Point(13, 43);
            this.AddDataGridView.Name = "AddDataGridView";
            this.AddDataGridView.Size = new System.Drawing.Size(221, 120);
            this.AddDataGridView.TabIndex = 21;
            // 
            // TeamDataGridView
            // 
            this.TeamDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TeamDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TeamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamDataGridView.Location = new System.Drawing.Point(262, 43);
            this.TeamDataGridView.Name = "TeamDataGridView";
            this.TeamDataGridView.Size = new System.Drawing.Size(515, 360);
            this.TeamDataGridView.TabIndex = 20;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Aqua;
            this.DeleteButton.Location = new System.Drawing.Point(14, 380);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(220, 23);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Aqua;
            this.AddButton.Location = new System.Drawing.Point(14, 169);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(220, 23);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Видалити команду із змагання";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Додати команду до змагання";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(446, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Команди на змаганні";
            // 
            // ChangeTeamFromContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(794, 426);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteDataGridView);
            this.Controls.Add(this.AddDataGridView);
            this.Controls.Add(this.TeamDataGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeTeamFromContest";
            this.Text = "Змінити команди у змаганні";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DeleteDataGridView;
        private System.Windows.Forms.DataGridView AddDataGridView;
        private System.Windows.Forms.DataGridView TeamDataGridView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}