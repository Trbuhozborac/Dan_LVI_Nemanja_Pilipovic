using System;
using System.IO.Compression;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Zadatak_1.Command;
using Zadatak_1.Models;

namespace Zadatak_1.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        #region Objects

        MainWindow main;

        #endregion

        #region Constructors

        public MainWindowViewModel(MainWindow mainOpen)
        {
            main = mainOpen;
            Content = new HtmlContent();
        }

        #endregion

        #region Properties

        private HtmlContent content;

        public HtmlContent Content
        {
            get { return content; }
            set 
            {
                content = value;
                OnPropertyChanged("Content");
            }
        }

        #endregion

        #region Commands

        private ICommand zip;
        public ICommand Zip
        {
            get
            {
                if (zip == null)
                {
                    zip = new RelayCommand(param => ZipExecute(), param => CanZipExecute());
                }
                return zip;
            }
        }

        private ICommand download;
        public ICommand Download
        {
            get
            {
                if (download == null)
                {
                    download = new RelayCommand(param => DownloadExecute(), param => CanDownloadExecute());
                }
                return download;
            }
        }

        #endregion

        #region Functions

        private void DownloadExecute()
        {
            string _location = @"~/../../../Html Content/Content.html";
            try
            {
                using(WebClient client = new WebClient())
                {
                    client.DownloadFile(Content.URL, _location);                   
                }
                MessageBox.Show("Content Downloaded Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid URL");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private bool CanDownloadExecute()
        {
            if (string.IsNullOrEmpty(Content.URL))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ZipExecute()
        {
            try
            {
                string startPath = @"~/../../../Html Content";
                string zipPath = @"~/../../../Html Content.zip";

                ZipFile.CreateFromDirectory(startPath, zipPath);

                MessageBox.Show("File Zipped Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("You already Zipped folder");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private bool CanZipExecute()
        {
            return true;
        }

        #endregion
    }
}
