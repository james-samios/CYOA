using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017cyoa
{

    public partial class Form1 : Form
    {
        // We create our own data type here to store the
        // content of the file as we read it in. 
        public struct Room
        {
            public int roomID;
            public string story;
            public int opt1;
            public string opt1Text;
            public int opt2;
            public string opt2Text;
            public int opt3;
            public string opt3Text;
        }

        // Create an array of our new data type.
        // remember to change the value in the [] 
        // to the number of lines in your text file
        Room[] room = new Room[20]; 

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // add the other buttons to the same event
            this.btn2.Click += btn1_Click;
            this.btn3.Click += btn1_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load the file into memory
            readFile();

            // load the initial room
            loadRoom(0);
        }

        private void readFile()
        {
            string line;

            // indicates the room in the array
            int counter = 0;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader(Application.StartupPath + "\\story.txt");
            while ((line = file.ReadLine()) != null)
            {
                // divide the string on the | character
                // and store in a temporary array
                string[] tmp = line.Split('|');

                // load the string into the structure
                room[counter].roomID = int.Parse(tmp[0]);
                room[counter].story = tmp[1];
                room[counter].opt1 = int.Parse(tmp[2]);
                room[counter].opt1Text = tmp[3];
                room[counter].opt2 = int.Parse(tmp[4]);
                room[counter].opt2Text = tmp[5];
                room[counter].opt3 = int.Parse(tmp[6]);
                room[counter].opt3Text = tmp[7];
                counter++;
            }

            file.Close();
        }

        // This function loads a room from the array
        // of rooms into the controls on the screen.
        private void loadRoom(int roomID)
        {
            lblStory.Text = room[roomID].story;
            btn1.Text = room[roomID].opt1Text;

            // store the target room for the button click
            btn1.Tag = room[roomID].opt1;
            btn2.Text = room[roomID].opt2Text;
            btn2.Tag = room[roomID].opt2;
            btn3.Text = room[roomID].opt3Text;
            btn3.Tag = room[roomID].opt3;
        }

        // This function handles the click button event
        // for all the controls on the screen
        private void btn1_Click(object sender, EventArgs e)
        {
            // Cast the 'sender' as a button
            Button sentButton = (Button)sender;

            // Extract the target room of the button
            int ID = int.Parse(sentButton.Tag.ToString());

            // Call the loadRoom function and pass the ID
            loadRoom(ID);
        }
    }
}
