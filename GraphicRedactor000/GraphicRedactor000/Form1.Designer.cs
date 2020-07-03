namespace GraphicRedactor000
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.circle = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.pencil = new System.Windows.Forms.Button();
            this.blackColor = new System.Windows.Forms.PictureBox();
            this.blueColor = new System.Windows.Forms.PictureBox();
            this.mainColor = new System.Windows.Forms.PictureBox();
            this.greenColor = new System.Windows.Forms.PictureBox();
            this.redColor = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1406, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 152);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1406, 754);
            this.panel2.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(238, 30);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(162, 90);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eraser);
            this.groupBox1.Controls.Add(this.pencil);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(35, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 130);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instruments";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.blackColor);
            this.groupBox2.Controls.Add(this.blueColor);
            this.groupBox2.Controls.Add(this.mainColor);
            this.groupBox2.Controls.Add(this.greenColor);
            this.groupBox2.Controls.Add(this.redColor);
            this.groupBox2.Location = new System.Drawing.Point(933, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 130);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.circle);
            this.groupBox3.Controls.Add(this.line);
            this.groupBox3.Location = new System.Drawing.Point(547, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 130);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shapes";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(159, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 50);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(233, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 50);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(208, 44);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(208, 44);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(208, 44);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1406, 754);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // circle
            // 
            this.circle.BackgroundImage = global::GraphicRedactor000.Properties.Resources.Purple_circle_100__svg;
            this.circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circle.Image = global::GraphicRedactor000.Properties.Resources.circle;
            this.circle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.circle.Location = new System.Drawing.Point(89, 53);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(48, 50);
            this.circle.TabIndex = 11;
            this.circle.UseVisualStyleBackColor = true;
            // 
            // line
            // 
            this.line.BackgroundImage = global::GraphicRedactor000.Properties.Resources.line_icon_256;
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.line.Location = new System.Drawing.Point(19, 52);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(48, 50);
            this.line.TabIndex = 10;
            this.line.UseVisualStyleBackColor = true;
            // 
            // eraser
            // 
            this.eraser.BackgroundImage = global::GraphicRedactor000.Properties.Resources.eraser;
            this.eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraser.Location = new System.Drawing.Point(94, 52);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(48, 50);
            this.eraser.TabIndex = 10;
            this.eraser.UseVisualStyleBackColor = true;
            // 
            // pencil
            // 
            this.pencil.BackgroundImage = global::GraphicRedactor000.Properties.Resources.editor_pencil_pen_edit_write_glyph_256;
            this.pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pencil.Location = new System.Drawing.Point(22, 52);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(48, 50);
            this.pencil.TabIndex = 8;
            this.pencil.UseVisualStyleBackColor = true;
            // 
            // blackColor
            // 
            this.blackColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blackColor.Location = new System.Drawing.Point(173, 73);
            this.blackColor.Name = "blackColor";
            this.blackColor.Size = new System.Drawing.Size(34, 35);
            this.blackColor.TabIndex = 0;
            this.blackColor.TabStop = false;
            // 
            // blueColor
            // 
            this.blueColor.BackColor = System.Drawing.Color.Blue;
            this.blueColor.Location = new System.Drawing.Point(121, 73);
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(34, 35);
            this.blueColor.TabIndex = 2;
            this.blueColor.TabStop = false;
            // 
            // mainColor
            // 
            this.mainColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainColor.Location = new System.Drawing.Point(32, 42);
            this.mainColor.Name = "mainColor";
            this.mainColor.Size = new System.Drawing.Size(64, 66);
            this.mainColor.TabIndex = 4;
            this.mainColor.TabStop = false;
            // 
            // greenColor
            // 
            this.greenColor.BackColor = System.Drawing.Color.ForestGreen;
            this.greenColor.Location = new System.Drawing.Point(173, 30);
            this.greenColor.Name = "greenColor";
            this.greenColor.Size = new System.Drawing.Size(34, 35);
            this.greenColor.TabIndex = 1;
            this.greenColor.TabStop = false;
            // 
            // redColor
            // 
            this.redColor.BackColor = System.Drawing.Color.OrangeRed;
            this.redColor.Location = new System.Drawing.Point(121, 30);
            this.redColor.Name = "redColor";
            this.redColor.Size = new System.Drawing.Size(34, 35);
            this.redColor.TabIndex = 3;
            this.redColor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 946);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graphic Redactor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox mainColor;
        private System.Windows.Forms.PictureBox redColor;
        private System.Windows.Forms.PictureBox blueColor;
        private System.Windows.Forms.PictureBox greenColor;
        private System.Windows.Forms.PictureBox blackColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button pencil;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

