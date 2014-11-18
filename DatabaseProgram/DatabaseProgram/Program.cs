



/*
 * 
 * below is sams code
 * 
 * 
 * 
 * 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace ImperialMusicPlayer
{
    class MusicID3Tag
    {

        public byte[] TAGID = new byte[3];      //  3
        public byte[] Title = new byte[30];     //  30
        public byte[] Artist = new byte[30];    //  30 
        public byte[] Album = new byte[30];     //  30 
        public byte[] Year = new byte[4];       //  4 
        public byte[] Comment = new byte[30];   //  30 
        public byte[] Genre = new byte[1];      //  1

    }
    [Table(Name = "PlaylistReferences")]
    public class PlaylistReference {
        [Column(IsPrimaryKey = true)]
        public int ID;
        [Column]
        public int PlaylistID;
        [Column]
        public int SongID;
    }
    [Table(Name = "PlaylistLibrary")]
    public class Playlist {
        [Column(IsPrimaryKey = true)]
        public int ID;
        [Column]
        public string PlaylistName;
    }
    [Table(Name = "SongLibrary")]
    public class Track
    {
        [Column(IsPrimaryKey = true)]
        public int ID;
        [Column]
        public string Path;
        [Column]
        public string Title;
        [Column]
        public string Artist;
        [Column]
        public string Album;
        [Column]
        public string Year;
        [Column]
        public string Comment;
        [Column]
        public string Genre;

    }
    class MyDatabase : DataContext
    {
        //private const String LoginString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\eblain\\documents\\CECS 343\\Semester Project\\IMP\\DatabaseProgram\\DatabaseProgram\\Database1.mdf\";Integrated Security=True";
        public static String LoginString = ConfigurationManager.ConnectionStrings["SongDatabase"].ToString();
        public Table<Track> SongLibrary;
        public Table<Playlist> PlaylistLibrary;
        public Table<PlaylistReference> PlaylistReferences;
        public MyDatabase()
            : base(LoginString)
        {
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String filePath = System.Reflection.Assembly.GetEntryAssembly().Location;
            String correctedPath = filePath.Substring(0, filePath.IndexOf("bin"));
            ConfigurationManager.AppSettings["DataDirectory"] = correctedPath;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MusicPlayer());
        }
    }
    public static class Prompt {
        public static string ShowDialog(string text, string caption) {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 150;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();
            return textBox.Text;
        }
    }
}















/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace ImperialMusicPlayer {
    class MusicID3Tag {

        public byte[] TAGID = new byte[3];      //  3
        public byte[] Title = new byte[30];     //  30
        public byte[] Artist = new byte[30];    //  30 
        public byte[] Album = new byte[30];     //  30 
        public byte[] Year = new byte[4];       //  4 
        public byte[] Comment = new byte[30];   //  30 
        public byte[] Genre = new byte[1];      //  1

    }
    [Table(Name = "PlaylistReferences")]
    public class PlaylistReference {
        [Column(IsPrimaryKey = true)]
        public int ID;
        [Column]
        public int PlaylistID;
        [Column]
        public int SongID;
    }
    [Table(Name = "PlaylistLibrary")]
    public class Playlist {
        [Column(IsPrimaryKey = true)]
        public int ID;
        [Column]
        public string PlaylistName;
    }
    [Table(Name = "SongLibrary")]
    public class Track {
        [Column(IsPrimaryKey = true)]
        public int ID;
        [Column]
        public string Path;
        [Column]
        public string Title;
        [Column]
        public string Artist;
        [Column]
        public string Album;
        [Column]
        public string Year;
        [Column]
        public string Comment;
        [Column]
        public string Genre;

    }
    
    class MyDatabase : DataContext {
        //public String filePath = System.Reflection.Assembly.GetEntryAssembly().Location;
        //public String data = ConfigurationManager.AppSettings["DataDirectory"];
        //private const String LoginString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\Samue_000\\documents\\visual studio 2012\\Projects\\DatabaseProgram\\DatabaseProgram\\Database1.mdf\";Integrated Security=True";
        //private static String LoginString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=\..\\..\\" + System.Reflection.Assembly.GetEntryAssembly().Location + "Database1.mdf\;Integrated Security=True";
        //public static String LoginString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"" + System.Reflection.Assembly.GetEntryAssembly().Location + "\\Database1.mdf\";Integrated Security=True";
        public static String LoginString = ConfigurationManager.ConnectionStrings["SongDatabase"].ToString();
        public Table<Track> SongLibrary;
        public Table<Playlist> PlaylistLibrary;
        public Table<PlaylistReference> PlaylistReferences;
        public MyDatabase()
            : base(LoginString) {
            //LoginString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"..\\..\\" + System.Reflection.Assembly.GetEntryAssembly().Location + "Database1.mdf\";Integrated Security=True";
        }
    }
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            String filePath = System.Reflection.Assembly.GetEntryAssembly().Location;
            String correctedPath = filePath.Substring(0, filePath.IndexOf("bin"));
            ConfigurationManager.AppSettings["DataDirectory"] = correctedPath;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MusicPlayer());
        }
    }
    public static class Prompt {
        public static string ShowDialog(string text, string caption) {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 150;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();
            return textBox.Text;
        }
    }
}
//end of eli code
*/