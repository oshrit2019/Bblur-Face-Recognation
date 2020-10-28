using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace BBlur
{
    /// <summary>
    /// Interaction logic for ChoosenDWindow.xaml
    /// </summary>
    public partial class ChoosenDWindow : Window
    {
        string fileChoosen1;
        public ChoosenDWindow(string fileChoosen)
        {
            InitializeComponent();
            TextFileName.Text = fileChoosen;
            fileChoosen1 = fileChoosen;


        }

        private void blurButtonFile_Click(object sender, RoutedEventArgs e)
            
        {
            String new1 = @"C:\Users\owner\Desktop\opencv-face-recognition\dataset\";
            String nameDir = textBox.Text;
            Copy(fileChoosen1,new1+"/"+nameDir);
            // System.IO.Directory.Move(new1, @"C:\Users\owner\Desktop\opencv-face-recognition\dataset\" + fileChoosen1);
            updateDataBase();
            this.Close();
           
        }

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(System.IO.Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
        public void updateDataBase()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            // string inputPath = txtEditor.Text //"C:/Users/owner/Desktop/ConsoleApp4/a.jpg";//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            cmd.StandardInput.WriteLine(@"C:\Users\owner\Desktop\updateDatabase");//%py_home%/

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            this.Close();
        }

    }
}
