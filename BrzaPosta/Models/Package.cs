using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.Models
{
    public class Package
    {
        [Key]
        public int Id { get; set; }

        //info pošiljatelja
        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Ime pošiljatelja")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Prezime pošiljatelja")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Adresa pošiljatelja")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Kontakt pošiljatelja")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Grad pošiljatelja")]
        public string City { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Županija pošiljatelja")]
        public string State { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Poštanski br. pošiljatelja")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Veličina pošiljke")]
        public string Size { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Opis pošiljke")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Status pošiljke")]
        public string Status { get; set; }

        //info primatelja

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Ime primatelja")]
        public string Name2 { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Prezime primatelja")]
        public string LastName2 { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Adresa primatelja")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Kontakt primatelja")]
        public string Contact2 { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Grad primatelja")]
        public string City2 { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Županija primatelja")]
        public string State2 { get; set; }

        [Required(ErrorMessage = "Neophodan podatak")]
        [Display(Name = "Poštanski br. primatelja")]
        public string Zip2 { get; set; }


    }
}
