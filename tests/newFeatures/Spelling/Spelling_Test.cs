using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Wordprocessing;
using LamedalCore.zPublicClass.Test;
using LamedalCore.zz;
using LamedalCore_Templates;
using Xunit;
using Xunit.Abstractions;

namespace Lamedal_UIWinForms.Test.newFeatures.Spelling
{
    public class Spelling_Test : pcTest
    {
        public Spelling_Test(ITestOutputHelper debug = null) : base(debug) { }

        [Fact]
        public void SpellWord_Test()
        {
            string retValue = string.Empty;
            var word = "behivior";

            var uri = "http://www.google.com/complete/search?output=toolbar&q={0}".zFormat(word);
            var request = (HttpWebRequest) WebRequest.Create(uri);
            var response = (HttpWebResponse) request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                retValue = sr.ReadToEnd();
            }

            var doc = XDocument.Parse(retValue);
            if (doc.Root == null) return; // <=================================================
            var attr = doc.Root.Element("CompleteSuggestion").Element("suggestion").Attribute("data");

            string correctedWord = attr.Value;
            _Debug.WriteLine($"{word}->{correctedWord}");

            _Debug.WriteLine("------------------------");
            //_Debug.WriteLine(doc.ToString(SaveOptions.None));

            var ids = doc.Descendants("suggestion").Select(x => (string)x.Attribute("data")).ToList();
            _Debug.WriteLine(ids.zTo_Str("".NL()));
        }

        [Fact]
        public void Translate_Test()
        {
            string translation = Translate("Your text to translate.", enGoogleLanguage.English, enGoogleLanguage.Afrikaans);
            _Debug.WriteLine(translation);
        }

        public enum enGoogleLanguage
        {
            [Description("af")]
            Afrikaans,
            [Description("en")]
            English,
            [Description("st")]
            Sesotho,
            [Description("tn")]
            Setswana,
            [Description("zu")]
            Zulu,
            [Description("xh")]
            Xhosa,
            [Description("nso")]
            NorthernSotho
        }

        public string Translate(string text,enGoogleLanguage fromLanguage, enGoogleLanguage toLanguage )
        {
            // https://sites.google.com/site/tomihasa/google-language-codes
            var from = fromLanguage.zAttributeDescription();
            var to = toLanguage.zAttributeDescription();

            string page = null;
            try
            {
                var webClient = new WebClient();
                webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                webClient.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                webClient.Encoding = Encoding.UTF8;

                string url = @"http://translate.google.com.tr/m?hl=en&sl={0}&tl={1}&ie=UTF-8&prev=_m&q={2}".zFormat(from, to, Uri.EscapeUriString(text));
                page = webClient.DownloadString(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

            page = page.Remove(0, page.IndexOf("<div dir=\"ltr\" class=\"t0\">")).Replace("<div dir=\"ltr\" class=\"t0\">", "");
            int last = page.IndexOf("</div>");
            page = page.Remove(last, page.Length - last);

            return page;
        }
    }
}
