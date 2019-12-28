namespace myAssistant1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnableVoice = new System.Windows.Forms.Button();
            this.btnDisableVoice = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.voiceBtn = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnEnableVoice
            // 
            this.btnEnableVoice.AccessibleName = "";
            this.btnEnableVoice.BackColor = System.Drawing.Color.White;
            this.btnEnableVoice.ForeColor = System.Drawing.Color.Black;
            this.btnEnableVoice.ImageIndex = 3;
            this.btnEnableVoice.ImageList = this.voiceBtn;
            this.btnEnableVoice.Location = new System.Drawing.Point(31, 214);
            this.btnEnableVoice.Name = "btnEnableVoice";
            this.btnEnableVoice.Size = new System.Drawing.Size(58, 61);
            this.btnEnableVoice.TabIndex = 1;
            this.btnEnableVoice.UseVisualStyleBackColor = false;
            this.btnEnableVoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisableVoice
            // 
            this.btnDisableVoice.AccessibleName = "";
            this.btnDisableVoice.BackColor = System.Drawing.Color.White;
            this.btnDisableVoice.Enabled = false;
            this.btnDisableVoice.ForeColor = System.Drawing.Color.Black;
            this.btnDisableVoice.ImageIndex = 0;
            this.btnDisableVoice.ImageList = this.voiceBtn;
            this.btnDisableVoice.Location = new System.Drawing.Point(476, 214);
            this.btnDisableVoice.Name = "btnDisableVoice";
            this.btnDisableVoice.Size = new System.Drawing.Size(58, 61);
            this.btnDisableVoice.TabIndex = 1;
            this.btnDisableVoice.UseVisualStyleBackColor = false;
            this.btnDisableVoice.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Maroon;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(553, 95);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // voiceBtn
            // 
            this.voiceBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("voiceBtn.ImageStream")));
            this.voiceBtn.TransparentColor = System.Drawing.Color.Transparent;
            this.voiceBtn.Images.SetKeyName(0, "mute-microphone-interface-symbol.png");
            this.voiceBtn.Images.SetKeyName(1, "mic.png");
            this.voiceBtn.Images.SetKeyName(2, "voice-control.png");
            this.voiceBtn.Images.SetKeyName(3, "voice-recorder-microphone.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(577, 340);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDisableVoice);
            this.Controls.Add(this.btnEnableVoice);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnableVoice;
        private System.Windows.Forms.Button btnDisableVoice;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ImageList voiceBtn;
    }
}

