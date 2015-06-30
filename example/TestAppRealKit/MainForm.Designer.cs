namespace TestAppRealKit
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btAuthenticate = new System.Windows.Forms.Button();
            this.btCreateRoom = new System.Windows.Forms.Button();
            this.btNotifyUser = new System.Windows.Forms.Button();
            this.btGetLogin = new System.Windows.Forms.Button();
            this.btLeaveRoom = new System.Windows.Forms.Button();
            this.btNotifyRoom = new System.Windows.Forms.Button();
            this.btJoinRoom = new System.Windows.Forms.Button();
            this.btGetRoom = new System.Windows.Forms.Button();
            this.txtRoomID2 = new System.Windows.Forms.TextBox();
            this.txtRoomID4 = new System.Windows.Forms.TextBox();
            this.txtRoomID1 = new System.Windows.Forms.TextBox();
            this.txtRoomID3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAuthenticate
            // 
            this.btAuthenticate.Location = new System.Drawing.Point(23, 13);
            this.btAuthenticate.Name = "btAuthenticate";
            this.btAuthenticate.Size = new System.Drawing.Size(271, 23);
            this.btAuthenticate.TabIndex = 0;
            this.btAuthenticate.Text = "AUTHENTICATE";
            this.btAuthenticate.UseVisualStyleBackColor = true;
            this.btAuthenticate.Click += new System.EventHandler(this.btAuthenticate_Click);
            // 
            // btCreateRoom
            // 
            this.btCreateRoom.Location = new System.Drawing.Point(331, 13);
            this.btCreateRoom.Name = "btCreateRoom";
            this.btCreateRoom.Size = new System.Drawing.Size(254, 23);
            this.btCreateRoom.TabIndex = 1;
            this.btCreateRoom.Text = "CREATE ROOM";
            this.btCreateRoom.UseVisualStyleBackColor = true;
            this.btCreateRoom.Click += new System.EventHandler(this.btCreateRoom_Click);
            // 
            // btNotifyUser
            // 
            this.btNotifyUser.Location = new System.Drawing.Point(331, 53);
            this.btNotifyUser.Name = "btNotifyUser";
            this.btNotifyUser.Size = new System.Drawing.Size(254, 23);
            this.btNotifyUser.TabIndex = 3;
            this.btNotifyUser.Text = "NOTIFY USERS";
            this.btNotifyUser.UseVisualStyleBackColor = true;
            this.btNotifyUser.Click += new System.EventHandler(this.btNotifyUser_Click);
            // 
            // btGetLogin
            // 
            this.btGetLogin.Location = new System.Drawing.Point(23, 53);
            this.btGetLogin.Name = "btGetLogin";
            this.btGetLogin.Size = new System.Drawing.Size(271, 23);
            this.btGetLogin.TabIndex = 4;
            this.btGetLogin.Text = "GET LOGIN";
            this.btGetLogin.UseVisualStyleBackColor = true;
            this.btGetLogin.Click += new System.EventHandler(this.btGetLogin_Click);
            // 
            // btLeaveRoom
            // 
            this.btLeaveRoom.Location = new System.Drawing.Point(430, 273);
            this.btLeaveRoom.Name = "btLeaveRoom";
            this.btLeaveRoom.Size = new System.Drawing.Size(155, 23);
            this.btLeaveRoom.TabIndex = 5;
            this.btLeaveRoom.Text = "LEAVE ROOM";
            this.btLeaveRoom.UseVisualStyleBackColor = true;
            this.btLeaveRoom.Click += new System.EventHandler(this.btLeaveRoom_Click);
            // 
            // btNotifyRoom
            // 
            this.btNotifyRoom.Location = new System.Drawing.Point(430, 337);
            this.btNotifyRoom.Name = "btNotifyRoom";
            this.btNotifyRoom.Size = new System.Drawing.Size(155, 24);
            this.btNotifyRoom.TabIndex = 6;
            this.btNotifyRoom.Text = "NOTIFY ROOM";
            this.btNotifyRoom.UseVisualStyleBackColor = true;
            this.btNotifyRoom.Click += new System.EventHandler(this.btNotifyRoom_Click);
            // 
            // btJoinRoom
            // 
            this.btJoinRoom.Location = new System.Drawing.Point(430, 208);
            this.btJoinRoom.Name = "btJoinRoom";
            this.btJoinRoom.Size = new System.Drawing.Size(155, 23);
            this.btJoinRoom.TabIndex = 7;
            this.btJoinRoom.Text = "JOIN ROOM";
            this.btJoinRoom.UseVisualStyleBackColor = true;
            this.btJoinRoom.Click += new System.EventHandler(this.btJoinRoom_Click);
            // 
            // btGetRoom
            // 
            this.btGetRoom.Location = new System.Drawing.Point(430, 127);
            this.btGetRoom.Name = "btGetRoom";
            this.btGetRoom.Size = new System.Drawing.Size(155, 23);
            this.btGetRoom.TabIndex = 8;
            this.btGetRoom.Text = "GET ROOM";
            this.btGetRoom.UseVisualStyleBackColor = true;
            this.btGetRoom.Click += new System.EventHandler(this.btGetRoom_Click);
            // 
            // txtRoomID2
            // 
            this.txtRoomID2.Location = new System.Drawing.Point(23, 208);
            this.txtRoomID2.Name = "txtRoomID2";
            this.txtRoomID2.Size = new System.Drawing.Size(391, 20);
            this.txtRoomID2.TabIndex = 9;
            // 
            // txtRoomID4
            // 
            this.txtRoomID4.Location = new System.Drawing.Point(23, 341);
            this.txtRoomID4.Name = "txtRoomID4";
            this.txtRoomID4.Size = new System.Drawing.Size(391, 20);
            this.txtRoomID4.TabIndex = 10;
            // 
            // txtRoomID1
            // 
            this.txtRoomID1.Location = new System.Drawing.Point(23, 127);
            this.txtRoomID1.Name = "txtRoomID1";
            this.txtRoomID1.Size = new System.Drawing.Size(391, 20);
            this.txtRoomID1.TabIndex = 11;
            // 
            // txtRoomID3
            // 
            this.txtRoomID3.Location = new System.Drawing.Point(23, 276);
            this.txtRoomID3.Name = "txtRoomID3";
            this.txtRoomID3.Size = new System.Drawing.Size(391, 20);
            this.txtRoomID3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "© 2015 - AppRealKit Group. All Rights Reserved.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomID3);
            this.Controls.Add(this.txtRoomID1);
            this.Controls.Add(this.txtRoomID4);
            this.Controls.Add(this.txtRoomID2);
            this.Controls.Add(this.btGetRoom);
            this.Controls.Add(this.btJoinRoom);
            this.Controls.Add(this.btNotifyRoom);
            this.Controls.Add(this.btLeaveRoom);
            this.Controls.Add(this.btGetLogin);
            this.Controls.Add(this.btNotifyUser);
            this.Controls.Add(this.btCreateRoom);
            this.Controls.Add(this.btAuthenticate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppRealKit Demo for .NET";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAuthenticate;
        private System.Windows.Forms.Button btCreateRoom;
        private System.Windows.Forms.Button btNotifyUser;
        private System.Windows.Forms.Button btGetLogin;
        private System.Windows.Forms.Button btLeaveRoom;
        private System.Windows.Forms.Button btNotifyRoom;
        private System.Windows.Forms.Button btJoinRoom;
        private System.Windows.Forms.Button btGetRoom;
        private System.Windows.Forms.TextBox txtRoomID2;
        private System.Windows.Forms.TextBox txtRoomID4;
        private System.Windows.Forms.TextBox txtRoomID1;
        private System.Windows.Forms.TextBox txtRoomID3;
        private System.Windows.Forms.Label label1;
    }
}

