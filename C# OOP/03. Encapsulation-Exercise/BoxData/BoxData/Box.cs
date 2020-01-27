using System;
using System.Collections.Generic;
using System.Text;

namespace BoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                if (value > 0)
                {
                    this.length = value;
                }
                else
                {
                    throw new Exception($"Length cannot be zero or negative.");
                }
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new Exception($"Height cannot be zero or negative.");
                }
            }
        }

        public double Area()
        {
            // Surface Area = 2lw + 2lh + 2wh
            double result = 2 * (this.Length * this.Width + this.Length * this.Height + this.Width * this.Height);
            return result;
        }

        public double LateralArea()
        {
            // Lateral Surface Area = 2lh + 2wh
            double result = 2 * (this.Length * this.Height + this.Width * this.Height);
            return result;
        }

        public double Volume()
        {
            // Volume = lwh
            double result = this.Length * this.Width * this.Height;
            return result;
        }

    }
}
