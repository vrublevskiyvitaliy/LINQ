using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelectualGamesImproved.TypeOfQuestion

{
    public partial class AddType : Form
    {
        public string name;
        public AddType()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Введіть дані!");
                return;
            }
            else
            {
                name = NameTextBox.Text.ToString();
                DialogResult = DialogResult.OK;
                return;
            }
        }

        
    }
}
