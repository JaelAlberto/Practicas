using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Practicas.Pages
{
    public class NominaModel : PageModel
    {
        private readonly ILogger<NominaModel>_log;
        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string nombre3 { get; set; }
        public string nombre4 { get; set; }
        public string nombre5 { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string apellido3 { get; set; }
        public string apellido4 { get; set; }
        public string apellido5 { get; set; }
        public string cargo1 { get; set; }
        public string cargo2 { get; set; }
        public string cargo3 { get; set; }
        public string cargo4 { get; set; }
        public string cargo5 { get; set; }
        public double salarios1 { get; set; }
        public double salarios2 { get; set; }
        public double salarios3 { get; set; }
        public double salarios4 { get; set; }
        public double salarios5 { get; set; }






        public NominaModel(ILogger<NominaModel> logger)
        {
            _log = logger;

            //Nombres
            this.nombre1 = "Jhon";
            this.nombre2 = "Maria";
            this.nombre3 = "Raul";
            this.nombre4 = "Laura";
            this.nombre5 = "Pedro";
            //Apellidos
            this.apellido1 = "Wick";
            this.apellido2 = "Perez";
            this.apellido3 = "De Leon";
            this.apellido4 = "Romero";
            this.apellido5 = "Ramirez";
            //Cargos
            this.cargo1 = "Gerente General";
            this.cargo2 = "Encargada RRHH";
            this.cargo3 = "Programador";
            this.cargo4 = "Digitadora";
            this.cargo5 = "Conserje";
            //Salarios
            this.salarios1 = 280000;
            this.salarios2 = 120000;
            this.salarios3 = 50000;
            this.salarios4 = 20000;
            this.salarios5 = 15000;
        }






        public void OnGet()
        {
        }
    }
}
