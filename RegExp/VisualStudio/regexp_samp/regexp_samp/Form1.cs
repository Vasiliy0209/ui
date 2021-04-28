using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace regexp_samp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_invoke_Click(object sender, EventArgs e)
        {        

            foreach (string regexp in tb_regexps.Lines)
            {
                tb_output.Text += "----------------["+regexp+"]-------------------" + Environment.NewLine;               

                foreach (string line in tb_input.Lines)
                {
                    Match m = Regex.Match(line,regexp);
                    if (m != Match.Empty)
                    {
                        tb_output.Text += line + Environment.NewLine;
                    }
                }
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_output.Clear();
        }

        private void парсерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
