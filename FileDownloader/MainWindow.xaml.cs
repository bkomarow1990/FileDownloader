//using Multi_File_Copy;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
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

namespace FileDownloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<FileCopyInfo> files = new ObservableCollection<FileCopyInfo>();
        public string FileName { get; set; }
        public string Url { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            threadsListBox.ItemsSource = files;
        }
        //private async void DownloadFileAsync(string address)
        //{
        //    WebClient client = new WebClient();

        //    client.DownloadFileCompleted += Client_DownloadFileCompleted;
        //    client.DownloadProgressChanged += Client_DownloadProgressChanged;

        //    string fileName = System.IO.Path.GetFileName(address);

        //    await client.DownloadFileTaskAsync(address, $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\{fileName}");

        //    MessageBox.Show($"{fileName} - File loaded!");
        //}

        //private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        //{
        //    files.Where((el) => el.FileName == (sender as WebClient).BaseAddress).First();
        //}

        //private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        //{
        //    return;
        //}

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            FileCopyInfo info = new FileCopyInfo()
            {
                FileName = fileNameTB.Text,
                FolderName = folderNameTB.Text,
                Progress = 0,
                WebClient = client
            };
            client.DownloadProgressChanged += (s, el) => { info.Progress = el.ProgressPercentage; };
            client.DownloadFileAsync(
               new Uri(fileNameTB.Text),
               folderNameTB.Text);
            //Console.WriteLine("File loaded");
            files.Add(info);
            
            //CopyFile(info); // freez

            //Thread newThread = new Thread(CopyFile);
            //newThread.Start(info);

            //ThreadPool.QueueUserWorkItem(CopyFile, info);
        }

        private void CopyFile(object obj)
        {
            FileCopyInfo info = obj as FileCopyInfo;
            if (info == null)
                return;

            // set current set ID
            info.Id = Thread.CurrentThread.ManagedThreadId;

            // test progress
            Random rnd = new Random();
            while (info.Progress < 99)
            {
                info.Progress += rnd.Next(5);
                Thread.Sleep(rnd.Next(500));
            }
            info.Progress = 100;

            ///////// Copy file
            //string name = System.IO.Path.GetFileName(info.FileName);
            //string destPath = System.IO.Path.Combine(info.FolderName, name);
            // TODO:
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //string file;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                folderNameTB.Text = saveFileDialog.FileName;
                    
            }
            
        }

        private void stopBtn_Click(object sender, RoutedEventArgs e)
        {
            if (threadsListBox.SelectedItem != null)
            {
                (threadsListBox.SelectedItem as FileCopyInfo).WebClient.CancelAsync();
                return;
            }
            MessageBox.Show("Please, select an item!");
        }

        private void pauseBtn_Click(object sender, RoutedEventArgs e)
        {
            if (threadsListBox.SelectedItem != null)
            {
                var selected = threadsListBox.SelectedItem as FileCopyInfo;
                if (selected.IsPaused)
                {
                    (threadsListBox.SelectedItem as FileCopyInfo).ResetEvent.Reset();
                    
                }
                else
                {
                    (threadsListBox.SelectedItem as FileCopyInfo).ResetEvent.Set();
                }
                return;
            }
            MessageBox.Show("Please, select an item!");
        }
    }
}
