/**
 ******************************************************************************
 * @file    PR.cs
 * @author  Kuan-Di Jiang
 * @brief   User interface
 ******************************************************************************
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feature_app
{
    public partial class PR : Form
    {
        public PR()
        {
            InitializeComponent();
        }

        private void check_bt_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
