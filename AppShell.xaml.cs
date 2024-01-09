using System.ComponentModel;
using Microsoft.Maui.Controls;
using System;

namespace LoadTracking
{
    public partial class AppShell : Shell
    {
        // Property to control the Shell items' enabled state
        private bool isShellItemsEnabled;

        public bool IsShellItemsEnabled
        {
            get => isShellItemsEnabled;
            set
            {
                if (isShellItemsEnabled != value)
                {
                    isShellItemsEnabled = value;
                    OnPropertyChanged(nameof(IsShellItemsEnabled));
                }
            }
        }

        public AppShell()
        {
            InitializeComponent();

            // Set the default state of the Shell items
            IsShellItemsEnabled = false;
            btnLoadOprerations.IsVisible = IsShellItemsEnabled;
            btnReports.IsVisible = IsShellItemsEnabled;
            btnInvoice.IsVisible = IsShellItemsEnabled;
            btnZipCode.IsVisible = IsShellItemsEnabled;
            btnDriver.IsVisible = IsShellItemsEnabled;
            btnAdmin.IsVisible = IsShellItemsEnabled;
            btnProfile.IsVisible = IsShellItemsEnabled;

            // Subscribe to the PropertyChanged event
            PropertyChanged += OnPropertyChanged;
        }

        // Event handler for PropertyChanged event
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // Check if the IsShellItemsEnabled property changed
            if (e.PropertyName == nameof(IsShellItemsEnabled))
            {
                // Enable or disable Shell items based on the property value
                btnLoadOprerations.IsVisible = IsShellItemsEnabled;
                btnReports.IsVisible = IsShellItemsEnabled;
                btnInvoice.IsVisible = IsShellItemsEnabled;
                btnZipCode.IsVisible = IsShellItemsEnabled;
                btnDriver.IsVisible = IsShellItemsEnabled;
                btnAdmin.IsVisible = IsShellItemsEnabled;
                btnProfile.IsVisible = IsShellItemsEnabled;
                
            }
        }

        // Method to be called after successful login
        public void EnableShellItemsAfterLogin()
        {
            IsShellItemsEnabled = true;
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            EnableShellItemsAfterLogin();
            btnProfile.IsVisible = true;
        }
    }
}

