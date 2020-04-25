using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Box
    {
        // member variable
        private int length;
        private int height;
        //public int width;
        private int volume;

        public int Width { get; set; }
        public int Volume
        { 
            get
            {
                return this.length*this.height*this.Width;
            }

        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)
                {
                    height = -value;
                }
                height = value;

            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }
        public int GetLength()
        {
            return this.length;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, and Height is {1}, and Width is {2}, and Volume is {3}", height, length, Width, volume = height*length*Width);
        }


        /*public int GetVolume()
        {
            return this.length * this.width * this.height;
        }
        */

        public int FrontSurface
        {
            get
            {
                return this.length * this.Width;
            }
        }
    }
}
