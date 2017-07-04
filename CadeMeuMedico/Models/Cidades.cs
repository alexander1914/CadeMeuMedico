namespace CadeMeuMedico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public partial class Cidades
    {
        [Key]
        public int IDCidade { get; set; }
        public string Nome { get; set; }
    }
}
