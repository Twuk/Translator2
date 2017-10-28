using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Translator2.Models;
using Google.Cloud.Translation.V2;


namespace Translator2.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            TranslatorViewModel model = new TranslatorViewModel();
            model.OriginalTekst = "";
            model.EersteTekst = "Eerste Tekst";
            model.EersteVertaaldeTekst = "Eerste Vertaalde Tekst";
            model.NieuweTekst = "Nieuwe Tekst";
            List<SelectListItem> items = new List<SelectListItem>();
            items = FillTalen(items);
            model.Talen = items;
            return View(model);
        }

        public List<SelectListItem> FillTalen(List<SelectListItem> items)
        {
            #region language hardcoded
            items.Add(new SelectListItem
            {
                Text = "Afrikaans",
                Value = "af"
            });
items.Add(new SelectListItem
{
    Text = "Albanian",
    Value = "sq"
});
            items.Add(new SelectListItem
{
    Text = "Amharic",
    Value = "am"
            });
            items.Add(new SelectListItem
{
    Text = "Arabic",
    Value = "ar"
            });
            items.Add(new SelectListItem
{
    Text = "Armenian",
    Value = "hy"
            });
            items.Add(new SelectListItem
{
    Text = "Azeerbaijani",
    Value = "az"
            });
            items.Add(new SelectListItem
{
    Text = "Basque",
    Value = "eu"
            });
            items.Add(new SelectListItem
{
    Text = "Belarusian",
    Value = "be"
            });
            items.Add(new SelectListItem
{
    Text = "Bengali",
    Value = "bn"
            });
            items.Add(new SelectListItem
{
    Text = "Bosnian",
    Value = "bs"
            });
            items.Add(new SelectListItem
{
    Text = "Bulgarian",
    Value = "bg"
            });
            items.Add(new SelectListItem
{
    Text = "Catalan",
    Value = "ca"
            });
            items.Add(new SelectListItem
{
    Text = "Cebuano",
    Value = "ceb"
            });
            items.Add(new SelectListItem
{
    Text = "Chinese(Simplified)",
    Value = "zh"
            });
            items.Add(new SelectListItem
{
    Text = "Chinese(Traditional)",
    Value = "zh"
            });
            items.Add(new SelectListItem
{
    Text = "Corsican",
    Value = "co"
            });
            items.Add(new SelectListItem
{
    Text = "Croatian",
    Value = "hr"
            });
            items.Add(new SelectListItem
{
    Text = "Czech",
                Value = "cs"
            });
            items.Add(new SelectListItem
{
    Text = "Danish",
    Value = "da"
            });
            items.Add(new SelectListItem
{
    Text = "Dutch",
    Value = "nl"
            });
            items.Add(new SelectListItem
{
    Text = "English",
    Value = "en"
            });
            items.Add(new SelectListItem
{
    Text = "Esperanto",
    Value = "eo"
            });
            items.Add(new SelectListItem
{
    Text = "Estonian",
    Value = "et"
            });
            items.Add(new SelectListItem
{
    Text = "Finnish",
    Value = "fi"
            });
            items.Add(new SelectListItem
{
    Text = "French",
    Value = " fr"
            });
            items.Add(new SelectListItem
{
    Text = "Frisian",
    Value = "fy"
            });
            items.Add(new SelectListItem
{
    Text = "Galician",
    Value = "gl"
            });
            items.Add(new SelectListItem
{
    Text = "Georgian",
    Value = "ka"
            });
            items.Add(new SelectListItem
{
    Text = "German",
    Value = "de"
            });
            items.Add(new SelectListItem
{
    Text = "Greek",
    Value = "el"
});
            items.Add(new SelectListItem
{
    Text = "Gujarati",
    Value = "gu"
            });
            items.Add(new SelectListItem
{
    Text = "Haitian Creole",
    Value = "ht"
            });
            items.Add(new SelectListItem
{
    Text = "Hausa",
    Value = "ha"
            });
            items.Add(new SelectListItem
{
    Text = "Hawaiian",
    Value = "haw"
            });
            items.Add(new SelectListItem
{
    Text = "Hebrew",
    Value = "iw"
            });
            items.Add(new SelectListItem
{
    Text = "Hindi ",
    Value = "hi"
            });
            items.Add(new SelectListItem
{
    Text = "Hmong ",
    Value = "hmn"
            });
            items.Add(new SelectListItem
{
    Text = "Hungarian ",
    Value = "hu"
            });
            items.Add(new SelectListItem
{
    Text = "Icelandic ",
    Value = "is"
            });
            items.Add(new SelectListItem
{
    Text = "Igbo ",
    Value = "ig"
            });
            items.Add(new SelectListItem
{
    Text = "Indonesian ",
    Value = "id"
            });
            items.Add(new SelectListItem
{
    Text = "Irish ",
    Value = "ga"
            });
            items.Add(new SelectListItem
{
    Text = "Italian ",
    Value = "it"
            });
            items.Add(new SelectListItem
{
    Text = "Japanese ",
    Value = "ja"
            });
            items.Add(new SelectListItem
{
    Text = "Javanese ",
    Value = "jw"
            });
            items.Add(new SelectListItem
{
    Text = "Kannada",
    Value = "kn"
            });
            items.Add(new SelectListItem
{
    Text = "Kazakh ",
    Value = "kk"
            });
            items.Add(new SelectListItem
{
    Text = "Khmer ",
    Value = "km"
            });
            items.Add(new SelectListItem
{
    Text = "Korean ",
    Value = "ko"
            });
            items.Add(new SelectListItem
{
    Text = "Kurdish ",
    Value = "ku"
            });
            items.Add(new SelectListItem
{
    Text = "Kyrgyz ",
    Value = "ky"
            });
            items.Add(new SelectListItem
{
    Text = "Lao",
    Value = "lo"
            });
            items.Add(new SelectListItem
{
    Text = "Latin ",
    Value = "la"
            });
            items.Add(new SelectListItem
{
    Text = "Latvian ",
    Value = "lv"
            });
            items.Add(new SelectListItem
{
    Text = "Lithuanian ",
    Value = "lt"
            });
            items.Add(new SelectListItem
{
    Text = "Luxembourgish ",
    Value = "lb"
            });
            items.Add(new SelectListItem
{
    Text = "Macedonian ",
    Value = "mk"
            });
            items.Add(new SelectListItem
{
    Text = "Malagasy ",
    Value = "mg"
            });
            items.Add(new SelectListItem
{
    Text = "Malay ",
    Value = "ms"
            });
            items.Add(new SelectListItem
{
    Text = "Malayalam ",
    Value = "ml"
            });
            items.Add(new SelectListItem
{
    Text = "Maltese ",
    Value = "mt"
            });
            items.Add(new SelectListItem
{
    Text = "Maori ",
    Value = "mi"
            });
            items.Add(new SelectListItem
{
    Text = "Marathi ",
    Value = "mr"
            });
            items.Add(new SelectListItem
{
    Text = "Mongolian ",
    Value = "mn"
            });
            items.Add(new SelectListItem
{
    Text = "Myanmar(Burmese)   ",
    Value = "my"
            });
            items.Add(new SelectListItem
{
    Text = "Nepali",
    Value = "ne"
            });
            items.Add(new SelectListItem
            {
                Text = "Norwegian   ",
                Value = "no"
            });
            items.Add(new SelectListItem
 {
     Text = "Nyanja(Chichewa)   ",
     Value = "ny"
            });
            items.Add(new SelectListItem
 {
     Text = "Pashto  ",
     Value = "ps"
            });
            items.Add(new SelectListItem
 {
     Text = "Persian ",
     Value = "fa"
            });
            items.Add(new SelectListItem
 {
     Text = "Polish  ",
     Value = "pl"
            });
            items.Add(new SelectListItem
 {
     Text = "Portuguese(Portugal, Brazil)   ",
     Value = "pt"
            });
            items.Add(new SelectListItem
 {
     Text = "Punjabi ",
     Value = "pa"
            });
            items.Add(new SelectListItem
 {
     Text = "Romanian    ",
     Value = "ro"
            });
            items.Add(new SelectListItem
 {
     Text = "Russian ",
     Value = "ru"
            });
            items.Add(new SelectListItem
 {
     Text = "Samoan  ",
     Value = "sm"
            });
            items.Add(new SelectListItem
 {
     Text = "Scots Gaelic ",
     Value = "gd"
            });
            items.Add(new SelectListItem
 {
     Text = "Serbian ",
     Value = "sr"
            });
            items.Add(new SelectListItem
 {
     Text = "Sesotho ",
     Value = "st"
            });
            items.Add(new SelectListItem
 {
     Text = "Shona ",
     Value = "sn"
            });
            items.Add(new SelectListItem
 {
     Text = "Sindhi ",
     Value = "sd"
            });
            items.Add(new SelectListItem
 {
     Text = "Sinhala(Sinhalese) ",
     Value = "si"
            });
            items.Add(new SelectListItem
 {
     Text = "Slovak  ",
     Value = "sk"
            });
            items.Add(new SelectListItem
 {
     Text = "Slovenian   ",
     Value = "sl"
            });
            items.Add(new SelectListItem
 {
     Text = "Somali  ",
     Value = "so"
            });
            items.Add(new SelectListItem
 {
     Text = "Spanish ",
     Value = "es"
            });
            items.Add(new SelectListItem
 {
     Text = "Sundanese   ",
     Value = "su"
            });
            items.Add(new SelectListItem
 {
     Text = "Swahili ",
     Value = "sw"
            });
            items.Add(new SelectListItem
 {
     Text = "Swedish ",
     Value = "sv"
            });
            items.Add(new SelectListItem
 {
     Text = "Tagalog(Filipino)  ",
     Value = "tl"
            });
            items.Add(new SelectListItem
 {
     Text = "Tajik   ",
     Value = "tg"
            });
            items.Add(new SelectListItem
 {
     Text = "Tamil   ",
     Value = "ta"
            });
            items.Add(new SelectListItem
 {
     Text = "Telugu  ",
     Value = "te"
            });
            items.Add(new SelectListItem
 {
     Text = "Thai    ",
     Value = "th"
            });
            items.Add(new SelectListItem
 {
     Text = "Turkish ",
     Value = "tr"
            });
            items.Add(new SelectListItem
 {
     Text = "Ukrainian   ",
     Value = "uk"
            });
            items.Add(new SelectListItem
 {
     Text = "Urdu    ",
     Value = "ur"
            });
            items.Add(new SelectListItem
 {
     Text = "Uzbek   ",
     Value = "uz"
            });
            items.Add(new SelectListItem
 {
     Text = "Vietnamese  ",
     Value = "vi"
            });
            items.Add(new SelectListItem
 {
     Text = "Welsh   ",
     Value = "cy"
            });
            items.Add(new SelectListItem
 {
     Text = "Xhosa   ",
     Value = "xh"
            });
            items.Add(new SelectListItem
 {
     Text = "Yiddish ",
     Value = "yi"
            });
            items.Add(new SelectListItem
 {
     Text = "Yoruba  ",
     Value = "yo"
            });
            items.Add(new SelectListItem
 {
     Text = "Zulu   ",
     Value = "zu"
            });
#endregion
            /*
            try
            {
                using (var reader = new System.IO.StreamReader(Server.MapPath("~") + "Talen.csv"))
                {

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        items.Add(new SelectListItem { Text = values[0], Value = values[1] });
                    }
                }
                return items;
            }
            catch (Exception ex)
            {
                return items;
            }
            */
            return items;
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        [HttpPost]
        public ActionResult Translate(TranslatorViewModel model)
        {
            TranslationClient client = TranslationClient.CreateFromApiKey("AIzaSyDEEPR1-xtzC3gV-oHJifs1X1iUtkZRqZY");
            if (model.OriginalTekst == null || model.OriginalTekst == "")
            {
                model.OriginalTekst = model.EersteTekst;
            }
            model.EersteVertaaldeTekst = client.TranslateText(model.EersteTekst, model.Taal).TranslatedText;

            model.NieuweTekst =
           client.TranslateText(model.EersteVertaaldeTekst, "nl").TranslatedText;
            model.Talen = FillTalen(new List<SelectListItem>());
            return View("Index",model);
        }
    }
}