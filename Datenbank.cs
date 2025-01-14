using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StreamingDB
{

    public class Datenbank
    {
        private MySqlConnection con;
        private string connectionString;

        public Datenbank()
        {
            connectionString = string.Format("SERVER = localhost; DATABASE = streamingdb; UID = {0}; PASSWORD = {1}", "root", "");
            con = new MySqlConnection(connectionString);

            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }

        }

        #region Conncetion
        private void Open()
        {
            con.Open();
        }
        public void Close()
        {
            con.Close();
        }
        #endregion

        #region Read Data from Database

        public List<Artist> getArtists()
        {
            List<Artist> liartist = new List<Artist>();

            try
            {
                Open();

                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM artist ORDER BY ArtistID desc;";
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liartist.Add(
                        new Artist(
                            reader.GetInt32("ArtistID"),
                            reader.GetString("ArtistName"),
                            reader.GetString("ArtistInformation"),
                            reader.GetString("ArtistImage")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Artists" + ex.Message);
            }
            finally
            {
                Close();


            }
            return liartist;
        }

        public List<Song> getSongs()
        {
            List<Song> lisongs = new List<Song>();
            try
            {
                Open();

                MySqlCommand com = con.CreateCommand();
                com.CommandText = @"SELECT * FROM song ORDER BY SongID desc;";
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    lisongs.Add(
                        new Song(
                            reader.GetInt32("SongID"),
                            reader.GetString("SongTitel"),
                            reader.GetInt32("GenreID"),
                            reader.GetInt32("AlbumID")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Songs" + ex.Message);
            }
            finally
            {
                Close();
            }

            return lisongs;
        }

        public List<Label> getLabels()
        {
            List<Label> lilabels = new List<Label>();

            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM label ORDER BY LabelID desc;";
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    lilabels.Add(
                        new Label(
                            reader.GetInt32("LabelID"),
                            reader.GetString("LabelName"),
                            reader.GetString("LabelInformation"),
                            reader.GetString("LabelImage")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Labels" + ex.Message);
            }
            
            finally
            {
                Close();
            }
            return lilabels;
        }

        public List<Album> getAlben()
        {
            List<Album> lialben = new List<Album>();

            try
            {
                Open();

                MySqlCommand com = con.CreateCommand();
                com.CommandText = @"SELECT * FROM album ORDER BY AlbumID desc;";
                MySqlDataReader reader = com.ExecuteReader();
                while(reader.Read())
                {
                    lialben.Add(
                        new Album(
                            reader.GetInt32("AlbumID"),
                            reader.GetString("AlbumName"),
                            reader.GetInt32("Erscheinungsjahr"),
                            reader.GetString("AlbumCover"),
                            reader.GetInt32("LabelID"),
                            reader.GetInt32("ArtistID")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alben" + ex.Message);
            }
            finally
            {
                Close();
            }
            return lialben;
        }

        public List<SongData> getSongData()
        {
            List<SongData> lisongdata = new List<SongData>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = @"SELECT * FROM songdata ORDER BY SongDataID desc;";
                MySqlDataReader reader = com.ExecuteReader();

                while(reader.Read())
                {
                    lisongdata.Add(
                        new SongData(
                            reader.GetInt32("SongDataID"),
                            reader.GetTimeSpan("SongDauer"),
                            reader.GetInt32("SongBPM"),
                            reader.GetString("SongFormat"),
                            reader.GetInt32("SongID")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SongData" + ex.Message);
            }
            finally
            {
                Close();
            }
            return lisongdata;
        }

        public List<Genre> getGenre()
        {
            List<Genre> ligenre = new List<Genre>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = @"SELECT * FROM genre ORDER BY GenreID desc;";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ligenre.Add(
                        new Genre(
                            reader.GetInt32("GenreID"),
                            reader.GetString("GenreName")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Genre" + ex.Message);
            }
            finally
            {
                Close();
            }
            return ligenre;
        }

        public List<Featuring> getFeaturing()
        {
            List<Featuring> lifeat = new List<Featuring>();

            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = @"SELECT * FROM featuring ORDER BY FeaturingID desc;";
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    lifeat.Add(
                        new Featuring(
                            reader.GetInt32("FeaturingID"),
                            reader.GetInt32("SongID"),
                            reader.GetInt32("ArtistID")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Feat" + ex.Message);
            }
            finally
            {
                Close();
            }

            return lifeat;
        }




        #endregion

            #region Direkter XML Export


        public void ExportAlbumToXml()
        {
            try
            {
                Open();

                MySqlCommand com = con.CreateCommand();
                com.CommandText = @"SELECT a.AlbumID, a.ALbumName, a.Erscheinungsjahr, a.AlbumCover, ar.ARtistName, l.LabelName
                                    FROM
                                        album a
                                    JOIN
                                        artist ar ON a.ArtistID = ar.ArtistID
                                    JOIN
                                        label l ON a.LabelID = l.LabelID
                                    ORDER BY a.AlbumID ASC;";

                MySqlDataReader reader = com.ExecuteReader();

                //XML Dokument erstellen

                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("Alben");
                xmlDoc.AppendChild(root);

                while (reader.Read())
                {
                    XmlElement albumElement = xmlDoc.CreateElement("Album");

                    XmlElement albumID = xmlDoc.CreateElement("AlbumID");
                    albumID.InnerText = reader.GetInt32("AlbumID").ToString();
                    albumElement.AppendChild(albumID);

                    XmlElement albumName = xmlDoc.CreateElement("AlbumName");
                    albumName.InnerText = reader.GetString("AlbumName");
                    albumElement.AppendChild(albumName);

                    XmlElement erscheinungsjahr = xmlDoc.CreateElement("Erscheinungsjahr");
                    erscheinungsjahr.InnerText = reader.GetInt32("Erscheinungsjahr").ToString();
                    albumElement.AppendChild(erscheinungsjahr);

                    XmlElement albumCover = xmlDoc.CreateElement("AlbumCover");
                    albumCover.InnerText = reader.GetString("AlbumCover");
                    albumElement.AppendChild(albumCover);

                    XmlElement artistName = xmlDoc.CreateElement("ArtistName");
                    artistName.InnerText = reader.GetString("ArtistName");
                    albumElement.AppendChild(artistName);

                    XmlElement labelName = xmlDoc.CreateElement("LabelName");
                    labelName.InnerText = reader.GetString("LabelName");
                    albumElement.AppendChild(labelName);

                    root.AppendChild(albumElement);
                }

                reader.Close();

                xmlDoc.Save("Album.xml");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }

        }


        #endregion
    }
}
