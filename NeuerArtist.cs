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
        public event Action<string> onAborted;
        
        private string artistName;
        private string artistInfo;
        private string imagePath;

        Datenbank db = new Datenbank();

        private bool isSaved = false;
        private string picDelPath;

        public NeuerArtist()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(onClosing);
        }

        private void onClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if (!isSaved && pictureBoxArtistNeu.Image != null)
                {
                    pictureBoxArtistNeu.Image.Dispose();
                    onAborted.Invoke(picDelPath);
                }
            }
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
                    string fileName = Path.GetFileName(sourceFilePath);
                    string destinationPath = Path.Combine(Application.StartupPath, "Images", fileName);
                    string imagePath = destinationPath;

                    File.Copy(sourceFilePath, destinationPath, overwrite: true);

                    if (pictureBoxArtistNeu.Image != null)
                    {
                        DialogResult result = MessageBox.Show("Wollen Sie das aktuelle Bild ersetzen?", "Bild ersetzen", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            pictureBoxArtistNeu.Image.Dispose();
                            pictureBoxArtistNeu.Image = Image.FromFile(destinationPath);

                            try
                            {
                                if (File.Exists(destinationPath))
                                {
                                    File.Delete(picDelPath);
                                    picDelPath = destinationPath;
                                }
                                else
                                {
                                    MessageBox.Show("Datei konnte nicht gelöscht werden");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("NeuerArtist_DragDrop" + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bild wurde nicht ersetzt");
                        }
                    }
                    else
                    {
                        labelArtistNeuDragDropLabel.Visible = false;
                        pictureBoxArtistNeu.BorderStyle = BorderStyle.None;
                        pictureBoxArtistNeu.Image = Image.FromFile(destinationPath);
                        picDelPath = destinationPath;
                    }

                        
                    
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
                isSaved = true;
                pictureBoxArtistNeu.Image.Dispose();

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
            isSaved = false;
            pictureBoxArtistNeu.Image.Dispose();
            onAborted.Invoke(picDelPath);

            this.Close();
        }
    }
}
