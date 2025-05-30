using GestoreSpeseMensili.Utils.Enum;
using System;
using System.Windows.Forms;

namespace GestoreSpeseMensili
{
    internal static class Program
    {
        public static Spese speseList;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            speseList = new Spese();
            speseList.BulkAdd(false, new Spesa("qweqweqw", 123, CategoriaBaseSpesa.Obbligatorie, Priorita.Alta));
            Application.Run(new Form1());
        }
    }
}