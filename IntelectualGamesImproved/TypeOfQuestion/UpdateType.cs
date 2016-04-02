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

namespace IntelectualGamesImproved.TypeOfQuestion
{
    public partial class UpdateType : Form
    {
        private Common.TypeOfQuestion oldType;
        public Common.TypeOfQuestion newType;
        public UpdateType(Common.TypeOfQuestion oldType)
        {
            InitializeComponent();

            this.oldType = oldType;

            IDTextBox.Text = oldType.ID.ToString();
            IDTextBox.Enabled = false;

            NameTextBox.Text = oldType.Name;



        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Введіть дані!");
                return;
            }
            else 
            {
                newType = new Common.TypeOfQuestion(oldType.ID, NameTextBox.Text.ToString().Trim());
                if (oldType.compare(newType))
                {
                    MessageBox.Show("Ви не змінили дані!");
                    //this.Close();
                    return;

                }
                else
                {
                    DialogResult = DialogResult.OK;
                    return;
                }

            }
        }
    }
}
