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


namespace IntelectualGamesImproved
{
    public partial class AddQuestion : Form
    {

        public Question newQuestion { get; set; }


        public AddQuestion(List<string> types, List<Author> authors, List<string> difficulties)
        {
            InitializeComponent();

            TypeComboBox.DataSource = types;
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> a = new List<string>();

            a.Add("");
            foreach (Author tmp in authors)
            {
                a.Add(tmp.Name);


            }

            AuthorComboBox.DataSource = a;

            AuthorComboBox.DataSource = a;
            AuthorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            DifficultiesComboBox.DataSource = difficulties;
            DifficultiesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TypeComboBox.SelectedValue.ToString().Trim() == string.Empty ||
                NameTextBox.Text.Trim() == string.Empty ||
                 AnswearTextBox.Text.Trim() == string.Empty ||
                 AuthorComboBox.SelectedValue.ToString().Trim() == string.Empty ||
                 DifficultiesComboBox.SelectedValue.ToString() == string.Empty ||
                 DateTextBox.Text.Trim() == string.Empty
                 )
            {
                MessageBox.Show("Введіть дані!");
                return;

            }
            else
            {
                int y = 0;
                try
                {
                    y = Int32.Parse(DateTextBox.Text.Trim());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }




                newQuestion = new Question(0, TypeComboBox.SelectedValue.ToString().Trim(),
                    NameTextBox.Text.Trim(),
                    AnswearTextBox.Text.Trim(),
                    y,
                    AuthorComboBox.SelectedValue.ToString(),
                    DifficultiesComboBox.SelectedValue.ToString(),
                    CommentTextBox.Text.Trim());
                DialogResult = DialogResult.OK;

            }



        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {

        }


    }
}
