using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoAccountTracking
{
    public partial class EditAddress : Form
    {
        public EditAddress(List<NetCurrency> currencies)
        {
            InitializeComponent();
            dg_Currencies.Columns.Add("ISO", "ISO Name e.g. BTC");
            dg_Currencies.Columns.Add("Name", "Long Name e.g. BitCoin");

            foreach (var netCurrency in currencies)
            {
                dg_Currencies.Rows.Add(netCurrency.IsoName, netCurrency.Name);
                dg_Currencies.Rows[dg_Currencies.Rows.Count - 2].ReadOnly = true;
            }
        }

        public EditAddress(List<NetCurrency> currencies, string addressName, string address, string iso)
        {
            InitializeComponent();
            dg_Currencies.Columns.Add("ISO", "ISO Name e.g. BTC");
            dg_Currencies.Columns.Add("Name", "Long Name e.g. BitCoin");

            foreach (var netCurrency in currencies)
            {
                dg_Currencies.Rows.Add(netCurrency.IsoName, netCurrency.Name);
                dg_Currencies.Rows[dg_Currencies.Rows.Count - 2].ReadOnly = true;
                if (netCurrency.IsoName == iso)
                {
                    dg_Currencies.Rows[dg_Currencies.Rows.Count - 2].Cells["ISO"].Selected = true;
                }
            }

            txt_AddressName.Text = addressName;
            txt_Address.Text = address;

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
