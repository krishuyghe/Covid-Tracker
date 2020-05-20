﻿using SQLite;
using System;
using Xamarin.Forms;

namespace Todo
{
    public class TodoItem
    {
        private string _totalString;
      

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
            set { _totalString = SelectedTime + " " + Name + " " + FirstName; }
        }
    }
}

