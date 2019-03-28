using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelpersForm.Models
{
    public class Usuario
    {
        [Required(ErrorMessage ="Llene este campo")]
        [MaxLength(15, ErrorMessage ="No se permiten mas de 15 caracteres")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Llene este campo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Llene este campo")]
        public string Apellido { get; set; }

        [Required]
        [Range(15, 100, ErrorMessage = "Su edad debe ser mayor que 15")]
        public short Edad { get; set; }

        [Required(ErrorMessage = "Llene este campo")]
        public string Telefono { get; set; }

       
        [EmailAddress(ErrorMessage ="Ingrese un correo valido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Llene este campo")]
        public Generos Genero { get; set; }

        [Required(ErrorMessage = "Llene este campo")]
        public string Estado_Civil { get; set; }

        public bool Pasatiempos_1 { get; set; }
        public bool Pasatiempos_2 { get; set; }
        public bool Pasatiempos_3 { get; set; }
        public bool Pasatiempos_4 { get; set; }

    }

    public enum Generos
    {
        Masculino,
        Femenino
    }

}