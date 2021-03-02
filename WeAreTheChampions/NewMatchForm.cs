using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class NewMatchForm : Form
    {
        WACDbContext db;
        Team team1;
        Team team2;
        public NewMatchForm(WACDbContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadTeams();
            LoadResults();
            cboTeam1.SelectedIndex = -1;
            cboTeam2.SelectedIndex = -1;
            cboResult.SelectedIndex = -1;
        }

        private void LoadResults()
        {
            cboResult.Items.Add(Result.Draw);
            cboResult.Items.Add(Result.Team1Win);
            cboResult.Items.Add(Result.Team2Win);
        }

        private void LoadTeams()
        {
            foreach (Team item in db.Teams)
            {
                cboTeam1.Items.Add(item);
                cboTeam2.Items.Add(item);
            }
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            Match match = new Match();
            match.MatchTime = dtpMatchTime.Value;
            
            match.Team1Id = team1.Id;
            match.Team1 = team1;
            match.Team2Id = team2.Id;
            match.Team2 = team2;
            match.Score1 = (int)nudTeam1Score.Value;
            match.Score2 = (int)nudTeam2Score.Value;
            if (cboResult.SelectedIndex != -1)
            {
                match.Result = (Result)cboResult.SelectedItem;
            }
            db.Matches.Add(match);
            db.SaveChanges();
            this.Close();
        }

        private void cboTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTeamstoTeam2();
            team1 = (Team)cboTeam1.SelectedItem;
            cboTeam2.Items.Remove(team1);
        }

        private void LoadTeamstoTeam1()
        {
            cboTeam1.Items.Clear();
            foreach (Team item in db.Teams)
            {
                cboTeam1.Items.Add(item);
            }
        }

        private void cboTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTeam1.Items.Clear();
            LoadTeamstoTeam1();
            team2 = (Team)cboTeam2.SelectedItem;
            cboTeam1.Items.Remove(team2);
        }

        private void LoadTeamstoTeam2()
        {
            cboTeam2.Items.Clear();
            foreach (Team item in db.Teams)
            {
                cboTeam2.Items.Add(item);
            }
        }
    }
}
