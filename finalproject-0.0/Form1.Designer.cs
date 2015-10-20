namespace FinalProject_0._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Filled = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Button_Pencil = new System.Windows.Forms.ToolStripButton();
            this.Button_Line = new System.Windows.Forms.ToolStripButton();
            this.Button_Oval = new System.Windows.Forms.ToolStripButton();
            this.Button_Rectangle = new System.Windows.Forms.ToolStripButton();
            this.Button_Eraser = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colourButton_Cyan = new System.Windows.Forms.Button();
            this.colourButton_White = new System.Windows.Forms.Button();
            this.colourButton_Black = new System.Windows.Forms.Button();
            this.colourButton_Blue = new System.Windows.Forms.Button();
            this.colourButton_Purple = new System.Windows.Forms.Button();
            this.colourButton_Green = new System.Windows.Forms.Button();
            this.colourButton_Orange = new System.Windows.Forms.Button();
            this.colourButton_Red = new System.Windows.Forms.Button();
            this.colourButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Brushsize_Box = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.positionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.existToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.toolStripMenuItem1.Text = "&Files";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // existToolStripMenuItem
            // 
            this.existToolStripMenuItem.Name = "existToolStripMenuItem";
            this.existToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.existToolStripMenuItem.Text = "Exist";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem2.Text = "About";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Filled);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(77, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // checkBox_Filled
            // 
            this.checkBox_Filled.AutoSize = true;
            this.checkBox_Filled.Enabled = false;
            this.checkBox_Filled.Location = new System.Drawing.Point(14, 137);
            this.checkBox_Filled.Name = "checkBox_Filled";
            this.checkBox_Filled.Size = new System.Drawing.Size(50, 17);
            this.checkBox_Filled.TabIndex = 1;
            this.checkBox_Filled.Text = "Filled";
            this.checkBox_Filled.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Pencil,
            this.Button_Line,
            this.Button_Oval,
            this.Button_Rectangle,
            this.Button_Eraser});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(71, 118);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // Button_Pencil
            // 
            this.Button_Pencil.AutoSize = false;
            this.Button_Pencil.Checked = true;
            this.Button_Pencil.CheckOnClick = true;
            this.Button_Pencil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Button_Pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Pencil.Image = ((System.Drawing.Image)(resources.GetObject("Button_Pencil.Image")));
            this.Button_Pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Pencil.Name = "Button_Pencil";
            this.Button_Pencil.Size = new System.Drawing.Size(35, 35);
            this.Button_Pencil.Text = "toolStripButton4";
            this.Button_Pencil.Click += new System.EventHandler(this.Button_Pencil_Click);
            // 
            // Button_Line
            // 
            this.Button_Line.AutoSize = false;
            this.Button_Line.CheckOnClick = true;
            this.Button_Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Line.Image = ((System.Drawing.Image)(resources.GetObject("Button_Line.Image")));
            this.Button_Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Line.Name = "Button_Line";
            this.Button_Line.Size = new System.Drawing.Size(35, 35);
            this.Button_Line.Text = "toolStripButton1";
            this.Button_Line.Click += new System.EventHandler(this.Button_Line_Click);
            // 
            // Button_Oval
            // 
            this.Button_Oval.AutoSize = false;
            this.Button_Oval.CheckOnClick = true;
            this.Button_Oval.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Oval.Image = ((System.Drawing.Image)(resources.GetObject("Button_Oval.Image")));
            this.Button_Oval.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Oval.Name = "Button_Oval";
            this.Button_Oval.Size = new System.Drawing.Size(35, 35);
            this.Button_Oval.Text = "toolStripButton2";
            this.Button_Oval.Click += new System.EventHandler(this.Button_Oval_Click);
            // 
            // Button_Rectangle
            // 
            this.Button_Rectangle.AutoSize = false;
            this.Button_Rectangle.CheckOnClick = true;
            this.Button_Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Button_Rectangle.Image")));
            this.Button_Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Rectangle.Name = "Button_Rectangle";
            this.Button_Rectangle.Size = new System.Drawing.Size(35, 35);
            this.Button_Rectangle.Text = "toolStripButton3";
            this.Button_Rectangle.Click += new System.EventHandler(this.Button_Rectangle_Click);
            // 
            // Button_Eraser
            // 
            this.Button_Eraser.AutoSize = false;
            this.Button_Eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Eraser.Image = ((System.Drawing.Image)(resources.GetObject("Button_Eraser.Image")));
            this.Button_Eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Eraser.Name = "Button_Eraser";
            this.Button_Eraser.Size = new System.Drawing.Size(35, 35);
            this.Button_Eraser.Text = "toolStripButton1";
            this.Button_Eraser.Click += new System.EventHandler(this.Button_Eraser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colourButton_Cyan);
            this.groupBox2.Controls.Add(this.colourButton_White);
            this.groupBox2.Controls.Add(this.colourButton_Black);
            this.groupBox2.Controls.Add(this.colourButton_Blue);
            this.groupBox2.Controls.Add(this.colourButton_Purple);
            this.groupBox2.Controls.Add(this.colourButton_Green);
            this.groupBox2.Controls.Add(this.colourButton_Orange);
            this.groupBox2.Controls.Add(this.colourButton_Red);
            this.groupBox2.Controls.Add(this.colourButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(76, 210);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colour";
            // 
            // colourButton_Cyan
            // 
            this.colourButton_Cyan.BackColor = System.Drawing.Color.Cyan;
            this.colourButton_Cyan.Location = new System.Drawing.Point(40, 114);
            this.colourButton_Cyan.Name = "colourButton_Cyan";
            this.colourButton_Cyan.Size = new System.Drawing.Size(28, 28);
            this.colourButton_Cyan.TabIndex = 2;
            this.colourButton_Cyan.UseVisualStyleBackColor = false;
            this.colourButton_Cyan.Click += new System.EventHandler(this.colourButton_Cyan_Click);
            // 
            // colourButton_White
            // 
            this.colourButton_White.BackColor = System.Drawing.Color.White;
            this.colourButton_White.Location = new System.Drawing.Point(40, 176);
            this.colourButton_White.Name = "colourButton_White";
            this.colourButton_White.Size = new System.Drawing.Size(28, 28);
            this.colourButton_White.TabIndex = 2;
            this.colourButton_White.UseVisualStyleBackColor = false;
            this.colourButton_White.Click += new System.EventHandler(this.colourButton_White_Click);
            // 
            // colourButton_Black
            // 
            this.colourButton_Black.BackColor = System.Drawing.Color.Black;
            this.colourButton_Black.Location = new System.Drawing.Point(9, 176);
            this.colourButton_Black.Name = "colourButton_Black";
            this.colourButton_Black.Size = new System.Drawing.Size(28, 28);
            this.colourButton_Black.TabIndex = 1;
            this.colourButton_Black.UseVisualStyleBackColor = false;
            this.colourButton_Black.Click += new System.EventHandler(this.colourButton_Black_Click);
            // 
            // colourButton_Blue
            // 
            this.colourButton_Blue.BackColor = System.Drawing.Color.Blue;
            this.colourButton_Blue.Location = new System.Drawing.Point(9, 145);
            this.colourButton_Blue.Name = "colourButton_Blue";
            this.colourButton_Blue.Size = new System.Drawing.Size(28, 28);
            this.colourButton_Blue.TabIndex = 1;
            this.colourButton_Blue.UseVisualStyleBackColor = false;
            this.colourButton_Blue.Click += new System.EventHandler(this.colourButton_Blue_Click);
            // 
            // colourButton_Purple
            // 
            this.colourButton_Purple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.colourButton_Purple.Location = new System.Drawing.Point(40, 145);
            this.colourButton_Purple.Name = "colourButton_Purple";
            this.colourButton_Purple.Size = new System.Drawing.Size(28, 28);
            this.colourButton_Purple.TabIndex = 2;
            this.colourButton_Purple.UseVisualStyleBackColor = false;
            this.colourButton_Purple.Click += new System.EventHandler(this.colourButton_Purple_Click);
            // 
            // colourButton_Green
            // 
            this.colourButton_Green.BackColor = System.Drawing.Color.Lime;
            this.colourButton_Green.Location = new System.Drawing.Point(9, 114);
            this.colourButton_Green.Name = "colourButton_Green";
            this.colourButton_Green.Size = new System.Drawing.Size(28, 28);
            this.colourButton_Green.TabIndex = 1;
            this.colourButton_Green.UseVisualStyleBackColor = false;
            this.colourButton_Green.Click += new System.EventHandler(this.colourButton_Green_Click);
            // 
            // colourButton_Orange
            // 
            this.colourButton_Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colourButton_Orange.Location = new System.Drawing.Point(40, 83);
            this.colourButton_Orange.Name = "colourButton_Orange";
            this.colourButton_Orange.Size = new System.Drawing.Size(28, 28);
            this.colourButton_Orange.TabIndex = 2;
            this.colourButton_Orange.UseVisualStyleBackColor = false;
            this.colourButton_Orange.Click += new System.EventHandler(this.colourButton_Orange_Click);
            // 
            // colourButton_Red
            // 
            this.colourButton_Red.BackColor = System.Drawing.Color.Red;
            this.colourButton_Red.Location = new System.Drawing.Point(9, 83);
            this.colourButton_Red.Name = "colourButton_Red";
            this.colourButton_Red.Size = new System.Drawing.Size(28, 28);
            this.colourButton_Red.TabIndex = 1;
            this.colourButton_Red.UseVisualStyleBackColor = false;
            this.colourButton_Red.Click += new System.EventHandler(this.colourButton_Red_Click);
            // 
            // colourButton
            // 
            this.colourButton.BackColor = System.Drawing.Color.Black;
            this.colourButton.Location = new System.Drawing.Point(8, 19);
            this.colourButton.Name = "colourButton";
            this.colourButton.Size = new System.Drawing.Size(60, 60);
            this.colourButton.TabIndex = 0;
            this.colourButton.UseVisualStyleBackColor = false;
            this.colourButton.Click += new System.EventHandler(this.colourButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Brushsize_Box);
            this.groupBox3.Location = new System.Drawing.Point(12, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(72, 49);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "px";
            // 
            // Brushsize_Box
            // 
            this.Brushsize_Box.FormattingEnabled = true;
            this.Brushsize_Box.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64"});
            this.Brushsize_Box.Location = new System.Drawing.Point(6, 19);
            this.Brushsize_Box.Name = "Brushsize_Box";
            this.Brushsize_Box.Size = new System.Drawing.Size(43, 21);
            this.Brushsize_Box.TabIndex = 0;
            this.Brushsize_Box.Text = "2";
            this.Brushsize_Box.SelectedIndexChanged += new System.EventHandler(this.Brushsize_Box_SelectedIndexChanged);
            this.Brushsize_Box.SelectedValueChanged += new System.EventHandler(this.Brushsize_Box_SelectedValueChanged);
            this.Brushsize_Box.TextChanged += new System.EventHandler(this.Brushsize_Box_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(971, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // positionLabel
            // 
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.Location = new System.Drawing.Point(95, 27);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(864, 542);
            this.drawingPanel.TabIndex = 6;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseUp);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(884, 1);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(75, 23);
            this.Button_Clear.TabIndex = 7;
            this.Button_Clear.Text = "Clear All";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 603);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simple Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel positionLabel;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Button colourButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Button_Line;
        private System.Windows.Forms.ToolStripButton Button_Oval;
        private System.Windows.Forms.ToolStripButton Button_Rectangle;
        private System.Windows.Forms.ComboBox Brushsize_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripButton Button_Pencil;
        private System.Windows.Forms.Button colourButton_Cyan;
        private System.Windows.Forms.Button colourButton_White;
        private System.Windows.Forms.Button colourButton_Black;
        private System.Windows.Forms.Button colourButton_Blue;
        private System.Windows.Forms.Button colourButton_Purple;
        private System.Windows.Forms.Button colourButton_Green;
        private System.Windows.Forms.Button colourButton_Orange;
        private System.Windows.Forms.Button colourButton_Red;
        private System.Windows.Forms.ToolStripButton Button_Eraser;
        private System.Windows.Forms.CheckBox checkBox_Filled;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

