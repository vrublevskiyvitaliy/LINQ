using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesToDataBase;
using Common;

namespace IntelectualGamesImproved
{
    public partial class IntelectualGamesImproved : Form
    {
        AccesToDataBase.AccesToDataBase accesToDataBase;
        public IntelectualGamesImproved()
        {
            InitializeComponent();
            accesToDataBase = new AccesToDataBase.AccesToDataBase();
           
            ChangeAllViews();
            //Initialize question Tab

            List<string> list = new List<string>();
            list.Add("");
            list.AddRange(accesToDataBase.getAllTypesName());
            TypeQuestionComboBox.DataSource = list;
            TypeQuestionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
           
            List<string> temp = new List<string>();
            temp.Clear();
            temp.Add("");
            temp.AddRange(accesToDataBase.getAllDifficulties());
            DifficultyQuestionComboBox.DataSource = temp;
            DifficultyQuestionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        
            //Initialize Type Of Question

            Common.TypeOfQuestion type = new Common.TypeOfQuestion(1, "Що? Де? Коли?");
            accesToDataBase.changeType(type);

        }

        private void reasizeDataGridView(DataGridView e)
        {
            for (int i = 0; i < e.ColumnCount; i++)
                e.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddQuestion form = new AddQuestion(accesToDataBase.getAllTypesName(),
                accesToDataBase.getAllAuthors(), accesToDataBase.getAllDifficulties());


            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {

                bool index = accesToDataBase.addQuestion(form.newQuestion);
                if (index)
                {
                    ChangeAllViews();
                    MessageBox.Show("Запитання добавлено!");
                   
                }

                else
                {
                    MessageBox.Show("Таке запитання вже є в Базі!");
                    return;

                }
            }
        }
        
        private void ChangeAllViews()
        {
            //Type of Question
            List<string> list = accesToDataBase.getAllTypesName();
           // TypeQuestionDataGridView
            
            TypeQuestionDataGridView.DataSource = accesToDataBase.getAllTypes();
         
            TypeQuestionDataGridView.ReadOnly = true;
            TypeQuestionDataGridView.MultiSelect = false;
            TypeQuestionDataGridView.Columns["ID"].Visible = false;
            reasizeDataGridView(TypeQuestionDataGridView);

            //Questions
            QuestionDataGridView.DataSource = accesToDataBase.getAllQuestions();
            QuestionDataGridView.ReadOnly = true;
            QuestionDataGridView.MultiSelect = false;
            QuestionDataGridView.Columns["ID"].Visible = false;
            reasizeDataGridView(QuestionDataGridView);

            //Contests

            ContestDataGridView.DataSource = accesToDataBase.getAllContests();
            ContestDataGridView.ReadOnly = true;
            ContestDataGridView.MultiSelect = false;
            ContestDataGridView.Columns["ID"].Visible = false;
            reasizeDataGridView(ContestDataGridView);

            //Authors

            AuthorsDataGridView.DataSource = accesToDataBase.getAllAuthors();
            AuthorsDataGridView.ReadOnly = true;
            AuthorsDataGridView.MultiSelect = false;
            AuthorsDataGridView.Columns["ID"].Visible = false;
            reasizeDataGridView(AuthorsDataGridView);

            //Players
            PlayerDataGridView.DataSource = accesToDataBase.getAllPlayers();
            PlayerDataGridView.ReadOnly = true;
            PlayerDataGridView.MultiSelect = false;
            PlayerDataGridView.Columns["ID"].Visible = false;
            reasizeDataGridView(PlayerDataGridView);


            //Teams
            TeamsDataGridView.DataSource = accesToDataBase.getAllTeams();
            TeamsDataGridView.ReadOnly = true;
            TeamsDataGridView.MultiSelect = false;
            TeamsDataGridView.Columns["ID"].Visible = false;
            reasizeDataGridView(TeamsDataGridView);



        }

