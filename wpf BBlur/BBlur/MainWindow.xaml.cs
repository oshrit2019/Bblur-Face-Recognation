using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace BBlur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //imageBackground.Source = @"C:\Users\owner\Desktop\logo";
            InitializeComponent();
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //עוברים לחלון חדש
            Window1 win2 = new Window1();
            win2.Show();
            //this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            FolderSelectDialog openFileDialog1 = new FolderSelectDialog();
            // FolderBrowserDialogWindow win = new FolderBrowserDialogWindow();
             string fileName=openFileDialog1.Show();
            ChoosenDWindow d = new ChoosenDWindow(fileName);
            d.Show();

            //this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Blur wb = new Blur();
            string fileNameBlur = wb.Show();
            WindowRunDirBur f = new WindowRunDirBur(fileNameBlur);
        }
    }

}
