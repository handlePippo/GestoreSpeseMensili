using GestoreSpeseMensili.Utils;
using GestoreSpeseMensili.Utils.Enum;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GestoreSpeseMensili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void EditSaveBtn_Click(object sender, EventArgs e)
        {
            if (this.ShopDetailTextBox.ReadOnly == true)
            {
                EditSaveShopBtn.Text = GenericCostants.ACTION_SAVE;
            }
            else
            {
                EditSaveShopBtn.Text = GenericCostants.ACTION_EDIT;
            }
            this.ShopDetailTextBox.ReadOnly = !ShopDetailTextBox.ReadOnly;
        }

        private void ComboChooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpeseListBox.Items.Clear();
            var item = ComboChooseCategory.SelectedItem.ToString();
            try
            {
                var category = (CategoriaBaseSpesa)Enum.Parse(typeof(CategoriaBaseSpesa), item);
                InjectSpese(category);
            }
            catch (Exception ex)
            {
                ex.Data["sender"] = sender;
                ex.Data["e"] = e;
                throw;
            }
        }

        private void InjectSpese(CategoriaBaseSpesa category)
        {
            try
            {
                var speseFiltered = Program.speseList.Where(s => s.Categoria == category);
                if (speseFiltered.Any() == true)
                {
                    var speseName = speseFiltered.Select(s => s.Nome);
                    SpeseListBox.Items.AddRange(speseName.ToArray());
                }
            }
            catch (Exception ex)
            {
                ex.Data["category"] = category;
                throw;
            }
        }

        private void AddShopBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(e is EventArgsForActionType)
                {
                    SpeseListBox.Items.Add(e as EventArgsForActionType);
                }
            }
            catch (Exception ex)
            {
                ex.Data["sender"] = sender;
                ex.Data["e"] = e;
                throw;
            }
        }

        public class Category
        {

        }

        public class EventArgsForActionType : EventArgs
        {
            public  string Name { get; set; }
            public  int Count { get; set; }
            public EventArgsForActionType()
            {

            }
        }
    }
}