﻿using System.Windows.Media;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class CompanyFormViewModel
    {
        private ImageSource imageIconCancelSource;
        public ImageSource ImageIconCancelSource
        {
            get { return imageIconCancelSource; }
            set { SetProperty(ref imageIconCancelSource, value); }
        }

        private ImageSource imageIconSaveSource;
        public ImageSource ImageIconSaveSource
        {
            get { return imageIconSaveSource; }
            set { SetProperty(ref imageIconSaveSource, value); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private string b3Code;
        public string B3Code
        {
            get { return b3Code; }
            set { SetProperty(ref b3Code, value); }
        }

        private string document;
        public string Document
        {
            get { return document; }
            set { SetProperty(ref document, value); }
        }
    }
}