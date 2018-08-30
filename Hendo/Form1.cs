using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using NAudio.CoreAudioApi;


//      
//        ___ ___                     .___      
//       /   |   \   ____   ____    __| _/____  
//      /    ~    \_/ __ \ /    \  / __ |/  _ \ 
//      \    Y    /\  ___/|   |  \/ /_/ (  <_> )
//       \___|_  /  \___  >___|  /\____ |\____/ 
//             \/       \/     \/      \/       
//      
//    Or, a Horribly-executed neural digital orangism


namespace Hendo
{
    public partial class Form1 : Form
    {

        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer synth = new SpeechSynthesizer();
        StatusStrip dynamicStatusStrip = new System.Windows.Forms.StatusStrip();
        public string speechstring;
        public string currentdate;
        public string prefix;



        public Form1()
        {
            InitializeComponent();

            // show installed voices
            foreach (var v in synth.GetInstalledVoices().Select(v => v.VoiceInfo))
            {
                Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}",
                  v.Description, v.Gender, v.Age);
            }

            // Configure the audio output. 
            synth.SetOutputToDefaultAudioDevice();

            // to change VoiceGender and VoiceAge
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);

            synth.Volume = 100;  // 0...100
            synth.Rate = 0;     // -10...10
            var current = synth.GetCurrentlySpokenPrompt();
            prefix = "Hendo: ";
            StatusText.Text = "Loading...";


        }



        //       __ _             _                   __                 _ 
        //      / _\ |_ __ _ _ __| |_ _   _ _ __     / /  ___   __ _  __| |
        //      \ \| __/ _` | '__| __| | | | '_ \   / /  / _ \ / _` |/ _` |
        //      _\ \ || (_| | |  | |_| |_| | |_) | / /__| (_) | (_| | (_| |
        //      \__/\__\__,_|_|   \__|\__,_| .__/  \____/\___/ \__,_|\__,_|
        //                                 |_|                             
        //      

        private void Form1_Load(object sender, EventArgs e)
        {
            currentdate = DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm tt");
            speechstring = "Hendo is now awake.";
            // Speak a string.
            synth.SpeakAsync(speechstring);
            // add the prefix to text box for legibility
            HendoTextForm.Text = prefix + speechstring;
            StatusText.Text = "Ready";


        }



        //                               
        //        /\/\   ___ _ __  _   _ 
        //       /    \ / _ \ '_ \| | | |
        //      / /\/\ \  __/ | | | |_| |
        //      \/    \/\___|_| |_|\__,_|
        //                               
        //      

        private void button1_Click(object sender, EventArgs e)
        {
            // listen
            speechstring = "";
            HendoTextForm.Text = speechstring;
            synth.SpeakAsync(speechstring);
            StatusText.Text = "Listening...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // read
            if (synth != null)
                synth.SpeakAsyncCancelAll();
            synth.SpeakAsync(speechstring);
            StatusText.Text = "Reading...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // stop
            if (synth != null)
                synth.SpeakAsyncCancelAll();
            StatusText.Text = "Ready";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // clear
            if (synth != null)
                synth.SpeakAsyncCancelAll();
            HendoTextForm.Text = "";
            StatusText.Text = "Ready";
        }

        private void HendoTextForm_TextChanged(object sender, EventArgs e)
        {
            HendoTextForm.ForeColor = Color.White;
            speechstring = HendoTextForm.Text;


        }

        
//         ___                
//        / __\ __ __ _ _ __  
//       / / | '__/ _` | '_ \ 
//      / /__| | | (_| | |_) |
//      \____/_|  \__,_| .__/ 
//                     |_|    
//      


        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
