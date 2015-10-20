using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace FinalProject_0._0
{
    
    /**public partial class BufferPanel : Panel
    {
        public BufferPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
    }
     */
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.DoubleBuffer, true);

            SetStyle(ControlStyles.ResizeRedraw, true);

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            SetStyle(ControlStyles.UserPaint, true);


        }

        int originalExStyle = -1;
    bool enableFormLevelDoubleBuffering = true;

    protected override CreateParams CreateParams
    {
        get
        {
            if (originalExStyle == -1)
                originalExStyle = base.CreateParams.ExStyle;

            CreateParams cp = base.CreateParams;
            if (enableFormLevelDoubleBuffering)
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
            else
                cp.ExStyle = originalExStyle;

            return cp;
        }
    }

    public void TurnOffFormLevelDoubleBuffering()
    {
        enableFormLevelDoubleBuffering = false;
        this.MaximizeBox = true;
    }


        private bool mouse_down = false;
        private Color col = Color.Black;
        private int brush_size = 2;
        private int shape = 0;
        private Point p_start, p_end;
        private Bitmap image;
       
        private void Form1_Load(object sender, EventArgs e)
        {
            image = new Bitmap(drawingPanel.ClientSize.Width, drawingPanel.ClientSize.Height, PixelFormat.Format32bppArgb);
        }

        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
             
            if (e.Button == MouseButtons.Left)
            {
                //Graphics graphic = drawingPanel.CreateGraphics();
                Graphics graphic = Graphics.FromImage(image); 
                mouse_down = true;
                p_start = e.Location;
                int brush_x, brush_y;
                switch (shape)
                {
                    case 0:
                        brush_x = e.X - brush_size / 2;
                        brush_y = e.Y - brush_size / 2;
                        //graphic= this.CreateGraphics();
                        //graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        graphic.DrawLine(new Pen(new SolidBrush(col), brush_size), p_start, p_start);
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        brush_x = e.X - brush_size / 2;
                        brush_y = e.Y - brush_size / 2;
                        //graphic= this.CreateGraphics();
                        //graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        graphic.DrawLine(new Pen(new SolidBrush(Color.White), brush_size), p_start, p_start);
                        break;
                }
            }
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_down = false;
                p_end = e.Location;
                //Graphics graphic = drawingPanel.CreateGraphics();
                Graphics graphic = Graphics.FromImage(image);
                switch (shape)
                {
                    case 0:
                        break;
                    case 1:
                        graphic.DrawLine(new Pen(col, brush_size), p_start, p_end);
                        break;
                    case 2:
                        int oval_x, oval_y, oval_h, oval_w;
                        oval_x = Math.Min(p_start.X, p_end.X);
                        oval_y = Math.Min(p_start.Y, p_end.Y);
                        oval_h = Math.Abs(p_start.Y - p_end.Y);
                        oval_w = Math.Abs(p_start.X - p_end.X);
                        if (checkBox_Filled.Checked)
                            graphic.FillEllipse(new SolidBrush(col), oval_x, oval_y, oval_w, oval_h);
                        else
                            graphic.DrawEllipse(new Pen(col, brush_size), oval_x, oval_y, oval_w, oval_h);
                        break;
                    case 3:
                        int rect_x, rect_y, rect_h, rect_w;
                        rect_x = Math.Min(p_start.X, p_end.X);
                        rect_y = Math.Min(p_start.Y, p_end.Y);
                        rect_h = Math.Abs(p_start.Y - p_end.Y);
                        rect_w = Math.Abs(p_start.X - p_end.X);
                        if (checkBox_Filled.Checked)
                            graphic.FillRectangle(new SolidBrush(col), rect_x, rect_y, rect_w, rect_h);
                        else
                            graphic.DrawRectangle(new Pen(col, brush_size), rect_x, rect_y, rect_w, rect_h);
                        break;
                    case 4:
                        break;
                }
                drawingPanel.Invalidate();
            }
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            positionLabel.Text = e.X + "," + e.Y;
            //Graphics graphic = drawingPanel.CreateGraphics();
            Graphics graphic = Graphics.FromImage(image);
            Graphics graphicBuffer = drawingPanel.CreateGraphics();
            if (mouse_down == true)
            {
                p_end = e.Location;
                int brush_x, brush_y;
                switch (shape)
                {
                    case 0:
                        brush_x = e.X - brush_size / 2;
                        brush_y = e.Y - brush_size / 2;
                        graphic.DrawLine(new Pen(new SolidBrush(col), brush_size), p_start, p_end);
                        graphicBuffer.DrawLine(new Pen(new SolidBrush(col), brush_size), p_start, p_end);
                        p_start = p_end;
                        //drawingPanel.Invalidate();
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        brush_x = e.X - brush_size / 2;
                        brush_y = e.Y - brush_size / 2;
                        graphic.DrawLine(new Pen(new SolidBrush(Color.White), brush_size), p_start, p_end);
                        graphicBuffer.DrawLine(new Pen(new SolidBrush(Color.White), brush_size), p_start, p_end);
                        p_start = p_end;
                        //drawingPanel.Invalidate();
                        break;
                }
                
            }
        }

        private void colourButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            col = colorDialog1.Color;
            colourButton.BackColor = col;
        }

        private void Button_Pencil_Click(object sender, EventArgs e)
        {
            shape = 0;
            Button_Pencil.Checked = true;
            Button_Line.Checked = false;
            Button_Oval.Checked = false;
            Button_Rectangle.Checked = false;
            Button_Eraser.Checked = false;
            checkBox_Filled.Checked = false;
            checkBox_Filled.Enabled = false;
        }

        private void Button_Line_Click(object sender, EventArgs e)
        {
            shape = 1;
            Button_Pencil.Checked = false;
            Button_Line.Checked = true;
            Button_Oval.Checked = false;
            Button_Rectangle.Checked = false;
            Button_Eraser.Checked = false;
            checkBox_Filled.Checked = false;
            checkBox_Filled.Enabled = false;
        }

        private void Button_Oval_Click(object sender, EventArgs e)
        {
            shape = 2;
            Button_Pencil.Checked = false;
            Button_Line.Checked = false;
            Button_Oval.Checked = true;
            Button_Rectangle.Checked = false;
            Button_Eraser.Checked = false;
            checkBox_Filled.Checked = false;
            checkBox_Filled.Enabled = true;
        }

        private void Button_Rectangle_Click(object sender, EventArgs e)
        {
            shape = 3;
            Button_Pencil.Checked = false;
            Button_Line.Checked = false;
            Button_Oval.Checked = false;
            Button_Rectangle.Checked = true;
            Button_Eraser.Checked = false;
            checkBox_Filled.Checked = false;
            checkBox_Filled.Enabled = true;
        }

        private void Brushsize_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Brushsize_Box_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Brushsize_Box_TextChanged(object sender, EventArgs e)
        {
            try
            {
                brush_size = Convert.ToInt32(Brushsize_Box.Text);
            }
            catch
            {
                Brushsize_Box.Text = Convert.ToString(brush_size);
            }
            if (brush_size < 2)
            {
                brush_size = 2;
                Brushsize_Box.Text = "2";
            }
            else if (brush_size > 72)
            {
                brush_size = 72;
                Brushsize_Box.Text = "72";
            }
        }

        private void colourButton_Red_Click(object sender, EventArgs e)
        {
            col = colourButton_Red.BackColor ;
            colourButton.BackColor = col;
        }

        private void colourButton_Orange_Click(object sender, EventArgs e)
        {
            col = colourButton_Orange.BackColor;
            colourButton.BackColor = col;
        }

        private void colourButton_Green_Click(object sender, EventArgs e)
        {
            col = colourButton_Green.BackColor;
            colourButton.BackColor = col;
        }

        private void colourButton_Cyan_Click(object sender, EventArgs e)
        {
            col = colourButton_Cyan.BackColor;
            colourButton.BackColor = col;
        }

        private void colourButton_Blue_Click(object sender, EventArgs e)
        {
            col = colourButton_Blue.BackColor;
            colourButton.BackColor = col;
        }

        private void colourButton_Purple_Click(object sender, EventArgs e)
        {
            col = colourButton_Purple.BackColor;
            colourButton.BackColor = col;
        }

        private void colourButton_Black_Click(object sender, EventArgs e)
        {
            col = colourButton_Black.BackColor;
            colourButton.BackColor = col;
        }

        private void colourButton_White_Click(object sender, EventArgs e)
        {
            col = colourButton_White.BackColor;
            colourButton.BackColor = col;
        }

        private void Button_Eraser_Click(object sender, EventArgs e)
        {
            shape = 4;
            brush_size = 10;
            Brushsize_Box.Text = "10";
            Button_Pencil.Checked = false;
            Button_Line.Checked = false;
            Button_Oval.Checked = false;
            Button_Rectangle.Checked = false;
            Button_Eraser.Checked = true;
            checkBox_Filled.Checked = false;
            checkBox_Filled.Enabled = false;
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear everything? You will not be able to recover the work after clearing.", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                drawingPanel.Invalidate();
                image = new Bitmap(drawingPanel.ClientSize.Width, drawingPanel.ClientSize.Height, PixelFormat.Format32bppArgb);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
           
            

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                drawingPanel.DrawToBitmap(image, drawingPanel.ClientRectangle);
                image.Save(fs, ImageFormat.Bmp);
                fs.Close();
            }
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project is made by Avi, Yu and Maulik. This is a simple application which allows user to create some shapes with different colors and save it as a bmp file.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static Bitmap Resize(Image image, int width, int height, bool keepAspectRatio, bool enlargeSmallerImages)
        {
            if (!enlargeSmallerImages && image.Width <= width && image.Height <= height)
            {
                return new Bitmap(image);
            }
            if (!keepAspectRatio)
            {
                return new Bitmap(image, width, height);
            }
            else
            {
                double aspectRatio = image.Width / (double)image.Height;
                double newAspectRatio = width / height;

                if (aspectRatio >= newAspectRatio) //fit horizontally
                {
                    double scale = image.Width / (double)width;
                    int newHeight = (int)(image.Height / scale);
                    return new Bitmap(image, width, newHeight);
                }
                else //fit vertically
                {
                    double scale = image.Height / (double)height;
                    int newWidth = (int)(image.Width / scale);
                    return new Bitmap(image, newWidth, height);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Graphics graphic = Graphics.FromImage(image);
                    System.Drawing.Image loadImage = new Bitmap(open.FileName);
                    if ((loadImage.Width>drawingPanel.Width) || (loadImage.Height>drawingPanel.Height)){
                        DialogResult result = MessageBox.Show("The file is too large. Do you want to resize the image to fit the window?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            Variables.enlargeSmallerImages = false;
                            Form2 f2 = new Form2();
                            f2.ShowDialog();
                            loadImage = Resize(loadImage, drawingPanel.Width, drawingPanel.Height, Variables.keepAspectRatio, Variables.enlargeSmallerImages);
                        }
                        
                    }
                    else if ((loadImage.Width < drawingPanel.Width) && (loadImage.Height < drawingPanel.Height))
                    {
                        DialogResult result = MessageBox.Show("The file is too small. Do you want to resize the image to fit the window?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            Variables.enlargeSmallerImages = true;
                            Form2 f2 = new Form2();
                            f2.ShowDialog();
                            loadImage = Resize(loadImage, drawingPanel.Width, drawingPanel.Height, Variables.keepAspectRatio, Variables.enlargeSmallerImages);
                        }

                    }
                    // Create rectangle for displaying image.
                    Rectangle destRect = new Rectangle(0, 0, drawingPanel.Width, drawingPanel.Height);

                    // Create rectangle for source image.
                    Rectangle srcRect = new Rectangle(0, 0, Math.Min(loadImage.Width, drawingPanel.Width), Math.Min(loadImage.Height, drawingPanel.Height));
                    GraphicsUnit units = GraphicsUnit.Pixel;

                    // Draw image to screen.
                    graphic.DrawImage(loadImage, destRect, srcRect, units);
                    drawingPanel.Invalidate();
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
            
        }


        /*
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            
        }
         */
    }
}
