using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TickNet.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Puntos { get; set; }
        public string Direc { get; set; }
        public string TelfMovil { get; set; }
        public string FNacimiento { get; set; }
        //public Tarjeta Tarj {get; set;}
        //public UserAccount User {get; set;}
        //public List<Sales> SalesHist {get; set;}
        //public List<Reserve> ReserveHist{get; set;}
        //public List<Comment> CommentHist{get; set;}
        public Client()
        {
            //this.Tarj = null;
            //this.SalesHist = new List<Sales>();
            //this.ReserveHist = new List<Reserve>();
            //this.CommentHist = new List<Comment>();
        }
    }
    public class ClientViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Correo Electrónico:")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name="Nombre:")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Apellido Parterno:")]
        public string LastNameF { get; set; }

        [Required]
        [Display(Name = "Apellido Materno:")]
        public string LastNameM { get; set; }

        [Required]
        [Display(Name = "Documento de Identidad:")]
        public string DocNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento:")]
        public DateTime DayofBirth { get; set; }

        [Required]
        [Display(Name = "Dirección:")]
        public string Address { get; set; }

        [Display(Name = "Teléfono:")]
        public string Mobile { get; set; }

    }
}