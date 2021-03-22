using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace criadorcaes.Models
{
    /// <summary>
    /// descrição de cada um dos cães
    /// </summary>
    public class Caes
    {
        /// <summary>
        /// identificador de cada cão
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// nome do cão
        /// </summary>
        public String Nome { get; set; }

        /// <summary>
        /// sexo do cão
        /// M - Masculino
        /// F - Feminino
        /// </summary>
        public String Sexo { get; set; }

        /// <summary>
        /// data de nascimento do cão
        /// </summary>
        public DateTime DataNasc { get; set; }

        /// <summary>
        /// data de compra do cão
        /// </summary>
        public DateTime DataCompra { get; set; }

        /// <summary>
        /// Registo do cao no livro de origens Portuguesa (LOP)
        /// </summary>
        public String LOP { get; set; }




    }
}
