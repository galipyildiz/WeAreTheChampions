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
    public partial class MatchUpdateForm : Form
    {
        WACDbContext db;
        Match match;
        public MatchUpdateForm(WACDbContext db, Match match)
        {
            InitializeComponent();
            this.db = db;
            this.match = match;
            LoadResults();
            txtTeam1.Text = match.Team1.TeamName;
            txtTeam2.Text = match.Team2.TeamName;
            dtpMatchTime.Value = match.MatchTime;
            nudTeam1Score.Value = match.Score1;
            nudTeam2Score.Value = match.Score2;
            switch (match.Result)
            {
                case (null):
                    cboResult.SelectedIndex = -1;
                    break;
                case (Result.Draw):
                    cboResult.SelectedIndex = 0;
                    break;
                case (Result.Team1Win):
                    cboResult.SelectedIndex = 1;
                    break;
                case (Result.Team2Win):
                    cboResult.SelectedIndex = 2;
                    break;
                default:
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            match.Result = (Result)cboResult.SelectedItem;
            match.Score1 = (int)nudTeam1Score.Value;
            match.Score2 = (int)nudTeam2Score.Value;
            match.MatchTime = dtpMatchTime.Value;
            db.SaveChanges();
            this.Close();
        }
        private void LoadResults()
        {
            cboResult.Items.Add(Result.Draw);
            cboResult.Items.Add(Result.Team1Win);
            cboResult.Items.Add(Result.Team2Win);
        }
    }
}
