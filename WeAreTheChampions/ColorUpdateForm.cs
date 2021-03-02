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
    public partial class ColorUpdateForm : Form
    {
        ListViewItem listViewItem;
        WACDbContext db;
        public ColorUpdateForm(ListViewItem lviItem, WACDbContext db)
        {
            InitializeComponent();
            this.listViewItem = lviItem;
            this.db = db;
            int colorId = (int)lviItem.Tag;
            Models.Color selectedColor = db.Colors.Where(x => x.Id == colorId).FirstOrDefault();
            txtColorName.Text = selectedColor.ColorName;
            nudRed.Value = selectedColor.Red;
            nudGreen.Value = selectedColor.Green;
            nudBlue.Value = selectedColor.Blue;

            //Color Convert İmage https://dyclassroom.com/csharp-project/how-to-convert-a-color-image-into-red-green-blue-image-in-csharp-using-visual-studio
            Bitmap newbmp = new Bitmap(62, 62);
            for (int x = 0; x < newbmp.Height; x++)
            {
                for (int y = 0; y < newbmp.Width; y++)
                {
                    newbmp.SetPixel(x, y, System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue));
                }
            }
            pboColor.Image = newbmp;
        }

        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
            Bitmap newbmp = new Bitmap(62, 62);
            for (int x = 0; x < newbmp.Height; x++)
            {
                for (int y = 0; y < newbmp.Width; y++)
                {
                    newbmp.SetPixel(x, y, System.Drawing.Color.FromArgb((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value));
                }
            }
            pboColor.Image = newbmp;
        }

        private void nudGreen_ValueChanged(object sender, EventArgs e)
        {
            Bitmap newbmp = new Bitmap(62, 62);
            for (int x = 0; x < newbmp.Height; x++)
            {
                for (int y = 0; y < newbmp.Width; y++)
                {
                    newbmp.SetPixel(x, y, System.Drawing.Color.FromArgb((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value));
                }
            }
            pboColor.Image = newbmp;
        }

        private void nudBlue_ValueChanged(object sender, EventArgs e)
        {
            Bitmap newbmp = new Bitmap(62, 62);
            for (int x = 0; x < newbmp.Height; x++)
            {
                for (int y = 0; y < newbmp.Width; y++)
                {
                    newbmp.SetPixel(x, y, System.Drawing.Color.FromArgb((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value));
                }
            }
            pboColor.Image = newbmp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int colorId = (int)listViewItem.Tag;
            Models.Color selectedColor = db.Colors.Where(x => x.Id == colorId).FirstOrDefault();
            selectedColor.Red = (int)nudRed.Value;
            selectedColor.Green = (int)nudGreen.Value;
            selectedColor.Blue = (int)nudBlue.Value;
            selectedColor.ColorName = txtColorName.Text.Trim();
            db.SaveChanges();
            this.Close();
        }
    }
}
