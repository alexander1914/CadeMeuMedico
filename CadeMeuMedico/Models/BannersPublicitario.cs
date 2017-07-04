using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    public partial class BannersPublicitario
    {
        public long IDBanner { get; set; }
        public string TituloCampanha { get; set; }
        public string BannerCampanha { get; set; }
        public string LinkBanner { get; set; }
    }
}