using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace criadorcaes.Models
{
    public class Criadores
    {

        /// <summary>
        /// nome do criador
        /// </summary>
        public String Nome { get; set; }

        /// <summary>
        /// nome comercial do criador
        /// </summary>
        public String NomeComercial { get; set; }

        /// <summary>
        /// Morada do criador
        /// </summary>
        public String Morada { get; set; }

        /// <summary>
        /// Codigo postal da morada
        /// </summary>
        public String CPostal { get; set; }

        /// <summary>
        /// Telemovel do criador de cães
        /// </summary>
        public int Telemovel { get; set; }

        /// <summary>
        /// email do criador de cães
        /// </summary>
        public String Email { get; set; }

    }
}
