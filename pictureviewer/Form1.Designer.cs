namespace pictureviewer
{
    partial class Pictureviewer_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pictureviewer_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.αρχείοToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.άνοιγμαΕικόναςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.αποθήκευσηΩςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.έξοδοςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εικόναToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.επόμενηΕικόναToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.προηγούμενηΕικόναToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strechΕικόναςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.περιστροφήΕικόναςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.δεξιόστροφαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.αριστερόστροφαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideshowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info_richTextBox = new System.Windows.Forms.RichTextBox();
            this.multi_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.streched_button = new System.Windows.Forms.Button();
            this.sepia_button = new System.Windows.Forms.Button();
            this.grayscale_button = new System.Windows.Forms.Button();
            this.slideshow_button = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.αρχείοToolStripMenuItem,
            this.εικόναToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // αρχείοToolStripMenuItem
            // 
            this.αρχείοToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.αρχείοToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.άνοιγμαΕικόναςToolStripMenuItem,
            this.αποθήκευσηΩςToolStripMenuItem,
            this.έξοδοςToolStripMenuItem});
            this.αρχείοToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.αρχείοToolStripMenuItem.Name = "αρχείοToolStripMenuItem";
            resources.ApplyResources(this.αρχείοToolStripMenuItem, "αρχείοToolStripMenuItem");
            // 
            // άνοιγμαΕικόναςToolStripMenuItem
            // 
            this.άνοιγμαΕικόναςToolStripMenuItem.Name = "άνοιγμαΕικόναςToolStripMenuItem";
            resources.ApplyResources(this.άνοιγμαΕικόναςToolStripMenuItem, "άνοιγμαΕικόναςToolStripMenuItem");
            this.άνοιγμαΕικόναςToolStripMenuItem.Click += new System.EventHandler(this.άνοιγμαΕικόναςToolStripMenuItem_Click);
            // 
            // αποθήκευσηΩςToolStripMenuItem
            // 
            this.αποθήκευσηΩςToolStripMenuItem.Name = "αποθήκευσηΩςToolStripMenuItem";
            resources.ApplyResources(this.αποθήκευσηΩςToolStripMenuItem, "αποθήκευσηΩςToolStripMenuItem");
            this.αποθήκευσηΩςToolStripMenuItem.Click += new System.EventHandler(this.αποθήκευσηΩςToolStripMenuItem_Click);
            // 
            // έξοδοςToolStripMenuItem
            // 
            this.έξοδοςToolStripMenuItem.Name = "έξοδοςToolStripMenuItem";
            resources.ApplyResources(this.έξοδοςToolStripMenuItem, "έξοδοςToolStripMenuItem");
            this.έξοδοςToolStripMenuItem.Click += new System.EventHandler(this.έξοδοςToolStripMenuItem_Click);
            // 
            // εικόναToolStripMenuItem
            // 
            this.εικόναToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.επόμενηΕικόναToolStripMenuItem,
            this.προηγούμενηΕικόναToolStripMenuItem,
            this.strechΕικόναςToolStripMenuItem,
            this.περιστροφήΕικόναςToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.slideshowToolStripMenuItem});
            this.εικόναToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.εικόναToolStripMenuItem.Name = "εικόναToolStripMenuItem";
            resources.ApplyResources(this.εικόναToolStripMenuItem, "εικόναToolStripMenuItem");
            // 
            // επόμενηΕικόναToolStripMenuItem
            // 
            this.επόμενηΕικόναToolStripMenuItem.Name = "επόμενηΕικόναToolStripMenuItem";
            resources.ApplyResources(this.επόμενηΕικόναToolStripMenuItem, "επόμενηΕικόναToolStripMenuItem");
            this.επόμενηΕικόναToolStripMenuItem.Click += new System.EventHandler(this.επόμενηΕικόναToolStripMenuItem_Click);
            // 
            // προηγούμενηΕικόναToolStripMenuItem
            // 
            this.προηγούμενηΕικόναToolStripMenuItem.Name = "προηγούμενηΕικόναToolStripMenuItem";
            resources.ApplyResources(this.προηγούμενηΕικόναToolStripMenuItem, "προηγούμενηΕικόναToolStripMenuItem");
            this.προηγούμενηΕικόναToolStripMenuItem.Click += new System.EventHandler(this.προηγούμενηΕικόναToolStripMenuItem_Click);
            // 
            // strechΕικόναςToolStripMenuItem
            // 
            this.strechΕικόναςToolStripMenuItem.Name = "strechΕικόναςToolStripMenuItem";
            resources.ApplyResources(this.strechΕικόναςToolStripMenuItem, "strechΕικόναςToolStripMenuItem");
            this.strechΕικόναςToolStripMenuItem.Click += new System.EventHandler(this.strechΕικόναςToolStripMenuItem_Click);
            // 
            // περιστροφήΕικόναςToolStripMenuItem
            // 
            this.περιστροφήΕικόναςToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.δεξιόστροφαToolStripMenuItem,
            this.αριστερόστροφαToolStripMenuItem});
            this.περιστροφήΕικόναςToolStripMenuItem.Name = "περιστροφήΕικόναςToolStripMenuItem";
            resources.ApplyResources(this.περιστροφήΕικόναςToolStripMenuItem, "περιστροφήΕικόναςToolStripMenuItem");
            // 
            // δεξιόστροφαToolStripMenuItem
            // 
            this.δεξιόστροφαToolStripMenuItem.Name = "δεξιόστροφαToolStripMenuItem";
            resources.ApplyResources(this.δεξιόστροφαToolStripMenuItem, "δεξιόστροφαToolStripMenuItem");
            this.δεξιόστροφαToolStripMenuItem.Click += new System.EventHandler(this.δεξιόστροφαToolStripMenuItem_Click);
            // 
            // αριστερόστροφαToolStripMenuItem
            // 
            this.αριστερόστροφαToolStripMenuItem.Name = "αριστερόστροφαToolStripMenuItem";
            resources.ApplyResources(this.αριστερόστροφαToolStripMenuItem, "αριστερόστροφαToolStripMenuItem");
            this.αριστερόστροφαToolStripMenuItem.Click += new System.EventHandler(this.αριστερόστροφαToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            resources.ApplyResources(this.grayscaleToolStripMenuItem, "grayscaleToolStripMenuItem");
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            resources.ApplyResources(this.sepiaToolStripMenuItem, "sepiaToolStripMenuItem");
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // slideshowToolStripMenuItem
            // 
            this.slideshowToolStripMenuItem.Name = "slideshowToolStripMenuItem";
            resources.ApplyResources(this.slideshowToolStripMenuItem, "slideshowToolStripMenuItem");
            this.slideshowToolStripMenuItem.Click += new System.EventHandler(this.slideshowToolStripMenuItem_Click);
            // 
            // info_richTextBox
            // 
            resources.ApplyResources(this.info_richTextBox, "info_richTextBox");
            this.info_richTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.info_richTextBox.Name = "info_richTextBox";
            // 
            // multi_button
            // 
            resources.ApplyResources(this.multi_button, "multi_button");
            this.multi_button.BackColor = System.Drawing.Color.LightGreen;
            this.multi_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.multi_button.Name = "multi_button";
            this.multi_button.UseVisualStyleBackColor = false;
            this.multi_button.Click += new System.EventHandler(this.multi_button_Click);
            // 
            // previous_button
            // 
            resources.ApplyResources(this.previous_button, "previous_button");
            this.previous_button.Name = "previous_button";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // next_button
            // 
            resources.ApplyResources(this.next_button, "next_button");
            this.next_button.Name = "next_button";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // left_button
            // 
            resources.ApplyResources(this.left_button, "left_button");
            this.left_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.left_button.Name = "left_button";
            this.left_button.UseVisualStyleBackColor = false;
            this.left_button.Click += new System.EventHandler(this.left_button_Click);
            // 
            // right_button
            // 
            resources.ApplyResources(this.right_button, "right_button");
            this.right_button.Name = "right_button";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.Click += new System.EventHandler(this.right_button_Click);
            // 
            // open_button
            // 
            resources.ApplyResources(this.open_button, "open_button");
            this.open_button.BackColor = System.Drawing.SystemColors.Control;
            this.open_button.Name = "open_button";
            this.open_button.UseVisualStyleBackColor = false;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // streched_button
            // 
            resources.ApplyResources(this.streched_button, "streched_button");
            this.streched_button.BackColor = System.Drawing.SystemColors.Control;
            this.streched_button.Name = "streched_button";
            this.streched_button.UseVisualStyleBackColor = false;
            this.streched_button.Click += new System.EventHandler(this.streched_button_Click);
            // 
            // sepia_button
            // 
            resources.ApplyResources(this.sepia_button, "sepia_button");
            this.sepia_button.BackColor = System.Drawing.Color.Coral;
            this.sepia_button.Name = "sepia_button";
            this.sepia_button.UseVisualStyleBackColor = false;
            this.sepia_button.Click += new System.EventHandler(this.sepia_button_Click);
            // 
            // grayscale_button
            // 
            resources.ApplyResources(this.grayscale_button, "grayscale_button");
            this.grayscale_button.BackColor = System.Drawing.SystemColors.GrayText;
            this.grayscale_button.Name = "grayscale_button";
            this.grayscale_button.UseVisualStyleBackColor = false;
            this.grayscale_button.Click += new System.EventHandler(this.grayscale_button_Click);
            // 
            // slideshow_button
            // 
            resources.ApplyResources(this.slideshow_button, "slideshow_button");
            this.slideshow_button.Name = "slideshow_button";
            this.slideshow_button.UseVisualStyleBackColor = true;
            this.slideshow_button.Click += new System.EventHandler(this.slideshow_button_Click);
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Name = "panel1";
            // 
            // Pictureviewer_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.slideshow_button);
            this.Controls.Add(this.grayscale_button);
            this.Controls.Add(this.sepia_button);
            this.Controls.Add(this.streched_button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.right_button);
            this.Controls.Add(this.left_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.multi_button);
            this.Controls.Add(this.info_richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pictureviewer_form";
            this.Load += new System.EventHandler(this.Pictureviewer_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem αρχείοToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem έξοδοςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εικόναToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem επόμενηΕικόναToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem προηγούμενηΕικόναToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strechΕικόναςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem περιστροφήΕικόναςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem δεξιόστροφαToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem αριστερόστροφαToolStripMenuItem;
        private System.Windows.Forms.RichTextBox info_richTextBox;
        private System.Windows.Forms.ToolStripMenuItem αποθήκευσηΩςToolStripMenuItem;
        private System.Windows.Forms.Button multi_button;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem άνοιγμαΕικόναςToolStripMenuItem;
        private System.Windows.Forms.Button streched_button;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.Button sepia_button;
        private System.Windows.Forms.Button grayscale_button;
        private System.Windows.Forms.Button slideshow_button;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem slideshowToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

