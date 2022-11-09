using mintazh_irf.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mintazh_irf
{
    public partial class Form1 : Form
    {
        List<OlympicResult> results = new List<OlympicResult>();

        public Form1()
        {
            InitializeComponent();
        }
        public void LoadData(string filename)
        {
            using (var sr= new StreamReader(filename, Encoding.Default))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(',');
                    var or = new OlympicResult()
                    {
                        Year = int.Parse(line[0]),
                        Country = line[3],
                        Medals = new int[]{
                            int.Parse(line[5]),
                            int.Parse(line[6]),
                            int.Parse(line[7]),

                        }
                    };
                    results.Add(or);

                }

            }
        }
        public
    }
}
