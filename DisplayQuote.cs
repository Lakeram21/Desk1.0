using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega
{
    public partial class DisplayQuote : Form
    {
        Form _mainMenu;
        public DisplayQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
