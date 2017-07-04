namespace CadeMeuMedico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity.Spatial;


    public partial class Medicos
    {
        [Key]
        public long IDMedico { get; set; }        
        public string CRM { get; set; }        
        public string Nome { get; set; }        
        public string Endereco { get; set; }        
        public string Bairro { get; set; }        
        public string Email { get; set; }
        [DisplayName("Tem Convênio ?")]
        public bool AtendePorConvenio { get; set; }
        [DisplayName("Tem Clínica ?")]
        public bool TemClinica { get; set; }
        [DisplayName("Site ou Blog")]
        public string WebsiteBlog { get; set; }
        [DisplayName("Cidade")]
        public int IDCidade { get; set; }
        [DisplayName("Especialidade")]
        public int IDEspecialidade { get; set; }

        public virtual Especialidades Especialidades { get; set; }
        public virtual Cidades Cidades { get; set; }
    }
}
