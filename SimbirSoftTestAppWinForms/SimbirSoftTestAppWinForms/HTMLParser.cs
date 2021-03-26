using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimbirSoftTestAppWinForms
{
    public class HTMLParser
    {
        string _fileSource;
        string[] parsedData;
        public string[] SetParsedData { set { if (value != null) parsedData = value; } }

        public HTMLParser(string fileSource)
        {
            if (fileSource == string.Empty)
                throw new ArgumentNullException("", "Скачайте или выберите файл для анализа!");
            _fileSource = fileSource;

        }

        void GetDataFromHTML()
        {
            try
            {
                string data = "";
                using (StreamReader reader = new StreamReader(_fileSource, Encoding.UTF8))
                {
                    data = reader.ReadToEnd();
                }
                var parsingHTML = new HtmlAgilityPack.HtmlDocument();
                parsingHTML.LoadHtml(data);
                data = parsingHTML.DocumentNode.InnerText;
                data = RegexParsing(data);

                parsedData = data.Split(' ').Where(x => x != "" && x != "-").ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorLogger logger = new ErrorLogger(ex);

            }


        }

        public string RegexParsing(string data)
        {
            try
            {
                //Remove characters like (c), &lt and etc
                Regex readableCharacters = new Regex("&(.{2,5})", RegexOptions.IgnoreCase);
                data = readableCharacters.Replace(data, "");

                //Удаление специальных символов, символов перевода на новую строку, табуляции, кавычек, чисел и т. д.
                Regex separatorRegex = new Regex(@"[^\P{P}-]+");
                data = separatorRegex.Replace(data, " ");
                separatorRegex = new Regex(@"[\p{M}]");
                data = separatorRegex.Replace(data, "");
                separatorRegex = new Regex(@"[\n\r\t]");
                data = separatorRegex.Replace(data, " ");
                separatorRegex = new Regex(@"[^а-яёА-ЯЁa-zA-Z -]");
                data = separatorRegex.Replace(data, " ");
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorLogger logger = new ErrorLogger(ex);
            }
            return null;
        }

        public async Task<Dictionary<string, int>> AnalyseDataFromHtml()
        {
            try
            {
                GetDataFromHTML();
                return await Task.Run(() => Analyse());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorLogger logger = new ErrorLogger(ex);
            }
            return null;
        }

        public Dictionary<string, int> Analyse()
        {
            try
            {
                Dictionary<string, int> result = new Dictionary<string, int>();
                var distinctStrings = parsedData.Distinct().ToArray();
                for (int i = 0; i < distinctStrings.Length; i++)
                {
                    result[parsedData[i]] = parsedData.Count(x => x == distinctStrings[i]);

                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorLogger logger = new ErrorLogger(ex);
            }
            return null;
        }
    }

}
