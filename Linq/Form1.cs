using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] namearr =  { "kamran", "ali", "umar", "usama", "asim", "sameer", "ali", "azeem", "salman", "abdullah", "farooqeazam", "umar", "ahad" };

        private void searchname(object sender, EventArgs e)
        {
            string combine = "";
            var names = from name in namearr
                        where name == nameuser.Text
                        select name;
            foreach(string n in names)
            {
                combine = combine + n + " ";
            }

            resultt.Text = combine;

        }

        private void search_startingalphabet(object sender, EventArgs e)
        {
            string combine = "";
            var names = from name in namearr
                        where name.StartsWith(startalpha.Text)
                        select name;
            foreach(string n in names)
            {
                combine = combine + n + " ";
            }

            resultt.Text = combine;
        }

        private void search_throughlength(object sender, EventArgs e)
        {
            string combine = "";
            var names = from name in namearr
                        where name.Length >= numofalpha.Text.Length
                        select name;
            foreach (string n in names)
            {
                combine = combine + n + " ";
            }

            resultt.Text = combine;
        }

        private void search_specificalphabet(object sender, EventArgs e)
        {
            string combine = "";
            var names = from name in namearr
                        where name.Contains(specificalpha.Text)
                        select name;
            foreach (string n in names)
            {
                combine = combine + n + " ";
            }

            resultt.Text = combine;
        }

        private void sort_Arr(object sender, EventArgs e)
        {
            string combine = "";
            var names = from name in namearr
                        orderby name ascending
                        select name;
            foreach (string n in names)
            {
                combine = combine + n + " ";
            }

            resultt.Text = combine;
        }


    }
}
