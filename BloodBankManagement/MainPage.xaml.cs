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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BloodBankManagement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public DonorManager donorList = new DonorManager();

        public DonorManager storedDonorList;

        public List<Donor> donors = new List<Donor>();


        public MainPage()
        {
            this.InitializeComponent();
            //donorList = new DonorManager();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

                storedDonorList = e.Parameter as DonorManager;

        }


        private void submitBtn_click(object sender, RoutedEventArgs e)
        {
            

            //create a new object with the parameters specified by the user
            Donor donor = new Donor()
            {
                Name = nameBox.Text,
                Age = ageBox.Text,
                BloodType = bloodTypeBox.Text,
            };

            if (donorList == null)
            {
                donorList.donors = storedDonorList.GetDonors();
            }

            donorList.AddDonor(donor);

            //add the object to the list since it is static the content the objects will remain the same    

        }

        private void nextPage_click(object sender, RoutedEventArgs e)
        {
            //if the next page is clicked it displays the list of donors 
            this.Frame.Navigate(typeof(DonorDisplay), donorList);
        }

        private void resetBtn_Click(object sender, RoutedEventArgs e)
        {
            //reset the values 
            donorList.ClearDonors();
        }
    }
}
