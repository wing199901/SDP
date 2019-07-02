using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();

            //ListView Header
            lvResult.GridLines = true;
            lvResult.View = View.Details;
            lvResult.FullRowSelect = true;
            lvResult.Columns.Add("Staff ID", 100);
            lvResult.Columns.Add("Role ID", 100);
            lvResult.Columns.Add("Staff Name", 100);
            lvResult.Columns.Add("Quantity", 100);
        }
    }
}
