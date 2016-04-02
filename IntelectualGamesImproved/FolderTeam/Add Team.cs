using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace IntelectualGamesImproved.FolderTeam
{
    public partial class Add_Team : Form
    {
        public Team newTeam { get; set; }
 
        public Add_Team()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.ToString().Trim() == string.Empty ||
                YearTextBox.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Введіть дані");
                return;
            }
            else
            {
                
                int y = 0;
                try
                {
                    y = Int32.Parse(YearTextBox.Text.ToString().Trim());

                
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
                
              
                    newTeam = new Team(0, NameTextBox.Text.ToString().Trim(), y);
                    DialogResult = DialogResult.OK;

            }
        }




    }
}
