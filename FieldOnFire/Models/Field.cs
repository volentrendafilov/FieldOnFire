using System;
using System.Collections.Generic;
using System.Text;

namespace FieldOnFire.Models
{
    public class Field
    {
        public int Width { get; private set; }

        public int Height { get; private set; }

        public int[,] Map { get; private set; }

        public int NumberOfFires { get; set; }

        public Field(int width, int height)
        {
            this.Width = width;
            this.Height = height;

            this.Map = new int[width, height];
        }

        public void CatchFire(List<int> fireCoordinates)
        {
            for (int i = 0; i < fireCoordinates.Count; i+=2)
            {

            }
        }
    }
}
