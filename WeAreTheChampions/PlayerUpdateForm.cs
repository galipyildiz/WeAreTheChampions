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
    public partial class PlayerUpdateForm : Form
    {
        WACDbContext db;
        Player player;
        public PlayerUpdateForm(WACDbContext db,Player player)
        {
            InitializeComponent();
            this.db = db;
            this.player = player;
            txtPlayerName.Text = player.PlayerName;
            txtPlayerPhotoPath.Text = player.PhotoPath;
            pboPlayerPhoto.Image = (Bitmap)new ImageConverter().ConvertFrom(player.Photo);
            LoadTeams();
            cboTeams.SelectedItem = player.Team;
        }

        private void LoadTeams()
        {
            cboTeams.DataSource = db.Teams.ToList();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPlayerPhotoPath.Text != "")
                {
                    MemoryStream stream = new MemoryStream();
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(txtPlayerPhotoPath.Text.Trim());
                    myRequest.Method = "GET";
                    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                    Bitmap bmp = new Bitmap(myResponse.GetResponseStream());
                    bmp.Save(stream, ImageFormat.Jpeg);
                    pboPlayerPhoto.Image = (Bitmap)new ImageConverter().ConvertFrom(stream.GetBuffer());
                }
                else
                {
                    pboPlayerPhoto.Image = WeAreTheChampions.Properties.Resources.anonim;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz Link Geçersizdir!");
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            player.PlayerName = txtPlayerName.Text.Trim();
            player.PhotoPath = txtPlayerPhotoPath.Text.Trim();
            player.Team = (Team)cboTeams.SelectedItem;
            if (txtPlayerPhotoPath.Text != "")
            {
                MemoryStream stream = new MemoryStream();
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(txtPlayerPhotoPath.Text.Trim());
                myRequest.Method = "GET";
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                Bitmap bmp = new Bitmap(myResponse.GetResponseStream());
                bmp.Save(stream, ImageFormat.Jpeg);
                player.Photo = stream.GetBuffer();
            }
            else
            {
                player.Photo = (byte[])new ImageConverter().ConvertTo(WeAreTheChampions.Properties.Resources.anonim, typeof(byte[]));
            }
            db.SaveChanges();
            this.Close();
        }
    }
}
