using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto

    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

     
        private string nombre;

        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo solo puede contener letras.")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string descripcion;

        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo solo puede contener letras.")]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private int referencia;
        [Required]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El campo debe ser numérico.")]
        //[Range(18, 100, ErrorMessage = "es menor de edad")]
        public int Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        private string categoria;
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo solo puede contener letras.")]
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private decimal precio;
        [Required]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El campo debe ser numérico.")]
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

    }

}