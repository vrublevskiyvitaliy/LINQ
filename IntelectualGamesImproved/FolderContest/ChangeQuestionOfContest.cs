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
using AccesToDataBase;

namespace IntelectualGamesImproved.FolderContest
{
    public partial class ChangeQuestionOfContest : Form
    {
        private Contest currentContest;
        private AccesToDataBase.AccesToDataBase accesToDataBase;

        public ChangeQuestionOfContest(AccesToDataBase.AccesToDataBase acces, Contest contest)
        {
            InitializeComponent();
            accesToDataBase = acces;
            currentContest = contest;

            UpdateAllData();
        
        
        }

        public void UpdateAllData()
        {

            List<string> addList = new List<string>();

            addList.Add("");
            addList.AddRange(accesToDataBase.getAllTypesName());
            AddComboBox.DataSource = addList;
            AddComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> deleteList = new List<string>();
            deleteList.Add("");
            deleteList.AddRange(accesToDataBase.getAllTypesName());
            DeleteComboBox.DataSource = deleteList;
            DeleteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;


            UpdateAddList();
            UpdateDeleteList();
            
            
            List<Question> list = new List<Question>();

            list = accesToDataBase.getQuestionsByContest(currentContest);

            
            QuestionDataGridView.DataSource = list;
            QuestionDataGridView.Columns["ID"].Visible = false;
            QuestionDataGridView.ReadOnly = true;
            QuestionDataGridView.MultiSelect = false;
            reasizeDataGridView(QuestionDataGridView);
        
        }

        
        private void UpdateAddList()
        {
            List<Question> addList = new List<Question>();

            if (AddComboBox.Items.Count == 1 || AddComboBox.SelectedValue.ToString() == "")
            {
                //AddDataGridView.DataSource = new 
                //AddDataGridView.Rows.Clear();


            }
            else
            {

                string name = AddComboBox.SelectedValue.ToString();

                List<Question> list = accesToDataBase.getQuestionByType(name);


                foreach (var c in list)
                {
                    if (!accesToDataBase.isQuestionInContest(currentContest, c))
                        addList.Add(c);
                }

            }

            AddDataGridView.DataSource = addList;
            //

            AddDataGridView.Columns["ID"].Visible = false;
            AddDataGridView.Columns["Type"].Visible = false;
            AddDataGridView.Columns["Year"].Visible = false;
            AddDataGridView.Columns["Author"].Visible = false;
            AddDataGridView.Columns["Answear"].Visible = false;
            AddDataGridView.Columns["Comment"].Visible = false;
            AddDataGridView.Columns["Difficulty"].Visible = false;
            
            AddDataGridView.ReadOnly = true;
            AddDataGridView.MultiSelect = false;
            AddDataGridView.Columns["ID"].Visible = false;
            reasizeDataGridView(AddDataGridView);
            
            
        
        }
        private void UpdateDeleteList()
        {
            List<Question> deleteList = new List<Question>();

            if (DeleteComboBox.Items.Count == 1 || DeleteComboBox.SelectedValue.ToString() == "")
            {
                //DeleteDataGridView.Rows.Clear();
               // return;
            }
            else
            {

                string name = DeleteComboBox.SelectedValue.ToString();

                List<Question> list = accesToDataBase.getQuestionByType(name);


                foreach (var c in list)
                {
                    if (accesToDataBase.isQuestionInContest(currentContest, c))
                        deleteList.Add(c);
                }

            }

            DeleteDataGridView.DataSource = deleteList;
            //

            DeleteDataGridView.Columns["ID"].Visible = false;
            DeleteDataGridView.Columns["Type"].Visible = false;
            DeleteDataGridView.Columns["Year"].Visible = false;
            DeleteDataGridView.Columns["Author"].Visible = false;
            DeleteDataGridView.Columns["Answear"].Visible = false;
            DeleteDataGridView.Columns["Comment"].Visible = false;
            DeleteDataGridView.Columns["Difficulty"].Visible = false;

            DeleteDataGridView.ReadOnly = true;
            DeleteDataGridView.MultiSelect = false;
            DeleteDataGridView.Columns["ID"].Visible = false;
            reasizeDataGridView(DeleteDataGridView);
        
        
        }

        private void reasizeDataGridView(DataGridView e)
        {
            for (int i = 0; i < e.ColumnCount; i++)
                e.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddDataGridView.Rows.Count == 0) return;
            int id = Int32.Parse(AddDataGridView.CurrentRow.Cells[0].Value.ToString());
            Question question = accesToDataBase.getQuestionByID(id);

            accesToDataBase.addQuestionToContest(currentContest,question);
            UpdateAllData();
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteDataGridView.Rows.Count == 0) return;
            int id = Int32.Parse(DeleteDataGridView.CurrentRow.Cells[0].Value.ToString());
            Question question = accesToDataBase.getQuestionByID(id);

            accesToDataBase.deleteQuestionFromContest(currentContest, question);
            UpdateAllData();
        }

        private void AddComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddList();
        }

        private void DeleteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDeleteList();
        }

    }
}
