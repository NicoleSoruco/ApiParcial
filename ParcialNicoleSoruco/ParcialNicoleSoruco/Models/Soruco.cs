using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialNicoleSoruco.Models
{
    
    public class Soruco
    {
        [Key]
        [Required(ErrorMessage = "debe ingresar la categoria del tipo")]
        [StringLength(4, ErrorMessage = "The field {0} must contain between {2} and {1} characters", MinimumLength = 2)]
        public string alpha3Code { get; set; }

        [Required]
        [StringLength(24, ErrorMessage = "The field {0} must contain between {2} and {1} characters", MinimumLength = 2)]
        public string name { get; set; }

        [Required]
        [StringLength(24, ErrorMessage = "The field {0} must contain between {2} and {1} characters", MinimumLength = 2)]
        public string  region { get; set; }

        [Required(ErrorMessage = "Debe ingresar numero de departamento ")]
        [Display(Name = "area de la region")]
        [Range (1, 900000000)]
        public int area { get; set; }

        [Url]
        [Required]
        [DataType(DataType.Url,ErrorMessage ="ingresar url de la bandera ")]
        public string flag { get; set; }

        [Required]
        [Display(Name = "codigo")]
        [Range(1, 100000)]
        public int callingCodes { get; set; }

        [Required(ErrorMessage = "debe ingresar su idioma del pais")]
        public string language { get; set; }
    }
}