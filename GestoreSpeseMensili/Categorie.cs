using System;
using System.Collections.Generic;
using GestoreSpeseMensili.Utils.Enum;

namespace GestoreSpeseMensili
{
    internal class Spese : List<Spesa>
    {
        public Spesa this[string n]
        {
            get
            {
                return this[n];
            }
        }

        public Spesa SearchByName(string s)
        {
            foreach (Spesa spesa in this)
            {
                if (spesa.Nome == s)
                {
                    return spesa;
                }
            }
            return null;
        }

        public virtual new void Add(Spesa s) => base.Add(s);

        public void BulkAdd(bool baseProcuedure, params Spesa[] spese)
        {
            if (baseProcuedure == true)
            {
                MockedSpeseGenerator();
                return;
            }

            if (spese == null)
            {
                throw new ArgumentNullException($"It's necessary to pass param for the field {nameof(spese)}");
            }

            foreach (var s in spese)
            {
                this.Add(s);
            }
        }

        /// <summary>
        /// private method to test the application
        /// </summary>
        [Obsolete]
        private void MockedSpeseGenerator()
        {
            this.Add(new Spesa("Spesa sensuale di test 1", 1577, CategoriaBaseSpesa.Obbligatorie, Priorita.Media, "Descrizione sexy 1"));
            this.Add(new Spesa("Spesa sensuale di test 2", 1130, CategoriaBaseSpesa.Obbligatorie, Priorita.Media, "Descrizione sexy 2"));
            this.Add(new Spesa("Spesa sensuale di test 3", 1890, CategoriaBaseSpesa.Extra, Priorita.Media, "Descrizione sexy 3"));
        }
    }
}