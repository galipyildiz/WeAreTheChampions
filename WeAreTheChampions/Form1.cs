using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class Form1 : Form
    {
        WACDbContext db = new WACDbContext();
        ImageList imgList = new ImageList();
        ImageList imgList2 = new ImageList();
        ImageList imgList3 = new ImageList();
        public Form1()
        {
            InitializeComponent();
            imgList.ImageSize = new Size(64, 64);
            lviColors.LargeImageList = imgList;
            imgList2.ImageSize = new Size(16, 16);
            lviWillAddTeamColors.LargeImageList = imgList2;
            imgList3.ImageSize = new Size(64, 64);
            lviTeamColors.LargeImageList = imgList3;
            LoadColors();
            LoadTeams();
            LoadPlayers();
            LoadMatches();
        }

        private void LoadTeams()
        {
            lstTeams.DataSource = db.Teams.ToList();
            lstTeams.DisplayMember = "TeamName";
            cboWillAddTeams.Items.Clear();
            cboTeams.Items.Clear();
            cboWillAddTeams.Items.Add("Boşta");
            cboTeams.Items.Add("Hepsi");
            foreach (var item in db.Teams)
            {
                cboWillAddTeams.Items.Add(item);
                cboTeams.Items.Add(item);
            }
            cboWillAddTeams.SelectedIndex = 0;
            cboTeams.SelectedIndex = 0;
        }

        private void LoadPlayers()
        {
            if (cboTeams.SelectedIndex == 0)
            {
                lstPlayers.DataSource = db.Players.ToList();
                lstPlayers.DisplayMember = "PlayerName";
            }
            else
            {
                Team selectedTeam = (Team)cboTeams.SelectedItem;
                lstPlayers.DataSource = selectedTeam.Players.ToList();
            }
        }

        private void LoadColors()
        {
            lviColors.Items.Clear();
            foreach (var item in db.Colors)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Name = item.ColorName;
                lvi.Text = $"ColorName:{item.ColorName}\t\nRed:{item.Red}, Green:{item.Green}, Blue:{item.Blue}";
                lvi.Tag = item.Id;

                Bitmap newbmp = new Bitmap(62, 62);

                for (int x = 0; x < newbmp.Height; x++)
                {
                    for (int y = 0; y < newbmp.Width; y++)
                    {
                        newbmp.SetPixel(x, y, System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue));
                    }
                }
                imgList.Images.Add($"{item.ColorName}", newbmp);
                lvi.ImageKey = item.ColorName;
                lviColors.Items.Add(lvi);
            }
            lviWillAddTeamColors.Items.Clear();
            foreach (var item in db.Colors)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Name = item.ColorName;
                lvi.Text = $"{item.ColorName}";
                lvi.Tag = item.Id;
                Bitmap newbmp = new Bitmap(16, 16);
                for (int i = 0; i < newbmp.Height; i++)
                {
                    for (int j = 0; j < newbmp.Width; j++)
                    {
                        newbmp.SetPixel(i, j, System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue));
                    }
                }
                imgList2.Images.Add($"{item.ColorName}", newbmp);
                lvi.ImageKey = item.ColorName;
                lviWillAddTeamColors.Items.Add(lvi);
            }
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {

            DialogResult dr = cdColor.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string promptValue = Prompt.ShowDialog("Renk adı giriniz:", "Renk-Adı");
                if (promptValue == "")
                {
                    promptValue = cdColor.Color.Name;
                }
                Models.Color color = new Models.Color()
                {
                    Red = cdColor.Color.R,
                    Blue = cdColor.Color.B,
                    Green = cdColor.Color.G,
                    ColorName = promptValue
                };
                db.Colors.Add(color);
                db.SaveChanges();
                LoadColors();
            }
        }

        private void btnDeleteColor_Click(object sender, EventArgs e)
        {
            if (lviColors.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Lütfen Renk Seçiniz.");
                return;
            }
            else if (lviColors.SelectedItems.Count > 1)
            {
                MessageBox.Show("Lütfen 1 adet renk seçiniz.");
                return;
            }
            ListViewItem lviItem = lviColors.SelectedItems[0];
            int colorId = (int)lviItem.Tag;
            Models.Color willDeleted = db.Colors.Where(x => x.Id == colorId).FirstOrDefault();
            imgList.Images.RemoveByKey(willDeleted.ColorName);
            db.Colors.Remove(willDeleted);
            db.SaveChanges();

            LoadColors();
        }

        private void lviColors_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem lviItem = lviColors.SelectedItems[0];
            ColorUpdateForm cuf = new ColorUpdateForm(lviItem, db);
            cuf.ShowDialog();
            LoadColors();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player()
            {
                PlayerName = txtWillAddPlayerName.Text.Trim(),
                PhotoPath = txtWillAddPlayerPhotoPath.Text.Trim()
            };
            if (txtWillAddPlayerPhotoPath.Text != "")
            {
                MemoryStream stream = new MemoryStream();
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(txtWillAddPlayerPhotoPath.Text.Trim());
                myRequest.Method = "GET";
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                Bitmap bmp = new Bitmap(myResponse.GetResponseStream());
                bmp.Save(stream, ImageFormat.Jpeg);
                newPlayer.Photo = stream.GetBuffer();
            }
            else
            {
                newPlayer.Photo = (byte[])new ImageConverter().ConvertTo(WeAreTheChampions.Properties.Resources.anonim, typeof(byte[]));
            }
            if (cboWillAddTeams.SelectedIndex != 0)
            {
                newPlayer.Team = (Team)cboWillAddTeams.SelectedItem;
            }


            db.Players.Add(newPlayer);
            db.SaveChanges();
            pboWillAddPlayerPhoto.Image = WeAreTheChampions.Properties.Resources.anonim;
            txtWillAddPlayerName.Clear();
            txtWillAddPlayerPhotoPath.Clear();
            LoadPlayers();
            Team selectedTeam = (Team)lstTeams.SelectedItem;
            lstTeamPlayers.DataSource = selectedTeam.Players.ToList();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(txtWillAddPlayerPhotoPath.Text.Trim());
                myRequest.Method = "GET";
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                Bitmap bmp = new Bitmap(myResponse.GetResponseStream());
                bmp.Save(stream, ImageFormat.Jpeg);
                pboWillAddPlayerPhoto.Image = (Bitmap)new ImageConverter().ConvertFrom(stream.GetBuffer());
            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz link geçersizdir.");
            }

        }

        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex > -1)
            {
                Player selectedPlayer = (Player)lstPlayers.SelectedItem;
                pboSelectedPlayerPhoto.Image = (Bitmap)new ImageConverter().ConvertFrom(selectedPlayer.Photo);
                txtSelectedPlayerName.Text = selectedPlayer.PlayerName;
                txtSelectedPlayerTeam.Text = selectedPlayer.TeamId == null ? "Boşta" : selectedPlayer.Team.TeamName;
            }
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Oyuncu silinecek emin misiniz?", "Oyuncu Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (dr == DialogResult.Yes)
            {
                Player willDeletedPlayer = (Player)lstPlayers.SelectedItem;
                db.Players.Remove(willDeletedPlayer);
                db.SaveChanges();
                LoadPlayers();
                Team selectedTeam = (Team)lstTeams.SelectedItem;
                lstTeamPlayers.DataSource = selectedTeam.Players.ToList();
            }

        }

        private void lstPlayers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstPlayers.SelectedIndex > -1)
            {
                Player selectedPlayer = (Player)lstPlayers.SelectedItem;
                PlayerUpdateForm puf = new PlayerUpdateForm(db, selectedPlayer);
                puf.ShowDialog();
                LoadPlayers();
            }
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            Team newTeam = new Team()
            {
                TeamName = txtTeamName.Text.Trim()
            };
            foreach (ListViewItem item in lviWillAddTeamColors.SelectedItems)
            {
                Models.Color color = db.Colors.Where(x => x.Id == (int)item.Tag).FirstOrDefault();
                newTeam.Colors.Add(color);
            }
            db.Teams.Add(newTeam);
            db.SaveChanges();
            LoadTeams();
            txtTeamName.Clear();
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            pboTeamPlayerPhoto.Image = WeAreTheChampions.Properties.Resources.anonim;
            imgList3.Images.Clear();
            lviTeamColors.Items.Clear();
            Team selectedTeam = (Team)lstTeams.SelectedItem;
            Bitmap newbmp = new Bitmap(62, 62);

            foreach (var item in selectedTeam.Colors)
            {
                for (int x = 0; x < newbmp.Height; x++)
                {
                    for (int y = 0; y < newbmp.Width; y++)
                    {
                        newbmp.SetPixel(x, y, System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue));
                    }
                }
                imgList3.Images.Add($"{item.ColorName}", newbmp);

                ListViewItem lvi = new ListViewItem();
                lvi.Name = item.ColorName;
                lvi.Text = $"{item.ColorName}";
                lvi.ImageKey = item.ColorName;
                lvi.Tag = item.Id;
                lviTeamColors.Items.Add(lvi);
            }
            lstTeamPlayers.DataSource = selectedTeam.Players.ToList();
            dgvHomeMatches.DataSource = selectedTeam.HomeMatches.ToList();
            dgvAwayMatches.DataSource = selectedTeam.AwayMatches.ToList();
        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Takım silinecek emin misiniz?", "Takım Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (dr == DialogResult.Yes)
            {
                Team willDeletedTeam = (Team)lstTeams.SelectedItem;
                db.Teams.Remove(willDeletedTeam);
                db.SaveChanges();
                LoadTeams();
            }

        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            pboSelectedPlayerPhoto.Image = WeAreTheChampions.Properties.Resources.anonim;
            LoadPlayers();
        }

        private void lstTeamPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player selectedPlayer = (Player)lstTeamPlayers.SelectedItem;
            pboTeamPlayerPhoto.Image = WeAreTheChampions.Properties.Resources.anonim;
            pboTeamPlayerPhoto.Image = (Bitmap)new ImageConverter().ConvertFrom(selectedPlayer.Photo);
        }

        private void btnPlayerTransfer_Click(object sender, EventArgs e)
        {
            gbTransfer.Visible = true;
            cboPlayerTransferTeam.DataSource = db.Teams.ToList();

        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            Player selectedPlayer = (Player)lstTeamPlayers.SelectedItem;
            Team selectedTeam = (Team)lstTeams.SelectedItem;
            selectedTeam.Players.Remove(selectedPlayer);
            db.SaveChanges();
            lstTeamPlayers.DataSource = selectedTeam.Players.ToList();
        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            if (lstTeams.Items.Count > 0)
            {
                Team selectedTeam = (Team)lstTeams.SelectedItem;
                TeamUpdateForm tuf = new TeamUpdateForm(db, selectedTeam);
                tuf.ShowDialog();
                LoadTeams();
            }
        }

        private void btnPlayerTransferSave_Click(object sender, EventArgs e)
        {
            Team transferTeam = (Team)cboPlayerTransferTeam.SelectedItem;
            Player transferPlayer = (Player)lstPlayers.SelectedItem;
            transferTeam.Players.Add(transferPlayer);
            db.SaveChanges();
            gbTransfer.Visible = false;
            txtSelectedPlayerTeam.Text = transferPlayer.Team.TeamName;
            txtSelectedPlayerName.Text = transferPlayer.PlayerName;
            Team selectedTeam = (Team)lstTeams.SelectedItem;
            lstTeamPlayers.DataSource = selectedTeam.Players.ToList();
        }

        private void btnCancelTransfer_Click(object sender, EventArgs e)
        {
            gbTransfer.Visible = false;
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            NewMatchForm nmf = new NewMatchForm(db);
            nmf.ShowDialog();
            LoadMatches();
            Team selectedTeam = (Team)lstTeams.SelectedItem;
            dgvHomeMatches.DataSource = selectedTeam.HomeMatches.ToList();
            dgvAwayMatches.DataSource = selectedTeam.AwayMatches.ToList();
        }

        private void LoadMatches()
        {
            List<Match> matches = new List<Match>();
            foreach (var item in db.Matches)
            {
                matches.Add(item);
            }
            matches.Sort();
            dgvMatches.DataSource = matches;
            //dgvMatches.Sort(dgvMatches.Columns[2], ListSortDirection.Ascending);
        }

        private void chkHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHide.Checked == true)
            {
                LoadNotPlayedMatches();
            }
            else
            {
                LoadMatches();
            }
        }

        private void LoadNotPlayedMatches()
        {
            List<Match> NotPlayedMatches = new List<Match>();
            foreach (var item in db.Matches)
            {
                if (item.MatchTime > DateTime.Now)
                {
                    NotPlayedMatches.Add(item);
                }
            }
            dgvMatches.DataSource = NotPlayedMatches;
        }

        private void dgvMatches_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMatches.SelectedRows[0];
                lblTeam1Name.Text = row.Cells[6].Value.ToString();
                lblTeam2Name.Text = row.Cells[8].Value.ToString();
                string sonuc = row.Cells[4].Value == null ? "Oynanmamış" : row.Cells[4].Value.ToString();
                lblResult.Text = "Sonuç: " + sonuc;
                lblTeam1Score.Text = row.Cells[2].Value.ToString();
                lblTeam2Score.Text = row.Cells[3].Value.ToString();
                Match match = (Match)dgvMatches.SelectedRows[0].DataBoundItem;
                if (match.Result == Result.Team1Win)
                {
                    Bitmap bmp = new Bitmap(gbResult.Width, gbResult.Height);
                    List<Models.Color> colors = match.Team1.Colors.ToList();
                    int parca = gbResult.Width / colors.Count;
                    int baslangic = 0;
                    foreach (var item in colors)
                    {
                        for (int i = baslangic; i < parca; i++)
                        {
                            for (int j = 0; j < bmp.Height; j++)
                            {
                                bmp.SetPixel(i, j, System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue));
                            }
                        }
                        if (parca >= bmp.Width)
                        {
                            baslangic = bmp.Width - (gbResult.Width / colors.Count);
                            parca = bmp.Width;
                        }
                        else
                        {
                            baslangic = parca;
                            parca += gbResult.Width / colors.Count;
                        }
                    }
                    gbResult.BackgroundImage = bmp;
                }
                else if (match.Result == Result.Team2Win)
                {
                    Bitmap bmp = new Bitmap(gbResult.Width, gbResult.Height);
                    List<Models.Color> colors = match.Team2.Colors.ToList();
                    int parca = gbResult.Width / colors.Count;
                    int baslangic = 0;
                    foreach (var item in colors)
                    {
                        for (int i = baslangic; i < parca; i++)
                        {
                            for (int j = 0; j < bmp.Height; j++)
                            {
                                bmp.SetPixel(i, j, System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue));
                            }
                        }
                        if (parca >= bmp.Width)
                        {
                            baslangic = bmp.Width - (gbResult.Width / colors.Count);
                            parca = bmp.Width;
                        }
                        else
                        {
                            baslangic = parca;
                            parca += gbResult.Width / colors.Count;
                        }
                    }
                    gbResult.BackgroundImage = bmp;
                }
                else if (match.Result == Result.Draw)
                {
                    Bitmap bmp = new Bitmap(gbResult.Width, gbResult.Height);
                    List<Models.Color> colors = match.Team1.Colors.ToList();
                    foreach (var item in match.Team2.Colors)
                    {
                        colors.Add(item);
                    }
                    int parca = gbResult.Width / colors.Count;
                    int baslangic = 0;
                    foreach (var item in colors)
                    {
                        for (int i = baslangic; i < parca; i++)
                        {
                            for (int j = 0; j < bmp.Height; j++)
                            {
                                bmp.SetPixel(i, j, System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue));
                            }
                        }
                        if (parca >= bmp.Width)
                        {
                            baslangic = bmp.Width - (gbResult.Width/colors.Count);
                            parca = bmp.Width;
                        }
                        else
                        {
                            baslangic = parca;
                            parca += gbResult.Width / colors.Count;
                        }
                    }
                    gbResult.BackgroundImage = bmp;
                }
                else
                {
                    gbResult.BackgroundImage = null;
                }
            }

        }

        private void dgvMatches_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvMatches.SelectedRows.Count > 0)
            {
                UpdateMatch(dgvMatches.SelectedRows[0]);
            }
        }
        private void UpdateMatch(DataGridViewRow row)
        {
            Match match = (Match)row.DataBoundItem;
            MatchUpdateForm muf = new MatchUpdateForm(db, match);
            muf.ShowDialog();
            if (chkHide.Checked == true)
            {
                LoadNotPlayedMatches();
            }
            else
            {
                LoadMatches();
            }
        }

        private void btnUpdateMatch_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count > 0)
            {
                UpdateMatch(dgvMatches.SelectedRows[0]);
            }
        }

        private void btnDeleteMatch_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count > 0)
            {
                Match match = (Match)dgvMatches.SelectedRows[0].DataBoundItem;
                db.Matches.Remove(match);
                db.SaveChanges();
                if (chkHide.Checked == true)
                {
                    LoadNotPlayedMatches();
                }
                else
                {
                    LoadMatches();
                }
            }
        }
    }
}
