using System;
using Microsoft.Phone.Controls;
using System.Collections.ObjectModel;

namespace LLMSCustomSelectionDesign
{
    public partial class MainPage : PhoneApplicationPage
    {

        ObservableCollection<string> llmsList;

        public MainPage()
        {
            InitializeComponent();

            llmsList = new ObservableCollection<string>();
            llmsAlbumMedia.ItemsSource = llmsList;
            GetMediaList();
        }

        private void GetMediaList()
        {
            try
            {
                llmsList.Add("/Assets/Img/1.png");
                llmsList.Add("/Assets/Img/2.png");
                llmsList.Add("/Assets/Img/3.png");
                llmsList.Add("/Assets/Img/4.png");
                llmsList.Add("/Assets/Img/5.png");
                llmsList.Add("/Assets/Img/6.png");
                llmsList.Add("/Assets/Img/7.png");
                llmsList.Add("/Assets/Img/8.png");
            }
            catch (Exception) { }
        }
    }
}