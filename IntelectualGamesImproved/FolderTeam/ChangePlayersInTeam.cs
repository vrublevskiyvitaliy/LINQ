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

namespace IntelectualGamesImproved.FolderTeam
{
    public partial class ChangePlayersInTeam : Form
    {
        private AccesToDataBase.AccesToDataBase accesToDataBase;
        private Team currentTeam;
         
        public ChangePlayersInTeam(AccesToDataBase.AccesToDataBase acces, Team team)
        {
            InitializeComponent();
            accesToDataBase = acces;
            currentTeam = team;

            UpdateAllData();

        }

        private void reasizeDataGridView(DataGridView e)
        {
            for (int i = 0; i < e.ColumnCount; i++)
                e.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void UpdateAllData()
        {
            List<Player> list = new List<Player>();

            list = accesToDataBase.getAllPlayers();

            List<Player> add = new List<Player>();
            List<Player> delete = new List<Player>();


            foreach (var c in list)
            {
                if (accesToDataBase.isPlayerInTeam(currentTeam, c))
                {
                    delete.Add(c);
                }
                else
                {
                    add.Add(c);
                }
            
            }

            AddDataGridView.DataSource = add;
            AddDataGridView.Columns["ID"].Visible = false;
            AddDataGridView.ReadOnly = true;
            AddDataGridView.MultiSelect = false;


            DeleteDataGridView.DataSource = delete;
            DeleteDataGridView.Columns["ID"].Visible = false;
            DeleteDataGridView.ReadOnly = true;
            DeleteDataGridView.MultiSelect = false;

            PlayersDataGridView.DataSource = delete;
            PlayersDataGridView.ReadOnly = true;
            PlayersDataGridView.MultiSelect = false;
            reasizeDataGridView(PlayersDataGridView);
                     
        
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddDataGridView.Rows.Count == 0) return;

            string name = AddDataGridView.CurrentRow.Cells[1].Value.ToString().Trim();
            int year = Int32.Parse(AddDataGridView.CurrentRow.Cells[2].Value.ToString().Trim());

            Player player = new Player(accesToDataBase.getIDOfPlayer(name, year), name, year);

            accesToDataBase.addPlayerInTeam(currentTeam, player);
            UpdateAllData();


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteDataGridView.Rows.Count == 0) return;
            
            string name = DeleteDataGridView.CurrentRow.Cells[1].Value.ToString().Trim();
            int year = Int32.Parse(DeleteDataGridView.CurrentRow.Cells[2].Value.ToString().Trim());

            Player player = new Player(accesToDataBase.getIDOfPlayer(name, year), name, year);

            accesToDataBase.deletePlayerFromTeam(currentTeam, player);
            UpdateAllData();
        }



    }
}
