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

        /// <summary>
        /// Download the HTML content from website to .html file
        /// </summary>
        private void DownloadExecute()
        {
            string _location = @"~/../../../Html Content/Content.html";
            try
            {
                //If URL is valid download will be executed
                using(WebClient client = new WebClient())
                {
                    client.DownloadFile(Content.URL, _location);                   
                }
                MessageBox.Show("Content Downloaded Successfully!");
            }
            catch (Exception ex)
            {
                //If exception occure that means that URL is Invalid
                MessageBox.Show("Invalid URL");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Checks if URL filed is populated
        /// </summary>     
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

        /// <summary>
        /// Zipp the folder where content file is placed
        /// </summary>
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
                //Exception will occure if file is already zipped
                MessageBox.Show("You already Zipped folder");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Checks if Zipp button can be clicked
        /// </summary>        
        private bool CanZipExecute()
        {
            return true;
        }

        #endregion
    }
}
