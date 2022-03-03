using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPart1
{
    internal class Box
    {
        // member variables
        private int length;
        private int height;
        private int width;
        private int volume;
        private int frontSurface;

        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
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

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public void setVolume(int volume)
        {
            this.volume = volume;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        // read - only : getters
        public int GetFrontSurface()
        {
            return this.length * this.height;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", 
                length, height, width, this.GetVolume());
        }
    }
}
