namespace playlist_linkedlist
{
    partial class Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.voLume_value = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.open = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.trangthai = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.start = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.song_name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.voLume_value);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.open);
            this.groupBox1.Controls.Add(this.Stop);
            this.groupBox1.Controls.Add(this.play);
            this.groupBox1.Controls.Add(this.Next);
            this.groupBox1.Controls.Add(this.Previous);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(13, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlist";
            // 
            // voLume_value
            // 
            this.voLume_value.AutoSize = true;
            this.voLume_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voLume_value.ForeColor = System.Drawing.Color.Cyan;
            this.voLume_value.Location = new System.Drawing.Point(627, 66);
            this.voLume_value.Name = "voLume_value";
            this.voLume_value.Size = new System.Drawing.Size(26, 16);
            this.voLume_value.TabIndex = 7;
            this.voLume_value.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(588, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Volume";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(588, 15);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 103);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(19, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(563, 84);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.open.Location = new System.Drawing.Point(502, 27);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(80, 23);
            this.open.TabIndex = 4;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Stop.Location = new System.Drawing.Point(265, 28);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(80, 23);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.play.Location = new System.Drawing.Point(136, 27);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(80, 23);
            this.play.TabIndex = 2;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Next.Location = new System.Drawing.Point(385, 28);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(80, 23);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Previous.Location = new System.Drawing.Point(19, 27);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(80, 23);
            this.Previous.TabIndex = 0;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // trangthai
            // 
            this.trangthai.AutoSize = true;
            this.trangthai.ForeColor = System.Drawing.Color.Cyan;
            this.trangthai.Location = new System.Drawing.Point(594, 1);
            this.trangthai.Name = "trangthai";
            this.trangthai.Size = new System.Drawing.Size(68, 20);
            this.trangthai.TabIndex = 2;
            this.trangthai.Text = ":Playlist";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(80, 315);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(524, 10);
            this.progressBar1.TabIndex = 3;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.Cyan;
            this.start.Location = new System.Drawing.Point(29, 312);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(38, 16);
            this.start.TabIndex = 8;
            this.start.Text = "00:00";
            // 
            // finish
            // 
            this.finish.AutoSize = true;
            this.finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish.ForeColor = System.Drawing.Color.Cyan;
            this.finish.Location = new System.Drawing.Point(619, 312);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(38, 16);
            this.finish.TabIndex = 9;
            this.finish.Text = "00:00";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 24);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(673, 285);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(13, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Song_name: ";
            // 
            // song_name
            // 
            this.song_name.AutoSize = true;
            this.song_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.song_name.ForeColor = System.Drawing.Color.Cyan;
            this.song_name.Location = new System.Drawing.Point(113, 4);
            this.song_name.Name = "song_name";
            this.song_name.Size = new System.Drawing.Size(0, 16);
            this.song_name.TabIndex = 12;
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(688, 499);
            this.Controls.Add(this.song_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.start);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trangthai);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Playlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLAYLIST";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Label voLume_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label trangthai;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label finish;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label song_name;
    }
}

