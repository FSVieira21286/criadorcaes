using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace criadorcaes.Models
{
    public class Fotografias
    {
        /// <summary>
        /// Foto do cão
        /// </summary>
        public String Fotografia { get; set; }

        /// <summary>
        /// Data do upload da foto
        /// </summary>
        public DateTime DataFoto { get; set; }

        /// <summary>
        /// Local onde a foto foi tirada
        /// </summary>
        public String LocalFoto { get; set; }


    }
}
