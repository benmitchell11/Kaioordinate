namespace Assignment1
{
    partial class RegistrationForm
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
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.dgvWhanau = new System.Windows.Forms.DataGridView();
            this.dgvRegistrations = new System.Windows.Forms.DataGridView();
            this.checkKaiPrepAssist = new System.Windows.Forms.CheckBox();
            this.lblKaiPrepAssist = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblWhanau = new System.Windows.Forms.Label();
            this.lblRegistrations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWhanau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(377, 414);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 105);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(492, 414);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 105);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.Location = new System.Drawing.Point(679, 414);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(109, 105);
            this.btnReturn.TabIndex = 40;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(26, 48);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.Size = new System.Drawing.Size(327, 233);
            this.dgvEvents.TabIndex = 42;
            // 
            // dgvWhanau
            // 
            this.dgvWhanau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWhanau.Location = new System.Drawing.Point(377, 48);
            this.dgvWhanau.Name = "dgvWhanau";
            this.dgvWhanau.RowHeadersWidth = 51;
            this.dgvWhanau.RowTemplate.Height = 24;
            this.dgvWhanau.Size = new System.Drawing.Size(392, 233);
            this.dgvWhanau.TabIndex = 43;
            // 
            // dgvRegistrations
            // 
            this.dgvRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrations.Location = new System.Drawing.Point(26, 331);
            this.dgvRegistrations.Name = "dgvRegistrations";
            this.dgvRegistrations.RowHeadersWidth = 51;
            this.dgvRegistrations.RowTemplate.Height = 24;
            this.dgvRegistrations.Size = new System.Drawing.Size(327, 188);
            this.dgvRegistrations.TabIndex = 44;
            // 
            // checkKaiPrepAssist
            // 
            this.checkKaiPrepAssist.AutoSize = true;
            this.checkKaiPrepAssist.Location = new System.Drawing.Point(377, 373);
            this.checkKaiPrepAssist.Name = "checkKaiPrepAssist";
            this.checkKaiPrepAssist.Size = new System.Drawing.Size(18, 17);
            this.checkKaiPrepAssist.TabIndex = 45;
            this.checkKaiPrepAssist.UseVisualStyleBackColor = true;
            // 
            // lblKaiPrepAssist
            // 
            this.lblKaiPrepAssist.AutoSize = true;
            this.lblKaiPrepAssist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiPrepAssist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKaiPrepAssist.Location = new System.Drawing.Point(401, 365);
            this.lblKaiPrepAssist.Name = "lblKaiPrepAssist";
            this.lblKaiPrepAssist.Size = new System.Drawing.Size(231, 25);
            this.lblKaiPrepAssist.TabIndex = 46;
            this.lblKaiPrepAssist.Text = "Kai Preperation Assistant";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEvents.Location = new System.Drawing.Point(21, 9);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(72, 25);
            this.lblEvents.TabIndex = 47;
            this.lblEvents.Text = "Events";
            // 
            // lblWhanau
            // 
            this.lblWhanau.AutoSize = true;
            this.lblWhanau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhanau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWhanau.Location = new System.Drawing.Point(372, 9);
            this.lblWhanau.Name = "lblWhanau";
            this.lblWhanau.Size = new System.Drawing.Size(87, 25);
            this.lblWhanau.TabIndex = 48;
            this.lblWhanau.Text = "Whānau";
            // 
            // lblRegistrations
            // 
            this.lblRegistrations.AutoSize = true;
            this.lblRegistrations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrations.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegistrations.Location = new System.Drawing.Point(21, 294);
            this.lblRegistrations.Name = "lblRegistrations";
            this.lblRegistrations.Size = new System.Drawing.Size(124, 25);
            this.lblRegistrations.TabIndex = 49;
            this.lblRegistrations.Text = "Registrations";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.lblRegistrations);
            this.Controls.Add(this.lblWhanau);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblKaiPrepAssist);
            this.Controls.Add(this.checkKaiPrepAssist);
            this.Controls.Add(this.dgvRegistrations);
            this.Controls.Add(this.dgvWhanau);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWhanau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridView dgvWhanau;
        private System.Windows.Forms.DataGridView dgvRegistrations;
        private System.Windows.Forms.CheckBox checkKaiPrepAssist;
        private System.Windows.Forms.Label lblKaiPrepAssist;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblWhanau;
        private System.Windows.Forms.Label lblRegistrations;
    }
}