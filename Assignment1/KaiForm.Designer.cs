namespace Assignment1
{
    partial class KaiForm
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
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.lblKaiID = new System.Windows.Forms.Label();
            this.txtKaiID = new System.Windows.Forms.TextBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtKaiName = new System.Windows.Forms.TextBox();
            this.lblKaiName = new System.Windows.Forms.Label();
            this.txtPreperation = new System.Windows.Forms.TextBox();
            this.lblPreperation = new System.Windows.Forms.Label();
            this.txtPreperationTime = new System.Windows.Forms.TextBox();
            this.lblPreperationTime = new System.Windows.Forms.Label();
            this.txtServingQuantity = new System.Windows.Forms.TextBox();
            this.lblServingQuantity = new System.Windows.Forms.Label();
            this.checkPreperation = new System.Windows.Forms.CheckBox();
            this.numServing = new System.Windows.Forms.NumericUpDown();
            this.numPreperation = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.lstKai = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numServing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreperation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.Location = new System.Drawing.Point(33, 424);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(109, 105);
            this.btnUp.TabIndex = 10;
            this.btnUp.Text = "UP";
            this.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.Location = new System.Drawing.Point(148, 424);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(109, 105);
            this.btnDown.TabIndex = 11;
            this.btnDown.Text = "DOWN";
            this.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.Location = new System.Drawing.Point(669, 424);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(109, 105);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(293, 424);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 105);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(408, 424);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 105);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(523, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 105);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblKaiID
            // 
            this.lblKaiID.AutoSize = true;
            this.lblKaiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKaiID.Location = new System.Drawing.Point(452, 34);
            this.lblKaiID.Name = "lblKaiID";
            this.lblKaiID.Size = new System.Drawing.Size(65, 25);
            this.lblKaiID.TabIndex = 16;
            this.lblKaiID.Text = "Kai ID";
            // 
            // txtKaiID
            // 
            this.txtKaiID.Location = new System.Drawing.Point(537, 36);
            this.txtKaiID.Name = "txtKaiID";
            this.txtKaiID.Size = new System.Drawing.Size(186, 22);
            this.txtKaiID.TabIndex = 17;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEvent.Location = new System.Drawing.Point(452, 80);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(62, 25);
            this.lblEvent.TabIndex = 18;
            this.lblEvent.Text = "Event";
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(537, 84);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(186, 22);
            this.txtEvent.TabIndex = 19;
            // 
            // txtKaiName
            // 
            this.txtKaiName.Location = new System.Drawing.Point(537, 132);
            this.txtKaiName.Name = "txtKaiName";
            this.txtKaiName.Size = new System.Drawing.Size(186, 22);
            this.txtKaiName.TabIndex = 20;
            // 
            // lblKaiName
            // 
            this.lblKaiName.AutoSize = true;
            this.lblKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKaiName.Location = new System.Drawing.Point(416, 132);
            this.lblKaiName.Name = "lblKaiName";
            this.lblKaiName.Size = new System.Drawing.Size(98, 25);
            this.lblKaiName.TabIndex = 21;
            this.lblKaiName.Text = "Kai Name";
            // 
            // txtPreperation
            // 
            this.txtPreperation.Location = new System.Drawing.Point(537, 179);
            this.txtPreperation.Name = "txtPreperation";
            this.txtPreperation.Size = new System.Drawing.Size(186, 22);
            this.txtPreperation.TabIndex = 22;
            // 
            // lblPreperation
            // 
            this.lblPreperation.AutoSize = true;
            this.lblPreperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreperation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPreperation.Location = new System.Drawing.Point(391, 179);
            this.lblPreperation.Name = "lblPreperation";
            this.lblPreperation.Size = new System.Drawing.Size(123, 25);
            this.lblPreperation.TabIndex = 23;
            this.lblPreperation.Text = "Preperation?";
            // 
            // txtPreperationTime
            // 
            this.txtPreperationTime.Location = new System.Drawing.Point(537, 227);
            this.txtPreperationTime.Name = "txtPreperationTime";
            this.txtPreperationTime.Size = new System.Drawing.Size(95, 22);
            this.txtPreperationTime.TabIndex = 24;
            // 
            // lblPreperationTime
            // 
            this.lblPreperationTime.AutoSize = true;
            this.lblPreperationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreperationTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPreperationTime.Location = new System.Drawing.Point(356, 224);
            this.lblPreperationTime.Name = "lblPreperationTime";
            this.lblPreperationTime.Size = new System.Drawing.Size(161, 25);
            this.lblPreperationTime.TabIndex = 25;
            this.lblPreperationTime.Text = "Preperation Time";
            // 
            // txtServingQuantity
            // 
            this.txtServingQuantity.Location = new System.Drawing.Point(537, 273);
            this.txtServingQuantity.Name = "txtServingQuantity";
            this.txtServingQuantity.Size = new System.Drawing.Size(95, 22);
            this.txtServingQuantity.TabIndex = 26;
            // 
            // lblServingQuantity
            // 
            this.lblServingQuantity.AutoSize = true;
            this.lblServingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServingQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblServingQuantity.Location = new System.Drawing.Point(360, 273);
            this.lblServingQuantity.Name = "lblServingQuantity";
            this.lblServingQuantity.Size = new System.Drawing.Size(157, 25);
            this.lblServingQuantity.TabIndex = 27;
            this.lblServingQuantity.Text = "Serving Quantity";
            // 
            // checkPreperation
            // 
            this.checkPreperation.AutoSize = true;
            this.checkPreperation.Location = new System.Drawing.Point(537, 185);
            this.checkPreperation.Name = "checkPreperation";
            this.checkPreperation.Size = new System.Drawing.Size(18, 17);
            this.checkPreperation.TabIndex = 28;
            this.checkPreperation.UseVisualStyleBackColor = true;
            // 
            // numServing
            // 
            this.numServing.Location = new System.Drawing.Point(537, 273);
            this.numServing.Name = "numServing";
            this.numServing.Size = new System.Drawing.Size(120, 22);
            this.numServing.TabIndex = 29;
            // 
            // numPreperation
            // 
            this.numPreperation.Location = new System.Drawing.Point(537, 227);
            this.numPreperation.Name = "numPreperation";
            this.numPreperation.Size = new System.Drawing.Size(120, 22);
            this.numPreperation.TabIndex = 30;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.Location = new System.Drawing.Point(408, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 50);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(561, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 50);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstKai
            // 
            this.lstKai.FormattingEnabled = true;
            this.lstKai.ItemHeight = 16;
            this.lstKai.Location = new System.Drawing.Point(21, 23);
            this.lstKai.Name = "lstKai";
            this.lstKai.Size = new System.Drawing.Size(272, 356);
            this.lstKai.TabIndex = 33;
            // 
            // KaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.lstKai);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPreperation);
            this.Controls.Add(this.numServing);
            this.Controls.Add(this.checkPreperation);
            this.Controls.Add(this.lblServingQuantity);
            this.Controls.Add(this.txtServingQuantity);
            this.Controls.Add(this.lblPreperationTime);
            this.Controls.Add(this.txtPreperationTime);
            this.Controls.Add(this.lblPreperation);
            this.Controls.Add(this.txtPreperation);
            this.Controls.Add(this.lblKaiName);
            this.Controls.Add(this.txtKaiName);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.txtKaiID);
            this.Controls.Add(this.lblKaiID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Name = "KaiForm";
            this.Text = "Kai Management";
            this.Load += new System.EventHandler(this.KaiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numServing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreperation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnUp;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.Label lblKaiID;
        private System.Windows.Forms.TextBox txtKaiID;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.TextBox txtKaiName;
        private System.Windows.Forms.Label lblKaiName;
        private System.Windows.Forms.TextBox txtPreperation;
        private System.Windows.Forms.Label lblPreperation;
        private System.Windows.Forms.TextBox txtPreperationTime;
        private System.Windows.Forms.Label lblPreperationTime;
        private System.Windows.Forms.TextBox txtServingQuantity;
        private System.Windows.Forms.Label lblServingQuantity;
        private System.Windows.Forms.CheckBox checkPreperation;
        private System.Windows.Forms.NumericUpDown numServing;
        private System.Windows.Forms.NumericUpDown numPreperation;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.ListBox lstKai;
    }
}