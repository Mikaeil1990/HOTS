namespace Client
{
    partial class FormGameRoom
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btUlty = new System.Windows.Forms.Button();
            this.btRefill = new System.Windows.Forms.Button();
            this.btAttack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbP2Mana = new System.Windows.Forms.Label();
            this.lbP2Health = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbP1Mana = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbP1Health = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelTurn = new System.Windows.Forms.Label();
            this.LbPlayer2 = new System.Windows.Forms.Label();
            this.LbPlayer1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkViolet;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(586, 725);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(613, 177);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // btUlty
            // 
            this.btUlty.BackColor = System.Drawing.Color.Transparent;
            this.btUlty.FlatAppearance.BorderSize = 5;
            this.btUlty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUlty.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUlty.ForeColor = System.Drawing.Color.Snow;
            this.btUlty.Location = new System.Drawing.Point(511, 348);
            this.btUlty.Name = "btUlty";
            this.btUlty.Size = new System.Drawing.Size(125, 73);
            this.btUlty.TabIndex = 17;
            this.btUlty.Text = "Ulty";
            this.btUlty.UseVisualStyleBackColor = false;
            this.btUlty.Click += new System.EventHandler(this.btUlty_Click);
            // 
            // btRefill
            // 
            this.btRefill.BackColor = System.Drawing.Color.Transparent;
            this.btRefill.FlatAppearance.BorderSize = 5;
            this.btRefill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefill.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefill.ForeColor = System.Drawing.Color.Snow;
            this.btRefill.Location = new System.Drawing.Point(511, 424);
            this.btRefill.Name = "btRefill";
            this.btRefill.Size = new System.Drawing.Size(125, 73);
            this.btRefill.TabIndex = 16;
            this.btRefill.Text = "Refill";
            this.btRefill.UseVisualStyleBackColor = false;
            this.btRefill.Click += new System.EventHandler(this.btRefill_Click);
            // 
            // btAttack
            // 
            this.btAttack.BackColor = System.Drawing.Color.Transparent;
            this.btAttack.FlatAppearance.BorderSize = 5;
            this.btAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAttack.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAttack.ForeColor = System.Drawing.Color.Snow;
            this.btAttack.Location = new System.Drawing.Point(511, 272);
            this.btAttack.Name = "btAttack";
            this.btAttack.Size = new System.Drawing.Size(125, 73);
            this.btAttack.TabIndex = 15;
            this.btAttack.Text = "Attack";
            this.btAttack.UseVisualStyleBackColor = false;
            this.btAttack.Click += new System.EventHandler(this.btAttack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbP2Mana);
            this.panel2.Controls.Add(this.lbP2Health);
            this.panel2.Controls.Add(this.progressBar4);
            this.panel2.Controls.Add(this.progressBar2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(660, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 597);
            this.panel2.TabIndex = 14;
            this.panel2.Visible = false;
            // 
            // lbP2Mana
            // 
            this.lbP2Mana.AutoSize = true;
            this.lbP2Mana.BackColor = System.Drawing.Color.Transparent;
            this.lbP2Mana.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP2Mana.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbP2Mana.Location = new System.Drawing.Point(18, 50);
            this.lbP2Mana.Name = "lbP2Mana";
            this.lbP2Mana.Size = new System.Drawing.Size(66, 26);
            this.lbP2Mana.TabIndex = 16;
            this.lbP2Mana.Text = "Mana";
            // 
            // lbP2Health
            // 
            this.lbP2Health.AutoSize = true;
            this.lbP2Health.BackColor = System.Drawing.Color.Transparent;
            this.lbP2Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP2Health.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbP2Health.Location = new System.Drawing.Point(18, 24);
            this.lbP2Health.Name = "lbP2Health";
            this.lbP2Health.Size = new System.Drawing.Size(43, 26);
            this.lbP2Health.TabIndex = 15;
            this.lbP2Health.Text = "HP";
            // 
            // progressBar4
            // 
            this.progressBar4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar4.Location = new System.Drawing.Point(148, 53);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(270, 10);
            this.progressBar4.TabIndex = 3;
            this.progressBar4.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(148, 17);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(270, 30);
            this.progressBar2.TabIndex = 1;
            this.progressBar2.Value = 100;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(23, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 489);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbP1Mana);
            this.panel1.Controls.Add(this.progressBar3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbP1Health);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(31, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 597);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // lbP1Mana
            // 
            this.lbP1Mana.AutoSize = true;
            this.lbP1Mana.BackColor = System.Drawing.Color.Transparent;
            this.lbP1Mana.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP1Mana.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbP1Mana.Location = new System.Drawing.Point(18, 51);
            this.lbP1Mana.Name = "lbP1Mana";
            this.lbP1Mana.Size = new System.Drawing.Size(66, 26);
            this.lbP1Mana.TabIndex = 14;
            this.lbP1Mana.Text = "Mana";
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar3.Location = new System.Drawing.Point(148, 53);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(270, 10);
            this.progressBar3.TabIndex = 2;
            this.progressBar3.Value = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 489);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbP1Health
            // 
            this.lbP1Health.AutoSize = true;
            this.lbP1Health.BackColor = System.Drawing.Color.Transparent;
            this.lbP1Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP1Health.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbP1Health.Location = new System.Drawing.Point(18, 21);
            this.lbP1Health.Name = "lbP1Health";
            this.lbP1Health.Size = new System.Drawing.Size(43, 26);
            this.lbP1Health.TabIndex = 13;
            this.lbP1Health.Text = "HP";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(148, 17);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(270, 30);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 100;
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.BackColor = System.Drawing.Color.Transparent;
            this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.ForeColor = System.Drawing.Color.Red;
            this.labelTurn.Location = new System.Drawing.Point(537, 116);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(101, 48);
            this.labelTurn.TabIndex = 22;
            this.labelTurn.Text = "<----";
            // 
            // LbPlayer2
            // 
            this.LbPlayer2.AutoSize = true;
            this.LbPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.LbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPlayer2.ForeColor = System.Drawing.Color.Gold;
            this.LbPlayer2.Location = new System.Drawing.Point(695, 33);
            this.LbPlayer2.Name = "LbPlayer2";
            this.LbPlayer2.Size = new System.Drawing.Size(162, 48);
            this.LbPlayer2.TabIndex = 21;
            this.LbPlayer2.Text = "Player2";
            // 
            // LbPlayer1
            // 
            this.LbPlayer1.AutoSize = true;
            this.LbPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.LbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPlayer1.ForeColor = System.Drawing.Color.Gold;
            this.LbPlayer1.Location = new System.Drawing.Point(239, 33);
            this.LbPlayer1.Name = "LbPlayer1";
            this.LbPlayer1.Size = new System.Drawing.Size(162, 48);
            this.LbPlayer1.TabIndex = 20;
            this.LbPlayer1.Text = "Player1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(416, 844);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 58);
            this.button1.TabIndex = 23;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(31, 790);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 39);
            this.textBox1.TabIndex = 24;
            // 
            // FormGameRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 953);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.LbPlayer2);
            this.Controls.Add(this.LbPlayer1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btUlty);
            this.Controls.Add(this.btRefill);
            this.Controls.Add(this.btAttack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormGameRoom";
            this.Text = "Room: ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btUlty;
        private System.Windows.Forms.Button btRefill;
        private System.Windows.Forms.Button btAttack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbP2Mana;
        private System.Windows.Forms.Label lbP2Health;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbP1Mana;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbP1Health;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Label LbPlayer2;
        private System.Windows.Forms.Label LbPlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}