using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingDB
{
    public partial class NeuerArtist : Form
    {
        private string artistName;
        private string artistInfo;
        private string imagePath;

        Datenbank db = new Datenbank();

        public NeuerArtist()
        {
            InitializeComponent();
        }
        #region Drag and Drop
        private void NeuerArtist_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                if (files != null && files.Length > 0)
                {
                    string sourceFilePath = files[0];
                    string fileName = Path.GetFileNameWithoutExtension(sourceFilePath); // Nur den Dateinamen ohne Extension holen
                    string destinationPath = Path.Combine(Application.StartupPath, "Images", fileName + ".png");
                    string imagePath = destinationPath;

                    File.Copy(sourceFilePath, destinationPath, overwrite: true);
                    labelArtistNeuDragDropLabel.Visible = false;
                    pictureBoxArtistNeu.BorderStyle = BorderStyle.None;
                    pictureBoxArtistNeu.Image = Image.FromFile(destinationPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Test Test " + ex.Message);
            }
        }

        private void NeuerArtist_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        #endregion

        private void buttonArtistNeuSpeichern_Click(object sender, EventArgs e)
        {
            artistName = textBoxNeuerArtist.Text;
            artistInfo = textBoxArtistNeuInfo.Text;
            imagePath = textBoxNeuerArtist.Text + ".png";
            try
            {
                Artist artist = new Artist(
                    artistName,
                    artistInfo,
                    imagePath
                );

                db.newArtist(artist);

                MessageBox.Show(artistName + " wurde erfolgreich gespeichert");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(artistName + "Konnte nicht gespeicher werden: " + ex.Message);
            }




        }

        private void buttonArtistNeuAbbrechen_Click(object sender, EventArgs e)
        {
            textBoxNeuerArtist.Text = "";
            textBoxArtistNeuInfo.Text = "";
            imagePath = "";

            this.Close();
        }
    }
}
