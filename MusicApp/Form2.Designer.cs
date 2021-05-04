
namespace MusicApp
{
    partial class Form2
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.txt_AddArtist = new System.Windows.Forms.TextBox();
            this.txt_AddAlbum = new System.Windows.Forms.TextBox();
            this.txt_AddSong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Albums = new System.Windows.Forms.ComboBox();
            this.btn_AddArtist = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_playlistYes = new System.Windows.Forms.CheckBox();
            this.chk_playlistNo = new System.Windows.Forms.CheckBox();
            this.btn_AddAlbum = new System.Windows.Forms.Button();
            this.cb_Artists = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_AddSong = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Playlists = new System.Windows.Forms.Button();
            this.cb_ChoosePlaylist = new System.Windows.Forms.ComboBox();
            this.lbl_choosePlaylist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(281, 25);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(52, 13);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome";
            // 
            // txt_AddArtist
            // 
            this.txt_AddArtist.Location = new System.Drawing.Point(185, 129);
            this.txt_AddArtist.Name = "txt_AddArtist";
            this.txt_AddArtist.Size = new System.Drawing.Size(134, 20);
            this.txt_AddArtist.TabIndex = 1;
            // 
            // txt_AddAlbum
            // 
            this.txt_AddAlbum.Location = new System.Drawing.Point(185, 269);
            this.txt_AddAlbum.Name = "txt_AddAlbum";
            this.txt_AddAlbum.Size = new System.Drawing.Size(100, 20);
            this.txt_AddAlbum.TabIndex = 2;
            // 
            // txt_AddSong
            // 
            this.txt_AddSong.Location = new System.Drawing.Point(185, 442);
            this.txt_AddSong.Name = "txt_AddSong";
            this.txt_AddSong.Size = new System.Drawing.Size(100, 20);
            this.txt_AddSong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Songs";
            // 
            // cb_Albums
            // 
            this.cb_Albums.FormattingEnabled = true;
            this.cb_Albums.Location = new System.Drawing.Point(360, 442);
            this.cb_Albums.Name = "cb_Albums";
            this.cb_Albums.Size = new System.Drawing.Size(255, 21);
            this.cb_Albums.TabIndex = 4;
            // 
            // btn_AddArtist
            // 
            this.btn_AddArtist.Location = new System.Drawing.Point(615, 118);
            this.btn_AddArtist.Name = "btn_AddArtist";
            this.btn_AddArtist.Size = new System.Drawing.Size(119, 31);
            this.btn_AddArtist.TabIndex = 5;
            this.btn_AddArtist.Text = "Add Artist";
            this.btn_AddArtist.UseVisualStyleBackColor = true;
            this.btn_AddArtist.Click += new System.EventHandler(this.btn_AddArtist_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Do you want to add this song to one of your playlists?";
            // 
            // chk_playlistYes
            // 
            this.chk_playlistYes.AutoSize = true;
            this.chk_playlistYes.Location = new System.Drawing.Point(473, 503);
            this.chk_playlistYes.Name = "chk_playlistYes";
            this.chk_playlistYes.Size = new System.Drawing.Size(44, 17);
            this.chk_playlistYes.TabIndex = 7;
            this.chk_playlistYes.Text = "Yes";
            this.chk_playlistYes.UseVisualStyleBackColor = true;
            this.chk_playlistYes.CheckedChanged += new System.EventHandler(this.chk_playlistYes_CheckedChanged);
            // 
            // chk_playlistNo
            // 
            this.chk_playlistNo.AutoSize = true;
            this.chk_playlistNo.Location = new System.Drawing.Point(523, 503);
            this.chk_playlistNo.Name = "chk_playlistNo";
            this.chk_playlistNo.Size = new System.Drawing.Size(40, 17);
            this.chk_playlistNo.TabIndex = 8;
            this.chk_playlistNo.Text = "No";
            this.chk_playlistNo.UseVisualStyleBackColor = true;
            // 
            // btn_AddAlbum
            // 
            this.btn_AddAlbum.Location = new System.Drawing.Point(615, 256);
            this.btn_AddAlbum.Name = "btn_AddAlbum";
            this.btn_AddAlbum.Size = new System.Drawing.Size(119, 33);
            this.btn_AddAlbum.TabIndex = 5;
            this.btn_AddAlbum.Text = "Add Album";
            this.btn_AddAlbum.UseVisualStyleBackColor = true;
            this.btn_AddAlbum.Click += new System.EventHandler(this.btn_AddAlbum_Click);
            // 
            // cb_Artists
            // 
            this.cb_Artists.FormattingEnabled = true;
            this.cb_Artists.Location = new System.Drawing.Point(360, 268);
            this.cb_Artists.Name = "cb_Artists";
            this.cb_Artists.Size = new System.Drawing.Size(121, 21);
            this.cb_Artists.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Choose Album Artist";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Choose Album";
            // 
            // btn_AddSong
            // 
            this.btn_AddSong.Location = new System.Drawing.Point(615, 555);
            this.btn_AddSong.Name = "btn_AddSong";
            this.btn_AddSong.Size = new System.Drawing.Size(119, 35);
            this.btn_AddSong.TabIndex = 11;
            this.btn_AddSong.Text = "Add Song";
            this.btn_AddSong.UseVisualStyleBackColor = true;
            this.btn_AddSong.Click += new System.EventHandler(this.btn_AddSong_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Album Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Artist Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Song Name";
            // 
            // btn_Playlists
            // 
            this.btn_Playlists.Location = new System.Drawing.Point(177, 641);
            this.btn_Playlists.Name = "btn_Playlists";
            this.btn_Playlists.Size = new System.Drawing.Size(438, 57);
            this.btn_Playlists.TabIndex = 14;
            this.btn_Playlists.Text = "GO TO MY PLAYLISTS";
            this.btn_Playlists.UseVisualStyleBackColor = true;
            this.btn_Playlists.Click += new System.EventHandler(this.btn_Playlists_Click);
            // 
            // cb_ChoosePlaylist
            // 
            this.cb_ChoosePlaylist.FormattingEnabled = true;
            this.cb_ChoosePlaylist.Location = new System.Drawing.Point(442, 563);
            this.cb_ChoosePlaylist.Name = "cb_ChoosePlaylist";
            this.cb_ChoosePlaylist.Size = new System.Drawing.Size(121, 21);
            this.cb_ChoosePlaylist.TabIndex = 15;
            // 
            // lbl_choosePlaylist
            // 
            this.lbl_choosePlaylist.AutoSize = true;
            this.lbl_choosePlaylist.Location = new System.Drawing.Point(442, 544);
            this.lbl_choosePlaylist.Name = "lbl_choosePlaylist";
            this.lbl_choosePlaylist.Size = new System.Drawing.Size(80, 13);
            this.lbl_choosePlaylist.TabIndex = 16;
            this.lbl_choosePlaylist.Text = "Choose playlist:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.lbl_choosePlaylist);
            this.Controls.Add(this.cb_ChoosePlaylist);
            this.Controls.Add(this.btn_Playlists);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_AddSong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Artists);
            this.Controls.Add(this.chk_playlistNo);
            this.Controls.Add(this.chk_playlistYes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_AddAlbum);
            this.Controls.Add(this.btn_AddArtist);
            this.Controls.Add(this.cb_Albums);
            this.Controls.Add(this.txt_AddSong);
            this.Controls.Add(this.txt_AddAlbum);
            this.Controls.Add(this.txt_AddArtist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.TextBox txt_AddArtist;
        private System.Windows.Forms.TextBox txt_AddAlbum;
        private System.Windows.Forms.TextBox txt_AddSong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Albums;
        private System.Windows.Forms.Button btn_AddArtist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_playlistYes;
        private System.Windows.Forms.CheckBox chk_playlistNo;
        private System.Windows.Forms.Button btn_AddAlbum;
        private System.Windows.Forms.ComboBox cb_Artists;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_AddSong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Playlists;
        private System.Windows.Forms.ComboBox cb_ChoosePlaylist;
        private System.Windows.Forms.Label lbl_choosePlaylist;
    }
}