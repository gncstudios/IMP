/******************************************************************************
 * CECS 343 - Imperial Music Player
 * ****************************************************************************
 * Engineers:       Samuel    Jacobs  (010168312)
 *                  Paul      Aldana  ()
 *                  Eli       Blain   ()
 * ****************************************************************************
 * **************************************************************************** 
 * Revision:        1
 * Revision Date:   10/12/2014
 * ****************************************************************************
 * Description:     This program is a music player.
 * 
 * *************************************************************************** 
 * (c) 2014 Samuel Jacobs
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib.Mpeg;
using TagLib.Id3v1;
using TagLib.Id3v2;
using System.IO;
using System.Media;
using WMPLib;

using System.Collections;

namespace ImperialMusicPlayer
{
    public partial class MusicPlayer : Form
    {

        MyDatabase db = new MyDatabase();

        Boolean persistence, mouse_click = false;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        double currentTrackPosition = 0;
        int[] recentlyPlayed = new int[10];
        string[] trackGenres = {
            "Blues",
            "Classic Rock",
            "Country",
            "Dance",
            "Disco",
            "Funk",
            "Grunge",
            "Hip Hop",
            "Jazz",
            "Metal",
            "New Age",
            "Oldies",
            "Other",
            "Pop",
            "R&B",
            "Rap",
            "Reggae",
            "Rock",
            "Techno",
            "Industrial",
            "Alternative",
            "Ska",
            "Death Metal",
            "Pranks",
            "Soundtrack",
            "Euro-Techno",
            "Ambient",
            "Trip Hop",
            "Vocal",
            "Jazz-Funk",
            "Fusion",
            "Trance",
            "Classical",
            "Instrumental",
            "Acid",
            "House",
            "Game",
            "Sound Clip",
            "Gospel",
            "Noise",
            "Alternative Rock",
            "Bass",
            "Soul",
            "Punk",
            "Space",
            "Meditative",
            "Instrumental Pop",
            "Instrumental Rock",
            "Ethnic",
            "Gothic",
            "Darkwave",
            "Techno-Industrial",
            "Electronic",
            "Pop / Folk",
            "Eurodance",
            "Dream",
            "Southern Rock",
            "Comedy",
            "Cult",
            "Gangsta Rap",
            "Top 40",
            "Christian Rap",
            "Pop / Funk",
            "Jungle",
            "Native American",
            "Cabaret",
            "New Wave",
            "Psychedelic",
            "Rave",
            "Showtunes",
            "Trailer",
            "Lo-fi",
            "Tribal",
            "Acid Punk",
            "Acid Jazz",
            "Polka",
            "Retro",
            "Musical",
            "Rock 'n'Roll",
            "Hard Rock",
            "Folk",
            "Folk / Rock",
            "National Folk",
            "Swing",
            "Fast Fusion",
            "Bebob",
            "Latin",
            "Revival",
            "Celtic",
            "Blue Grass",
            "Avant Garde",
            "Gothic Rock",
            "Progressive Rock",
            "Psychedelic Rock",
            "Symphonic Rock",
            "Slow Rock",
            "Big Band",
            "Chorus",
            "Easy Listening",
            "Acoustic",
            "Humour",
            "Speech",
            "Chanson",
            "Opera",
            "Chamber Music",
            "Sonata",
            "Symphony",
            "Booty Bass",
            "Primus",
            "Pr0n Groove",
            "Satire",
            "Slow Jam",
            "Club",
            "Tango",
            "Samba",
            "Folklore",
            "Ballad",
            "Power Ballad",
            "Rhythmic Soul",
            "Freestyle",
            "Duet",
            "Punk Rock",
            "Drum Solo",
            "Acapella",
            "Euro-House",
            "Dance Hall",
            "Goa",
            "Drum & Bass",
            "Club-House",
            "Hardcore",
            "Terror",
            "Indie",
            "Brit Pop",
            "Negerpunk",
            "Polsk Punk",
            "Beat",
            "Christian Gangsta Rap",
            "Heavy Metal",
            "Black Metal",
            "Crossover",
            "Contemporary Christian",
            "Christian Rock",
            "Merengue",
            "Salsa",
            "Thrash Metal",
            "Anime",
            "JPop",
            "Synth Pop"
        };
        public MusicPlayer(Boolean p)
        {
            InitializeComponent();
            InitSqlTables();
            InitListViewColumns();
            InitControls();
            InitializeTreeView();
            UpdateTree();
            //UpdatePlaylistMenuItems();

            InitColumnStatusMenu();
            
           //DropTables();

            persistence = p;
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        public void InitSqlTables() {
            try {
                db.ExecuteCommand("CREATE TABLE SongLibrary (ID int, Path varchar(512), Genre varchar(4), Title varchar(30), Year varchar(4), Artist varchar(30), Album varchar(30), Comment varchar(30), PlayRecent int)");
                db.SubmitChanges();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                
            }
            try {
                db.ExecuteCommand("CREATE TABLE PlaylistReferences (ID int, PlaylistID int, SongID int)");
                db.SubmitChanges();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);

            }
            try {
                db.ExecuteCommand("CREATE TABLE PlaylistLibrary (ID int, PlaylistName varchar(64))");
                db.SubmitChanges();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);

            }

            try
            {
                db.ExecuteCommand("CREATE TABLE ColumnStatus (ID int, index_of int, name varchar(30), visible bit, sort_by bit)");
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        public void DropTables() {
            try {
                db.ExecuteCommand("DROP TABLE SongLibrary");
                db.SubmitChanges();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);

            }
            
            try {
            db.ExecuteCommand("DROP TABLE PlaylistReferences");
            db.SubmitChanges();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);

            }
            try {
                db.ExecuteCommand("DROP TABLE PlaylistLibrary");
                db.SubmitChanges();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);

            }
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        public void InitControls()
        {
            CurrentSong.SelectionAlignment = HorizontalAlignment.Center;
            CurrentSong.Clear();
            CurrentSong.AppendText("\nImperial Music Player");
            VolumeSlider.Value = 10;
            wplayer.settings.volume = (int)(VolumeSlider.Value * 10);
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void UpdateDisplayToShowLibrary() 
        {
            LibraryView.Items.Clear();
            try
            {
                LibraryView.Hide();
                if (this.TreeExplorer.SelectedNode.Name == "Library" || this.TreeExplorer.SelectedNode.Name == "Playlist") 
                {
                    /*
                    var libraryTracks = from track in db.SongLibrary
                                        orderby track.Title
                                        select track;
                     */
                    var libraryTracks = from songs in db.SongLibrary
                                        select songs;

                    foreach (Track track in libraryTracks) 
                    {

                        ListViewItem item = new ListViewItem();
                        item.Text = track.ID.ToString();
                        item.SubItems.Add(track.Title);
                        item.SubItems.Add(track.Artist);
                        item.SubItems.Add(track.Album);
                        item.SubItems.Add(track.Year);
                        item.SubItems.Add(track.Comment);

                        if (Convert.ToChar(track.Genre) < trackGenres.Length) {
                            Console.WriteLine("Genre Index: " + Convert.ToInt32(Convert.ToChar(track.Genre)));
                            item.SubItems.Add(trackGenres[Convert.ToInt32(Convert.ToChar(track.Genre))]);
                        }
                        else {
                            item.SubItems.Add("Unknown");
                        }



                        item.SubItems.Add(track.Path);

                        this.LibraryView.Items.Add(item);

                    }
                }
                else
                {
                    //this.LibraryView.Items.Clear();
                    var playlistTracks = from Track track
                                         in db.SongLibrary
                                         join reference in db.PlaylistReferences on track.ID equals reference.SongID
                                         where reference.PlaylistID == Convert.ToInt32(this.TreeExplorer.SelectedNode.Name.ToString())
                                         select track;

                    try {
                        this.LibraryView.Hide();
                        foreach (Track track in playlistTracks) 
                        {

                            ListViewItem item = new ListViewItem();
                            item.Text = track.ID.ToString();
                            item.SubItems.Add(track.Title);
                            item.SubItems.Add(track.Artist);
                            item.SubItems.Add(track.Album);
                            item.SubItems.Add(track.Year);
                            item.SubItems.Add(track.Comment);

                            if (Convert.ToChar(track.Genre) < trackGenres.Length) {
                                Console.WriteLine("Genre Index: " + Convert.ToInt32(Convert.ToChar(track.Genre)));
                                item.SubItems.Add(trackGenres[Convert.ToInt32(Convert.ToChar(track.Genre))]);
                            }
                            else {
                                item.SubItems.Add("Unknown");
                            }



                            //item.SubItems.Add(track.Path);
                            LibraryView.Items.Add(item);
                        }
                        Console.WriteLine(this.TreeExplorer.SelectedNode.Text + "\n" + this.TreeExplorer.SelectedNode.Name);
                        //after for each loop
                        /*
                        if (LibraryView.Items.Count > 0) {
                            LibraryView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        }
                        else {
                            LibraryView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        }
                        LibraryView.Show();
                        */

                    }
                    catch (Exception err) {
                        Console.WriteLine(err.Message);
                    }
                }
                /*
                if (LibraryView.Items.Count > 0)
                {
                    LibraryView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else
                {
                    LibraryView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                */

                UpdateColumns();

                




                LibraryView.Show();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        /**********************************************************************
        * @name:       
        * @returns:    void
        * @param1:     object sender
        * @param2:     EventArgs e
        * @desription: 
        **********************************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {

            //HideLibraryViewColumn(0);
            //HideLibraryViewColumn(7);

            TreeExplorer.SelectedNode = TreeExplorer.Nodes[0];    
            UpdateDisplayToShowLibrary();
        }
        
        /// <summary>
        /// InstertTrackIntoDataBaseFromFilePath
        /// </summary>
        /// <param name="filePath">Filepath used to extract ID3Tag information and
        /// insterts it into the database.</param>
        /// <remarks>
        /// This method insterts a track into the database from the filename</remarks>
        private void InstertTrackIntoDataBaseFromFilePath(string filePath)
        {
            try
            {
                Track track = new Track();

                // http://stackoverflow.com/questions/68283/view-edit-id3-data-for-mp3-files
                using (FileStream fs = System.IO.File.OpenRead(filePath))
                {
                    if (fs.Length >= 128)
                    {
                        MusicID3Tag tag = new MusicID3Tag();
                        fs.Seek(-128, SeekOrigin.End);
                        fs.Read(tag.TAGID, 0, tag.TAGID.Length);
                        fs.Read(tag.Title, 0, tag.Title.Length);
                        fs.Read(tag.Artist, 0, tag.Artist.Length);
                        fs.Read(tag.Album, 0, tag.Album.Length);
                        fs.Read(tag.Year, 0, tag.Year.Length);
                        fs.Read(tag.Comment, 0, tag.Comment.Length);
                        fs.Read(tag.Genre, 0, tag.Genre.Length);
                        string theTAGID = Encoding.Default.GetString(tag.TAGID);
                        
                        if (theTAGID.Equals("TAG"))
                        {
                            string Title = Encoding.Default.GetString(tag.Title);
                            string Artist = Encoding.Default.GetString(tag.Artist);
                            string Album = Encoding.Default.GetString(tag.Album);
                            string Year = Encoding.Default.GetString(tag.Year);
                            string Comment = Encoding.Default.GetString(tag.Comment);
                            string Genre = Encoding.Default.GetString(tag.Genre);


                            track.Path = filePath;
                            track.Genre = Genre;
                            track.Title = Title;
                            track.Artist = Artist;
                            track.Comment = Comment;
                            track.Album = Album;
                            track.Year = Year;
                            if (db.SongLibrary.Count() > 0)
                            {
                                Console.WriteLine("Highest ID: " + db.SongLibrary.OrderByDescending(item => item.ID).First().ID + 1);
                                track.ID = db.SongLibrary.OrderByDescending(item => item.ID).First().ID + 1;

                            }
                            else
                            {
                                Console.WriteLine("Highest ID: " + 1);
                                track.ID = 1;
                            }

                            db.SongLibrary.InsertOnSubmit(track);
                            db.SubmitChanges();
                            Console.WriteLine("Adding to library: " + Title);

                        }
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        /**********************************************************************
        * @name:       
        * @returns:    void
        * @param1:     object sender
        * @param2:     EventArgs e
        * @desription: 
        **********************************************************************/
        private void LibraryView_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                if (filePath != null)
                {
                    foreach (string path in filePath)
                    {
                        // check if you are adding a uniqe record
                        if (!(db.SongLibrary.Any(track => track.Path == path)))
                        {
                            InstertTrackIntoDataBaseFromFilePath(path);
                            if (TreeExplorer.SelectedNode.Name != "Library" || TreeExplorer.SelectedNode.Name != "Playlist") {
                                addSongToPlaylist(db.SongLibrary.OrderByDescending(i => i.ID).FirstOrDefault().ID, Convert.ToInt32(TreeExplorer.SelectedNode.Name));
                                
                                UpdateDisplay();
                                //Console.WriteLine(TreeExplorer.SelectedNode.Name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Track already exists");
                        }

                    }
                }
                else //file path is null because it is from inside the musicplayer
                {
                    int songId = Convert.ToInt32(e.Data.GetData(DataFormats.Text, true).ToString());

                    int playlistId = Convert.ToInt32(TreeExplorer.SelectedNode.Name.ToString());
                    if (TreeExplorer.SelectedNode.Text != "Library" && TreeExplorer.SelectedNode.Text != "Playlist")
                    {
                        addSongToPlaylist(songId, playlistId);
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            
            UpdateDisplayToShowLibrary();

          
            
        }
    
        public void InitListViewColumns()
        {
            try
            {
                LibraryView.View = View.Details;
                LibraryView.Columns.Add("ID");
                LibraryView.Columns.Add("Title");
                LibraryView.Columns.Add("Artist");
                LibraryView.Columns.Add("Album");
                LibraryView.Columns.Add("Year");
                LibraryView.Columns.Add("Comment");
                LibraryView.Columns.Add("Genre");
                LibraryView.Columns.Add("Path");

                /* ONLY FOR INITIALIZATION OF TABLE 'COLUMNSTATUS'
                var db_columns = from columnStatus status 
                                 in db.ColumnStatus
                                 orderby status.ID
                                 select status;

                foreach(ColumnHeader item in LibraryView.Columns)
                {
                    bool exist = false;
                    foreach(columnStatus cs in db_columns)
                    {
                        if (String.Compare(item.Text, cs.name) == 0)
                            exist = true;
                    }

                    if(!exist)
                    {
                        //add to db
                        columnStatus temp = new columnStatus();
                        temp.ID = item.Index;
                        temp.index_of = item.Index;
                        temp.name = item.Text;
                        temp.sort_by = false;
                        temp.visible = true;

                        db.ColumnStatus.InsertOnSubmit(temp);
                    }
                }
                db.SubmitChanges();

                var db_columns2 = from columnStatus status
                                in db.ColumnStatus
                                 orderby status.ID
                                 select status;
                */
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        /**********************************************************************
        * @name:       
        * @returns:    void
        * @param1:     object sender
        * @param2:     EventArgs e
        * @desription: 
        **********************************************************************/
        private void LibraryView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.WaveAudio))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Copy;
        }
        /**********************************************************************
        * @name:       
        * @returns:    void
        * @param1:     object sender
        * @param2:     EventArgs e
        * @desription: 
        **********************************************************************/
        public void DeleteFromLibrary(int deleteID)
        {
            try
            {
                wplayer.controls.stop();
                var library = from t in db.SongLibrary
                              where t.ID == deleteID
                              select t;
                foreach (var track in library)
                {
                    Console.WriteLine("Deleteing: " + track.ToString());
                    db.SongLibrary.DeleteOnSubmit(track);
                }
                db.SubmitChanges();
               

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        /**********************************************************************
          * @name:       
          * @returns:    void
          * @param1:     object sender
          * @param2:     EventArgs e
          * @desription: 
          **********************************************************************/
        private void DeleteSongs_Click(object sender, EventArgs e)
        {
            
            try
            {
                foreach (ListViewItem itemToDelete in  LibraryView.SelectedItems) {
                    Console.WriteLine(itemToDelete.Text);
                    DeleteFromLibrary(Convert.ToInt32(itemToDelete.Text));
                
                    itemToDelete.Remove();
                }
            }
            catch(Exception noSongSelectException)
            {
                Console.WriteLine("error");
                Console.WriteLine(noSongSelectException.Message);

            }
            UpdateDisplayToShowLibrary();
        }
        /**********************************************************************
        * @name:       
        * @returns:    void
        * @param1:     object sender
        * @param2:     EventArgs e
        * @desription: 
        **********************************************************************/
        private void PlayButton_Click(object sender, EventArgs e)
        {
            Play();
        }
        /**********************************************************************
        * @name:       
        * @returns:    void
        * @param1:     object sender
        * @param2:     EventArgs e
        * @desription: 
        **********************************************************************/
        private void StopButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                wplayer.URL = "";
                currentTrackPosition = 0;
                wplayer.controls.currentPosition = 0;
                wplayer.controls.stop();
                CurrentSong.Clear();
                CurrentSong.AppendText("\nImperial Music Player");
                timer1.Stop();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
        /**********************************************************************
        * @name:       
        * @returns:    void
        * @param1:     object sender
        * @param2:     EventArgs e
        * @desription: 
        **********************************************************************/
        public void UpdateDisplay()
        {
            if (wplayer.URL == LibraryView.FocusedItem.SubItems[7].Text)
            {
                CurrentSong.Clear();
                CurrentSong.AppendText("Song: " + LibraryView.FocusedItem.SubItems[1].Text);
                CurrentSong.AppendText("\nArtist: " + LibraryView.FocusedItem.SubItems[2].Text);
                CurrentSong.AppendText("\nAlbum: " + LibraryView.FocusedItem.SubItems[3].Text);
                //CurrentSong.AppendText("\nPosition: " + wplayer.controls.currentPositionString.ToString());
            }
        }
        /**********************************************************************
        * @name:       
        * @returns:    void
        * @param1:     object sender
        * @param2:     EventArgs e
        * @desription: 
        **********************************************************************/
        private void NextButton_Click_1(object sender, EventArgs e)
        {
            Next();
            /*
            try
            {
                if (LibraryView.FocusedItem.Index < LibraryView.Items.Count - 1)
                {
                    int selectedIndex = LibraryView.SelectedIndices[0];
                    selectedIndex++;
                    LibraryView.Items[selectedIndex - 1].Selected = false;
                    LibraryView.Items[selectedIndex - 1].Focused = false;
                    LibraryView.Items[selectedIndex].Focused = true;
                    LibraryView.Items[selectedIndex].Selected = true;
                    wplayer.URL = "";
                    wplayer.URL = LibraryView.FocusedItem.SubItems[7].Text;
                    Console.WriteLine("Playing Next Song # " + LibraryView.FocusedItem.Index + " " + LibraryView.FocusedItem.SubItems[7].Text);
                    wplayer.controls.play();
                    UpdateDisplay();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            */
        }
        /**********************************************************************
        * @name:       
        * @returns:    void
        * @param1:     object sender
        * @param2:     EventArgs e
        * @desription: 
        **********************************************************************/
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            Previous();
            /*
            try
            {
                if (LibraryView.FocusedItem.Index > 0)
                {
                    int selectedIndex = LibraryView.SelectedIndices[0];
                    selectedIndex--;
                    LibraryView.Items[selectedIndex + 1].Selected = false;
                    LibraryView.Items[selectedIndex + 1].Focused = false;
                    LibraryView.Items[selectedIndex].Focused = true;
                    LibraryView.Items[selectedIndex].Selected = true;
                    wplayer.URL = "";
                    wplayer.URL = LibraryView.FocusedItem.SubItems[7].Text;
                    Console.WriteLine("Playing Previous Song # " + LibraryView.FocusedItem.Index + " " + LibraryView.FocusedItem.SubItems[7].Text);
                    wplayer.controls.play();
                    UpdateDisplay();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            */
        }
        /**********************************************************************
        * @name:       
        * @returns:    void
        * @param1:     object sender
        * @param2:     EventArgs e
        * @desription: 
        **********************************************************************/
        private void PauseButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.pause();
            currentTrackPosition = wplayer.controls.currentPosition;
            UpdateDisplay();
        }
        /**********************************************************************
        * @name:       
        * @returns:    void
        * @param1:     object sender
        * @param2:     EventArgs e
        * @desription: 
        **********************************************************************/
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /**********************************************************************
        * @name:       
        * @returns:    void
        * @param1:     object sender
        * @param2:     EventArgs e
        * @desription: 
        **********************************************************************/
        private void SongAdd_Click_1(object sender, EventArgs e)
        {
            SongBrowse.ShowDialog();
           
            string[] filePath = SongBrowse.FileNames;
            if (filePath != null)
            {
                foreach (string path in filePath)
                {
                    // check if you are adding a uniqe record
                    if (!(db.SongLibrary.Any(track => track.Path == path)))
                    {
                        InstertTrackIntoDataBaseFromFilePath(path);
                    }
                    else
                    {
                        Console.WriteLine("Track already exists");
                    }

                }
            }
            UpdateDisplayToShowLibrary();
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void LibraryView_MouseClick(object sender, MouseEventArgs e)
        {
            // check if right click
            if (e.Button == MouseButtons.Right)
            {
                mouse_click = true;
            }
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void rightClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wplayer.URL = "";
            currentTrackPosition = 0;
            wplayer.controls.currentPosition = currentTrackPosition;
            PlayButton_Click(sender, e);
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopButton_Click_1(sender, e);
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void LibraryView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            wplayer.URL = "";
            currentTrackPosition = 0;
            wplayer.controls.currentPosition = currentTrackPosition;
            PlayButton_Click(sender, e);
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void ForwardButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                wplayer.controls.currentPosition += 1;
                currentTrackPosition = wplayer.controls.currentPosition;
                UpdateDisplay();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void RewindButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                wplayer.controls.currentPosition -= 1;
                currentTrackPosition = wplayer.controls.currentPosition;
                UpdateDisplay();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSongs_Click(sender, e);
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e) {
            PauseButton_Click(sender, e);
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void addSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SongAdd_Click_1(sender, e);
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                wplayer.controls.stop();
                var library = from t in db.SongLibrary
                              select t;
                foreach (var track in library)
                {
                    Console.WriteLine("Deleteing: " + track.Path.ToString());
                    db.SongLibrary.DeleteOnSubmit(track);
                }
                db.SubmitChanges();

                UpdateDisplayToShowLibrary();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void aboutTheImerialMusicPlayerToolStripMenuItem_Click(
         object sender, EventArgs e) {
            Console.WriteLine("Imperial Music Player.\nCECS 343 Semester Project\nEngineer: Samuel Jacobs\nEngineer: Eli Blain\nEngineer: Paul Aldana\n(c) 2014");
        }
        ///////////////////////////////////////////////////////////////////////
        /// <summary></summary>
        /// <remarks></remarks>
        ///////////////////////////////////////////////////////////////////////
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("If you need help with this, please contact us http://bit.ly/1sbxqJV");
        }

        private void LibraryView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playSongNotInLibraryToolStripMenuItem_Click(object sender, EventArgs e) 
        {

            PlayExternal.ShowDialog();
            wplayer.URL = PlayExternal.FileName;
            wplayer.controls.play();
            CurrentSong.Clear();
            CurrentSong.AppendText("Playing External File");
            CurrentSong.AppendText("\nPath: " + wplayer.URL);
        }

        private void addSongsToolStripMenuItem1_Click(object sender, EventArgs e) {
            addSongsToolStripMenuItem_Click(sender, e);
        }

        private void playSongNotInLibraryToolStripMenuItem1_Click(object sender, EventArgs e) {
            playSongNotInLibraryToolStripMenuItem_Click(sender, e);
        }
        // Populates a TreeView control with example nodes.  
        private void InitializeTreeView() {
            TreeExplorer.BeginUpdate();
            // Add a Parent Node For Library
            TreeExplorer.Nodes.Add("Library");
            TreeExplorer.Nodes[0].Name = "Library";
            TreeExplorer.Nodes.Add("Playlist");
            TreeExplorer.Nodes[1].Name = "Playlist";
            TreeExplorer.EndUpdate();
            TreeExplorer.ExpandAll();
        }

        private void CreatePlaylist_Click(object sender, EventArgs e) {
            CreatePlaylist();
        }
        
        public void CreatePlaylist() {
            InstertPlaylistIntoSqlTable(Prompt.ShowDialog("Playlist Name", "New Playlist Name"));
            //UpdatePlaylistMenuItems();
            UpdateTree();
            TreeExplorer.ExpandAll();
            TreeExplorer.SelectedNode = TreeExplorer.Nodes[TreeExplorer.Nodes.Count - 1].LastNode;
        }
        
        public void UpdatePlaylistMenuItems() {
            try {
                /* Clear the children Items in the right click
                 * drop down menu
                 */
                (TrackMenu.Items["addToPlaylistToolStripMenuItem"] 
                 as ToolStripMenuItem).DropDownItems.Clear();

                // Iterate through Items and attach Responsiblities
                foreach (Playlist playlist in db.PlaylistLibrary) {
                    (TrackMenu.Items["addToPlaylistToolStripMenuItem"] as 
                     ToolStripMenuItem).DropDownItems.Add(TrackMenu.Items.Add(
                     playlist.PlaylistName, 
                     ImperialMusicPlayer.Properties.Resources.glyphicons_159_playlist,
                     addToPlaylistRightClickDynamicMenuItem_Click));

                    /* Set the name of the child items to the ID of the 
                     * playlist
                     */ 
                    (TrackMenu.Items["addToPlaylistToolStripMenuItem"] 
                     as ToolStripMenuItem).DropDown.Items[
                     (TrackMenu.Items["addToPlaylistToolStripMenuItem"] 
                     as ToolStripMenuItem).DropDownItems.Count - 1].Name = 
                     playlist.ID.ToString();
                }
                
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
            }
        }
        
        private void addToPlaylistRightClickDynamicMenuItem_Click(object sender, EventArgs e) {
            addSongToPlaylist(Convert.ToInt32(LibraryView.FocusedItem.SubItems[0].Text.ToString()), Convert.ToInt32((sender as ToolStripMenuItem).Name.ToString()));

            TreeExplorer.ExpandAll();
        }
        
        public void InstertPlaylistIntoSqlTable(string name) {
            Playlist playlist = new Playlist();
            if (db.PlaylistLibrary.Count() > 0) {
                playlist.ID = db.PlaylistLibrary.OrderByDescending(i => i.ID).FirstOrDefault().ID + 1;
            }
            else {
                playlist.ID = 1;
            }
            playlist.PlaylistName = name;
            db.PlaylistLibrary.InsertOnSubmit(playlist);
            db.SubmitChanges();
        }
        
        public void UpdateTree() {
            TreeExplorer.Nodes[1].Nodes.Clear();
            foreach (Playlist playlist in db.PlaylistLibrary) {
                TreeExplorer.Nodes[1].Nodes.Add(playlist.PlaylistName).Name = playlist.ID.ToString(); ;
            }
            UpdatePlaylistMenuItems();
        }

        private void deleteAllPlaylistsToolStripMenuItem_Click(object sender, EventArgs e) {
            // delete all the playlists
            foreach (Playlist playlist in db.PlaylistLibrary) {
                db.PlaylistLibrary.DeleteOnSubmit(playlist);
                db.SubmitChanges();
            }
            // delte all the playlist refrences
            foreach (PlaylistReference playlistReference in db.PlaylistReferences) {
                db.PlaylistReferences.DeleteOnSubmit(playlistReference);
                db.SubmitChanges();
            }

            UpdateTree();
        }

        private void deletePlaylistToolStripMenuItem_Click(object sender, EventArgs e) {
            if (TreeExplorer.SelectedNode.Name != "Library" && TreeExplorer.SelectedNode.Name != "Playlist") {
                DialogResult deleteResult = MessageBox.Show("Do you really want to delete the " + TreeExplorer.SelectedNode.Text + " playlist?", "Playlist Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteResult == DialogResult.Yes) {
                    try {

                        Console.WriteLine("Deleting Playlist: " + TreeExplorer.SelectedNode.Text);
                    }
                    catch (Exception error) {
                        Console.WriteLine(error.Message);
                    }
                    // delete all the playlist refrences associated with this playlist
                    var playlistItemsToDelete = from playlistItem in db.PlaylistReferences
                                                where playlistItem.PlaylistID.ToString() == TreeExplorer.SelectedNode.Name.ToString()
                                                select playlistItem;

                    foreach (PlaylistReference playlistReference in playlistItemsToDelete) {
                        db.PlaylistReferences.DeleteOnSubmit(playlistReference);
                        db.SubmitChanges();
                    }
                    // delete the playlist
                    var playlistsToDelete = from p in db.PlaylistLibrary
                                            where p.ID.ToString() == TreeExplorer.SelectedNode.Name.ToString()
                                            select p;
                    foreach (Playlist playlist in playlistsToDelete) {
                        db.PlaylistLibrary.DeleteOnSubmit(playlist);
                        db.SubmitChanges();
                    }

                    UpdateTree();
                    TreeExplorer.SelectedNode = TreeExplorer.Nodes[1];
                    UpdateDisplayToShowLibrary();
                }
            }
        }

        private void TreeExplorer_MouseDoubleClick(object sender, MouseEventArgs e) {
           
        }

        private void TreeExplorer_AfterSelect(object sender, TreeViewEventArgs e) {
            //removed old code as it was the same as 'UpdateDisplayToShowLibrary()
            //  can recover by rolling backthe file.
            UpdateDisplayToShowLibrary();
        }
        
        public void addSongToPlaylist(int songId, int playlistId) {
            PlaylistReference playlistReference = new PlaylistReference();
            MessageBox.Show("Added to " + TreeExplorer.SelectedNode.Text + " playlist");
            playlistReference.SongID = songId;
            playlistReference.PlaylistID = playlistId;
            playlistReference.ID = db.PlaylistReferences.Count() + 1;
            db.PlaylistReferences.InsertOnSubmit(playlistReference);
            db.SubmitChanges();
        }

        private void clearAllPlaylistsToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                foreach (Playlist playlist in db.PlaylistLibrary) {
                    db.PlaylistLibrary.DeleteOnSubmit(playlist);
                }
                db.SubmitChanges();
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
            }
            try {
                foreach (PlaylistReference playlistReference in db.PlaylistReferences) {
                    db.PlaylistReferences.DeleteOnSubmit(playlistReference);
                }
                db.SubmitChanges();
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
            }
        }

        private void openPlaylistInNewWindowToolStripMenuItem_Click(object sender, EventArgs e) {

            if (TreeExplorer.SelectedNode.Name != "Library" && TreeExplorer.SelectedNode.Name != "Playlist") {
                MusicPlayer newPlaylistWindow = new MusicPlayer(false);
                newPlaylistWindow.Show();
                newPlaylistWindow.TreeExplorer.Hide();
                foreach (TreeNode node in newPlaylistWindow.TreeExplorer.Nodes[1].Nodes) {
                    if (node.Name == TreeExplorer.SelectedNode.Name) {
                        newPlaylistWindow.TreeExplorer.SelectedNode = node;
                    }
                }
                newPlaylistWindow.Text = TreeExplorer.SelectedNode.Text;
                newPlaylistWindow.UpdateDisplayToShowLibrary();
                newPlaylistWindow.LibraryView.Width = newPlaylistWindow.LibraryView.Width + 184;
                Point moveLibraryLeftOverDeletedTreeView = newPlaylistWindow.LibraryView.Location;
                moveLibraryLeftOverDeletedTreeView.Offset(-184, 0);
                newPlaylistWindow.LibraryView.Location = moveLibraryLeftOverDeletedTreeView;

                //Reset main window to the Library view by setting selected node and updating library view
                TreeExplorer.SelectedNode = TreeExplorer.Nodes[0];
                UpdateDisplayToShowLibrary();
                
            }

        }

        private void VolumeSlider_Scroll(object sender, EventArgs e) {
            wplayer.settings.volume = (int) (VolumeSlider.Value * 5);
        }

        private void TreeExplorer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            openPlaylistInNewWindowToolStripMenuItem_Click(sender, e);
        }

        private void LibraryView_DragLeave(object sender, EventArgs e) {
           
        }

        private void LibraryView_ItemDrag(object sender, ItemDragEventArgs e) 
        {
            LibraryView.DoDragDrop(LibraryView.SelectedItems[0].Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void TreeExplorer_DragEnter(object sender, DragEventArgs e) 
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void TreeExplorer_DragDrop(object sender, DragEventArgs e) {
            try 
            {
                Point dragPosition = new Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
                TreeNode targetNode = TreeExplorer.GetNodeAt(TreeExplorer.PointToClient(dragPosition));
                TreeExplorer.SelectedNode = targetNode;
                
                string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                if (filePath != null)
                {
                    foreach (string path in filePath)
                    {
                        // check if you are adding a uniqe record
                        if (!(db.SongLibrary.Any(track => track.Path == path)))
                        {
                            InstertTrackIntoDataBaseFromFilePath(path);
                            if (TreeExplorer.SelectedNode.Name != "Library" || TreeExplorer.SelectedNode.Name != "Playlist")
                            {
                                addSongToPlaylist(db.SongLibrary.OrderByDescending(i => i.ID).FirstOrDefault().ID, Convert.ToInt32(TreeExplorer.SelectedNode.Name));

                                UpdateDisplay();
                                //Console.WriteLine(TreeExplorer.SelectedNode.Name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Track already exists");
                        }

                    }
                }
                else//track is coming from inside the music player
                {
                    Console.WriteLine(e.Data.GetData(DataFormats.Text, true).ToString() + "\n" + dragPosition.ToString());
                    int songId = Convert.ToInt32(e.Data.GetData(DataFormats.Text, true).ToString());

                    int playlistId = Convert.ToInt32(targetNode.Name.ToString());
                    if (targetNode.Text != "Library" && targetNode.Text != "Playlist")
                    {
                        addSongToPlaylist(songId, playlistId);
                    }
                }
                
               
                
                
               // MessageBox.Show("Added to " + targetNode.Text + " playlist");
            }
            catch (Exception error) {
                Console.WriteLine("Drag to invalid playlist\n" + error.Message);


            }

            UpdateDisplayToShowLibrary();

         }
        
        private void HideLibraryViewColumn(int index)
        {
            if (persistence)
            {
                //set visible to false in the database for this column
                // and update columns
                var updateQuery =
                    from status in db.ColumnStatus
                    where status.index_of == index
                    select status;

                //only 1 item in updateQuery
                foreach (columnStatus status in updateQuery)
                {
                    status.visible = false;
                }

                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }

        private void ShowLibraryViewColumn(int index)
        {
            //set visible = true and update columns
            //set visible to false in the database for this column
            if (persistence)
            {
                var updateQuery =
                    from status in db.ColumnStatus
                    where status.index_of == index
                    select status;

                //only 1 item in updateQuery
                foreach (columnStatus status in updateQuery)
                {
                    status.visible = true;
                }

                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }


        }

        private void viewToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //toggle checked state
            ((ToolStripMenuItem)e.ClickedItem).Checked = !((ToolStripMenuItem)e.ClickedItem).Checked;

            //update database
            int index = 8;
            foreach(ColumnHeader column in LibraryView.Columns)
            {
                if(column.Text == ((ToolStripMenuItem)e.ClickedItem).Text )
                {
                    index = column.Index;
                }
            }

            if(((ToolStripMenuItem)e.ClickedItem).Checked)
            {
                ShowLibraryViewColumn(index);
            }
            else
            {
                HideLibraryViewColumn(index);
            }
            
            //update libraryView
            UpdateColumns();
            
        }

        private void ViewMenuItem_CheckedStateChanged(object sender, EventArgs e)
        {
            //based on check state, show or hide column
            Console.WriteLine(sender.ToString());
            Console.WriteLine(e.ToString());
        }

        private void UpdateColumns()
        {
            //sets the width of the columns based on which ones are checked in the menu

            LibraryView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //hides first and last columns (id and path)
            LibraryView.Columns[0].Width = 0;
            LibraryView.Columns[LibraryView.Columns.Count - 1].Width = 0;

            foreach(ToolStripMenuItem tsmi in viewToolStripMenuItem.DropDownItems)
            {
                if(!tsmi.Checked)
                {
                    LibraryView.Columns[viewToolStripMenuItem.DropDownItems.IndexOf(tsmi) + 2].Width = 0;
                }
            }
        }

        private void LibraryView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            /*
            System.Windows.Forms.MouseButtons b = new System.Windows.Forms.MouseButtons();
            MouseEventArgs ev = new MouseEventArgs(b,1,Cursor.Position.X,Cursor.Position.Y,0);
            LibraryView_ColumnRightClick(sender, ev);
            */
            this.LibraryView.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }
        
        private void InitColumnStatusMenu()
        {
            var columns = from columnStatus status
                             in db.ColumnStatus
                          select status;

            foreach (columnStatus status in columns)
            {   
                foreach(ToolStripMenuItem tsmi in viewToolStripMenuItem.DropDownItems)
                {
                    if (status.name == tsmi.Text && status.visible)
                        tsmi.Checked = true;
                    else if (status.name == tsmi.Text && !status.visible)
                        tsmi.Checked = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double time = 0;
            double duration = 0;
            if (wplayer.playState == WMPPlayState.wmppsPlaying)
            {
                duration = wplayer.controls.currentItem.duration;
                progressBar.Maximum = (int)duration;
                progressBar.Value = (int)wplayer.controls.currentPosition;
                TimeSpan currTime = TimeSpan.FromSeconds(wplayer.controls.currentPosition);
                currentPositionTimer.Text = String.Format("{0:D2}:{1:D2}", currTime.Minutes, currTime.Seconds);//wplayer.controls.currentPositionString;

                time = wplayer.controls.currentItem.duration - wplayer.controls.currentPosition;
                System.TimeSpan timeLeft = TimeSpan.FromSeconds(time);
                durationTimer.Text = String.Format("{0:D2}:{1:D2}", timeLeft.Minutes, timeLeft.Seconds); //Convert.ToString(timeLeft);

            }
        }

        private void MusicPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            //all other keys are preceded by ctrl and are therefore valid control values for shortcuts
            if (e.KeyCode == Keys.Space)
            {
                Play();
            }            
        }

        /*
         *Plays the Windows Media Player using the path of the selected track (focused item) in the 
         *LibraryView
        */
        private void Play()
        {
            Console.WriteLine(Convert.ToInt32(LibraryView.FocusedItem.SubItems[0].Text));
            try
            {
                if (LibraryView.FocusedItem != null)
                {
                    if ((wplayer.URL.Length) == 0)
                    {
                        wplayer.URL = LibraryView.FocusedItem.SubItems[7].Text;


                        currentTrackPosition = 0.00;
                        wplayer.controls.currentPosition = currentTrackPosition;
                    }
                    else if (wplayer.URL != LibraryView.FocusedItem.SubItems[7].Text)
                    {
                        wplayer.URL = LibraryView.FocusedItem.SubItems[7].Text;
                    }
                    wplayer.controls.play();
                    timer1.Start();
                    UpdateDisplay();

                    //query db for all songs where playRecent != 0
                    var updateQuery =
                        from songs in db.SongLibrary
                        select songs;
                    //increment playRecent by one where PlayRecent != 0
                    //set current song playRecent = 1
                    foreach(Track t in updateQuery)
                    {
                        if( t.Path.CompareTo(LibraryView.FocusedItem.SubItems[7].Text.ToString()) == 0)
                        {
                            t.PlayRecent = 1;
                        }
                        else if(t.PlayRecent != 0)
                        {
                            t.PlayRecent++;
                        }
                    }
                    
                    //submit changes
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Next()
        {
            try
            {
                if (LibraryView.FocusedItem.Index < LibraryView.Items.Count - 1)
                {
                    int selectedIndex = LibraryView.SelectedIndices[0];
                    selectedIndex++;
                    LibraryView.Items[selectedIndex - 1].Selected = false;
                    LibraryView.Items[selectedIndex - 1].Focused = false;
                    LibraryView.Items[selectedIndex].Focused = true;
                    LibraryView.Items[selectedIndex].Selected = true;
                    Play();
                   

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Previous()
        {
            try
            {
                if (LibraryView.FocusedItem.Index > 0)
                {
                    int selectedIndex = LibraryView.SelectedIndices[0];
                    selectedIndex--;
                    LibraryView.Items[selectedIndex + 1].Selected = false;
                    LibraryView.Items[selectedIndex + 1].Focused = false;
                    LibraryView.Items[selectedIndex].Focused = true;
                    LibraryView.Items[selectedIndex].Selected = true;
                    Play();

                    /*
                    wplayer.URL = "";
                    wplayer.URL = LibraryView.FocusedItem.SubItems[7].Text;
                    Console.WriteLine("Playing Previous Song # " + LibraryView.FocusedItem.Index + " " + LibraryView.FocusedItem.SubItems[7].Text);
                    wplayer.controls.play();
                    UpdateDisplay();
                    */

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void IncreaseVolume()
        {
            if (VolumeSlider.Value != VolumeSlider.Maximum)
                VolumeSlider.Value = VolumeSlider.Value + VolumeSlider.SmallChange;

            wplayer.settings.volume = (int)(VolumeSlider.Value * 5);
        }

        private void DecreaseVolume()
        {
            if (VolumeSlider.Value != VolumeSlider.Minimum)
                VolumeSlider.Value = VolumeSlider.Value - VolumeSlider.SmallChange;

            wplayer.settings.volume = (int)(VolumeSlider.Value * 5);
        }

        private void increaseVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncreaseVolume();
        }

        private void decreaseVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecreaseVolume();
        }

        private void progressBar_MouseClick(object sender, MouseEventArgs e)
        {
            wplayer.controls.currentPosition = ((float)((float)e.Location.X) / (float)progressBar.Width) * wplayer.controls.currentItem.duration;
        }

        private void playRecentToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            try
            {
                //Clear the children Items click drop down menu
                (playRecentToolStripMenuItem).DropDownItems.Clear();

                //query db for recently played songs where playRecent != 0
                //display songs where playRecent < 10
                var recentSongs =
                        from songs in db.SongLibrary
                        where songs.PlayRecent != 0
                        orderby songs.PlayRecent
                        select songs;

                foreach (Track t in recentSongs)
                {
                    Console.WriteLine(t.PlayRecent.ToString());
                    if (t.PlayRecent <= 10)
                    {
                        (playRecentToolStripMenuItem).DropDownItems.Add(t.Title);
                    }
                }



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void playRecentToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String selected = e.ClickedItem.Text.ToString();

            //set focused item based on title; ideally should be on song id
            for (int i = 0; i < LibraryView.Items.Count; i++ )
            {
                if(selected.CompareTo(LibraryView.Items[i].SubItems[1].Text.ToString()) == 0)
                {
                    LibraryView.FocusedItem = LibraryView.Items[i];
                }
            }

                Play();
            
        }

        private void goToCurrentSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibraryView.FocusedItem.EnsureVisible();
        }

        private void MusicPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            var columns = from columnStatus status
                             in db.ColumnStatus
                          select status;
            /*
            foreach (ColumnHeader column in LibraryView.Columns)
            {
                if (column.Text == ((ToolStripMenuItem)e.ClickedItem).Text)
                {
                    index = column.Index;
                }
            }            
            */
            foreach(ToolStripMenuItem tsmi in viewToolStripMenuItem.DropDownItems)
            {
                //if(status.name.CompareTo(tsmi.Text.ToString()) == 0 && status.visible != tsmi.Checked)
                {

                    if (tsmi.Checked)
                        ShowLibraryViewColumn(viewToolStripMenuItem.DropDownItems.IndexOf(tsmi)+2);
                    else if(!tsmi.Checked)
                        HideLibraryViewColumn(viewToolStripMenuItem.DropDownItems.IndexOf(tsmi)+2);
                }
            }

            UpdateColumns();
        }

        private void contextMenuContainer_Opening(object sender, CancelEventArgs e)
        {
            //if mouse click fires, show trackmenu
            if(mouse_click)
            {
                TrackMenu.Show(Cursor.Position);
            }
            //else show headermenu
            else
            {
                HeaderMenu.Show(Cursor.Position);
            }
            //reset mouse_click flag
            mouse_click = false;
        }

    }

    // Implements the manual sorting of items by columns. 
    //From example at: http://msdn.microsoft.com/en-us/library/system.windows.forms.listview.listviewitemsorter(v=vs.110).aspx
    class ListViewItemComparer : IComparer
    {
        private int col;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
        }
    }

}