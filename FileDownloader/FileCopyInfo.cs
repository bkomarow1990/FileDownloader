using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileDownloader
{
    class FileCopyInfo : INotifyPropertyChanged
    {
        public string FileName { get; set; }
        public string FolderName { get; set; }
        private float progress;
        public float Progress
        {
            get { return progress; }
            set
            {
                progress = value;
                OnPropertyChanged();
            }
        }
        public ManualResetEvent ResetEvent { get; set; } = new ManualResetEvent(false);
        public WebClient WebClient{ get; set; }
        public bool IsPaused { get; set; } = false;
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
