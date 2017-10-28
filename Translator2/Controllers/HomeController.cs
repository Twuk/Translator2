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