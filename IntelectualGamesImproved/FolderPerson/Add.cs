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

namespace IntelectualGamesImproved.FolderPerson
{
    public partial class Add : Form
    {
        public Person newPerson { get; set; } 
        public Add()
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message );
                }
                newPerson = new Person(0, NameTextBox.Text.ToString().Trim(), y);
                DialogResult = DialogResult.OK;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
