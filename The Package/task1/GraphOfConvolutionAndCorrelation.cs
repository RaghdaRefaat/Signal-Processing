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
    public partial class GraphOfConvolutionAndCorrelation : Form
    {
        List<double> list = new List<double>();

        public GraphOfConvolutionAndCorrelation(List<double> x)
        {
            InitializeComponent();
            
            list = x;
        }

        private void GraphOfConvolution_Load(object sender, EventArgs e )
        {
            FirstTask f = new FirstTask();
            f.CreateGraph(zedGraphControl1, list , Color.Red);
        }
    }
}
