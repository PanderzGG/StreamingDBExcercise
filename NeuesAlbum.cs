using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingDB
{

    public partial class NeuesAlbum : Form
    {
        public event Action<string> onAborted;
        
        
        private List<Artist> artists = new List<Artist>();
        private List<Album> alben = new List<Album>();
        private List<Genre> genres = new List<Genre>();
        private List<Label> labels = new List<Label>();
        private List<Song> songs = new List<Song>();
        private List<SongData> songDatas = new List<SongData>();
        private List<Featuring> featurings = new List<Featuring>();


        private Datenbank db = new Datenbank();

        private bool isSaved = false;

        private string imagePath = "";
        private string picDelPath;


        public NeuesAlbum()
        {
            InitializeComponent();
            onLoad();
            hideTabsOnLoad();

            this.FormClosing += new FormClosingEventHandler(onClosing);
        }

        private void onLoad()
        {
            artists = db.getArtists();
            alben = db.getAlben();
            genres = db.getGenre();
            labels = db.getLabels();
            songs = db.getSongs();
            songDatas = db.getSongData();
            featurings = db.getFeaturing();

            textBoxAlbumAlbumNeu.Text = "";
            numericUpDownAlbumErschJahrNeu.Value = 0;
            comboBoxAlbumArtistNeu.Items.Clear();
            comboBoxAlbumGenreNeu.Items.Clear();
            comboBoxAlbumLabelNeu.Items.Clear();

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

        private void onClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!isSaved && pictureBoxAlbumNeu.Image != null)
                {
                    pictureBoxAlbumNeu.Image.Dispose();
                    onAborted.Invoke(picDelPath);
                }
            }
        }

        private void tabPageNeuesAlbum_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                if (files != null && files.Length > 0)
                {
                    string sourceFilePath = files[0];
                    string fileName = Path.GetFileName(sourceFilePath);
                    string destinationPath = Path.Combine(Application.StartupPath, "Images", fileName);
                    imagePath = fileName;

                    labelAlbumNeuDragDrop.Visible = false;
                    pictureBoxAlbumNeu.BorderStyle = BorderStyle.None;

                    File.Copy(sourceFilePath, destinationPath, overwrite: true);

                    if (pictureBoxAlbumNeu.Image != null)
                    {
                        DialogResult result = MessageBox.Show("Wollen Sie das aktuelle Bild ersetzen?", "Bild ersetzen", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            pictureBoxAlbumNeu.Image.Dispose();
                            pictureBoxAlbumNeu.Image = Image.FromFile(destinationPath);
                            try
                            {
                                if (File.Exists(destinationPath))
                                {
                                    File.Delete(picDelPath);
                                    picDelPath = destinationPath;
                                }
                                else
                                {
                                    MessageBox.Show("Bild wurde nicht ersetzt");
                                }
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Hier ist der Mistake");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Bild wurde nicht ersetzt");
                        }
                    }
                    else
                    {
                        pictureBoxAlbumNeu.Image = Image.FromFile(destinationPath);
                        picDelPath = destinationPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
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
            
            pictureBoxAlbumNeu.Image.Dispose();
            onAborted.Invoke(imagePath);
            
            this.Close();
        }

        private void buttonAlbumNeuNaechsteSeite_Click(object sender, EventArgs e)
        {
            if (textBoxAlbumAlbumNeu.Text != "" && !tabControlAlbumNeu.TabPages.Contains(tabPageSongs))
            {
                tabControlAlbumNeu.TabPages.Add(tabPageSongs);
                tabControlAlbumNeu.SelectedTab = tabPageSongs;
            }
            else if (textBoxAlbumAlbumNeu.Text != "")
            {
                tabControlAlbumNeu.SelectedTab = tabPageSongs;
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Albumnamen ein");
                textBoxAlbumAlbumNeu.Focus();
            }

        }

        private void hideTabsOnLoad()
        {
            tabControlAlbumNeu.TabPages.Remove(tabPageSongs);
        }

        private void buttonAlbumSpeichern_Click(object sender, EventArgs e)
        {
            int artistID = artists.Find(x => x.ArtistName == comboBoxAlbumArtistNeu.Text).ArtistID;
            int labelID = labels.Find(x => x.LabelName == comboBoxAlbumLabelNeu.Text).LabelID;
            int genreID = genres.Find(x => x.GenreName == comboBoxAlbumGenreNeu.Text).GenreID;
            int erscheinungsjahr = Convert.ToInt32(numericUpDownAlbumErschJahrNeu.Value);

            try
            {
                Album album = new Album(
                textBoxAlbumAlbumNeu.Text,
                erscheinungsjahr,
                imagePath,
                labelID,
                artistID
                );

                db.newAlbum(album);
                alben = db.getAlben();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Album konnte nicht erstellt werden: " + ex.Message);
            }

            int albumID = alben.Find(x => x.AlbumName == textBoxAlbumAlbumNeu.Text).AlbumID;

            try
            {
                int rowCount = dataGridViewTracklist.Rows.Count;
                int cellCount = dataGridViewTracklist.Rows[0].Cells.Count;

                for (int i = 0; i < rowCount; i++)
                {

                    // Leerzeilen überspringen
                    if (dataGridViewTracklist.Rows[i].IsNewRow)
                    {
                        continue;
                    }

                    if (dataGridViewTracklist.Rows[i].Cells[0].Value == null)
                    {
                        continue;
                    }

                    string songTitel = dataGridViewTracklist.Rows[i].Cells[0].Value.ToString();

                    Song song = new Song(
                        songTitel,
                        genreID,
                        albumID
                        );

                    db.newSong(song);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Album konnte nicht erstellt werden: " + ex.Message);
            }

            songs = db.getSongs();


            try
            {
                int rowCount = dataGridViewTracklist.Rows.Count;
                int cellCount = dataGridViewTracklist.Rows[0].Cells.Count;

                for (int i = 0; i < rowCount; i++)
                {
                    // Leerzeilen überspringen
                    if (dataGridViewTracklist.Rows[i].IsNewRow)
                    {
                        continue;
                    }

                    // Zeilen ohne Wert in der ersten Spalte überspringen
                    if (dataGridViewTracklist.Rows[i].Cells[0].Value == null)
                    {
                        continue;
                    }


                    int songID = songs.Find(x => x.SongTitel == dataGridViewTracklist.Rows[i].Cells[0].Value.ToString()).SongID;

                    // Zeitwert aus der zweiten Spalte formatieren und parsen
                    string rawTime = dataGridViewTracklist.Rows[i].Cells[1].Value.ToString();
                    TimeSpan dauer;
                    try
                    {
                        dauer = TimeSpan.ParseExact(rawTime,
                            new[] { "h\\:mm", "hh\\:mm", "h\\:mm\\:ss", "hh\\:mm\\:ss" },
                            CultureInfo.InvariantCulture);
                    }
                    catch (FormatException)
                    {
                        throw new FormatException($"Ungültiges Zeitformat in Zeile {i + 1}: {rawTime}");
                    }


                    int bpm = Convert.ToInt32(dataGridViewTracklist.Rows[i].Cells[2].Value);
                    string format = dataGridViewTracklist.Rows[i].Cells[3].Value.ToString();


                    SongData songData = new SongData(
                        dauer,
                        bpm,
                        format,
                        songID
                    );


                    db.newSongData(songData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Album konnte nicht erstellt werden: " + ex.Message);
            }


            try
            {

                int rowCount = dataGridViewTracklist.Rows.Count;
                int cellCount = dataGridViewTracklist.Rows[0].Cells.Count;

                for (int i = 0; i < rowCount; i++)
                {
                    //Leerzeilen überspringen
                    if (dataGridViewTracklist.Rows[i].IsNewRow)
                    {
                        continue;
                    }

                    if (dataGridViewTracklist.Rows[i].Cells[0].Value == null)
                    {
                        continue;
                    }

                    int songID = songs.Find(x => x.SongTitel == dataGridViewTracklist.Rows[i].Cells[0].Value.ToString()).SongID;

                    Featuring feat = new Featuring(
                        songID,
                        artistID
                        );

                    db.newFeat(feat);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Album konnte nicht erstellt werden: " + ex.Message);
            }

            MessageBox.Show("Album wurde erfolgreich erstellt");
            isSaved = true;
            pictureBoxAlbumNeu.Image.Dispose();
            this.Close();
        }

        private void buttonAlbumSongZurueck_Click(object sender, EventArgs e)
        {
            tabControlAlbumNeu.SelectedTab = tabPageNeuesAlbum;
        }
    }
}
