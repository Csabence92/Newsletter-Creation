namespace Newsletter_Creation
{
    partial class StyleForm
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.bodyFontFamilyBox = new System.Windows.Forms.TextBox();
            this.bodyWidthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imagePaddingBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageWidthBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageMarginRightBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contMarginRightBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contColorBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contFontSizeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paraghFontFamilyBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.paraghTextAlignBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.linkFontStyleBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linkColorBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.footerFontFamilyBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.footerColorBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.footerPaddingBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.footerBgBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.footerTextFontFamilyBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.footerTextTextAlignBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnContTextColor = new System.Windows.Forms.Button();
            this.btnFooterTextColor = new System.Windows.Forms.Button();
            this.btnFooterBg = new System.Windows.Forms.Button();
            this.btnLinkColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(449, 12);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(511, 477);
            this.webBrowser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Törzs Font-family";
            // 
            // bodyFontFamilyBox
            // 
            this.bodyFontFamilyBox.Location = new System.Drawing.Point(170, 12);
            this.bodyFontFamilyBox.Name = "bodyFontFamilyBox";
            this.bodyFontFamilyBox.Size = new System.Drawing.Size(100, 20);
            this.bodyFontFamilyBox.TabIndex = 2;
            this.bodyFontFamilyBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // bodyWidthBox
            // 
            this.bodyWidthBox.Location = new System.Drawing.Point(170, 39);
            this.bodyWidthBox.Name = "bodyWidthBox";
            this.bodyWidthBox.Size = new System.Drawing.Size(100, 20);
            this.bodyWidthBox.TabIndex = 4;
            this.bodyWidthBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Törzs szélesség (%)";
            // 
            // imagePaddingBox
            // 
            this.imagePaddingBox.Location = new System.Drawing.Point(170, 65);
            this.imagePaddingBox.Name = "imagePaddingBox";
            this.imagePaddingBox.Size = new System.Drawing.Size(100, 20);
            this.imagePaddingBox.TabIndex = 6;
            this.imagePaddingBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kép Padding (%)";
            // 
            // imageWidthBox
            // 
            this.imageWidthBox.Location = new System.Drawing.Point(170, 94);
            this.imageWidthBox.Name = "imageWidthBox";
            this.imageWidthBox.Size = new System.Drawing.Size(100, 20);
            this.imageWidthBox.TabIndex = 8;
            this.imageWidthBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kép szélesség (%)";
            // 
            // imageMarginRightBox
            // 
            this.imageMarginRightBox.Location = new System.Drawing.Point(170, 120);
            this.imageMarginRightBox.Name = "imageMarginRightBox";
            this.imageMarginRightBox.Size = new System.Drawing.Size(100, 20);
            this.imageMarginRightBox.TabIndex = 10;
            this.imageMarginRightBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kép behúzása jobbról (%)";
            // 
            // contMarginRightBox
            // 
            this.contMarginRightBox.Location = new System.Drawing.Point(170, 146);
            this.contMarginRightBox.Name = "contMarginRightBox";
            this.contMarginRightBox.Size = new System.Drawing.Size(100, 20);
            this.contMarginRightBox.TabIndex = 12;
            this.contMarginRightBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tartalom behúzás jobbról";
            // 
            // contColorBox
            // 
            this.contColorBox.Location = new System.Drawing.Point(170, 172);
            this.contColorBox.Name = "contColorBox";
            this.contColorBox.Size = new System.Drawing.Size(100, 20);
            this.contColorBox.TabIndex = 14;
            this.contColorBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tartalom betűszíne (HEX)";
            // 
            // contFontSizeBox
            // 
            this.contFontSizeBox.Location = new System.Drawing.Point(170, 198);
            this.contFontSizeBox.Name = "contFontSizeBox";
            this.contFontSizeBox.Size = new System.Drawing.Size(100, 20);
            this.contFontSizeBox.TabIndex = 16;
            this.contFontSizeBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tartalom betűmérete";
            // 
            // paraghFontFamilyBox
            // 
            this.paraghFontFamilyBox.Location = new System.Drawing.Point(170, 224);
            this.paraghFontFamilyBox.Name = "paraghFontFamilyBox";
            this.paraghFontFamilyBox.Size = new System.Drawing.Size(100, 20);
            this.paraghFontFamilyBox.TabIndex = 18;
            this.paraghFontFamilyBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Bekezdés font-family";
            // 
            // paraghTextAlignBox
            // 
            this.paraghTextAlignBox.Location = new System.Drawing.Point(170, 250);
            this.paraghTextAlignBox.Name = "paraghTextAlignBox";
            this.paraghTextAlignBox.Size = new System.Drawing.Size(100, 20);
            this.paraghTextAlignBox.TabIndex = 20;
            this.paraghTextAlignBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Bekezdés szövegigazítás";
            // 
            // linkFontStyleBox
            // 
            this.linkFontStyleBox.Location = new System.Drawing.Point(170, 276);
            this.linkFontStyleBox.Name = "linkFontStyleBox";
            this.linkFontStyleBox.Size = new System.Drawing.Size(100, 20);
            this.linkFontStyleBox.TabIndex = 22;
            this.linkFontStyleBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Link szövegtípus";
            // 
            // linkColorBox
            // 
            this.linkColorBox.Location = new System.Drawing.Point(170, 302);
            this.linkColorBox.Name = "linkColorBox";
            this.linkColorBox.Size = new System.Drawing.Size(100, 20);
            this.linkColorBox.TabIndex = 24;
            this.linkColorBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Link Színe";
            // 
            // footerFontFamilyBox
            // 
            this.footerFontFamilyBox.Location = new System.Drawing.Point(170, 328);
            this.footerFontFamilyBox.Name = "footerFontFamilyBox";
            this.footerFontFamilyBox.Size = new System.Drawing.Size(100, 20);
            this.footerFontFamilyBox.TabIndex = 26;
            this.footerFontFamilyBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Lábfej font-family";
            // 
            // footerColorBox
            // 
            this.footerColorBox.Location = new System.Drawing.Point(170, 354);
            this.footerColorBox.Name = "footerColorBox";
            this.footerColorBox.Size = new System.Drawing.Size(100, 20);
            this.footerColorBox.TabIndex = 28;
            this.footerColorBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Lábfej szövegszíne (HEX)";
            // 
            // footerPaddingBox
            // 
            this.footerPaddingBox.Location = new System.Drawing.Point(170, 380);
            this.footerPaddingBox.Name = "footerPaddingBox";
            this.footerPaddingBox.Size = new System.Drawing.Size(100, 20);
            this.footerPaddingBox.TabIndex = 30;
            this.footerPaddingBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Lábfej padding (%)";
            // 
            // footerBgBox
            // 
            this.footerBgBox.Location = new System.Drawing.Point(170, 406);
            this.footerBgBox.Name = "footerBgBox";
            this.footerBgBox.Size = new System.Drawing.Size(100, 20);
            this.footerBgBox.TabIndex = 32;
            this.footerBgBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 406);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Lábfej Háttérszín (HEX)";
            // 
            // footerTextFontFamilyBox
            // 
            this.footerTextFontFamilyBox.Location = new System.Drawing.Point(170, 432);
            this.footerTextFontFamilyBox.Name = "footerTextFontFamilyBox";
            this.footerTextFontFamilyBox.Size = new System.Drawing.Size(100, 20);
            this.footerTextFontFamilyBox.TabIndex = 34;
            this.footerTextFontFamilyBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 432);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Lábfej szöveg font-family";
            // 
            // footerTextTextAlignBox
            // 
            this.footerTextTextAlignBox.Location = new System.Drawing.Point(170, 458);
            this.footerTextTextAlignBox.Name = "footerTextTextAlignBox";
            this.footerTextTextAlignBox.Size = new System.Drawing.Size(100, 20);
            this.footerTextTextAlignBox.TabIndex = 36;
            this.footerTextTextAlignBox.TextChanged += new System.EventHandler(this.AddTextChangeListener);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 458);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Lábfejszöveg szövegelhelyezés";
            // 
            // btnContTextColor
            // 
            this.btnContTextColor.Location = new System.Drawing.Point(276, 172);
            this.btnContTextColor.Name = "btnContTextColor";
            this.btnContTextColor.Size = new System.Drawing.Size(75, 23);
            this.btnContTextColor.TabIndex = 37;
            this.btnContTextColor.Text = "Color picker";
            this.btnContTextColor.UseVisualStyleBackColor = true;
            this.btnContTextColor.Click += new System.EventHandler(this.btnContTextColor_Click);
            // 
            // btnFooterTextColor
            // 
            this.btnFooterTextColor.Location = new System.Drawing.Point(276, 354);
            this.btnFooterTextColor.Name = "btnFooterTextColor";
            this.btnFooterTextColor.Size = new System.Drawing.Size(75, 23);
            this.btnFooterTextColor.TabIndex = 38;
            this.btnFooterTextColor.Text = "Color picker";
            this.btnFooterTextColor.UseVisualStyleBackColor = true;
            this.btnFooterTextColor.Click += new System.EventHandler(this.btnFooterTextColor_Click);
            // 
            // btnFooterBg
            // 
            this.btnFooterBg.Location = new System.Drawing.Point(276, 406);
            this.btnFooterBg.Name = "btnFooterBg";
            this.btnFooterBg.Size = new System.Drawing.Size(75, 23);
            this.btnFooterBg.TabIndex = 39;
            this.btnFooterBg.Text = "Color picker";
            this.btnFooterBg.UseVisualStyleBackColor = true;
            this.btnFooterBg.Click += new System.EventHandler(this.btnFooterBg_Click);
            // 
            // btnLinkColor
            // 
            this.btnLinkColor.Location = new System.Drawing.Point(276, 300);
            this.btnLinkColor.Name = "btnLinkColor";
            this.btnLinkColor.Size = new System.Drawing.Size(75, 23);
            this.btnLinkColor.TabIndex = 40;
            this.btnLinkColor.Text = "Color picker";
            this.btnLinkColor.UseVisualStyleBackColor = true;
            this.btnLinkColor.Click += new System.EventHandler(this.btnLinkColor_Click);
            // 
            // StyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 484);
            this.Controls.Add(this.btnLinkColor);
            this.Controls.Add(this.btnFooterBg);
            this.Controls.Add(this.btnFooterTextColor);
            this.Controls.Add(this.btnContTextColor);
            this.Controls.Add(this.footerTextTextAlignBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.footerTextFontFamilyBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.footerBgBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.footerPaddingBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.footerColorBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.footerFontFamilyBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.linkColorBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.linkFontStyleBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.paraghTextAlignBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.paraghFontFamilyBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.contFontSizeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.contColorBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.contMarginRightBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imageMarginRightBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imageWidthBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imagePaddingBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bodyWidthBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bodyFontFamilyBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser);
            this.Name = "StyleForm";
            this.Text = "StyleForm";
            this.Load += new System.EventHandler(this.StyleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bodyFontFamilyBox;
        private System.Windows.Forms.TextBox bodyWidthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imagePaddingBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imageWidthBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imageMarginRightBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contMarginRightBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contColorBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox contFontSizeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox paraghFontFamilyBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox paraghTextAlignBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox linkFontStyleBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox linkColorBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox footerFontFamilyBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox footerColorBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox footerPaddingBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox footerBgBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox footerTextFontFamilyBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox footerTextTextAlignBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnContTextColor;
        private System.Windows.Forms.Button btnFooterTextColor;
        private System.Windows.Forms.Button btnFooterBg;
        private System.Windows.Forms.Button btnLinkColor;
    }
}