using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Entidades
{
    public class Marca
    {
        [Key]
        [Column("CategoriaId")]
        public int Id { get; set; }


        public string Nombre { get; set; }

    }
}