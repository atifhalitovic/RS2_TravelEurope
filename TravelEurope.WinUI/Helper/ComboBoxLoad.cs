using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEurope.WinUI.Helper
{
   public class ComboBoxLoad<T> where T : class
    {
        public ComboBoxLoad()
        {

        }
        public void Load(ComboBox cmb, List<T> result, string DisplayMember, string ValueMember)
        {
            cmb.DataSource = result;
            cmb.DisplayMember = DisplayMember;
            cmb.ValueMember = ValueMember;
        }
    }
}
