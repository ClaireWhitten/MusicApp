
namespace MusicApp
{
    partial class Form4
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
            this.txt_NewPlaylistName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ChooseAlbum = new System.Windows.Forms.ComboBox();
            this.lb_ChooseSong = new System.Windows.Forms.ListBox();
            this.btn_addsong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SavePlaylist = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFinalPlaylist = new System.Windows.Forms.ComboBox();
            this.lbl_SongsAdded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name for playlist:";
            // 
            // txt_NewPlaylistName
            // 
            this.txt_NewPlaylistName.Location = new System.Drawing.Point(213, 68);
            this.txt_NewPlaylistName.Name = "txt_NewPlaylistName";
            this.txt_NewPlaylistName.Size = new System.Drawing.Size(183, 20);
            this.txt_NewPlaylistName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add songs from different albums";
            // 
            // cb_ChooseAlbum
            // 
            this.cb_ChooseAlbum.FormattingEnabled = true;
            this.cb_ChooseAlbum.Location = new System.Drawing.Point(213, 158);
            this.cb_ChooseAlbum.Name = "cb_ChooseAlbum";
            this.cb_ChooseAlbum.Size = new System.Drawing.Size(138, 21);
            this.cb_ChooseAlbum.TabIndex = 2;
            this.cb_ChooseAlbum.SelectedIndexChanged += new System.EventHandler(this.cb_ChooseAlbum_SelectedIndexChanged);
            // 
            // lb_ChooseSong
            // 
            this.lb_ChooseSong.FormattingEnabled = true;
            this.lb_ChooseSong.Location = new System.Drawing.Point(403, 158);
            this.lb_ChooseSong.Name = "lb_ChooseSong";
            this.lb_ChooseSong.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_ChooseSong.Size = new System.Drawing.Size(194, 186);
            this.lb_ChooseSong.TabIndex = 3;
            this.lb_ChooseSong.SelectedIndexChanged += new System.EventHandler(this.lb_ChooseSong_SelectedIndexChanged);
            // 
            // btn_addsong
            // 
            this.btn_addsong.Location = new System.Drawing.Point(638, 158);
            this.btn_addsong.Name = "btn_addsong";
            this.btn_addsong.Size = new System.Drawing.Size(75, 23);
            this.btn_addsong.TabIndex = 4;
            this.btn_addsong.Text = "Add ";
            this.btn_addsong.UseVisualStyleBackColor = true;
            this.btn_addsong.Click += new System.EventHandler(this.btn_addsong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Song";
            // 
            // btn_SavePlaylist
            // 
            this.btn_SavePlaylist.Location = new System.Drawing.Point(295, 445);
            this.btn_SavePlaylist.Name = "btn_SavePlaylist";
            this.btn_SavePlaylist.Size = new System.Drawing.Size(172, 42);
            this.btn_SavePlaylist.TabIndex = 6;
            this.btn_SavePlaylist.Text = "Save Playlist";
            this.btn_SavePlaylist.UseVisualStyleBackColor = true;
            this.btn_SavePlaylist.Click += new System.EventHandler(this.btn_SavePlaylist_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(326, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "New Playlist";
            // 
            // cbFinalPlaylist
            // 
            this.cbFinalPlaylist.FormattingEnabled = true;
            this.cbFinalPlaylist.Location = new System.Drawing.Point(295, 418);
            this.cbFinalPlaylist.Name = "cbFinalPlaylist";
            this.cbFinalPlaylist.Size = new System.Drawing.Size(172, 21);
            this.cbFinalPlaylist.TabIndex = 8;
            // 
            // lbl_SongsAdded
            // 
            this.lbl_SongsAdded.AutoSize = true;
            this.lbl_SongsAdded.Location = new System.Drawing.Point(339, 391);
            this.lbl_SongsAdded.Name = "lbl_SongsAdded";
            this.lbl_SongsAdded.Size = new System.Drawing.Size(82, 13);
            this.lbl_SongsAdded.TabIndex = 9;
            this.lbl_SongsAdded.Text = "All songs added";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.lbl_SongsAdded);
            this.Controls.Add(this.cbFinalPlaylist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_SavePlaylist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_addsong);
            this.Controls.Add(this.lb_ChooseSong);
            this.Controls.Add(this.cb_ChooseAlbum);
            this.Controls.Add(this.txt_NewPlaylistName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NewPlaylistName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_ChooseAlbum;
        private System.Windows.Forms.ListBox lb_ChooseSong;
        private System.Windows.Forms.Button btn_addsong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SavePlaylist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFinalPlaylist;
        private System.Windows.Forms.Label lbl_SongsAdded;
    }
}