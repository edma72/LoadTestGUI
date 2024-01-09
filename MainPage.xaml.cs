
using LoadTracking.Views;
using Microsoft.Maui.Controls;

namespace LoadTracking
{
    public partial class MainPage : ContentPage
    {

        int count = 0;
        private object btnReports;

        public MainPage()
        {
            InitializeComponent();
        }

        //private void InitializeComponent()
        //{
        //    throw new NotImplementedException();
        //}

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Button clicked", "OK");
        }

        private void btnLoadDetails_Clicked(object sender, EventArgs e)
        {
            //CP.Content = new LoadOprerations();
        }


        // dispaly LoadOperations page IN the ContentPage GRID COLUMN 1



        private void btnReports_Clicked(object sender, EventArgs e)
        {
            //CP.Content = new Reports();
        }

        private void btnZipcode_Clicked(object sender, EventArgs e)
        {
            //CP.Content = new ZipCodeOperation();
        }

        private void btnDriverDetails_Clicked(object sender, EventArgs e)
        {
            //CP.Content = new DriverOperations();
        }

        private void btnAdmin_Clicked(object sender, EventArgs e)
        {
            //CP.Content = new AdminOperations();
        }

        private void btnInvoice_Clicked(object sender, EventArgs e)
        {
            CP = new Invoice();
            //cange background color    
            CP.BackgroundColor = Colors.Aqua;



        }

        private void btnProfile_Clicked(object sender, EventArgs e)
        {
            //CP.Content = new Profile(); 
        }
    }

}
