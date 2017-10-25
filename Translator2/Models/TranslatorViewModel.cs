using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Translator2.Models
{
    public class TranslatorViewModel
    {
        [Display(Name =  "Begin Tekst")]
        public string OriginalTekst { get; set; }

        [Display(Name = "Eerste Tekst")]
        public string EersteTekst { get; set; }

        [Display(Name = "Vertaalde Tekst")]
        public string EersteVertaaldeTekst { get; set; }

        [Display(Name = "Nieuwe Tekst")]
        public string NieuweTekst { get; set; }

        public string Taal { get; set; }

        public List<SelectListItem> Talen { get; set; }
    }
}