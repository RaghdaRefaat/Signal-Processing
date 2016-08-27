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
    public partial class GraphAmpOrThetaVSSegmaFF : Form
    {
        GraphPane myPane;
        List<double> x = new List<double>();
        string Title, YTitle, XTitle;

        public GraphAmpOrThetaVSSegmaFF(List<double> X , string title , string yTitle , string xTitle)
        {
            InitializeComponent();
            x = X;
            Title = title;
            YTitle = yTitle;
            XTitle = xTitle;
        }

        private void GraphAmpVSSegmaFF_Load(object sender, EventArgs e)
        {
            double xAxis = (2 * Math.PI * FastFourier.FsFF) / x.Count;
            myPane = zedGraphControl1.GraphPane;
            myPane.Title = Title;
            myPane.YAxis.Title = YTitle;
            myPane.XAxis.Title = XTitle;
            PointPairList list = new PointPairList();
            for (int i = 0; i < x.Count; i++)
                list.Add(i * xAxis, x[i]);
            LineItem l = myPane.AddCurve("Signal", list, Color.Blue, SymbolType.Diamond);
            l.Line.IsVisible = false;
            zedGraphControl1.AxisChange();
        }
    }
}
