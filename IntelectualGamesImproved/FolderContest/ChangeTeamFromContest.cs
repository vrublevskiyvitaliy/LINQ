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
    public partial class ChangeTeamFromContest : Form
    {
        private Contest currentContest;
        private AccesToDataBase.AccesToDataBase accesToDataBase;
        public ChangeTeamFromContest(AccesToDataBase.AccesToDataBase acces, Contest contest)
        {
            InitializeComponent();
            accesToDataBase = acces;
            currentContest = contest;

            UpdateAllData();
        }

        public void UpdateAllData()
        {
            List<Team> AddList = new List<Team>();

            List<Team> AllTeams = accesToDataBase.getAllTeams();

            foreach (var c in AllTeams)
            {
                if (!accesToDataBase.isTeamInContest(currentContest, c))
                    AddList.Add(c);

            }

            AddDataGridView.DataSource = AddList;
            AddDataGridView.Columns["ID"].Visible = false;
            AddDataGridView.ReadOnly = true;
            AddDataGridView.MultiSelect = false;


            List<Team> DeleteList = new List<Team>();

            foreach (var c in AllTeams)
            {
                if (accesToDataBase.isTeamInContest(currentContest, c))
                    DeleteList.Add(c);

            }

            DeleteDataGridView.DataSource = DeleteList;
            DeleteDataGridView.Columns["ID"].Visible = false;
            DeleteDataGridView.ReadOnly = true;
            DeleteDataGridView.MultiSelect = false;
            
            
            
            //Team list
            List<Team> List = new List<Team>();

            List = accesToDataBase.getTeamsByContest(currentContest);

            TeamDataGridView.DataSource = List;
            TeamDataGridView.ReadOnly = true;
            TeamDataGridView.MultiSelect = false;
            reasizeDataGridView(TeamDataGridView);

        
        }


        private void reasizeDataGridView(DataGridView e)
        {
            for (int i = 0; i < e.ColumnCount; i++)
                e.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddDataGridView.Rows.Count == 0) return ;

            int id = Int32.Parse(AddDataGridView.CurrentRow.Cells[0].Value.ToString().Trim());

            Team team = accesToDataBase.getTeamByID(id);

            accesToDataBase.addTeamToContest(currentContest, team);

            UpdateAllData();


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (DeleteDataGridView.Rows.Count == 0) return;

            int id = Int32.Parse(DeleteDataGridView.CurrentRow.Cells[0].Value.ToString().Trim());

            Team team = accesToDataBase.getTeamByID(id);

            accesToDataBase.deleteTeamFromContest(currentContest, team);

            UpdateAllData();

        }




    }
}
