//Author: Josh Werlein
//Purpose: Create an application with 3 classes of Philospher Dog and Car
//Date: 9/20/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhilosopherDogCar_List
{
    internal class Philosopher
    {
        //Define Class level Variables
        private string mName;
        private string mQuote;
        private DateTime mDate;

        public string Name
        { get { return mName; } set { mName = value; } }
        public string Quote
        { get { return mQuote; } set { mQuote = value; } }
        public DateTime Date
        { get { return mDate; } set { mDate = value; } }

        //Default constructor
        public Philosopher()
        {
            mName = string.Empty;
            mQuote = string.Empty;
        }

        //Overload constructor
        public Philosopher(string Name)
        {
            mName = Name;
            mQuote = string.Empty;
        }

        //Method to display the philosopher's quote in a message box
        public string Philosophize()
        {
            return mName + " is famous for saying " + mQuote + " on " + mDate.ToString("d");
        }
    }
}   



