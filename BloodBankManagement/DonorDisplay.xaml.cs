using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using BloodBankManagement.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BloodBankManagement
{

    
    public sealed partial class DonorDisplay : Page
    {
        //Create a local variable
        private List<Donor> Donors;
        private DonorManager donorList;

        public DonorDisplay()
        {
            this.InitializeComponent();
            //initialize the new donor list

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //pass the object from the mainpage 
            donorList = e.Parameter as DonorManager;
            Donors = donorList.GetDonors();
        }


        private void goBack_click(object sender, RoutedEventArgs e)
        {
            // take the data stored in the list and make it usable in the mainpage 
            this.Frame.Navigate(typeof(MainPage));
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
