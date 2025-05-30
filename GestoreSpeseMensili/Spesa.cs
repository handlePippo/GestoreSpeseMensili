using GestoreSpeseMensili.Utils.Enum;
using System;

namespace GestoreSpeseMensili
{
    internal class Spesa : ABaseSpesa, IComparable<Spesa>
    {
        public string Descrizione { get; set; }
        public Priorita Priorita { get; set; }
        public DateTime? DataScadenza { get; set; }
        public DateTime? DataEstinzione { get; set; }

        public Spesa(string nome, double ammontare, CategoriaBaseSpesa categoria, Priorita priorita, string descrizione=null, DateTime? dataScadenza=null, DateTime? dataEstinzione=null) 
            : base(nome, categoria, ammontare)
        {
            Priorita = priorita;
            Descrizione = descrizione ?? string.Empty;
            DataScadenza = dataScadenza;
            DataEstinzione = dataEstinzione;
            Categoria = categoria;
        }

        public int CompareTo(Spesa other) => 1;
    }
}