namespace TelClient
{
    partial class Form1
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
            this.btnSendCodeRequest = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSetSMS_Code = new System.Windows.Forms.Button();
            this.btnImportedContacts = new System.Windows.Forms.Button();
            this.edTelNum = new System.Windows.Forms.TextBox();
            this.edSMScode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendCodeRequest
            // 
            this.btnSendCodeRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendCodeRequest.Location = new System.Drawing.Point(41, 162);
            this.btnSendCodeRequest.Name = "btnSendCodeRequest";
            this.btnSendCodeRequest.Size = new System.Drawing.Size(195, 61);
            this.btnSendCodeRequest.TabIndex = 0;
            this.btnSendCodeRequest.Text = "SendCodeRequest";
            this.btnSendCodeRequest.UseVisualStyleBackColor = true;
            this.btnSendCodeRequest.Click += new System.EventHandler(this.btnSendCodeRequest_ClickAsync);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Location = new System.Drawing.Point(41, 22);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(195, 61);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_ClickAsync);
            // 
            // btnSetSMS_Code
            // 
            this.btnSetSMS_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetSMS_Code.Location = new System.Drawing.Point(41, 303);
            this.btnSetSMS_Code.Name = "btnSetSMS_Code";
            this.btnSetSMS_Code.Size = new System.Drawing.Size(195, 61);
            this.btnSetSMS_Code.TabIndex = 2;
            this.btnSetSMS_Code.Text = "Set SMS Code";
            this.btnSetSMS_Code.UseVisualStyleBackColor = true;
            this.btnSetSMS_Code.Click += new System.EventHandler(this.btnSetSMS_Code_ClickAsync);
            // 
            // btnImportedContacts
            // 
            this.btnImportedContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImportedContacts.Location = new System.Drawing.Point(41, 391);
            this.btnImportedContacts.Name = "btnImportedContacts";
            this.btnImportedContacts.Size = new System.Drawing.Size(195, 61);
            this.btnImportedContacts.TabIndex = 3;
            this.btnImportedContacts.Text = "Imported Contacts";
            this.btnImportedContacts.UseVisualStyleBackColor = true;
            this.btnImportedContacts.Click += new System.EventHandler(this.btnImportedContacts_ClickAsync);
            // 
            // edTelNum
            // 
            this.edTelNum.Location = new System.Drawing.Point(41, 114);
            this.edTelNum.Name = "edTelNum";
            this.edTelNum.Size = new System.Drawing.Size(170, 20);
            this.edTelNum.TabIndex = 4;
            this.edTelNum.Text = "+998901304288";
            // 
            // edSMScode
            // 
            this.edSMScode.Location = new System.Drawing.Point(41, 265);
            this.edSMScode.Name = "edSMScode";
            this.edSMScode.Size = new System.Drawing.Size(170, 20);
            this.edSMScode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SMS Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tel №";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edSMScode);
            this.Controls.Add(this.edTelNum);
            this.Controls.Add(this.btnImportedContacts);
            this.Controls.Add(this.btnSetSMS_Code);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSendCodeRequest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendCodeRequest;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnImportedContacts;
        private System.Windows.Forms.TextBox edTelNum;
        private System.Windows.Forms.TextBox edSMScode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnSetSMS_Code;
    }
}

