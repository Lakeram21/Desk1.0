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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            var addQuote = new AddQuote(this);
       
            addQuote.Show();

            this.Hide();
        }

        private void btnViewQuote_Click(object sender, EventArgs e)
        {
            var viewAllQuotes =new ViewAllQuotes(this);

            viewAllQuotes.Show();

            this.Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            var searchAllQuotes = new SearchQuotes(this);
            searchAllQuotes.Show();
            this.Hide();
        }
    }
}
