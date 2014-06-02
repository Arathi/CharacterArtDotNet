namespace CharacterArtDotNet
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxInputImage = new System.Windows.Forms.TextBox();
            this.buttonSelectInputImage = new System.Windows.Forms.Button();
            this.numericUpDownTileLength = new System.Windows.Forms.NumericUpDown();
            this.buttonOpenSrcImage = new System.Windows.Forms.Button();
            this.labelImageInfo = new System.Windows.Forms.Label();
            this.buttonOutputImage = new System.Windows.Forms.Button();
            this.buttonBatch = new System.Windows.Forms.Button();
            this.textBoxOutputText = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFontName = new System.Windows.Forms.Label();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.buttonSelectFont = new System.Windows.Forms.Button();
            this.pictureBoxBGColor = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBGColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入图片";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "图块边长";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "图片信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "输出文本";
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(11, 132);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(77, 12);
            this.labelFont.TabIndex = 4;
            this.labelFont.Text = "输出字符间隔";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // textBoxInputImage
            // 
            this.textBoxInputImage.Location = new System.Drawing.Point(71, 9);
            this.textBoxInputImage.Name = "textBoxInputImage";
            this.textBoxInputImage.Size = new System.Drawing.Size(238, 21);
            this.textBoxInputImage.TabIndex = 5;
            // 
            // buttonSelectInputImage
            // 
            this.buttonSelectInputImage.Location = new System.Drawing.Point(315, 7);
            this.buttonSelectInputImage.Name = "buttonSelectInputImage";
            this.buttonSelectInputImage.Size = new System.Drawing.Size(37, 23);
            this.buttonSelectInputImage.TabIndex = 6;
            this.buttonSelectInputImage.Text = "...";
            this.buttonSelectInputImage.UseVisualStyleBackColor = true;
            this.buttonSelectInputImage.Click += new System.EventHandler(this.buttonSelectInputImage_Click);
            // 
            // numericUpDownTileLength
            // 
            this.numericUpDownTileLength.Location = new System.Drawing.Point(71, 40);
            this.numericUpDownTileLength.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownTileLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTileLength.Name = "numericUpDownTileLength";
            this.numericUpDownTileLength.Size = new System.Drawing.Size(63, 21);
            this.numericUpDownTileLength.TabIndex = 8;
            this.numericUpDownTileLength.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonOpenSrcImage
            // 
            this.buttonOpenSrcImage.Location = new System.Drawing.Point(276, 40);
            this.buttonOpenSrcImage.Name = "buttonOpenSrcImage";
            this.buttonOpenSrcImage.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenSrcImage.TabIndex = 9;
            this.buttonOpenSrcImage.Text = "打开源图";
            this.buttonOpenSrcImage.UseVisualStyleBackColor = true;
            this.buttonOpenSrcImage.Click += new System.EventHandler(this.buttonOpenSrcImage_Click);
            // 
            // labelImageInfo
            // 
            this.labelImageInfo.AutoSize = true;
            this.labelImageInfo.Location = new System.Drawing.Point(74, 72);
            this.labelImageInfo.Name = "labelImageInfo";
            this.labelImageInfo.Size = new System.Drawing.Size(0, 12);
            this.labelImageInfo.TabIndex = 10;
            // 
            // buttonOutputImage
            // 
            this.buttonOutputImage.Location = new System.Drawing.Point(277, 186);
            this.buttonOutputImage.Name = "buttonOutputImage";
            this.buttonOutputImage.Size = new System.Drawing.Size(75, 23);
            this.buttonOutputImage.TabIndex = 11;
            this.buttonOutputImage.Text = "输出图片";
            this.buttonOutputImage.UseVisualStyleBackColor = true;
            this.buttonOutputImage.Click += new System.EventHandler(this.buttonOutputImage_Click);
            // 
            // buttonBatch
            // 
            this.buttonBatch.Location = new System.Drawing.Point(195, 186);
            this.buttonBatch.Name = "buttonBatch";
            this.buttonBatch.Size = new System.Drawing.Size(75, 23);
            this.buttonBatch.TabIndex = 12;
            this.buttonBatch.Text = "批量处理";
            this.buttonBatch.UseVisualStyleBackColor = true;
            this.buttonBatch.Click += new System.EventHandler(this.buttonBatch_Click);
            // 
            // textBoxOutputText
            // 
            this.textBoxOutputText.Location = new System.Drawing.Point(71, 99);
            this.textBoxOutputText.Name = "textBoxOutputText";
            this.textBoxOutputText.Size = new System.Drawing.Size(280, 21);
            this.textBoxOutputText.TabIndex = 14;
            this.textBoxOutputText.Text = "输出文本";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(94, 130);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 21);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "输出字符字体";
            // 
            // labelFontName
            // 
            this.labelFontName.AutoSize = true;
            this.labelFontName.Location = new System.Drawing.Point(105, 162);
            this.labelFontName.Name = "labelFontName";
            this.labelFontName.Size = new System.Drawing.Size(29, 12);
            this.labelFontName.TabIndex = 17;
            this.labelFontName.Text = "字体";
            // 
            // labelFontSize
            // 
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Location = new System.Drawing.Point(193, 162);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(29, 12);
            this.labelFontSize.TabIndex = 18;
            this.labelFontSize.Text = "12号";
            // 
            // buttonSelectFont
            // 
            this.buttonSelectFont.Location = new System.Drawing.Point(277, 157);
            this.buttonSelectFont.Name = "buttonSelectFont";
            this.buttonSelectFont.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFont.TabIndex = 19;
            this.buttonSelectFont.Text = "选择字体";
            this.buttonSelectFont.UseVisualStyleBackColor = true;
            this.buttonSelectFont.Click += new System.EventHandler(this.buttonSelectFont_Click);
            // 
            // pictureBoxBGColor
            // 
            this.pictureBoxBGColor.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxBGColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBGColor.Location = new System.Drawing.Point(315, 131);
            this.pictureBoxBGColor.Name = "pictureBoxBGColor";
            this.pictureBoxBGColor.Size = new System.Drawing.Size(36, 19);
            this.pictureBoxBGColor.TabIndex = 20;
            this.pictureBoxBGColor.TabStop = false;
            this.pictureBoxBGColor.Click += new System.EventHandler(this.pictureBoxBGColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "背景颜色";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 215);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxBGColor);
            this.Controls.Add(this.buttonSelectFont);
            this.Controls.Add(this.labelFontSize);
            this.Controls.Add(this.labelFontName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxOutputText);
            this.Controls.Add(this.buttonBatch);
            this.Controls.Add(this.buttonOutputImage);
            this.Controls.Add(this.labelImageInfo);
            this.Controls.Add(this.buttonOpenSrcImage);
            this.Controls.Add(this.numericUpDownTileLength);
            this.Controls.Add(this.buttonSelectInputImage);
            this.Controls.Add(this.textBoxInputImage);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CharacterArt.NET";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBGColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox textBoxInputImage;
        private System.Windows.Forms.Button buttonSelectInputImage;
        private System.Windows.Forms.NumericUpDown numericUpDownTileLength;
        private System.Windows.Forms.Button buttonOpenSrcImage;
        private System.Windows.Forms.Label labelImageInfo;
        private System.Windows.Forms.Button buttonOutputImage;
        private System.Windows.Forms.Button buttonBatch;
        private System.Windows.Forms.TextBox textBoxOutputText;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFontName;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.Button buttonSelectFont;
        private System.Windows.Forms.PictureBox pictureBoxBGColor;
        private System.Windows.Forms.Label label5;
    }
}

