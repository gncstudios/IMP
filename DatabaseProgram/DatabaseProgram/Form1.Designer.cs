using System;
namespace ImperialMusicPlayer
{
    /// <summary>
    /// Mucis Player Class. Defines the MusicPlayer</summary>
    /// <remarks>
    /// Longer comments can be associated with a type or member through
    /// the remarks tag.</remarks>
    partial class MusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.RewindButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playSongNotInLibraryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllPlaylistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheImerialMusicPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToCurrentSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SongAdd = new System.Windows.Forms.Button();
            this.SongBrowse = new System.Windows.Forms.OpenFileDialog();
            this.TrackMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rightClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playSongNotInLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllPlaylistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentSong = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CreatePlaylistButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PlayExternal = new System.Windows.Forms.OpenFileDialog();
            this.TreeExplorer = new System.Windows.Forms.TreeView();
            this.PlaylistRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPlaylistInNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HeaderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.durationTimer = new System.Windows.Forms.Label();
            this.currentPositionTimer = new System.Windows.Forms.Label();
            this.LibraryView = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.TrackMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PlaylistRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.HeaderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(128, -8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 33);
            this.label3.TabIndex = 5;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteButton.Location = new System.Drawing.Point(117, 18);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 52);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete Songs";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteSongs_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.White;
            this.PlayButton.BackgroundImage = global::ImperialMusicPlayer.Properties.Resources.glyphicons_173_play;
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(122, 29);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(30, 30);
            this.PlayButton.TabIndex = 8;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.White;
            this.StopButton.BackgroundImage = global::ImperialMusicPlayer.Properties.Resources.glyphicons_175_stop;
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.ForeColor = System.Drawing.Color.White;
            this.StopButton.Location = new System.Drawing.Point(87, 29);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(29, 30);
            this.StopButton.TabIndex = 9;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click_1);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.White;
            this.NextButton.BackgroundImage = global::ImperialMusicPlayer.Properties.Resources.glyphicons_178_step_forward;
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(228, 29);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(29, 30);
            this.NextButton.TabIndex = 10;
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click_1);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.White;
            this.PreviousButton.BackgroundImage = global::ImperialMusicPlayer.Properties.Resources.glyphicons_170_step_backward;
            this.PreviousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PreviousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousButton.ForeColor = System.Drawing.Color.White;
            this.PreviousButton.Location = new System.Drawing.Point(17, 29);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(29, 30);
            this.PreviousButton.TabIndex = 11;
            this.PreviousButton.UseVisualStyleBackColor = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.Color.White;
            this.PauseButton.BackgroundImage = global::ImperialMusicPlayer.Properties.Resources.glyphicons_174_pause;
            this.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseButton.ForeColor = System.Drawing.Color.White;
            this.PauseButton.Location = new System.Drawing.Point(158, 29);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(29, 30);
            this.PauseButton.TabIndex = 12;
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // RewindButton
            // 
            this.RewindButton.BackColor = System.Drawing.Color.White;
            this.RewindButton.BackgroundImage = global::ImperialMusicPlayer.Properties.Resources.glyphicons_172_rewind;
            this.RewindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RewindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RewindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RewindButton.ForeColor = System.Drawing.Color.White;
            this.RewindButton.Location = new System.Drawing.Point(52, 29);
            this.RewindButton.Name = "RewindButton";
            this.RewindButton.Size = new System.Drawing.Size(29, 30);
            this.RewindButton.TabIndex = 13;
            this.RewindButton.UseVisualStyleBackColor = false;
            this.RewindButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RewindButton_MouseClick);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackColor = System.Drawing.Color.White;
            this.ForwardButton.BackgroundImage = global::ImperialMusicPlayer.Properties.Resources.glyphicons_176_forward;
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ForwardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.ForeColor = System.Drawing.Color.White;
            this.ForwardButton.Location = new System.Drawing.Point(193, 29);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(29, 30);
            this.ForwardButton.TabIndex = 14;
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ForwardButton_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.controlsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongsToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.quitToolStripMenuItem,
            this.playSongNotInLibraryToolStripMenuItem1,
            this.createPlaylistToolStripMenuItem,
            this.deleteAllPlaylistsToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.addToolStripMenuItem.Text = "File";
            // 
            // addSongsToolStripMenuItem
            // 
            this.addSongsToolStripMenuItem.Name = "addSongsToolStripMenuItem";
            this.addSongsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.addSongsToolStripMenuItem.Text = "Add Songs";
            this.addSongsToolStripMenuItem.Click += new System.EventHandler(this.addSongsToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.deleteToolStripMenuItem1.Text = "Delete All";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // playSongNotInLibraryToolStripMenuItem1
            // 
            this.playSongNotInLibraryToolStripMenuItem1.Name = "playSongNotInLibraryToolStripMenuItem1";
            this.playSongNotInLibraryToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.playSongNotInLibraryToolStripMenuItem1.Text = "Play Song Not In Library";
            this.playSongNotInLibraryToolStripMenuItem1.Click += new System.EventHandler(this.playSongNotInLibraryToolStripMenuItem1_Click);
            // 
            // createPlaylistToolStripMenuItem
            // 
            this.createPlaylistToolStripMenuItem.Name = "createPlaylistToolStripMenuItem";
            this.createPlaylistToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.createPlaylistToolStripMenuItem.Text = "Create Playlist";
            this.createPlaylistToolStripMenuItem.Click += new System.EventHandler(this.CreatePlaylist_Click);
            // 
            // deleteAllPlaylistsToolStripMenuItem
            // 
            this.deleteAllPlaylistsToolStripMenuItem.Name = "deleteAllPlaylistsToolStripMenuItem";
            this.deleteAllPlaylistsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.deleteAllPlaylistsToolStripMenuItem.Text = "Delete All Playlists";
            this.deleteAllPlaylistsToolStripMenuItem.Click += new System.EventHandler(this.deleteAllPlaylistsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheImerialMusicPlayerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutTheImerialMusicPlayerToolStripMenuItem
            // 
            this.aboutTheImerialMusicPlayerToolStripMenuItem.Name = "aboutTheImerialMusicPlayerToolStripMenuItem";
            this.aboutTheImerialMusicPlayerToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.aboutTheImerialMusicPlayerToolStripMenuItem.Text = "About Imperial Music Player V1.0";
            this.aboutTheImerialMusicPlayerToolStripMenuItem.Click += new System.EventHandler(this.aboutTheImerialMusicPlayerToolStripMenuItem_Click);
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.playRecentToolStripMenuItem,
            this.goToCurrentSongToolStripMenuItem,
            this.repeatToolStripMenuItem});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.NextButton_Click_1);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // playRecentToolStripMenuItem
            // 
            this.playRecentToolStripMenuItem.Name = "playRecentToolStripMenuItem";
            this.playRecentToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.playRecentToolStripMenuItem.Text = "Play Recent";
            this.playRecentToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.playRecentToolStripMenuItem_DropDownItemClicked);
            this.playRecentToolStripMenuItem.Click += new System.EventHandler(this.playRecentToolStripMenuItem_Click);
            this.playRecentToolStripMenuItem.MouseHover += new System.EventHandler(this.playRecentToolStripMenuItem_MouseHover);
            // 
            // goToCurrentSongToolStripMenuItem
            // 
            this.goToCurrentSongToolStripMenuItem.Name = "goToCurrentSongToolStripMenuItem";
            this.goToCurrentSongToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.goToCurrentSongToolStripMenuItem.Text = "Go to Current Song";
            this.goToCurrentSongToolStripMenuItem.Click += new System.EventHandler(this.goToCurrentSongToolStripMenuItem_Click);
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.CheckOnClick = true;
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.repeatToolStripMenuItem.Text = "Repeat";
            this.repeatToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.repeatToolStripMenuItem_CheckStateChanged);
            // 
            // SongAdd
            // 
            this.SongAdd.BackColor = System.Drawing.Color.Transparent;
            this.SongAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SongAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SongAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SongAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SongAdd.Image = global::ImperialMusicPlayer.Properties.Resources.glyphicons_190_circle_plus;
            this.SongAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SongAdd.Location = new System.Drawing.Point(6, 18);
            this.SongAdd.Name = "SongAdd";
            this.SongAdd.Size = new System.Drawing.Size(105, 52);
            this.SongAdd.TabIndex = 17;
            this.SongAdd.Text = "Add Songs";
            this.SongAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SongAdd.UseVisualStyleBackColor = false;
            this.SongAdd.Click += new System.EventHandler(this.SongAdd_Click_1);
            // 
            // SongBrowse
            // 
            this.SongBrowse.Filter = "Mpeg3 files | *.mp3";
            this.SongBrowse.Multiselect = true;
            // 
            // TrackMenu
            // 
            this.TrackMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightClickToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.playSongNotInLibraryToolStripMenuItem,
            this.addSongsToolStripMenuItem1,
            this.addToPlaylistToolStripMenuItem,
            this.clearAllPlaylistsToolStripMenuItem});
            this.TrackMenu.Name = "TrackMenu";
            this.TrackMenu.Size = new System.Drawing.Size(202, 180);
            // 
            // rightClickToolStripMenuItem
            // 
            this.rightClickToolStripMenuItem.Image = global::ImperialMusicPlayer.Properties.Resources.glyphicons_173_play;
            this.rightClickToolStripMenuItem.Name = "rightClickToolStripMenuItem";
            this.rightClickToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.rightClickToolStripMenuItem.Text = "Play";
            this.rightClickToolStripMenuItem.Click += new System.EventHandler(this.rightClickToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // playSongNotInLibraryToolStripMenuItem
            // 
            this.playSongNotInLibraryToolStripMenuItem.Name = "playSongNotInLibraryToolStripMenuItem";
            this.playSongNotInLibraryToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.playSongNotInLibraryToolStripMenuItem.Text = "Play Song Not In Library";
            this.playSongNotInLibraryToolStripMenuItem.Click += new System.EventHandler(this.playSongNotInLibraryToolStripMenuItem_Click);
            // 
            // addSongsToolStripMenuItem1
            // 
            this.addSongsToolStripMenuItem1.Name = "addSongsToolStripMenuItem1";
            this.addSongsToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.addSongsToolStripMenuItem1.Text = "Add Songs";
            this.addSongsToolStripMenuItem1.Click += new System.EventHandler(this.addSongsToolStripMenuItem1_Click);
            // 
            // addToPlaylistToolStripMenuItem
            // 
            this.addToPlaylistToolStripMenuItem.Image = global::ImperialMusicPlayer.Properties.Resources.glyphicons_159_playlist;
            this.addToPlaylistToolStripMenuItem.Name = "addToPlaylistToolStripMenuItem";
            this.addToPlaylistToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.addToPlaylistToolStripMenuItem.Text = "Add To Playlist";
            this.addToPlaylistToolStripMenuItem.Click += new System.EventHandler(this.addToPlaylistToolStripMenuItem_Click);
            // 
            // clearAllPlaylistsToolStripMenuItem
            // 
            this.clearAllPlaylistsToolStripMenuItem.Name = "clearAllPlaylistsToolStripMenuItem";
            this.clearAllPlaylistsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.clearAllPlaylistsToolStripMenuItem.Text = "Clear All Playlists";
            this.clearAllPlaylistsToolStripMenuItem.Click += new System.EventHandler(this.clearAllPlaylistsToolStripMenuItem_Click);
            // 
            // CurrentSong
            // 
            this.CurrentSong.BackColor = System.Drawing.Color.White;
            this.CurrentSong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentSong.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CurrentSong.Font = new System.Drawing.Font("Calibri", 8F);
            this.CurrentSong.ForeColor = System.Drawing.Color.Black;
            this.CurrentSong.Location = new System.Drawing.Point(6, 20);
            this.CurrentSong.Name = "CurrentSong";
            this.CurrentSong.ReadOnly = true;
            this.CurrentSong.Size = new System.Drawing.Size(279, 44);
            this.CurrentSong.TabIndex = 18;
            this.CurrentSong.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlayButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ForwardButton);
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Controls.Add(this.RewindButton);
            this.groupBox1.Controls.Add(this.NextButton);
            this.groupBox1.Controls.Add(this.PauseButton);
            this.groupBox1.Controls.Add(this.PreviousButton);
            this.groupBox1.Location = new System.Drawing.Point(481, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 70);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playback Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CreatePlaylistButton);
            this.groupBox2.Controls.Add(this.SongAdd);
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Location = new System.Drawing.Point(749, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 70);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Track Library";
            // 
            // CreatePlaylistButton
            // 
            this.CreatePlaylistButton.BackColor = System.Drawing.Color.Transparent;
            this.CreatePlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CreatePlaylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreatePlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePlaylistButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreatePlaylistButton.Image = global::ImperialMusicPlayer.Properties.Resources.glyphicons_159_playlist;
            this.CreatePlaylistButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreatePlaylistButton.Location = new System.Drawing.Point(228, 18);
            this.CreatePlaylistButton.Name = "CreatePlaylistButton";
            this.CreatePlaylistButton.Size = new System.Drawing.Size(105, 52);
            this.CreatePlaylistButton.TabIndex = 22;
            this.CreatePlaylistButton.Text = "New Playlist";
            this.CreatePlaylistButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CreatePlaylistButton.UseVisualStyleBackColor = false;
            this.CreatePlaylistButton.Click += new System.EventHandler(this.CreatePlaylist_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CurrentSong);
            this.groupBox3.Location = new System.Drawing.Point(184, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 72);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Now Playing";
            // 
            // PlayExternal
            // 
            this.PlayExternal.Filter = "Mpeg3 files | *.mp3";
            // 
            // TreeExplorer
            // 
            this.TreeExplorer.AllowDrop = true;
            this.TreeExplorer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TreeExplorer.ContextMenuStrip = this.PlaylistRightClick;
            this.TreeExplorer.Font = new System.Drawing.Font("Calibri", 10F);
            this.TreeExplorer.ForeColor = System.Drawing.Color.White;
            this.TreeExplorer.FullRowSelect = true;
            this.TreeExplorer.HideSelection = false;
            this.TreeExplorer.LabelEdit = true;
            this.TreeExplorer.LineColor = System.Drawing.Color.White;
            this.TreeExplorer.Location = new System.Drawing.Point(0, 142);
            this.TreeExplorer.Name = "TreeExplorer";
            this.TreeExplorer.Size = new System.Drawing.Size(177, 555);
            this.TreeExplorer.TabIndex = 25;
            this.TreeExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeExplorer_AfterSelect);
            this.TreeExplorer.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeExplorer_NodeMouseDoubleClick);
            this.TreeExplorer.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeExplorer_DragDrop);
            this.TreeExplorer.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeExplorer_DragEnter);
            this.TreeExplorer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TreeExplorer_MouseDoubleClick);
            // 
            // PlaylistRightClick
            // 
            this.PlaylistRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playPlaylistToolStripMenuItem,
            this.openPlaylistInNewWindowToolStripMenuItem,
            this.deletePlaylistToolStripMenuItem});
            this.PlaylistRightClick.Name = "PlaylistRightClick";
            this.PlaylistRightClick.Size = new System.Drawing.Size(231, 70);
            // 
            // playPlaylistToolStripMenuItem
            // 
            this.playPlaylistToolStripMenuItem.Name = "playPlaylistToolStripMenuItem";
            this.playPlaylistToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.playPlaylistToolStripMenuItem.Text = "Play Playlist";
            // 
            // openPlaylistInNewWindowToolStripMenuItem
            // 
            this.openPlaylistInNewWindowToolStripMenuItem.Name = "openPlaylistInNewWindowToolStripMenuItem";
            this.openPlaylistInNewWindowToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.openPlaylistInNewWindowToolStripMenuItem.Text = "Open Playlist in New Window";
            this.openPlaylistInNewWindowToolStripMenuItem.Click += new System.EventHandler(this.openPlaylistInNewWindowToolStripMenuItem_Click);
            this.openPlaylistInNewWindowToolStripMenuItem.DoubleClick += new System.EventHandler(this.openPlaylistInNewWindowToolStripMenuItem_Click);
            // 
            // deletePlaylistToolStripMenuItem
            // 
            this.deletePlaylistToolStripMenuItem.Name = "deletePlaylistToolStripMenuItem";
            this.deletePlaylistToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.deletePlaylistToolStripMenuItem.Text = "Delete Playlist";
            this.deletePlaylistToolStripMenuItem.Click += new System.EventHandler(this.deletePlaylistToolStripMenuItem_Click);
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.AccessibleDescription = "Volume";
            this.VolumeSlider.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.VolumeSlider.Location = new System.Drawing.Point(6, 18);
            this.VolumeSlider.Maximum = 20;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Size = new System.Drawing.Size(159, 45);
            this.VolumeSlider.TabIndex = 27;
            this.VolumeSlider.Tag = "Value";
            this.VolumeSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.VolumeSlider.Scroll += new System.EventHandler(this.VolumeSlider_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.VolumeSlider);
            this.groupBox4.Location = new System.Drawing.Point(12, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 72);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Volume";
            // 
            // HeaderMenu
            // 
            this.HeaderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.HeaderMenu.Name = "HeaderRightClick";
            this.HeaderMenu.Size = new System.Drawing.Size(100, 26);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistToolStripMenuItem,
            this.albumToolStripMenuItem,
            this.yearToolStripMenuItem,
            this.commentToolStripMenuItem,
            this.genreToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.viewToolStripMenuItem_DropDownItemClicked);
            // 
            // artistToolStripMenuItem
            // 
            this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            this.artistToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.artistToolStripMenuItem.Text = "Artist";
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.albumToolStripMenuItem.Text = "Album";
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.yearToolStripMenuItem.Text = "Year";
            // 
            // commentToolStripMenuItem
            // 
            this.commentToolStripMenuItem.Name = "commentToolStripMenuItem";
            this.commentToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.commentToolStripMenuItem.Text = "Comment";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(184, 108);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(291, 10);
            this.progressBar.TabIndex = 27;
            this.progressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // durationTimer
            // 
            this.durationTimer.AutoSize = true;
            this.durationTimer.ForeColor = System.Drawing.Color.Black;
            this.durationTimer.Location = new System.Drawing.Point(481, 99);
            this.durationTimer.Name = "durationTimer";
            this.durationTimer.Size = new System.Drawing.Size(37, 19);
            this.durationTimer.TabIndex = 28;
            this.durationTimer.Text = "0:00";
            // 
            // currentPositionTimer
            // 
            this.currentPositionTimer.AutoSize = true;
            this.currentPositionTimer.ForeColor = System.Drawing.Color.Black;
            this.currentPositionTimer.Location = new System.Drawing.Point(140, 104);
            this.currentPositionTimer.Name = "currentPositionTimer";
            this.currentPositionTimer.Size = new System.Drawing.Size(37, 19);
            this.currentPositionTimer.TabIndex = 29;
            this.currentPositionTimer.Text = "0:00";
            // 
            // LibraryView
            // 
            this.LibraryView.AllowColumnReorder = true;
            this.LibraryView.AllowDrop = true;
            this.LibraryView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.LibraryView.BackgroundImage = global::ImperialMusicPlayer.Properties.Resources.ImperialMusicPlayerLibraryBackground;
            this.LibraryView.BackgroundImageTiled = true;
            this.LibraryView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LibraryView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LibraryView.Font = new System.Drawing.Font("Calibri", 10F);
            this.LibraryView.ForeColor = System.Drawing.Color.White;
            this.LibraryView.FullRowSelect = true;
            this.LibraryView.HideSelection = false;
            this.LibraryView.Location = new System.Drawing.Point(184, 125);
            this.LibraryView.Margin = new System.Windows.Forms.Padding(4);
            this.LibraryView.MinimumSize = new System.Drawing.Size(800, 400);
            this.LibraryView.Name = "LibraryView";
            this.LibraryView.RightToLeftLayout = true;
            this.LibraryView.Size = new System.Drawing.Size(971, 572);
            this.LibraryView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LibraryView.TabIndex = 3;
            this.LibraryView.UseCompatibleStateImageBehavior = false;
            this.LibraryView.View = System.Windows.Forms.View.List;
            this.LibraryView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LibraryView_ColumnClick);
            this.LibraryView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LibraryView_ItemDrag);
            this.LibraryView.SelectedIndexChanged += new System.EventHandler(this.LibraryView_SelectedIndexChanged);
            this.LibraryView.DragDrop += new System.Windows.Forms.DragEventHandler(this.LibraryView_DragDrop);
            this.LibraryView.DragEnter += new System.Windows.Forms.DragEventHandler(this.LibraryView_DragEnter);
            this.LibraryView.DragLeave += new System.EventHandler(this.LibraryView_DragLeave);
            this.LibraryView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MusicPlayer_KeyDown);
            this.LibraryView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LibraryView_MouseClick);
            this.LibraryView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LibraryView_MouseDoubleClick);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 632);
            this.Controls.Add(this.currentPositionTimer);
            this.Controls.Add(this.durationTimer);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.TreeExplorer);
            this.Controls.Add(this.LibraryView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.Color.Azure;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MusicPlayer";
            this.Text = "Imperial Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MusicPlayer_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TrackMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.PlaylistRightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.HeaderMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button RewindButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button SongAdd;
        private System.Windows.Forms.OpenFileDialog SongBrowse;
        private System.Windows.Forms.ContextMenuStrip TrackMenu;
        private System.Windows.Forms.ToolStripMenuItem rightClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheImerialMusicPlayerToolStripMenuItem;
        private System.Windows.Forms.RichTextBox CurrentSong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem playSongNotInLibraryToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog PlayExternal;
        private System.Windows.Forms.ToolStripMenuItem addSongsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem playSongNotInLibraryToolStripMenuItem1;
        private System.Windows.Forms.TreeView TreeExplorer;
        private System.Windows.Forms.ToolStripMenuItem createPlaylistToolStripMenuItem;
        private System.Windows.Forms.Button CreatePlaylistButton;
        private System.Windows.Forms.ToolStripMenuItem deleteAllPlaylistsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip PlaylistRightClick;
        private System.Windows.Forms.ToolStripMenuItem playPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPlaylistInNewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllPlaylistsToolStripMenuItem;
        private System.Windows.Forms.TrackBar VolumeSlider;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip HeaderMenu;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playRecentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToCurrentSongToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label durationTimer;
        private System.Windows.Forms.Label currentPositionTimer;
        private System.Windows.Forms.ListView LibraryView;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
    }

    public class SongView : System.Windows.Forms.ListView
    {/*
        //declare actual event
        public event System.Windows.Forms.MouseEventHandler MouseColumnClick;

        //define event listener
        protected virtual void OnClick(System.Windows.Forms.MouseEventArgs e)
        {
            if (base.ColumnClick != null)
                MouseColumnClick(this, e);
        }
      */
    }
}

