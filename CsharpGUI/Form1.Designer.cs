namespace CsharpGUI
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputImage_pictureBox = new System.Windows.Forms.PictureBox();
            this.outputImage_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputImage2_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.invert_button = new System.Windows.Forms.Button();
            this.loadSecondImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage2_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1557, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.loadSecondImageToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openImageToolStripMenuItem.Text = "Load First Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // inputImage_pictureBox
            // 
            this.inputImage_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputImage_pictureBox.Location = new System.Drawing.Point(12, 62);
            this.inputImage_pictureBox.Name = "inputImage_pictureBox";
            this.inputImage_pictureBox.Size = new System.Drawing.Size(449, 576);
            this.inputImage_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputImage_pictureBox.TabIndex = 1;
            this.inputImage_pictureBox.TabStop = false;
            // 
            // outputImage_pictureBox
            // 
            this.outputImage_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputImage_pictureBox.Location = new System.Drawing.Point(1096, 53);
            this.outputImage_pictureBox.Name = "outputImage_pictureBox";
            this.outputImage_pictureBox.Size = new System.Drawing.Size(449, 585);
            this.outputImage_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.outputImage_pictureBox.TabIndex = 2;
            this.outputImage_pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Image 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Image 2";
            // 
            // inputImage2_pictureBox1
            // 
            this.inputImage2_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputImage2_pictureBox1.Location = new System.Drawing.Point(566, 62);
            this.inputImage2_pictureBox1.Name = "inputImage2_pictureBox1";
            this.inputImage2_pictureBox1.Size = new System.Drawing.Size(449, 576);
            this.inputImage2_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputImage2_pictureBox1.TabIndex = 9;
            this.inputImage2_pictureBox1.TabStop = false;
            // 
            // invert_button
            // 
            this.invert_button.Location = new System.Drawing.Point(1375, 644);
            this.invert_button.Name = "invert_button";
            this.invert_button.Size = new System.Drawing.Size(75, 43);
            this.invert_button.TabIndex = 8;
            this.invert_button.Text = "Invert Image";
            this.invert_button.UseVisualStyleBackColor = true;
            this.invert_button.Click += new System.EventHandler(this.invert_button_Click);
            // 
            // loadSecondImageToolStripMenuItem
            // 
            this.loadSecondImageToolStripMenuItem.Name = "loadSecondImageToolStripMenuItem";
            this.loadSecondImageToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.loadSecondImageToolStripMenuItem.Text = "Load Second Image";
            this.loadSecondImageToolStripMenuItem.Click += new System.EventHandler(this.loadSecondImageToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1096, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 716);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputImage2_pictureBox1);
            this.Controls.Add(this.invert_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputImage_pictureBox);
            this.Controls.Add(this.inputImage_pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage2_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox inputImage_pictureBox;
        private System.Windows.Forms.PictureBox outputImage_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox inputImage2_pictureBox1;
        private System.Windows.Forms.Button invert_button;
        private System.Windows.Forms.ToolStripMenuItem loadSecondImageToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

