using GestoreSpeseMensili.Utils.Enum;
using System;

namespace GestoreSpeseMensili
{
    /// <summary>
    /// ABaseSpesa
    /// </summary>
    internal abstract class ABaseSpesa
    {
        public string Nome { get; set; }
        public CategoriaBaseSpesa Categoria { get; set; }
        public double Ammontare { get; set; }
        public DateTime DataCreazione { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="categoria"></param>
        /// <param name="ammontare"></param>
        protected ABaseSpesa(string nome, CategoriaBaseSpesa categoria, double ammontare)
        {
            DataCreazione = DateTime.Now;
            Nome = nome;
            Categoria = categoria;
            Ammontare = ammontare;
        }
    }
}