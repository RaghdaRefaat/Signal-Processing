using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZedGraph;



namespace Package
{
    public partial class FirstTask : Form
    {
        public static List<double> signal1 , signal2 , sum;
        GraphPane myPane;
        int counter = 0;

        public FirstTask()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            signal1 = new List<double>(2000);
            signal2 = new List<double>(2000);
            sum = new List<double>(2000);
        }

        public void readFile(string path , List<double> y)
        {
            FileStream fs = new FileStream(path,FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > -1)
            {
                string tmp = sr.ReadLine();
                y.Add(double.Parse(tmp));
            }
            sr.Close();
            fs.Close();
        }

        public void CreateGraph(ZedGraphControl zgc, List<double> y , Color c)
        {
            myPane = zgc.GraphPane;
            myPane.Title = "The Graph\n";
            myPane.YAxis.Title = "Voltage\n";
            myPane.XAxis.Title = "Number Of Samples\n";
            PointPairList list = new PointPairList();
            for (int i = 0; i < y.Count(); i++)
                list.Add(i , y[i]);
            LineItem l = myPane.AddCurve("Signal", list, c , SymbolType.Diamond);
            l.Line.IsVisible = false;
            zgc.AxisChange();
        }

        public string[] showDialog( )
        {
            string[] tmp = new string[2];
            using (OpenFileDialog o = new OpenFileDialog()
               {
                   Filter = "text documents |* .txt",
                   ValidateNames = true,
                   Multiselect = true
               })
                if (o.ShowDialog() == DialogResult.OK)
                    return o.FileNames;
            return tmp ;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                string[] path = showDialog();
                readFile(path[0], signal1);
                CreateGraph(zedGraphControl2,signal1, Color.Black);
            }
            else
            {
                string[] path = showDialog();
                readFile(path[0], signal2);
                CreateGraph(zedGraphControl2, signal2, Color.Blue);
            }
            counter++;
            zedGraphControl2.ClientSize = this.Size;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (signal1.Count() != 2000 && signal2.Count() != 2000)
                MessageBox.Show("Sorry The First Signal Or The Second Or Both haven't been read\n", "Caution", MessageBoxButtons.OK);
            else
            {
                for (int i = 0; i < signal1.Count(); i++)
                    sum.Add(signal1[i] + signal2[i]);
                FileStream f = new FileStream("D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\First Task Files\\Sum Of 2 Signals.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(f);
                for (int i = 0; i < sum.Count(); i++)
                    sw.WriteLine(sum[i].ToString());
                GraphSumOfSignals s = new GraphSumOfSignals();
                s.Show();
            }
        }

    }
}
