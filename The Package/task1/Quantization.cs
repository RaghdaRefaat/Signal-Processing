using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Package
{
    public partial class Quantization : Form
    {
        public static List<double> x , q_x , midpoint;
        List<string> encode , interval;
        FirstTask f = new FirstTask();

        public Quantization()
        {
            InitializeComponent();
        }

        private void Quantization_Load(object sender, EventArgs e)
        {
            x = new List<double>();
            q_x = new List<double>();
            midpoint = new List<double>();
            encode = new List<string>();
            interval = new List<string>();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string[] path = f.showDialog();
            f.readFile(path[0], x);
        }

        private void btnQuantization_Click(object sender, EventArgs e)
        {
            double min = x.Min();
            double max = x.Max();
            int level = int.Parse(txtLevels.Text.ToString());
            int bitLevel = (int)Math.Ceiling(Math.Log(level) / Math.Log(2));
            double delta = (max - min) / level;
            double[] arr = new double[level + 1];
            arr[0] = min;
            for (int i = 1; i < level+1 ; i++)
                arr[i] = arr[i - 1] + delta;
            //Encodint The Levels & calculate mid points
            for (int i = 0; i < level; i++)
            {
                encode.Add(Convert.ToString(i,2).PadLeft(bitLevel,'0'));
                midpoint.Add((arr[i] + arr[i + 1]) / 2);
            }
            //calculate quantized data 
            for (int i = 0; i < x.Count(); i++)
                for (int j = 0; j < level ; j++)
                    if (x[i] >= arr[j] && x[i] <= arr[j + 1])
                    {
                        q_x.Add((midpoint[j]));
                        interval.Add(encode[j]);
                        break;
                    }
            //Display In DGV
            for (int i = 0; i < x.Count; i++)
            {
                quantDGV.Rows.Add();
                quantDGV.Rows[i].Cells[0].Value = i;
                quantDGV.Rows[i].Cells[1].Value = x[i];
                quantDGV.Rows[i].Cells[2].Value = interval[i];
                quantDGV.Rows[i].Cells[3].Value = q_x[i];
                quantDGV.Rows[i].Cells[4].Value = q_x[i] - x[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphOfQuantization q = new GraphOfQuantization();
            q.Show();
        }
    }
}
