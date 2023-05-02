using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_Babcock_Olivia
{   // Creates a class
    class Car
    
    {/// <summary>
    /// Creates setter and getter for the model property
    /// </summary>
        private string model;

        public string Model { get { return model; } set { model = value; } }

        public string Make { get; set; }



    }
}
