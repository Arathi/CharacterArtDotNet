using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace CharacterArtDotNet
{
    public partial class Form1 : Form
    {
        private ImageContainer ic = null;
        private Font font = null;
        private Image Transparent = null;

        public Form1()
        {
            InitializeComponent();
            Transparent = new Bitmap(pictureBoxBGColor.Width, pictureBoxBGColor.Height);
            Graphics g = Graphics.FromImage(Transparent);
            Pen pen = new Pen(Color.Red);
            g.DrawLine(pen, 0, 0, pictureBoxBGColor.Width - 1, pictureBoxBGColor.Height - 1);
            g.DrawLine(pen, 0, 1, pictureBoxBGColor.Width - 2, pictureBoxBGColor.Height - 1);
            g.DrawLine(pen, 1, 0, pictureBoxBGColor.Width - 1, pictureBoxBGColor.Height - 2);
            pictureBoxBGColor.Image = Transparent;
        }

        private void buttonSelectInputImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "请选取要打开的图片";
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                textBoxInputImage.Text = fileName;
            }
        }

        private void buttonOpenSrcImage_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBoxInputImage.Text) == false)
            {
                openFileDialog.Title = "请选取要打开的图片";
                openFileDialog.FileName = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxInputImage.Text = openFileDialog.FileName;
                }
                else
                {
                    return;
                }
            }
            int tileLenght = 0;
            if (numericUpDownTileLength.Value<0)
            {
                return;
            }
            else
            {
                tileLenght = (int) numericUpDownTileLength.Value;
            }
            string fileName = textBoxInputImage.Text;
            ic = new ImageContainer(fileName, tileLenght);
            ic.load();

            //TODO 显示图像信息
            string info = "";
            info = "Tile数量 " + ic.getSizeX() + "*" + ic.getSizeY()
                            + " 边角Tile " + ic.getRemainderX() + "/" + ic.getRemainderY();
            labelImageInfo.Text = info;
        }

        private void buttonOutputImage_Click(object sender, EventArgs e)
        {
            if (ic == null)
            {
                MessageBox.Show("源图未打开！", "错误");
                return;
            }
            if (textBoxOutputText.Text.Length <= 0)
            {
                MessageBox.Show("输出字符串为空！","错误");
                return;
            }
            if (numericUpDown1.Value < 0)
            {
                return;
            }
            int interval = 0;
            interval = (int)numericUpDown1.Value;
            ic.split();
            saveFileDialog.Title = "请选择保存路径";
            saveFileDialog.Filter = "PNG图片|*.png|GIF图片|*.gif|JPEG图片|*.jpg|Bitmap图片|*.bmp|TIFF图片|*.tiff";
            string savePath = "";
            string format = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                savePath = saveFileDialog.FileName;
                int dotIndex = savePath.LastIndexOf('.');
                if (dotIndex >= 0)
                {
                    format = savePath.Substring(dotIndex+1);
                }
            }
            Color bg = Color.Empty;
            if (pictureBoxBGColor.Image == null)
            {
                bg = pictureBoxBGColor.BackColor;
            }
            ic.saveImage(savePath, format, textBoxOutputText.Text, font, interval, bg);
            MessageBox.Show("处理完成！","提示");
        }

        private void buttonSelectFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog.Font;
                labelFontName.Text = font.Name;
                labelFontSize.Text = font.Size.ToString() + "号";
            }
        }

        private void pictureBoxBGColor_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse_e = (MouseEventArgs)e;
            if (mouse_e.Button == MouseButtons.Right)
            {
                //清除颜色
                pictureBoxBGColor.BackColor = Color.Empty;// System.Drawing.SystemColors.Control;
                pictureBoxBGColor.Image = Transparent;
            }
            else if (mouse_e.Button == MouseButtons.Left)
            {
                //设置颜色
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxBGColor.BackColor = colorDialog.Color;
                    pictureBoxBGColor.Image = null;
                }
            }
        }
    }
}
