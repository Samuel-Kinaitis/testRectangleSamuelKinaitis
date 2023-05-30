using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testRectangleSamuelKinaitis
{
    internal class Rectangle
    {//variables and set
        private float length = 1;
        public float width = 1;

        //constructor
        public Rectangle(float length, float width)
        {
            Length = length;
            Width = width;
        }

        //checking to make sure length is between 0 and 20
        public float Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0.0f || value > 20.0f)
                {
                    this.length = 1.0f;
                }
                else
                {
                    this.length = value;
                }
            }
            

        }
        //checking to make sure width is between 0 and 20
        public float Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0.0f || value > 20.0f)
                {
                    this.width = 1.0f;
                }
                else
                {
                    this.width = value;
                }
            }
        }
            //Gets perimeter from length and width
            public float Perimeter
        {
            get 
            {
                return (length + width)*2;
            }
        }
        //Times length and width to get Area
        public float Area
        {
            get
            {
                return (length * width);
            }
        }
        //returns length, width, perimeter, and area.
        public override string ToString()
        {
            return string.Format("Perimeter of the {0:F2} by {1:F2} rectangle is {2:F2} and the area is {3:F2}", length, width, Perimeter, Area);
        }
    }
}