        private void SearchQuestionButton_Click(object sender, EventArgs e)
        {
            List<Question> list = new List<Question>();
            if (sender == null || e == null || questionFilterIsNull())
            {
                list = accesToDataBase.getAllQuestions();

            }
            else
            {
                string year = YearQuestionTextBox.Text.ToString().Trim();
                if (year == string.Empty) year = "0";
                int y;
                try
                {
                    y = Int32.Parse(year);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                Question filter = new Question(0,TypeQuestionComboBox.SelectedValue.ToString().Trim(),
                    NameQuestionTextBox.Text.ToString().Trim(),
                    AnswearQuestionTextBox.Text.ToString().Trim(),
                    y,
                    AuthorQuestionTextBox.Text.ToString().Trim(),
                    DifficultyQuestionComboBox.SelectedValue.ToString().Trim(),
                    CommentQuestionTextBox.Text.ToString().Trim());
                list = accesToDataBase.getFilteredQuestion(filter);
            
            }

            QuestionDataGridView.DataSource = list;
       }


        private bool questionFilterIsNull()
        {
            if (TypeQuestionComboBox.SelectedValue.ToString().Trim() == string.Empty &&
                NameQuestionTextBox.Text.ToString().Trim() == string.Empty &&
                AnswearQuestionTextBox.Text.ToString().Trim() == string.Empty &&
                AuthorQuestionTextBox.Text.ToString().Trim() == string.Empty &&
                YearQuestionTextBox.Text.ToString().Trim() == string.Empty &&
                CommentQuestionTextBox.Text.ToString().Trim() == string.Empty &&
                DifficultyQuestionComboBox.SelectedValue.ToString().Trim() == string.Empty)
                return true;
            return false;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearQuestionFilterButton_Click(object sender, EventArgs e)
        {
            TypeQuestionComboBox.SelectedIndex = 0;
            NameQuestionTextBox.Text = "";
            AnswearQuestionTextBox.Text = "";
            AuthorQuestionTextBox.Text = "";
            DifficultyQuestionComboBox.SelectedIndex = 0;
            CommentQuestionTextBox.Text = "";
            YearQuestionTextBox.Text = "";
        }

        private void SearchTypeButton_Click(object sender, EventArgs e)
        {
            List<Common.TypeOfQuestion> list = new List<Common.TypeOfQuestion>();

            if (sender == null || e == null ||
                NameTypeQuestionTextBox.Text.ToString().Trim() == string.Empty)
            {
                list = accesToDataBase.getAllTypes();
            }
            else
                list = accesToDataBase.getFilteredTypeName(NameTypeQuestionTextBox.Text.ToString().Trim());
            TypeQuestionDataGridView.DataSource = list;
            

        }

        private void ClearTypeButton_Click(object sender, EventArgs e)
        {
            NameTypeQuestionTextBox.Text = "";

        }

        private void TypeQuestionDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name;
            try
            {
                 name = TypeQuestionDataGridView.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            List<Question> list = accesToDataBase.getQuestionByType(name);
            QuestionToTypeDataGridView.DataSource = list;

            QuestionToTypeDataGridView.Columns["ID"].Visible = false;
            QuestionToTypeDataGridView.Columns["Type"].Visible = false;
            QuestionToTypeDataGridView.Columns["Author"].Visible = false;
            QuestionToTypeDataGridView.Columns["Comment"].Visible = false;
            QuestionToTypeDataGridView.Columns["Year"].Visible = false;
            QuestionToTypeDataGridView.Columns["Difficulty"].Visible = false;

            QuestionToTypeDataGridView.ReadOnly = true;
            QuestionToTypeDataGridView.MultiSelect = false;

            reasizeDataGridView(QuestionToTypeDataGridView);
        }

        private Common.TypeOfQuestion getCurrentType()
        {
            Common.TypeOfQuestion current = new Common.TypeOfQuestion(
                Int32.Parse(TypeQuestionDataGridView.CurrentRow.Cells[0].Value.ToString()),
                TypeQuestionDataGridView.CurrentRow.Cells[1].Value.ToString()
                );
            return current;
        
        }


        private Question getCurrentQuestion()
        {
            Question oldQuestion = new Question(Int32.Parse(QuestionDataGridView.CurrentRow.Cells[0].Value.ToString()),
                                                QuestionDataGridView.CurrentRow.Cells[1].Value.ToString(),
                                                QuestionDataGridView.CurrentRow.Cells[2].Value.ToString(),
                                                QuestionDataGridView.CurrentRow.Cells[3].Value.ToString(),
                                                Int32.Parse(QuestionDataGridView.CurrentRow.Cells[4].Value.ToString()),
                                                QuestionDataGridView.CurrentRow.Cells[5].Value.ToString(),
                                                QuestionDataGridView.CurrentRow.Cells[6].Value.ToString(),
                                                QuestionDataGridView.CurrentRow.Cells[7].Value.ToString()
                                                );
            return oldQuestion;
        }
        private void updateTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.TypeOfQuestion current;
            try 
            { 
                current = getCurrentType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            TypeOfQuestion.UpdateType form = new TypeOfQuestion.UpdateType(current);

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                if (accesToDataBase.changeType(form.newType))
                {
                    ChangeAllViews();
                    MessageBox.Show("Тип запитання змінено!");
                   
                    return;
                }
                else
                {
                    MessageBox.Show("Такий тип вже існує!");


                    return;
                
                }
            
            }

        }

        private void addTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfQuestion.AddType form = new TypeOfQuestion.AddType();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                if (accesToDataBase.addType(new Common.TypeOfQuestion(0, form.name)))
                {
                    ChangeAllViews();
                    MessageBox.Show("Тип запитання додано!");
                   
                    return;
                
                }
                else
                {
                    MessageBox.Show("Такий тип вже існує!");
                   

                    return;
                    
                }
            
            
            }
        }

