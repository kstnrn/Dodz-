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
    public partial class UCHome : UserControl
    {
        private static UCHome _instance;

        public static UCHome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCHome();
                return _instance;
            }
        }
        public UCHome()
        {
            InitializeComponent();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {

        }
    }
}
