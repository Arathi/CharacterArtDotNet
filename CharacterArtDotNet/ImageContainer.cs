using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CharacterArtDotNet
{
    class ImageContainer
    {
        protected Bitmap originImage;
        protected Bitmap[,] tiles;
        protected ColorTable colorMap;

        protected int sizeX, sizeY;
        protected int remainderX, remainderY;
        protected int tileLength;
        protected string path;
        
	    public ImageContainer(String path, int tileLength)
        {
			this.tileLength = tileLength;
            this.path = path;
	    }

        public void Dispose()
        {
            if (originImage != null)
            {
                originImage.Dispose();
            }
            int x, y;
            for (x = 0; x < sizeX; x++)
            {
                for (y = 0; y < sizeY; y++)
                {
                    if (tiles[x, y] != null)
                    {
                        tiles[x, y].Dispose();
                        tiles[x, y] = null;
                    }
                }
            }
        }

        public void load()
        {
            load(path, tileLength);
        }

        protected void load(string path, int tileLength)
        {
            originImage = (Bitmap)Image.FromFile(path, true);
            sizeX = originImage.Width / tileLength;
            sizeY = originImage.Height / tileLength;

            remainderX = originImage.Width % tileLength;
            remainderY = originImage.Height % tileLength;

            if (remainderX != 0)
            {
                sizeX++;
            }
            if (remainderY != 0)
            {
                sizeY++;
            }
            colorMap = new ColorTable(sizeX, sizeY);
            tiles = new Bitmap[sizeX, sizeY];
        }

        public int getSizeX()
        {
            return sizeX;
        }

        public int getSizeY()
        {
            return sizeY;
        }

        public int getRemainderX()
        {
            return remainderX;
        }

        public int getRemainderY()
        {
            return remainderY;
        }

        public void split()
        {
		    int x, y;
		    for (y=0; y<sizeY; y++){
			    int h = tileLength;
			    if (y==sizeY-1 && remainderY!=0){
				    h = remainderY;
			    }
			    for (x=0; x<sizeX; x++){
				    int startX = x*tileLength;
				    int startY = y*tileLength;
				    int w = tileLength;
				    if (x==sizeX-1 && remainderX!=0){
					    w = remainderX;
				    }
                    tiles[x, y] = new Bitmap(w, h);
                    Graphics.FromImage(tiles[x, y]).DrawImage(originImage, new Rectangle(0, 0, w, h), new Rectangle(startX, startY, w, h), GraphicsUnit.Pixel);
			    }
		    }
	    }

        public Color monocolour(Bitmap image)
        {
            Color color;
            int x, y;
            int sx = image.Width, sy = image.Height;
            int pixels = sx * sy;
            int sumR = 0, sumG = 0, sumB = 0;
            for (y = 0; y < sy; y++)
            {
                for (x = 0; x < sx; x++)
                {
                    Color colorInt = image.GetPixel(x, y);
                    int r = colorInt.R;
                    int g = colorInt.G;
                    int b = colorInt.B;
                    sumR += r;
                    sumG += g;
                    sumB += b;
                }
            }
            int avgR = sumR / pixels, avgG = sumG / pixels, avgB = sumB / pixels;
            color = Color.FromArgb(avgR, avgG, avgB);
            return color;
        }

        public void saveMosaic(String basePath)
        {
            Bitmap image = new Bitmap(sizeX * tileLength, sizeY * tileLength);
		    Graphics g = Graphics.FromImage(image);
		    int x, y;
		    for (y=0; y<sizeY; y++){
			    for (x=0; x<sizeX; x++){
                    Brush brush = new SolidBrush(monocolour(tiles[x,y]));
                    g.FillRectangle(brush, x * tileLength, y * tileLength, tileLength, tileLength);
			    }
		    }
            image.Save(basePath + "output.png", System.Drawing.Imaging.ImageFormat.Png);
	    }

        public void saveImage(string path, string formatStr, string str, Font font, int interval, Color bg)
        {
            if (font == null)
                font = new Font("simsun", 12);
            int tileSize = (int)font.Size + interval;
            Bitmap image = new Bitmap(sizeX * tileSize, sizeY * tileSize);
            Graphics g = Graphics.FromImage(image);
            if (bg != Color.Empty)
            {
                Brush brushBG = new SolidBrush(bg);
                g.FillRectangle(brushBG, 0, 0, sizeX * tileSize - 1, sizeY * tileSize - 1);
            }
            int strLength = str.Length;
            int x, y, counter = 0;
            for (y = 0; y < sizeY; y++)
            {
                for (x = 0; x < sizeX; x++)
                {
                    int dx = x * tileSize, dy = y * tileSize;
                    Brush brush = new SolidBrush(monocolour(tiles[x, y]));
                    PointF point = new PointF( (float)dx, (float)dy );
                    g.DrawString(str[counter % strLength] + "", font, brush, point);
                    counter++;
                }
            }
            System.Drawing.Imaging.ImageFormat format = null;
            string fs = formatStr.ToLower();
            switch (fs)
            {
                case "bmp":
                    format = System.Drawing.Imaging.ImageFormat.Bmp;
                    break;
                case "gif":
                    format = System.Drawing.Imaging.ImageFormat.Gif;
                    break;
                case "jpg":
                case "jpeg":
                    format = System.Drawing.Imaging.ImageFormat.Jpeg;
                    break;
                case "png":
                    format = System.Drawing.Imaging.ImageFormat.Png;
                    break;
                case "tif":
                case "tiff":
                    format = System.Drawing.Imaging.ImageFormat.Tiff;
                    break;
            }
            image.Save(path, format);
            image.Dispose();
        }

	    public void saveSplitedImages(string basePath)
        {
		    int x, y;
		    for (y=0; y<sizeY; y++)
            {
			    for (x=0; x<sizeX; x++)
                {
                    tiles[x, y].Save(basePath + x + "_" + y + ".png", System.Drawing.Imaging.ImageFormat.Png);
				}
			}
	    }
    }
}
