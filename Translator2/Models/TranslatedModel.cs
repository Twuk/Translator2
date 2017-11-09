using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Translator2.Models
{
    public class TranslatedModel
    {
        [Display(Name = "Eerste Tekst")]
        public string EersteTekst { get; set; }

        [Display(Name = "Vertaalde Tekst")]
        public string EersteVertaaldeTekst { get; set; }

        [Display(Name = "Nieuwe Tekst")]
        public string NieuweTekst { get; set; }

        public string Uitdelen { get; set; }
        public string ZelfDrinken { get; set; }
    }
}