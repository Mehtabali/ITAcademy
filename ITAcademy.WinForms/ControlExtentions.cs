using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITAcademy.WinForms
{
    public static class ControlExtention
    {
        public static void Load(this System.Windows.Forms.ComboBox combo, DataTable table, String columnToDisplay, String value)
        {

            if (table.Rows.Count > 0)
            {
                combo.DataSource = table;
                combo.DisplayMember = columnToDisplay;
                combo.ValueMember = value;
                
            }
        }
    }
}
