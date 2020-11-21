using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CINE.Models
{
    public class Clasificacion
    {
        public int Id
        {
            get; set;
        }
        public string Tipo
        { get; set; }
         
        public string Descripcion
        {
            get; set;
        }

    }
}