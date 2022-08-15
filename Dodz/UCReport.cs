using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dodz
{
    public partial class UCReport : UserControl
    {
        private static UCReport _instance;

        public static UCReport Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCReport();
                return _instance;
            }
        }

        public UCReport()
        {
            InitializeComponent();
        }

        private void UCReport_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.dodzDataSet.products);

            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
