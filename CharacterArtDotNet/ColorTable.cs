using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CharacterArtDotNet
{
    class ColorTable
    {
        protected int sizeX;
        protected int sizeY;
        protected Color[,] colors;

        public ColorTable(int x, int y)
        {
            init(x, y);
        }

        private void init(int x, int y){
		    if (x<=0 || y<=0) return;
		    sizeX = x;
		    sizeY = y;
		    colors = new Color[sizeX,sizeY];
	    }

        public bool setColor(int x, int y, Color c)
        {
            if (x >= 0 && x < sizeX && y >= 0 && y < sizeY)
            {
                colors[x,y] = c;
                return true;
            }
            return false;
        }
    }
    
}
