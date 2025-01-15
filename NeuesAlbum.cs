using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingDB
{

    public partial class NeuesAlbum : Form
    {
        private List<Artist> artists = new List<Artist>();
        private List<Album> alben = new List<Album>();
        private List<Genre> genres = new List<Genre>();
        private List<Label> labels = new List<Label>();

        Datenbank db = new Datenbank();

        public NeuesAlbum()
        {
            InitializeComponent();
            onLoad();
            hideTabsOnLoad();
        }

        private void onLoad()
        {
            artists = db.getArtists();
            alben = db.getAlben();
            genres = db.getGenre();
            labels = db.getLabels();

            foreach (Artist artist in artists)
            {
                comboBoxAlbumArtistNeu.Items.Add(artist.ArtistName);
            }

            foreach (Genre genre in genres)
            {
                comboBoxAlbumGenreNeu.Items.Add(genre.GenreName);
            }

            foreach (Label label in labels)
            {
                comboBoxAlbumLabelNeu.Items.Add(label.LabelName);
            }
        }

        private void NeuesAlbum_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void NeuesAlbum_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void tabPageNeuesAlbum_DragDrop(object sender, DragEventArgs e)
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
                    pictureBoxAlbumNeu.Image = Image.FromFile(destinationPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Test Test " + ex.Message);
            }
        }

        private void tabPageNeuesAlbum_DragEnter(object sender, DragEventArgs e)
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

        private void buttonAlbumAbbrechenNeu_Click(object sender, EventArgs e)
        {
            textBoxAlbumAlbumNeu.Text = "";
            numericUpDownAlbumErschJahrNeu.Value = 0;
            comboBoxAlbumArtistNeu.Text = "";
            comboBoxAlbumGenreNeu.Text = "";
            comboBoxAlbumLabelNeu.Text = "";


            this.Close();
        }

        private void buttonAlbumNeuNaechsteSeite_Click(object sender, EventArgs e)
        {

            int artistID = artists.Find(x => x.ArtistName == comboBoxAlbumArtistNeu.Text).ArtistID;
            int labelID = labels.Find(x => x.LabelName == comboBoxAlbumLabelNeu.Text).LabelID;

            MessageBox.Show(artistID.ToString() + " " + labelID.ToString());

            //Album album = new Album(
            //    textBoxAlbumAlbumNeu.Text,
            //    numericUpDownAlbumErschJahrNeu.Value,
            //    comboBoxAlbumArtistNeu.Text,
            //    comboBoxAlbumGenreNeu.Text,
            //    comboBoxAlbumLabelNeu.text
            //    );
            
            //tabControlAlbumNeu.TabPages.Add(tabPageSongs);
            //tabControlAlbumNeu.SelectedTab = tabPageSongs;
            
            
        }

        private void hideTabsOnLoad()
        {
            tabControlAlbumNeu.TabPages.Remove(tabPageSongs);
        }
    }
}
