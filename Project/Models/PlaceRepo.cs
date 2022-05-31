using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    
   public class PlaceRepo
    {
        ObservableCollection<Places> place;
        public PlaceRepo()
        {
            this.place = new ObservableCollection<Places>()
            {
                new Places{Id=1, Name="Ghutia Mosque", Location="Barishal", Country="Bangladesh",PackageDate=new DateTime(2022,05,28), Picture="Assets/Barishal.jpg"},
                new Places{Id=2, Name="Cox's Bazar", Location="Chitagong", Country="Bangladesh", PackageDate=new DateTime(2022,05,30), Picture="Assets/coxbazar.jpg"},
                new Places{Id=3, Name="National Monument", Location="Dhaka", Country="Bangladesh", PackageDate=new DateTime(2022,06,03), Picture="Assets/Nationalmonument.jpg"},
                new Places{Id=4, Name="Sajek Valley", Location="Rangamati", Country="Bangladesh", PackageDate=new DateTime(2022,06,06), Picture="Assets/sajekvalley.jpg"},
                new Places{Id=5, Name="Sundarban", Location="Khulna", Country="Bangladesh", PackageDate=new DateTime(2022,06,10), Picture="Assets/sundarban.jpg"},
                new Places{Id=6, Name="Bichana Kandi", Location="Sylhet", Country="Bangladesh", PackageDate=new DateTime(2022,06,13), Picture="Assets/sylhetbd.jpg"},
                new Places{Id=7, Name="Ahsan Manzil", Location="Dhaka", Country="Bangladesh",PackageDate=new DateTime(2022,06,17), Picture="Assets/AhsanManzil.jpg"},
                new Places{Id=8, Name="Chhera Dhip", Location="Saint Martin", Country="Bangladesh", PackageDate=new DateTime(2022,06,20), Picture="Assets/ChheraDwip.jpg"},
                new Places{Id=9, Name="Tanguar Haor", Location="Sunamganj", Country="Bangladesh", PackageDate=new DateTime(2022,06,23), Picture="Assets/TanguarHaor.jpg"},
                new Places{Id=10, Name="National Zoo", Location="Dhaka", Country="Bangladesh", PackageDate=new DateTime(2022,06,26), Picture="Assets/NationalZoo.jpg"},
                new Places{Id=11, Name="Saint Martin", Location="Cox's Bazar", Country="Bangladesh", PackageDate=new DateTime(2022,06,28), Picture="Assets/Senmartin.jpg"},
                new Places{Id=12, Name="Sitakunda", Location="Chittagong", Country="Bangladesh", PackageDate=new DateTime(2022,06,30), Picture="Assets/sitakund.jpg"}
            };
        }
        public ObservableCollection<Places> Get()
        {
            return this.place;
        }
        public Places Get(int id)
        {
            return this.place.FirstOrDefault(t => t.Id == id);
        }

    }
}
