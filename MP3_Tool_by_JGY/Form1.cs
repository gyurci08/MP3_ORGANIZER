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
        private string toLog = null;


        private List<string> files = new List<string>();

        private string logPath=@".\Log\"; // Use %APPDATA% ?
        private string inputPath;
        private string outputPath;

        public MP3_Tool_by_JGY()
        {       
            InitializeComponent();
            logWriter.checkFolder(logPath);
            logWriter.createLogFile(logPath + "log.txt");
        }



        private async void generate_bt_Click(object sender, EventArgs e)
        {
            outputPath = output_tb.Text;
            inputPath = input_tb.Text;


            if(!string.IsNullOrEmpty(inputPath) && !string.IsNullOrEmpty(outputPath)) // outputPath.Lenght > 3 ?
            {
                // files = iO_Handler.GetFileNamesInPath(inputPath);  //not using it
                if (Directory.GetFiles(inputPath).Length > 0) // there's no need to cound the files with a function
                {
                    foreach (string file in files)
                    {                   
                        File.Move(file, $"{outputPath}\\{Path.GetFileName(file)}"); // Moves files with ".mp3" extension
                        toLog = $"Author folder: {Path.GetFileName(file).Trim().Split('-')[0]}\t\tAudio file: {Path.GetFileNameWithoutExtension(file)}\n";

                        await logWriter.Write(toLog, logPath + "log.txt");
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
                }
            }
        }
    }
}
