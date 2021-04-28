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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_parse_Click(object sender, EventArgs e)
        {
            foreach (string regexp in tb_regexps.Lines)
            {
                tb_output.Text += "----------------[" + regexp + "]-------------------" + Environment.NewLine;
               
                MatchCollection matches = Regex.Matches(tb_input.Text, regexp);
                //if (matches.Count > 0)
                //{
                    foreach (Match m in matches)
                    {
                        for (int i = 0; i < m.Groups.Count; i++)
                            tb_output.Text += m.Groups[i].Value + Environment.NewLine;
                    }
                //}
                
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_output.Clear();
        }
    }
}