        private void deleteTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.TypeOfQuestion current = new Common.TypeOfQuestion() ;
            try
            {
                current = new Common.TypeOfQuestion(
               Int32.Parse(TypeQuestionDataGridView.CurrentRow.Cells[0].Value.ToString()),
               TypeQuestionDataGridView.CurrentRow.Cells[1].Value.ToString()
               );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (accesToDataBase.deleteType(current))
            {
                ChangeAllViews();
                MessageBox.Show("Тип запитання видано!");
                
                return;
            }
            else
            {
                MessageBox.Show("Видалення неможливе!");

                return;

            }
        }

        private void updateQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Question oldQuestion = new Question();
            try
            {
                oldQuestion = getCurrentQuestion();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ChangeQuestion form = new ChangeQuestion(oldQuestion,accesToDataBase.getAllTypesName(),
                                                    accesToDataBase.getAllAuthors(),
                                                    accesToDataBase.getAllDifficulties());
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {

                bool index = accesToDataBase.changeQuestion(form.newQuestion);
                if (index)
                {
                    ChangeAllViews();
                    MessageBox.Show("Запитання змінено!");

                }

                else
                {
                    MessageBox.Show("Таке запитання вже є в Базі!");
                    return;

                }
            }

        }

        private void deleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question current = new Question();
            try
            {
                current = getCurrentQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

                if (accesToDataBase.deleteQuestion(current))
            {
                ChangeAllViews();
                MessageBox.Show("Запитання видалено!");
                return;

            }
            else
            {
                
                MessageBox.Show("Запитання не може бути видаленно!");
                return;


            }
        }

