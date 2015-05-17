namespace WindowsFormsApplication1
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
            this.upload = new System.Windows.Forms.Button();
            this.images = new System.Windows.Forms.PictureBox();
            this.tracker = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.url_movie = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.play = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.save = new System.Windows.Forms.Button();
            this.scan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(67, 363);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 1;
            this.upload.Text = "upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // images
            // 
            this.images.Location = new System.Drawing.Point(512, 63);
            this.images.Name = "images";
            this.images.Size = new System.Drawing.Size(307, 239);
            this.images.TabIndex = 2;
            this.images.TabStop = false;
            // 
            // tracker
            // 
            this.tracker.Location = new System.Drawing.Point(512, 341);
            this.tracker.Name = "tracker";
            this.tracker.Size = new System.Drawing.Size(307, 45);
            this.tracker.TabIndex = 6;
            this.tracker.Scroll += new System.EventHandler(this.tracker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "position ";
            // 
            // url_movie
            // 
            this.url_movie.Location = new System.Drawing.Point(154, 343);
            this.url_movie.Name = "url_movie";
            this.url_movie.Size = new System.Drawing.Size(100, 20);
            this.url_movie.TabIndex = 5;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 63);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(341, 239);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(67, 317);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 6;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.oPENToolStripMenuItem,
            this.sAVEToolStripMenuItem,
            this.toolStripMenuItem2});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.nEWToolStripMenuItem.Text = "NEW ";
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.oPENToolStripMenuItem.Text = "OPEN";
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sAVEToolStripMenuItem.Text = "SAVE ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 6);
            //  
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(403, 343);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(75, 23);
            this.scan.TabIndex = 9;
            this.scan.Text = "scan";
            this.scan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 496);
            this.Controls.Add(this.scan);
            this.Controls.Add(this.save);
            this.Controls.Add(this.play);
            this.Controls.Add(this.url_movie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tracker);
            this.Controls.Add(this.images);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Project_1";
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.PictureBox images;
        private System.Windows.Forms.TrackBar tracker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox url_movie;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button scan;
    }
}

