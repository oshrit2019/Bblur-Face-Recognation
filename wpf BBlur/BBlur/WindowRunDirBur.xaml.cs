using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;

namespace BBlur
{
    /// <summary>
    /// Interaction logic for WindowRunDirBur.xaml
    /// </summary>
    public partial class WindowRunDirBur : Window
    {
        public WindowRunDirBur(string file)
        {
            InitializeComponent();
            string[] files =Directory.GetFiles(file, "*.*", SearchOption.AllDirectories);
            foreach (string x in files){
                RunBlur(x);
            }
            MessageBox.Show("Done");
            te.Content = file[0];
            InitializeComponent();
        }

        public void RunBlur(string filename)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            // string inputPath = txtEditor.Text //"C:/Users/owner/Desktop/ConsoleApp4/a.jpg";//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            cmd.StandardInput.WriteLine(@"python %py_home%\recognize.py --detector %py_home%\face_detection_model --embedding-model %py_home%/openface_nn4.small2.v1.t7 --recognizer %py_home%/output/recognizer.pickle --le %py_home%/output/le.pickle --image " + filename);//%py_home%/
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            this.Close();
        }
        public void runCheck(string fileName)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            // string inputPath = txtEditor.Text //"C:/Users/owner/Desktop/ConsoleApp4/a.jpg";//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            cmd.StandardInput.WriteLine(@"python %py_home%\recognize.py --detector %py_home%\face_detection_model --embedding-model %py_home%/openface_nn4.small2.v1.t7 --recognizer %py_home%/output/recognizer.pickle --le %py_home%/output/le.pickle --image " + fileName);//%py_home%/
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            this.Close();
        }
    }
}
