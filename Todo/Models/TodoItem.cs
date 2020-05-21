using SQLite;
using System;
using Xamarin.Forms;

namespace Todo
{
    public class TodoItem
    {
        private string _totalString;
        private string _outputData;

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }

        public bool Done { get; set; }
        public DateTime SelectedTime { get; set; }
       
        public bool HouseMember { get; set; }
        public bool Lover { get; set; }
        public bool Classmate { get; set; }
        public bool Colleague { get; set; }
        public bool SameTransport { get; set; }
        public bool OtherContact { get; set; }
        public bool NearContact { get; set; }
        public bool LongContact { get; set; }
        public bool CloseContact { get; set; }
        public bool MedicalProfessional { get; set; }
        public string TotalString
        {
           get => _totalString;
            set { _totalString = SelectedTime.ToString("dd-MM-yyyy") + " " + Name + " " + FirstName; }
        }
        public string OutputData
        {
            get => _outputData;
            set {
                _outputData = SelectedTime.ToString("dd-MM-yyyy") + " Naam:" + Name + " Voornaam" + FirstName + " Telefoon:" + Phone
                  + " Adres:" + Adress + " Huisgenoot:" + HouseMember + " Lief/partner:" + Lover + " Klasgenoot:" + Classmate + " Collega:" + Colleague
                  + " Zelfde Transport:" + SameTransport + "Ander Contact:" + OtherContact + " < 1.5 meter:" + NearContact + " > 15 min:" + LongContact 
                  + " Fysiek Contact:" + CloseContact + " Medisch Professional:" + MedicalProfessional + " Nog opmerkingen:" + Notes +
                  "\n"

              ;
            }
        }
    }
}