        private void addAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderPerson.Add form = new FolderPerson.Add();
            form.Text = "Додати Автора";
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                if (accesToDataBase.addAuthor(new Author(form.newPerson)))
                {
                    ChangeAllViews();
                    MessageBox.Show("Нового автора додано!");
                    return;

                }
                else
                {
                   
                    MessageBox.Show("Такий автор вже існує!");
                    return;
                }

            }
            
        }
        private Author getCurrentAuthor()
        {
            Author current = new Author(Int32.Parse(AuthorsDataGridView.CurrentRow.Cells[0].Value.ToString().Trim()),
                                        AuthorsDataGridView.CurrentRow.Cells[1].Value.ToString().Trim(),
                                        Int32.Parse(AuthorsDataGridView.CurrentRow.Cells[2].Value.ToString().Trim()));
            return current;
        
        }
        private void changeAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Author current = new Author();
            try
            {
                current = getCurrentAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            FolderPerson.Change form = new FolderPerson.Change((Person)current);

            form.Text = "Змінити Автора";

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                if (accesToDataBase.changeAuthor(new Author(form.newPerson)))
                {
                    ChangeAllViews();
                    MessageBox.Show("Автора змінено!");
                    return;

                }
                else
                {
                    MessageBox.Show("Такий автор вже існує!");
                    return;
                }
            
            }

        }

        private void deleteAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Author current = new Author();
            try
            {
                current = getCurrentAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (accesToDataBase.deleteAuthor(current))
            {
                ChangeAllViews();
                MessageBox.Show("Автора видалено!");
                return;
            }
            else
            {
                MessageBox.Show("Автор не може бути видалений!");
                return;
            }


        }

        private void AuthorsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Author current = new Author();
            try
            {
                current = getCurrentAuthor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            QuestionToAuthorDataGridView.DataSource = accesToDataBase.getQuestionByAuthor(current);
            
            QuestionToAuthorDataGridView.Columns["ID"].Visible = false;
            QuestionToAuthorDataGridView.Columns["Author"].Visible = false;
            QuestionToAuthorDataGridView.Columns["Comment"].Visible = false;
            QuestionToAuthorDataGridView.Columns["Year"].Visible = false;
            QuestionToAuthorDataGridView.Columns["Difficulty"].Visible = false;
            
            QuestionToAuthorDataGridView.ReadOnly = true;
            QuestionToAuthorDataGridView.MultiSelect = false;
            reasizeDataGridView(QuestionToAuthorDataGridView);
        
        }

        private void AuthorSearchButton_Click(object sender, EventArgs e)
        {
            if (sender == null || e == null ||
                (NameAuthorTextBox.Text.ToString().Trim() == string.Empty &&
                 YearAuthorTextBox.Text.ToString().Trim() == string.Empty
                )
                )
            {
                
                AuthorsDataGridView.DataSource = accesToDataBase.getAllAuthors();

            }
            else
            {
                string year = "0";
                int y;
                if (YearAuthorTextBox.Text.ToString().Trim() != string.Empty) year = YearAuthorTextBox.Text.ToString().Trim();
                try
                {
                     y = Int32.Parse(year);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                Author filter = new Author(0,NameAuthorTextBox.Text.ToString().Trim(),y);
                
                AuthorsDataGridView.DataSource = accesToDataBase.getFilteredAuthors(filter);


            }
        }

        private void AuthorClearButton_Click(object sender, EventArgs e)
        {
            NameAuthorTextBox.Text = "";
            YearAuthorTextBox.Text = "";
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderPerson.Add form = new FolderPerson.Add();
            form.Text = "Додати Гравця";
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                if (accesToDataBase.addPlayer(new Player(form.newPerson)))
                {
                    ChangeAllViews();
                    MessageBox.Show("Нового гравця додано!");
                    return;

                }
                else
                {

                    MessageBox.Show("Такий гравець вже існує!");
                    return;
                }

            }
            
        }
        private Player getCurrentPlayer()
        {
            Player current = new Player(Int32.Parse(PlayerDataGridView.CurrentRow.Cells[0].Value.ToString().Trim()),
                                        PlayerDataGridView.CurrentRow.Cells[1].Value.ToString().Trim(),
                                        Int32.Parse(PlayerDataGridView.CurrentRow.Cells[2].Value.ToString().Trim()));

            return current;
        
        }

        private void changePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Player current = new Player();
            try
            {
                current = getCurrentPlayer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            FolderPerson.Change form = new FolderPerson.Change((Person)current);

            form.Text = "Змінити Гравця";

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                if (accesToDataBase.changePlayer(new Player(form.newPerson)))
                {
                    ChangeAllViews();
                    MessageBox.Show("Гравця змінено!");
                    return;

                }
                else
                {
                    MessageBox.Show("Такий гравець вже існує!");
                    return;
                }

            }


        }

        private void deletePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Player current = new Player();
            try
            {
                current = getCurrentPlayer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (accesToDataBase.deletePlayer(current))
            {
                ChangeAllViews();
                MessageBox.Show("Гравця видалено!");
                return;
            }
            else
            {
                MessageBox.Show("Гравець не може бути видалений!");
                return;
            }

        }

        private void PlayerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Player current = new Player();
            try
            {
              current = getCurrentPlayer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            TeamToPlayerDataGridView.DataSource = accesToDataBase.getTeamByPlayer(current);

            TeamToPlayerDataGridView.Columns["ID"].Visible = false;
            
            TeamToPlayerDataGridView.ReadOnly = true;
            TeamToPlayerDataGridView.MultiSelect = false;
            reasizeDataGridView(TeamToPlayerDataGridView);

        }

        private void ClearPlayerButton_Click(object sender, EventArgs e)
        {
            NamePlayerTextBox.Text = "";
            YearPlayerTextBox.Text = "";

        }

        private void PlayerSearchButton_Click(object sender, EventArgs e)
        {
            if (sender == null || e == null ||
                (NamePlayerTextBox.Text.ToString().Trim() == string.Empty &&
                 YearPlayerTextBox.Text.ToString().Trim() == string.Empty)

                )
            {
                PlayerDataGridView.DataSource = accesToDataBase.getAllPlayers();

            }
            else
            {
                string year = "0";
                if (YearPlayerTextBox.Text.ToString().Trim() != string.Empty) year = YearPlayerTextBox.Text.ToString().Trim();

                int y;
                try
                {

                    y = Int32.Parse(year);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                Player filter = new Player(0, NamePlayerTextBox.Text.ToString().Trim(), y);
                PlayerDataGridView.DataSource = accesToDataBase.getFilteredPlayers(filter);

            
            
            
            }
        }

        private void addTeamToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FolderTeam.Add_Team form = new FolderTeam.Add_Team();
      
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                if (accesToDataBase.addTeam(form.newTeam))
                {
                    ChangeAllViews();
                    MessageBox.Show("Нову команду додано!");
                    return;

                }
                else
                {

                    MessageBox.Show("Така команда вже існує!");
                    return;
                }

            }
        }

        private Team getCurrentTeam()
        { 
            Team current = new Team(Int32.Parse(TeamsDataGridView.CurrentRow.Cells[0].Value.ToString().Trim()),
                                    TeamsDataGridView.CurrentRow.Cells[1].Value.ToString().Trim(),
                                    Int32.Parse(TeamsDataGridView.CurrentRow.Cells[2].Value.ToString()));
            return current;
       
        }
        private void changeTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Team current = new Team();
            try
            {
                current = getCurrentTeam();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            FolderTeam.ChangeTeam form = new FolderTeam.ChangeTeam(current);

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                if (accesToDataBase.changeTeam(form.newTeam))
                {
                    ChangeAllViews();
                    MessageBox.Show("Команду змінено!");
                    return;

                }
                else
                {
                    MessageBox.Show("Така команда вже існує!");
                    return;
                }

            }
        }

        private void deleteTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Team current = new Team();
            try
            {
               current = getCurrentTeam();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (accesToDataBase.deleteTeam(current))
            {
                ChangeAllViews();
                MessageBox.Show("Команду видалено!");
                return;
            }
            else
            {
                MessageBox.Show("Команда не може бути видалена!");
                return;
            }
        }

        private void TeamSearchButton_Click(object sender, EventArgs e)
        {
            if (sender == null || e == null ||
                (NameTeamTextBox.Text.ToString().Trim() == string.Empty &&
                 YearTeamTextBox.Text.ToString().Trim() == string.Empty)

                )
            {
                TeamsDataGridView.DataSource = accesToDataBase.getAllTeams();

            }
            else
            {
                string year = "0";
                if (YearTeamTextBox.Text.ToString().Trim() != string.Empty) year = YearTeamTextBox.Text.ToString().Trim();

                int y;
                try
                {

                    y = Int32.Parse(year);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                Team filter = new Team(0, NameTeamTextBox.Text.ToString().Trim(), y);
                TeamsDataGridView.DataSource = accesToDataBase.getFilteredTeams(filter);





            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTeamTextBox.Text = "";
            YearTeamTextBox.Text = "";
        }

        private void TeamsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Team current = new Team();
            try
            {
                current = getCurrentTeam();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            PlayerToTeamDataGridView.DataSource = accesToDataBase.getPlayersByTeam(current);

            PlayerToTeamDataGridView.Columns["ID"].Visible = false;

            PlayerToTeamDataGridView.ReadOnly = true;
            PlayerToTeamDataGridView.MultiSelect = false;
            reasizeDataGridView(PlayerToTeamDataGridView);
        }

        private void changePlayersInTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Team current = new Team();
            try
            {
                current = getCurrentTeam();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            FolderTeam.ChangePlayersInTeam form = new FolderTeam.ChangePlayersInTeam(accesToDataBase, current);
            form.ShowDialog();
            ChangeAllViews();
        }

        private void SearchContestButton_Click(object sender, EventArgs e)
        {
            if (sender == null || e == null ||
                (NameContestTextBox.Text.ToString().Trim() == string.Empty &&
                 YearContestTextBox.Text.ToString().Trim() == string.Empty)

                )
            {
                ContestDataGridView.DataSource = accesToDataBase.getAllContests();

            }
            else
            {
                string year = "0";
                if (YearContestTextBox.Text.ToString().Trim() != string.Empty) year = YearContestTextBox.Text.ToString().Trim();

                int y;
                try
                {

                    y = Int32.Parse(year);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                Contest filter = new Contest(0, NameContestTextBox.Text.ToString().Trim(), y);
                ContestDataGridView.DataSource = accesToDataBase.getFilteredContests(filter);





            }
        }

        private void addContestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderContest.AddContest form = new FolderContest.AddContest();

            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                if (accesToDataBase.addContest(form.newContest))
                {
                    ChangeAllViews();
                    MessageBox.Show("Нове змагання додано!");
                    return;

                }
                else
                {

                    MessageBox.Show("Таке змагання вже існує!");
                    return;
                }

            }
        }

        private Contest getCurrentContest()
        {
            Contest contest = new Contest(Int32.Parse(ContestDataGridView.CurrentRow.Cells[0].Value.ToString().Trim()),
                                          ContestDataGridView.CurrentRow.Cells[1].Value.ToString().Trim(),
                                          Int32.Parse(ContestDataGridView.CurrentRow.Cells[2].Value.ToString().Trim()));
            return contest;
        }
        private void ClearContestButton_Click(object sender, EventArgs e)
        {
            NameContestTextBox.Text = "";
            YearContestTextBox.Text = "";
        }

        private void changeContestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contest current = new Contest();
            try
            {
                current = getCurrentContest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            FolderContest.ChangeContest form = new FolderContest.ChangeContest(current);

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                if (accesToDataBase.changeContest(form.newContest))
                {
                    ChangeAllViews();
                    MessageBox.Show("Змагання змінено!");
                    return;

                }
                else
                {
                    MessageBox.Show("Таке змагання вже існує!");
                    return;
                }

            }
        }

        private void deleteContestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Contest current = new Contest();
            try
            {
                current = getCurrentContest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (accesToDataBase.deleteContest(current))
            {
                ChangeAllViews();
                MessageBox.Show("Змагання видалено!");
                return;
            }
            else
            {
                MessageBox.Show("Змагання не може бути видалено!");
                return;
            }
        }

        private void changeTeamsInContestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Contest current = getCurrentContest();
                FolderContest.ChangeTeamFromContest form = new FolderContest.ChangeTeamFromContest(accesToDataBase, current);
                form.ShowDialog();
                ChangeAllViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void changeQuestionInContestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Contest current = getCurrentContest();
                FolderContest.ChangeQuestionOfContest form = new FolderContest.ChangeQuestionOfContest(accesToDataBase, current);
                form.ShowDialog();
                ChangeAllViews();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void ContestDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Contest current = getCurrentContest();
                QuestionsInContestDataGridView.DataSource = accesToDataBase.getQuestionsByContest(current);

                //QuestionsInContestDataGridView.Columns["ID"].Visible = false;
                QuestionsInContestDataGridView.Columns["ID"].Visible = false;
                QuestionsInContestDataGridView.Columns["Type"].Visible = false;
                QuestionsInContestDataGridView.Columns["Author"].Visible = false;
                QuestionsInContestDataGridView.Columns["Comment"].Visible = false;
                QuestionsInContestDataGridView.Columns["Year"].Visible = false;
                QuestionsInContestDataGridView.Columns["Difficulty"].Visible = false;
                
                QuestionsInContestDataGridView.ReadOnly = true;
                QuestionsInContestDataGridView.MultiSelect = false;
                reasizeDataGridView(QuestionsInContestDataGridView);

                TeamsInContestDataGridView.DataSource = accesToDataBase.getTeamsByContest(current);

                TeamsInContestDataGridView.Columns["ID"].Visible = false;

                TeamsInContestDataGridView.ReadOnly = true;
                TeamsInContestDataGridView.MultiSelect = false;
                reasizeDataGridView(TeamsInContestDataGridView);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuestionPage_Click(object sender, EventArgs e)
        {

        }

        private void TypeQuestionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NameQuestionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AnswearQuestionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void YearQuestionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DifficultyQuestionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CommentQuestionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NameTypeQuestionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SearchTypeButton_Click(sender, e);
            }
        }

        private void NameQuestionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SearchQuestionButton_Click(sender, e);
            }
        }

        private void NameContestTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SearchContestButton_Click(sender, e);
            }
        }

        private void NameAuthorTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AuthorSearchButton_Click(sender, e);
            }
        }

        private void NamePlayerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                PlayerSearchButton_Click(sender, e);
            }
        }

        private void NameTeamTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                TeamSearchButton_Click(sender, e);
            }
        }

        private void знайтиКомандиЯкіГралиТількиВТихТурнірахОІДанаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new About1();
            f.ShowDialog();
        }







        
        
    }
}
