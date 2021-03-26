
namespace SimbirSoftTestAppWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.HtmlSource = new System.Windows.Forms.TextBox();
            this.DownloadHtmlPageBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComputerFilePath = new System.Windows.Forms.TextBox();
            this.ChooseBtn = new System.Windows.Forms.Button();
            this.AnalysisResult = new System.Windows.Forms.RichTextBox();
            this.StartAnalyseBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите адрес html-страницы для скачиваия";
            // 
            // HtmlSource
            // 
            this.HtmlSource.Location = new System.Drawing.Point(12, 54);
            this.HtmlSource.Name = "HtmlSource";
            this.HtmlSource.Size = new System.Drawing.Size(361, 23);
            this.HtmlSource.TabIndex = 1;
            // 
            // DownloadHtmlPageBtn
            // 
            this.DownloadHtmlPageBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DownloadHtmlPageBtn.Location = new System.Drawing.Point(420, 54);
            this.DownloadHtmlPageBtn.Name = "DownloadHtmlPageBtn";
            this.DownloadHtmlPageBtn.Size = new System.Drawing.Size(89, 25);
            this.DownloadHtmlPageBtn.TabIndex = 2;
            this.DownloadHtmlPageBtn.Text = "Скачать";
            this.DownloadHtmlPageBtn.UseVisualStyleBackColor = true;
            this.DownloadHtmlPageBtn.Click += new System.EventHandler(this.DownloadHtmlPageBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "или загрузите файл для анализа с компьютера";
            // 
            // ComputerFilePath
            // 
            this.ComputerFilePath.Location = new System.Drawing.Point(12, 139);
            this.ComputerFilePath.Name = "ComputerFilePath";
            this.ComputerFilePath.ReadOnly = true;
            this.ComputerFilePath.Size = new System.Drawing.Size(361, 23);
            this.ComputerFilePath.TabIndex = 4;
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChooseBtn.Location = new System.Drawing.Point(420, 139);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(153, 29);
            this.ChooseBtn.TabIndex = 5;
            this.ChooseBtn.Text = "Выбрать файл";
            this.ChooseBtn.UseVisualStyleBackColor = true;
            this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
            // 
            // AnalysisResult
            // 
            this.AnalysisResult.DetectUrls = false;
            this.AnalysisResult.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnalysisResult.Location = new System.Drawing.Point(12, 248);
            this.AnalysisResult.Name = "AnalysisResult";
            this.AnalysisResult.ReadOnly = true;
            this.AnalysisResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.AnalysisResult.Size = new System.Drawing.Size(361, 172);
            this.AnalysisResult.TabIndex = 6;
            this.AnalysisResult.Text = "";
            // 
            // StartAnalyseBtn
            // 
            this.StartAnalyseBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartAnalyseBtn.Location = new System.Drawing.Point(420, 219);
            this.StartAnalyseBtn.Name = "StartAnalyseBtn";
            this.StartAnalyseBtn.Size = new System.Drawing.Size(145, 41);
            this.StartAnalyseBtn.TabIndex = 7;
            this.StartAnalyseBtn.Text = "Начать анализ";
            this.StartAnalyseBtn.UseVisualStyleBackColor = true;
            this.StartAnalyseBtn.Click += new System.EventHandler(this.StartAnalyseBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 8;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.Location = new System.Drawing.Point(425, 298);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(139, 39);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartAnalyseBtn);
            this.Controls.Add(this.AnalysisResult);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.ComputerFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DownloadHtmlPageBtn);
            this.Controls.Add(this.HtmlSource);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Count unique words in html-page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HtmlSource;
        private System.Windows.Forms.Button DownloadHtmlPageBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ComputerFilePath;
        private System.Windows.Forms.Button ChooseBtn;
        private System.Windows.Forms.RichTextBox AnalysisResult;
        private System.Windows.Forms.Button StartAnalyseBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitBtn;
    }
}

