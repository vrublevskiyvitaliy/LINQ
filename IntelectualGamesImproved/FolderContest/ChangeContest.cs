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

namespace IntelectualGamesImproved.FolderContest
{
    public partial class ChangeContest : Form
    {
        private Contest oldContest;
        public Contest newContest { get; set; }
        public ChangeContest(Contest contest)
        {
            InitializeComponent();
            oldContest = contest;

            IDTextBox.Text = contest.ID.ToString();
            IDTextBox.Enabled = false;

            NameTextBox.Text = contest.Name;
            YearTextBox.Text = contest.Year.ToString();


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

                newContest = new Contest(oldContest.ID, NameTextBox.Text.ToString().Trim(), y);

                if (oldContest.Compare(newContest))
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


    }
}
