using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDesignTool
{
    public partial class FrmMenu : Form
    {
        private Point point;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Move(object sender, EventArgs e)
        {
            this.Location = point;
        }

    }
}
