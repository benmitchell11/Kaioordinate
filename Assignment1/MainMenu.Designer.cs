namespace Assignment1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lblKai = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKai = new FontAwesome.Sharp.IconButton();
            this.btnRegistration = new FontAwesome.Sharp.IconButton();
            this.btnLocations = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnEvents = new FontAwesome.Sharp.IconButton();
            this.btnWhanau = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKai
            // 
            this.lblKai.AutoSize = true;
            this.lblKai.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKai.Location = new System.Drawing.Point(176, 26);
            this.lblKai.Name = "lblKai";
            this.lblKai.Size = new System.Drawing.Size(570, 105);
            this.lblKai.TabIndex = 7;
            this.lblKai.Text = "Kaioordinate";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 107);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnKai
            // 
            this.btnKai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKai.IconChar = FontAwesome.Sharp.IconChar.DrumstickBite;
            this.btnKai.IconColor = System.Drawing.Color.Black;
            this.btnKai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKai.Location = new System.Drawing.Point(51, 161);
            this.btnKai.Name = "btnKai";
            this.btnKai.Size = new System.Drawing.Size(156, 105);
            this.btnKai.TabIndex = 9;
            this.btnKai.Text = "KAI";
            this.btnKai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKai.UseVisualStyleBackColor = true;
            this.btnKai.Click += new System.EventHandler(this.btnKai_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnRegistration.IconColor = System.Drawing.Color.Black;
            this.btnRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistration.Location = new System.Drawing.Point(51, 287);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(156, 105);
            this.btnRegistration.TabIndex = 10;
            this.btnRegistration.Text = "REGISTRATION";
            this.btnRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnLocations
            // 
            this.btnLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.btnLocations.IconColor = System.Drawing.Color.Black;
            this.btnLocations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLocations.Location = new System.Drawing.Point(590, 161);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(156, 105);
            this.btnLocations.TabIndex = 11;
            this.btnLocations.Text = "LOCATIONS";
            this.btnLocations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLocations.UseVisualStyleBackColor = true;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(590, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 105);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnEvents.IconColor = System.Drawing.Color.Black;
            this.btnEvents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEvents.Location = new System.Drawing.Point(233, 161);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(156, 105);
            this.btnEvents.TabIndex = 13;
            this.btnEvents.Text = "EVENTS";
            this.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnWhanau
            // 
            this.btnWhanau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhanau.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnWhanau.IconColor = System.Drawing.Color.Black;
            this.btnWhanau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWhanau.Location = new System.Drawing.Point(414, 161);
            this.btnWhanau.Name = "btnWhanau";
            this.btnWhanau.Size = new System.Drawing.Size(156, 105);
            this.btnWhanau.TabIndex = 14;
            this.btnWhanau.Text = "WHĀNAU ";
            this.btnWhanau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWhanau.UseVisualStyleBackColor = true;
            this.btnWhanau.Click += new System.EventHandler(this.btnWhanau_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnReport.IconColor = System.Drawing.Color.Black;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.Location = new System.Drawing.Point(233, 287);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(156, 105);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "REPORT";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnWhanau);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnKai);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKai);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnKai;
        private FontAwesome.Sharp.IconButton btnRegistration;
        private FontAwesome.Sharp.IconButton btnLocations;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnEvents;
        private FontAwesome.Sharp.IconButton btnWhanau;
        private FontAwesome.Sharp.IconButton btnReport;
    }
}

