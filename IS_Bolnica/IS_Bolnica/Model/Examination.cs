using System;
using System.ComponentModel;

namespace Model
{
    public class Examination
    {
        public int DurationInMinutes { get; set; }
        public DateTime Date { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Secretary Secretary { get; set; }
        public Room Room { get; set; }
        public GuestUser GuestUser { get; set; }
        public DateTime PostponedDate { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        public Boolean Paying()
        {
            throw new NotImplementedException();
        }

        public Boolean Scheduling()
        {
            throw new NotImplementedException();
        }

        public Boolean Rescheduling(DateTime oldDate, DateTime newDate)
        {
            throw new NotImplementedException();
        }
    }


}
