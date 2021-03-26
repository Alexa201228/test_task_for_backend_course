using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Windows.Forms;
using System.Threading;

namespace SimbirSoftTestAppWinForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            toolTip1.SetToolTip(HtmlSource, @"Введите адрес страницы, например https://www.google.com/");
        }


        string htmlForAnalysis = "";
        private void DownloadHtmlPageBtn_Click(object sender, EventArgs e)
        {

            try
            {
                ComputerFilePath.Text = "";
                AnalysisResult.Clear();
                TextToLabel(label3, "");
                string validHttpPattern = "((http|https)://)(www.)?" +
                                            "[a-zA-Z0-9@:%._\\+~#?&//=]" +
                                            "{2,256}\\.[a-z]" +
                                            "{2,6}\\b([-a-zA-Z0-9@:%" +
                                            "._\\+~#?&//=]*)";

                if (!Regex.IsMatch(HtmlSource.Text, validHttpPattern))
                    throw new ArgumentException("Строка адреса не соответсвует каноничному виду");
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "HTML-files|*.html|All files (*.*)|*.*";
                if (saveDialog.ShowDialog() == DialogResult.OK && saveDialog.FileName != "")
                {
                    htmlForAnalysis = Path.GetFullPath(saveDialog.FileName);
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(HtmlSource.Text, htmlForAnalysis);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorLogger logger = new ErrorLogger(ex);
            }
        }



        private void ChooseBtn_Click(object sender, EventArgs e)
        {

            try
            {
                AnalysisResult.Clear();
                TextToLabel(label3, "");
                HtmlSource.Text = "";
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "HTML-files|*.html";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    ComputerFilePath.Text = openFile.FileName;
                    htmlForAnalysis = Path.GetFullPath(openFile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorLogger logger = new ErrorLogger(ex);
            }

        }

        private void StartAnalyseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TextToLabel(label3, "");
                AnalysisResult.Clear();
                AnalysisResult.Text = "";
                HTMLParser parser = new HTMLParser(htmlForAnalysis);
                label3.Text = "Проводится анализ...";
                var result = parser.AnalyseDataFromHtml().ContinueWith(t => PrintResults(t.Result));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorLogger logger = new ErrorLogger(ex);
            }

        }

        private void TextToLabel(Label label, string text)
        {
            if (InvokeRequired)
                label.Invoke(new Action<string>((s) => label.Text = s), text);
            else
                label.Text = text;
        }

        private void ToRichTextBox(RichTextBox richText, string text)
        {
            if (InvokeRequired)
                richText.Invoke(new Action<string>((s) => richText.Text += s), text);
            else
                richText.Text += text;
        }
        delegate DialogResult SaveFileDialogInvoker();
        private void PrintResults(Dictionary<string, int> result)
        {
            try
            {
                foreach (var item in result)
                {
                    ToRichTextBox(AnalysisResult, item.Key + " - " + item.Value.ToString() + Environment.NewLine);
                }
                TextToLabel(label3, "Анализ завершён!");
                string requestToSaveRes = "Сохранить данные анализа в отдельном текстовом файле?";
                var response = MessageBox.Show(requestToSaveRes, "Сохранение результатов", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    SaveResultsInTXTFile();
                }
                result.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorLogger logger = new ErrorLogger(ex);
            }

        }

        private void SaveResultsInTXTFile()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "txt-files|*.txt|All files (*.*)|*.*";
                SaveFileDialogInvoker invoker = new SaveFileDialogInvoker(saveDialog.ShowDialog);
                this.Invoke(invoker);
                var resultData = AnalysisResult.Invoke(new Func<string>(() => AnalysisResult.Text)).ToString();

                if (saveDialog.FileName != "")
                {

                    string filePath = Path.GetFullPath(saveDialog.FileName);
                    File.WriteAllTextAsync(filePath, resultData);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorLogger logger = new ErrorLogger(ex);
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}
