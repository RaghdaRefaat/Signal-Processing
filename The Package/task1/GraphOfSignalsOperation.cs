using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Package
{
    public partial class GraphOfSignalsOperation : Form
    {
        List<double> x = new List<double>();
        List<double> y = new List<double>();
        GraphPane myPane;

        public GraphOfSignalsOperation(List<KeyValuePair<double,double>> p)
        {
            InitializeComponent();
            for(int i=0 ; i<p.Count; i++)
            {
                x.Add(p[i].Key);
                y.Add(p[i].Value);
            }
        }

        private void GraphOfSignalsOperation_Load(object sender, EventArgs e)
        {
            myPane = zedGraphControl1.GraphPane;
            myPane.Title = "Signl's Operations Graph\n";
            myPane.YAxis.Title = "Voltage\n";
            myPane.XAxis.Title = "Number Of Samples\n";
            PointPairList list = new PointPairList();
            for (int i = 0; i < y.Count(); i++)
                list.Add(x[i], y[i]);
            LineItem l = myPane.AddCurve("Signal", list,Color.Red, SymbolType.Diamond);
            l.Line.IsVisible = false;
            zedGraphControl1.AxisChange();
        }
    }
}
