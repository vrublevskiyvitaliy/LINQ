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
    public partial class ChangeTeam : Form
    {
        private Team oldTeam;
        public Team newTeam { get; set; }

        public ChangeTeam(Team team)
        {
            InitializeComponent();

            oldTeam = team;
            IDTextBox.Text = oldTeam.ID.ToString();
            IDTextBox.Enabled = false;

            NameTextBox.Text = oldTeam.Name;
            YearTextBox.Text = oldTeam.Year.ToString();


        }

        private void ChangeButton_Click(object sender, EventArgs e)
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                newTeam = new Team(oldTeam.ID, NameTextBox.Text.ToString().Trim(), y);

                if (oldTeam.Compare(newTeam))
                {
                    MessageBox.Show("Ви не змінили дані!");
                    this.Close();
                    return;

                }
                else
                {
                    DialogResult = DialogResult.OK;
                }



            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
