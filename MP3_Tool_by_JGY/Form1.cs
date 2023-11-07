using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_Tool_by_JGY
{
    public partial class MP3_Tool_by_JGY : Form
    {
        private IO_handler iO_Handler = new IO_handler();
        private LogWriter logWriter = new LogWriter();



        private List<string> files = new List<string>();

        private string logPath=".\\Log\\";
        private string inputPath;
        private string outputPath;



        private string toLog=null;




        public MP3_Tool_by_JGY()
        {
            logWriter.checkFolder(logPath);
            logWriter.createLogFile(logPath + "log.txt");
            InitializeComponent();
        }



        private void generate_bt_Click(object sender, EventArgs e)
        {
            outputPath = output_tb.Text;
            inputPath = input_tb.Text;


            if(inputPath.Length > 3 && outputPath.Length>3)
            {
                files = iO_Handler.loadFiles(inputPath + "\\");



                if (files.Count > 0)
                {
                    foreach (string file in files)
                    {
                        string actualName = file.Replace(" ", "ß").Replace("&", "ß&ß").Replace(",","ß&ß").Replace("-","ß-ß").Replace("–", "-").Replace("ßß","ß").Replace("ß", " ");

                        string author = actualName.Replace(" -", "-").Split('-')[0];


                        iO_Handler.move(inputPath + "\\", file, String.Format("{0}\\{1}\\", outputPath, author), actualName);



                        toLog = String.Format("Author folder: {0}\t\tAudio file: {1}\n", author, actualName);

                        logWriter.Write(toLog, logPath + "log.txt");

                        log_tb.AppendText(toLog);
                        log_tb.AppendText(Environment.NewLine);
                    }
                }
                else MessageBox.Show("There is no audio file!");

            }
            else MessageBox.Show("There is no path defined!");





        }
        






        private void browse_input_bt_Click(object sender, EventArgs e)
        {

            using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            inputPath = input_tb.Text = fbd.SelectedPath;
                            //System.Windows.Forms.MessageBox.Show("Files found: " + files[0], "Message");
                        }
                }

        }

        private void browse_output_bt_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    outputPath = output_tb.Text = fbd.SelectedPath;

                    //System.Windows.Forms.MessageBox.Show("Files found: " + files[0], "Message");
                }
            }
        }
    }
}
