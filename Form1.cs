using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace myAssistant1
{
   
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer flash = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new String[] 
            {
                "open My H C I Lecture From D Drive ",
                " say Hello",
                " what Time Is It ",
                " stop Listening",
                
                " google Please ",
                "face Book Please",
                "open My mail Account",
                "mini Mize Window",
                "maxi Mize Window",
                "normalize Window Size",
                "you Tube Please",
                "open Song Folder"

            });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;


        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            

            if (e.Result.Text == "open My H C I Lecture From D Drive")
            {
                richTextBox1.Text = "YOU : " + speech;
                System.Diagnostics.Process.Start("explorer.exe", @"D:\BSE-V\HCI\class\Lect 1 HCI Introduction 12.09.17.ppt");
                //MessageBox.Show("\nHello Sir. How are you");
               
            }
            else if (e.Result.Text == "say Hello")
            {
                richTextBox1.Text = "YOU : " + speech;
                flash.SpeakAsync("Hello Boss How are you");


                MessageBox.Show("\nHello Boss How are you");
                

            }
            else if (e.Result.Text == "what Time Is It")
            {
                richTextBox1.Text = "YOU : " + speech;
                richTextBox1.Text = "FLASH : " + speech;
                flash.SpeakAsync(DateTime.Now.ToString("h mm tt"));


            }
            else if (e.Result.Text == "stop Listening")
            {
                richTextBox1.Text = "YOU : " + speech;
                flash.SpeakAsync("ok Boss.I Am In Sleep Mode");
                recEngine.RecognizeAsyncStop();
                btnDisableVoice.Enabled = false;

            }
            //else if (e.Result.Text == "start Listening")
            //{
            //    richTextBox1.Text = "YOU : " + speech;
            //    flash.SpeakAsync("welcome Boss I Am In Ready");
            //    recEngine.RecognizeAsync(RecognizeMode.Multiple);
            //    btnDisableVoice.Enabled = true;

            //}
            else if (e.Result.Text == "google Please")
            {
                richTextBox1.Text = "YOU : " + speech;
                System.Diagnostics.Process.Start("https://www.google.com/?gws_rd=ssl");

            }
            else if (e.Result.Text == "face Book Please")
            {
                richTextBox1.Text = "YOU : " + speech;
                System.Diagnostics.Process.Start("https://www.facebook.com/");
            

            }
            else if (e.Result.Text == "open My mail Account")
            {
                richTextBox1.Text = "YOU : " + speech;
                System.Diagnostics.Process.Start("explorer.exe", @"C:\Program Files\WindowsApps\Microsoft.Office.Desktop.Outlook_16051.12228.20364.0_x86__8wekyb3d8bbwe\Office16\OUTLOOK.EXE");


            }
            else if (e.Result.Text == "mini Mize Window")
            {
                richTextBox1.Text = "YOU : " + speech;
                this.WindowState = FormWindowState.Minimized;


            }
            else if (e.Result.Text == "maxi Mize Window")
            {
                richTextBox1.Text = "YOU : " + speech;
                this.WindowState = FormWindowState.Maximized;


            }
            else if (e.Result.Text == "normalize Window Size")
            {
                richTextBox1.Text = "YOU : " + speech;
                this.WindowState = FormWindowState.Normal;

            }
            else if (e.Result.Text == "stop Debugging")
            {
                richTextBox1.Text = "YOU : " + speech;
                

            }
            else if (e.Result.Text == "you Tube Please")
            {
                richTextBox1.Text = "YOU : " + speech;
                System.Diagnostics.Process.Start("https://www.youtube.com/");
            

            }

            else if (e.Result.Text == "open Song Folder")
            {

                richTextBox1.Text = "YOU : " + speech;
                System.Diagnostics.Process.Start("explorer.exe", @"C:\Users\Sherry\Desktop\gaany");

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnDisableVoice.Enabled = true;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnDisableVoice.Enabled = false;
        }
    }
}
