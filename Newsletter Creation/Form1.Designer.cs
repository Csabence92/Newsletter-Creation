namespace Newsletter_Creation
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
            this.sendButton = new System.Windows.Forms.Button();
            this.previewBrowser = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bodyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.footerBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.recipientsBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.browserButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(51, 472);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(169, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Hírlevél küldése";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // previewBrowser
            // 
            this.previewBrowser.Location = new System.Drawing.Point(393, 47);
            this.previewBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewBrowser.Name = "previewBrowser";
            this.previewBrowser.Size = new System.Drawing.Size(521, 464);
            this.previewBrowser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Címsor";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(68, 13);
            this.titleBox.Multiline = true;
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(175, 50);
            this.titleBox.TabIndex = 3;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(68, 69);
            this.urlBox.Multiline = true;
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(175, 30);
            this.urlBox.TabIndex = 5;
            this.urlBox.TextChanged += new System.EventHandler(this.urlBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kép URL";
            // 
            // bodyBox
            // 
            this.bodyBox.Location = new System.Drawing.Point(68, 119);
            this.bodyBox.Multiline = true;
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.Size = new System.Drawing.Size(175, 50);
            this.bodyBox.TabIndex = 7;
            this.bodyBox.TextChanged += new System.EventHandler(this.bodyBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Törzs";
            // 
            // footerBox
            // 
            this.footerBox.Location = new System.Drawing.Point(68, 189);
            this.footerBox.Multiline = true;
            this.footerBox.Name = "footerBox";
            this.footerBox.Size = new System.Drawing.Size(175, 50);
            this.footerBox.TabIndex = 9;
            this.footerBox.TextChanged += new System.EventHandler(this.footerBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lábfej";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(11, 389);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(61, 13);
            this.labelTo.TabIndex = 10;
            this.labelTo.Text = "Címzett(ek)";
            // 
            // recipientsBox
            // 
            this.recipientsBox.Location = new System.Drawing.Point(79, 376);
            this.recipientsBox.Multiline = true;
            this.recipientsBox.Name = "recipientsBox";
            this.recipientsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recipientsBox.Size = new System.Drawing.Size(141, 38);
            this.recipientsBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Több címzett esetén ;-vel válasza el őkett";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tárgy";
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(79, 427);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(141, 20);
            this.subjectBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fealdó";
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(79, 292);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(138, 20);
            this.fromBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Jelszó";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(79, 326);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(138, 20);
            this.passwordBox.TabIndex = 18;
            // 
            // browserButton
            // 
            this.browserButton.Location = new System.Drawing.Point(250, 72);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(96, 27);
            this.browserButton.TabIndex = 19;
            this.browserButton.Text = "Tallózás...";
            this.browserButton.UseVisualStyleBackColor = true;
            this.browserButton.Click += new System.EventHandler(this.browserButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Edit Style";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(506, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 523);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.browserButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.recipientsBox);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.footerBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bodyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewBrowser);
            this.Controls.Add(this.sendButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.WebBrowser previewBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bodyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox footerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox recipientsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button browserButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefresh;
    }
}

