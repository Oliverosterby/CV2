using CV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CV.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public string Hobbyer { get; set; }
        public string About { get; set; }

        public List<Arbejde> Arbejdesteder { get; set; }
        
        public Kontaktinfo Kontaktinfo { get; set; }

        public List<Uddannelse> Uddannelser { get; set; }

        public List<string> Skills { get; set; }

        public IDictionary<string, int> Languages { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {


            this.About = "Jeg er en dreng på 16 år, Jeg har siddet bag kassen i Meny det har jeg gjort det sidste år. Jeg har kørt motocross på eliteplan, så når jeg sætter mig nogle mål gøre jeg alt hvad jeg kan få at nå dem, Jeg er en meget aktiv ung mand og jeg elsker systemer. Jeg arbejder lige nu ved med24 på lageret";

            this.Hobbyer = "Fitness";



            this.Arbejdesteder = new List<Arbejde>()
            {
                new Arbejde()
                {
                    Navn = "Med24",
                    Beskrivelse = "Jeg arbejder hos Med24 lige nu hvor jeg arbejder på lageret",
                    
        },
                new Arbejde()
                {
                    Navn = "Meny",
                    Beskrivelse = "Jeg sad bagkassen i 9 klasse i meny men sagde op fordi jeg gerne ville ud og prøve noget nyt",
                    
                }
            };

            this.Kontaktinfo = new Kontaktinfo()
            {
                
                    Iphonenummer = "+45 42656585",
                    Mail = "Oliverosterby@hotmail.com",
                    Adresse = "Ny hammelmosevej 3",
                

            };

            this.Uddannelser = new List<Uddannelse>()
            {
                new Uddannelse()
                {
                    Navn = "Techcollege, Aalborg",
                    Beskrivelse = "Jeg er i gang med at uddanne mig til programmør på linjen,data og kommunikation Grundforløb 2 - afslutter jeg 24/6/22",
                    Slutdato = new DateTime(2022, 6, 24),
        },
                new Uddannelse()
                {
                    Navn = "Tolstrup Stenum Friskole",
                    Beskrivelse = "Gik der fra 7 - 9 klasse",
                    Slutdato = new DateTime(2021, 6, 28),
                }
            };


            this.Skills = new List<string>()
            {
                { "C#" },
                { "HTML" },
                { "CSS" },
            };

            this.Languages = new Dictionary<string, int>()
            {
                { "Dansk", 4 },
                { "Engelsk", 3 },
            };
        }
    }
}