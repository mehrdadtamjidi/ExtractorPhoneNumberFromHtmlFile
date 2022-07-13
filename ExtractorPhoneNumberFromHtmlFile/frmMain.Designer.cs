namespace ExtractorPhoneNumberFromHtmlFile
{
    partial class frmMain
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLoadContact = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCountFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this._lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPhoneNumberList = new System.Windows.Forms.ListBox();
            this.bgwExtractor = new System.ComponentModel.BackgroundWorker();
            this.lblLoadMessage = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(179, 626);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(104, 626);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(69, 23);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLoadContact
            // 
            this.btnLoadContact.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadContact.ForeColor = System.Drawing.Color.Black;
            this.btnLoadContact.Location = new System.Drawing.Point(29, 626);
            this.btnLoadContact.Name = "btnLoadContact";
            this.btnLoadContact.Size = new System.Drawing.Size(69, 23);
            this.btnLoadContact.TabIndex = 18;
            this.btnLoadContact.Text = "Load";
            this.btnLoadContact.UseVisualStyleBackColor = true;
            this.btnLoadContact.Click += new System.EventHandler(this.btnLoadContact_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCountFile);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this._lblCount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbPhoneNumberList);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 585);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extractor Phone Number";
            // 
            // lblCountFile
            // 
            this.lblCountFile.AutoSize = true;
            this.lblCountFile.Location = new System.Drawing.Point(72, 569);
            this.lblCountFile.Name = "lblCountFile";
            this.lblCountFile.Size = new System.Drawing.Size(0, 13);
            this.lblCountFile.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Count File :";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(11, 510);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(176, 509);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(69, 23);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // _lblCount
            // 
            this._lblCount.AutoSize = true;
            this._lblCount.Location = new System.Drawing.Point(53, 546);
            this._lblCount.Name = "_lblCount";
            this._lblCount.Size = new System.Drawing.Size(0, 13);
            this._lblCount.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Count :";
            // 
            // lbPhoneNumberList
            // 
            this.lbPhoneNumberList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbPhoneNumberList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumberList.FormattingEnabled = true;
            this.lbPhoneNumberList.ItemHeight = 16;
            this.lbPhoneNumberList.Location = new System.Drawing.Point(9, 19);
            this.lbPhoneNumberList.Name = "lbPhoneNumberList";
            this.lbPhoneNumberList.Size = new System.Drawing.Size(239, 516);
            this.lbPhoneNumberList.TabIndex = 0;
            // 
            // bgwExtractor
            // 
            this.bgwExtractor.WorkerReportsProgress = true;
            this.bgwExtractor.WorkerSupportsCancellation = true;
            this.bgwExtractor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExtractor_DoWork);
            // 
            // lblLoadMessage
            // 
            this.lblLoadMessage.AutoSize = true;
            this.lblLoadMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLoadMessage.ForeColor = System.Drawing.Color.Green;
            this.lblLoadMessage.Location = new System.Drawing.Point(32, 603);
            this.lblLoadMessage.Name = "lblLoadMessage";
            this.lblLoadMessage.Size = new System.Drawing.Size(0, 16);
            this.lblLoadMessage.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 669);
            this.Controls.Add(this.lblLoadMessage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnLoadContact);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extractor Phone Number";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLoadContact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCountFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label _lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPhoneNumberList;
        private System.ComponentModel.BackgroundWorker bgwExtractor;
        private System.Windows.Forms.Label lblLoadMessage;
    }
}

