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
    public partial class TeamUpdateForm : Form
    {
        WACDbContext db;
        Team selectedTeam;
        ImageList imgList = new ImageList();
        public TeamUpdateForm(WACDbContext db, Team selectedTeam)
        {
            InitializeComponent();
            this.db = db;
            this.selectedTeam = selectedTeam;
            txtTeamName.Text = selectedTeam.TeamName;
            lstTeamColors.DataSource = selectedTeam.Colors.ToList();
            imgList.ImageSize = new Size(16, 16);
            lviColors.LargeImageList = imgList;
            lviColors.Items.Clear();
            foreach (var item in db.Colors)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Name = item.ColorName;
                lvi.Text = $"{item.ColorName}";
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
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lviColors.SelectedItems)
            {
                Models.Color color = db.Colors.Where(x => x.Id == (int)item.Tag).FirstOrDefault();
                selectedTeam.Colors.Add(color);
            }
            lstTeamColors.DataSource = selectedTeam.Colors.ToList();
            db.SaveChanges();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            selectedTeam.TeamName = txtTeamName.Text.Trim();
            db.SaveChanges();
            this.Close();
        }

        private void btnRemoveColor_Click(object sender, EventArgs e)
        {
            Models.Color selectedColor = (Models.Color)lstTeamColors.SelectedItem;
            selectedTeam.Colors.Remove(selectedColor);
            db.SaveChanges();
            lstTeamColors.DataSource = selectedTeam.Colors.ToList();
        }
    }
}
