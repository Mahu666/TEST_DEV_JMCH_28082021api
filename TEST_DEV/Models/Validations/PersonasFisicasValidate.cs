using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TEST_DEV.Models
{
    //Relacionar con tabla origen generada.
    [MetadataType(typeof(Tb_PersonasFisicas.MetaData))]
    public partial class Tb_PersonasFisicas
    {
        sealed class MetaData
        {
            [Required]
            public string Nombre;
        }
    }
}