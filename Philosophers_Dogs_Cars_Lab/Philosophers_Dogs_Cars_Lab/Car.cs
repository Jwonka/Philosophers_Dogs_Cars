//Author: Josh Werlein
//Purpose: Create an application with 3 classes of Philospher Dog and Car
//Date: 9/20/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PhilosopherDogCar_List
{
    internal class Car
    {
        //Define Class level Variables
        private string mMake;
        private string mModel;
        private string mColor;

        public string Make 
            { get { return mMake; } set {  mMake = value; } }
        public string Model 
            { get {  return mModel; } set { mModel = value; } }
        public string Color
            { get { return mColor; } set { mColor = value; } }

        //Default constructor
        public Car() 
        { 
            mMake = string.Empty;
            mModel = string.Empty;
            mColor = string.Empty;
        }

        //Overload constructor
        public Car(string Make)
        {
            mMake = Make;
            mModel = string.Empty;
            mColor = string.Empty;
        }

        //Method
        public string GetCarDescription()
        {
            return "The car is a " + mColor + " " + Make + " " + mModel;
        }
    }
}
