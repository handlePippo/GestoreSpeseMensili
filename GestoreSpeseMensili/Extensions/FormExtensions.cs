using MonthExpenseManager;
using System;
using System.Windows.Forms;

public static class FormExtensions
{
    public static void IniatializeControls<T>(this T source) where T : Form
    {
        if (source is Form1)
        {
            (source as Form1).ShopDetailTextBox.Text = default;
            (source as Form1).AmountTextBox.Text = default;
            (source as Form1).CreationDTPicker.Value = DateTime.Today;
            (source as Form1).ExpirationDTPicker.Value = DateTime.Today;
            (source as Form1).AddShopBtn.Enabled = true;
            (source as Form1).SpeseListBox.Items.Clear();
        }
    }

    public static void ResetControls<T>(this T source, bool value) where T : Form
    {
        if (source is Form1)
        {
            (source as Form1).EditSaveShopBtn.Enabled = value;
            (source as Form1).AmountTextBox.Enabled = value;
            (source as Form1).CreationDTPicker.Enabled = value;
            (source as Form1).ExpirationDTPicker.Enabled = value;
        }
    }
}