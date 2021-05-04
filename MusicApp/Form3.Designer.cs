
namespace MusicApp
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_UserPlaylists = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_PlaylistSongs = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_like = new System.Windows.Forms.Button();
            this.lbl_likedSong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(273, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your PlayLists";
            // 
            // lb_UserPlaylists
            // 
            this.lb_UserPlaylists.FormattingEnabled = true;
            this.lb_UserPlaylists.Location = new System.Drawing.Point(40, 129);
            this.lb_UserPlaylists.Name = "lb_UserPlaylists";
            this.lb_UserPlaylists.Size = new System.Drawing.Size(358, 134);
            this.lb_UserPlaylists.TabIndex = 1;
            this.lb_UserPlaylists.SelectedIndexChanged += new System.EventHandler(this.lb_UserPlaylists_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Playlist:";
            // 
            // lb_PlaylistSongs
            // 
            this.lb_PlaylistSongs.FormattingEnabled = true;
            this.lb_PlaylistSongs.Location = new System.Drawing.Point(444, 120);
            this.lb_PlaylistSongs.Name = "lb_PlaylistSongs";
            this.lb_PlaylistSongs.Size = new System.Drawing.Size(309, 251);
            this.lb_PlaylistSongs.TabIndex = 3;
            this.lb_PlaylistSongs.SelectedIndexChanged += new System.EventHandler(this.lb_PlaylistSongs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(439, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Songs on this playlist:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add New Playlist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_like
            // 
            this.btn_like.Location = new System.Drawing.Point(444, 394);
            this.btn_like.Name = "btn_like";
            this.btn_like.Size = new System.Drawing.Size(108, 44);
            this.btn_like.TabIndex = 6;
            this.btn_like.Text = "Like this song!";
            this.btn_like.UseVisualStyleBackColor = true;
            this.btn_like.Click += new System.EventHandler(this.btn_like_Click);
            // 
            // lbl_likedSong
            // 
            this.lbl_likedSong.AutoSize = true;
            this.lbl_likedSong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_likedSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_likedSong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_likedSong.Location = new System.Drawing.Point(629, 394);
            this.lbl_likedSong.Name = "lbl_likedSong";
            this.lbl_likedSong.Size = new System.Drawing.Size(112, 17);
            this.lbl_likedSong.TabIndex = 7;
            this.lbl_likedSong.Text = "LIKED SONG <3";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_likedSong);
            this.Controls.Add(this.btn_like);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_PlaylistSongs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_UserPlaylists);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_UserPlaylists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_PlaylistSongs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_like;
        private System.Windows.Forms.Label lbl_likedSong;
    }
}