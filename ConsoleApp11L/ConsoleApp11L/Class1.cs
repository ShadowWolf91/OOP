using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11L
{
    class Citizen
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
    class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
    public class Airline
    {
        private string placefrom;
        private string placein;
        private string aviacompany;
        private uint number;
        private string type;
        private string timedeparture;
        private string timearrival;
        private uint day;
        private string dayinweek;
        private string deley;

        public Airline(string placefrom, string placein, string aviacompany, uint number, string type, string timedeparture, string timearrival, uint day, string dayinweek, string deley)
        {
            this.placefrom = placefrom;
            this.placein = placein;
            this.aviacompany = aviacompany;
            this.number = number;
            this.type = type;
            this.timedeparture = timedeparture;
            this.timearrival = timearrival;
            this.day = day;
            this.dayinweek = dayinweek;
            this.deley = deley;
        }

        public string PlaceFrom
        {
            get { return placefrom; }
            set { placefrom = value; }
        }


        public string PlaceIn
        {
            get { return placein; }
            set { placein = value; }
        }

        public string AviaCompany
        {
            get { return aviacompany; }
            set { aviacompany = value; }
        }

        public uint Number
        {

            get { return number; }
            set { number = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string TimeDeparture
        {
            get { return timedeparture; }
            set { timedeparture = value; }
        }

        public string TimeArrival
        {
            get { return timearrival; }
            set { timearrival = value; }
        }

        public uint Day
        {
            get { return day; }
            set 
            {
                if (day <= 31)
                    day = value;
                else day = 0;
            }
        }
        
        public string DayInWeek
        {
            get { return dayinweek; }
            set { dayinweek = value; }
        }

        public string Deley
        {
            get { return deley; }
            set { deley = value; }
        }
    }
}
