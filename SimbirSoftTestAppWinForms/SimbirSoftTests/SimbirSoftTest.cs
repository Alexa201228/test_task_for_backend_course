using NUnit.Framework;
using SimbirSoftTestAppWinForms;
using System;
using System.Linq;

namespace SimbirSoftTests
{
    //create class for fake html-pages to test html-parser
    public class FakeHtml
    {

        public string InnerHtmlWithoutSpecialCharacters()
        {
            return "My First Heading," +
                "My first paragraph";
        }

        public string InnerHtmlWithSpecialCharacters()
        {
            return "I will display &#8364;";
        }

        public string ComplexInnerHTML()
        {
            return "My " +
                "I will display &#8364;" +
                "Регуля́рные выраже́ния " +
                "self-confidence " +
                "(англ. regular expressions) — {}[],.><?//\\'|%^\n\t\r#@~;";
        }


    }
    [TestFixture]
    public class SimbirSoftTest
    {
        [Test]
        public void RegexParsing_ParseSimpleHtml_ShouldReturnWordsSepWithSpaces()
        {
            FakeHtml fakeHtml = new FakeHtml();
            HTMLParser parser = new HTMLParser("f");
            string fake = fakeHtml.InnerHtmlWithoutSpecialCharacters();
            var res = string.Join(' ', parser.RegexParsing(fake).Split(' ').Where(x => x!= ""));
            Assert.AreEqual("My First Heading My first paragraph", res);
        }

        [Test]
        public void RegexParsing_ParseInnerHtmlWithSpecialCharacter_ShouldReturnPlainText()
        {
            FakeHtml fakeHtml = new FakeHtml();
            HTMLParser parser = new HTMLParser("f");
            string fake = fakeHtml.InnerHtmlWithSpecialCharacters();
            var res = string.Join(' ', parser.RegexParsing(fake).Split(' ').Where(x => x != ""));
            Assert.AreEqual("I will display", res);
        }

        [Test]
        public void RegexParsing_ParseComplexInnerHtml_ShouldReturnTextWithoutAnyAdditionalCharacters()
        {
            FakeHtml fakeHtml = new FakeHtml();
            HTMLParser parser = new HTMLParser("f");
            string fake = fakeHtml.ComplexInnerHTML();
            var res = string.Join(' ', parser.RegexParsing(fake).Split(' ').Where(x => x != ""));
            Assert.AreEqual("My I will display Регулярные выражения self-confidence англ regular expressions", res);
        }

        [Test]
        public void HtmlAnalyse_AnalyseParsedData_ShouldReturnCountOfDistinctWords()
        {
            FakeHtml fakeHtml = new FakeHtml();
            HTMLParser parser = new HTMLParser("f");
            string fake = fakeHtml.InnerHtmlWithoutSpecialCharacters();
            var parsed = parser.RegexParsing(fake).Split(' ').Where(x => x != "").ToArray();
            parser.SetParsedData = parsed;
            var res = parser.Analyse();
            Assert.AreEqual(4, res.Keys.Count);
        }

        [Test]
        public void HtmlParser_CreateInstanceOfParser_ShouldReturnArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new HTMLParser(""));
        }
    }
}
