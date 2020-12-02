using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Newsletter_Creation
{
    public partial class Form1 : Form
    {
        String[] htmlRows;
        HtmlStringBuilder htmlBuilder = new HtmlStringBuilder();
        HTMLManager hTMLManager = new HTMLManager();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            LoadHTMLFile();
            htmlRows = hTMLManager.ReadHTMLContent();
            this.openFileDialog.InitialDirectory = @"C:\Users\";
            this.openFileDialog.Title = "Válasz egy képet";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message msg = new Message();
            try
            {
                msg.SendMessage(this.Recipients(), this.From(), this.Password(), this.Subject(), urlBox.Text);
                MessageBox.Show("Elküldve");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void LoadHTMLFile()
        {
            
            previewBrowser.Navigate(HTMLManager.HTML_FILE);
        }
       
        private void ModifyContent(String id, String inputString)
        {
            for(int i = 0; i < htmlRows.Length; i++)
            {
                if (htmlRows[i].Contains(id)){
                    htmlRows[i] = this.htmlBuilder.modifyID(htmlRows[i], inputString);
                    break;
                }
            }
            hTMLManager.WriteHTMLContent(htmlRows);
            htmlRows = hTMLManager.ReadHTMLContent();
            LoadHTMLFile();
        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {
            String str = titleBox.Text;
            str = str.Replace(System.Environment.NewLine, "</br>");
            ModifyContent(HtmlStringBuilder.titleText, str);
        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {
            ModifyContent(HtmlStringBuilder.titleImage, urlBox.Text);
        }

        private void bodyBox_TextChanged(object sender, EventArgs e)
        {
            String str = bodyBox.Text;
            str = str.Replace(System.Environment.NewLine, "</br>");
            ModifyContent(HtmlStringBuilder.bodyText, str);
        }

        private void footerBox_TextChanged(object sender, EventArgs e)
        {
            String str = footerBox.Text;
            str = str.Replace(System.Environment.NewLine, "</br>");
            ModifyContent(HtmlStringBuilder.footerText, str);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private String Password() { return passwordBox.Text; }
        private String From() { return fromBox.Text; }
        private String[] Recipients()
        {
            String rec = recipientsBox.Text;
            return rec.Split(';');
        }
        private String Subject() { return subjectBox.Text; }

        private void browserButton_Click(object sender, EventArgs e)
        {

            this.openFileDialog.ShowDialog();
            urlBox.Text = openFileDialog.FileName;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StyleForm styleForm = new StyleForm();
            styleForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHTMLFile();
        }
    }
}
