using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBankManagement.Model;
using System.Collections.ObjectModel;

namespace BloodBankManagement.Model
{
    public class Donor
    {
        public int DonorId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string BloodType { get; set; }

    }

    public class DonorManager
    {
        public List<Donor> donors = new List<Donor>();


        // A method that returns a list of donors 
        public List<Donor> AddDonor(Donor donor)
        {
            donors.Add(donor);
            return donors;
        }


        public List<Donor> GetDonors()
        {
            return donors;
        }

        public List<Donor> ClearDonors()
        {
            //clear all donors
            donors.Clear();
            return donors;
        }

    }
}
