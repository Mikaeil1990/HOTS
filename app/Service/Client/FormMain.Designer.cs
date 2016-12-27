namespace Client
{
    partial class FormMain
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
            this.pbSelectTyrael = new System.Windows.Forms.PictureBox();
            this.pbSelectkerrigan = new System.Windows.Forms.PictureBox();
            this.pbSelectTychus = new System.Windows.Forms.PictureBox();
            this.pbSelectedHero = new System.Windows.Forms.PictureBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.listBoxOnlinePlayers = new System.Windows.Forms.ListBox();
            this.btGameReq = new System.Windows.Forms.Button();
            this.labelVS = new System.Windows.Forms.Label();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelGAMEs = new System.Windows.Forms.Label();
            this.labelWINS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectTyrael)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectkerrigan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectTychus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedHero)).BeginInit();
            this.groupBoxProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSelectTyrael
            // 
            this.pbSelectTyrael.Image = global::Client.Properties.Resources.TyraelSelect;
            this.pbSelectTyrael.Location = new System.Drawing.Point(12, 465);
            this.pbSelectTyrael.Name = "pbSelectTyrael";
            this.pbSelectTyrael.Size = new System.Drawing.Size(77, 220);
            this.pbSelectTyrael.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectTyrael.TabIndex = 7;
            this.pbSelectTyrael.TabStop = false;
            this.pbSelectTyrael.Click += new System.EventHandler(this.pbSelectTyrael_Click);
            // 
            // pbSelectkerrigan
            // 
            this.pbSelectkerrigan.Image = global::Client.Properties.Resources.KeriganSelect;
            this.pbSelectkerrigan.Location = new System.Drawing.Point(12, 239);
            this.pbSelectkerrigan.Name = "pbSelectkerrigan";
            this.pbSelectkerrigan.Size = new System.Drawing.Size(77, 220);
            this.pbSelectkerrigan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectkerrigan.TabIndex = 8;
            this.pbSelectkerrigan.TabStop = false;
            this.pbSelectkerrigan.Click += new System.EventHandler(this.pbSelectkerrigan_Click);
            // 
            // pbSelectTychus
            // 
            this.pbSelectTychus.Image = global::Client.Properties.Resources.TychusSelect;
            this.pbSelectTychus.Location = new System.Drawing.Point(12, 13);
            this.pbSelectTychus.Name = "pbSelectTychus";
            this.pbSelectTychus.Size = new System.Drawing.Size(77, 220);
            this.pbSelectTychus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectTychus.TabIndex = 9;
            this.pbSelectTychus.TabStop = false;
            this.pbSelectTychus.Click += new System.EventHandler(this.pbSelectTychus_Click);
            // 
            // pbSelectedHero
            // 
            this.pbSelectedHero.BackColor = System.Drawing.Color.Transparent;
            this.pbSelectedHero.Location = new System.Drawing.Point(105, 102);
            this.pbSelectedHero.Name = "pbSelectedHero";
            this.pbSelectedHero.Size = new System.Drawing.Size(400, 406);
            this.pbSelectedHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectedHero.TabIndex = 10;
            this.pbSelectedHero.TabStop = false;
            this.pbSelectedHero.Click += new System.EventHandler(this.pbSelectedHero_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.DarkOrchid;
            this.buttonSubmit.Location = new System.Drawing.Point(177, 531);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(252, 66);
            this.buttonSubmit.TabIndex = 11;
            this.buttonSubmit.Text = "Ready";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // listBoxOnlinePlayers
            // 
            this.listBoxOnlinePlayers.FormattingEnabled = true;
            this.listBoxOnlinePlayers.ItemHeight = 16;
            this.listBoxOnlinePlayers.Location = new System.Drawing.Point(837, 49);
            this.listBoxOnlinePlayers.Name = "listBoxOnlinePlayers";
            this.listBoxOnlinePlayers.Size = new System.Drawing.Size(146, 164);
            this.listBoxOnlinePlayers.TabIndex = 12;
            // 
            // btGameReq
            // 
            this.btGameReq.BackColor = System.Drawing.Color.Transparent;
            this.btGameReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGameReq.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGameReq.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btGameReq.Location = new System.Drawing.Point(837, 219);
            this.btGameReq.Name = "btGameReq";
            this.btGameReq.Size = new System.Drawing.Size(135, 43);
            this.btGameReq.TabIndex = 13;
            this.btGameReq.Text = "Request";
            this.btGameReq.UseVisualStyleBackColor = false;
            this.btGameReq.Click += new System.EventHandler(this.btGameReq_Click);
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.BackColor = System.Drawing.Color.Transparent;
            this.labelVS.Font = new System.Drawing.Font("Forte", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVS.ForeColor = System.Drawing.Color.DarkOrchid;
            this.labelVS.Location = new System.Drawing.Point(530, 299);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(263, 87);
            this.labelVS.TabIndex = 15;
            this.labelVS.Text = "VS. AI";
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.ItemHeight = 16;
            this.listBoxRooms.Location = new System.Drawing.Point(658, 49);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(146, 164);
            this.listBoxRooms.TabIndex = 16;
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxProfile.Controls.Add(this.labelWINS);
            this.groupBoxProfile.Controls.Add(this.labelGAMEs);
            this.groupBoxProfile.Controls.Add(this.labelEmail);
            this.groupBoxProfile.Controls.Add(this.labelUserName);
            this.groupBoxProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProfile.ForeColor = System.Drawing.Color.DarkOrchid;
            this.groupBoxProfile.Location = new System.Drawing.Point(12, 705);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(971, 146);
            this.groupBoxProfile.TabIndex = 17;
            this.groupBoxProfile.TabStop = false;
            this.groupBoxProfile.Text = "Profile";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(88, 85);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(92, 29);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email: ";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(74, 44);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(151, 29);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User name: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button1.Location = new System.Drawing.Point(658, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "Request";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelGAMEs
            // 
            this.labelGAMEs.AutoSize = true;
            this.labelGAMEs.Location = new System.Drawing.Point(580, 44);
            this.labelGAMEs.Name = "labelGAMEs";
            this.labelGAMEs.Size = new System.Drawing.Size(194, 29);
            this.labelGAMEs.TabIndex = 2;
            this.labelGAMEs.Text = "Games Played: ";
            // 
            // labelWINS
            // 
            this.labelWINS.AutoSize = true;
            this.labelWINS.Location = new System.Drawing.Point(580, 85);
            this.labelWINS.Name = "labelWINS";
            this.labelWINS.Size = new System.Drawing.Size(160, 29);
            this.labelWINS.TabIndex = 3;
            this.labelWINS.Text = "Games Win: ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 914);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.listBoxRooms);
            this.Controls.Add(this.labelVS);
            this.Controls.Add(this.btGameReq);
            this.Controls.Add(this.listBoxOnlinePlayers);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.pbSelectedHero);
            this.Controls.Add(this.pbSelectTychus);
            this.Controls.Add(this.pbSelectkerrigan);
            this.Controls.Add(this.pbSelectTyrael);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectTyrael)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectkerrigan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectTychus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedHero)).EndInit();
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSelectTyrael;
        private System.Windows.Forms.PictureBox pbSelectkerrigan;
        private System.Windows.Forms.PictureBox pbSelectTychus;
        private System.Windows.Forms.PictureBox pbSelectedHero;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ListBox listBoxOnlinePlayers;
        private System.Windows.Forms.Button btGameReq;
        private System.Windows.Forms.Label labelVS;
        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelWINS;
        private System.Windows.Forms.Label labelGAMEs;
    }
}