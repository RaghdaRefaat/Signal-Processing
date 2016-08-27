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

namespace Package
{
    public partial class FastFourier : Form
    {
        public List<double> XnFF , amplitudeFF, thetaFF;
        public List<List<double>> XkFF ;
        public static double FsFF;

        public FastFourier()
        {
            InitializeComponent();
        }

        private void FastFourier_Load(object sender, EventArgs e)
        {
            XnFF = new List<double>();
            amplitudeFF = new List<double>();
            thetaFF = new List<double>();
            XkFF = new List<List<double>>();
            FsFF = 0;
        }

        private void Draw(List<double> x , string t , string yt , string xt)
        {
            GraphAmpOrThetaVSSegmaFF g = new GraphAmpOrThetaVSSegmaFF(x,t,yt,xt);
            g.Show();
        }
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FirstTask f = new FirstTask();
            string[] path = f.showDialog();
            f.readFile(path[0], XnFF);
        }

        public List<List<double>> fastFourier(List<double> x, int N)
        {
            List<List<double>> y = new List<List<double>>();
            List<double> l1 = new List<double>();
            List<double> l2 = new List<double>();
            List<List<double>> ff1 = new List<List<double>>();
            List<List<double>> ff2 = new List<List<double>>();
            double[] imaginaryNumberFF = new double[2];
            double[] elementFF = new double[2];
            if (N == 2)
            {
                List<double> t1 = new List<double>();
                List<double> t2 = new List<double>();
                t1.Add(x[0] + x[1]);
                t1.Add(0);
                y.Add(t1);
                t2.Add(x[0] - x[1]);
                t2.Add(0);
                y.Add(t2);
                return y;
            }
            else
            {
                for (int i = 0; i < N/2; i++)
                {
                    l1.Add(x[2*i]); //put in l1 the even samples
                    l2.Add(x[(2*i)+1]); // put in l2 the odd samples
                }
                ff1 = fastFourier(l1, N / 2);
                ff2 = fastFourier(l2, N / 2);
                for (int i = 0; i < x.Count; i++)
                {
                    List<double> tmp = new List<double>();
                    tmp.Add(0);
                    tmp.Add(0);
                    y.Add(tmp);
                }
                for (int k = 0; k < (N / 2) ; k++)
                {
                    double powerOfWeight = (k * 2 * Math.PI ) / N;
                    imaginaryNumberFF[0] = Math.Cos(powerOfWeight);
                    imaginaryNumberFF[1] = -Math.Sin(powerOfWeight);
                    elementFF[0] = ff2[k][0] * imaginaryNumberFF[0];
                    elementFF[1] = (imaginaryNumberFF[0] * ff2[k][1]) + (imaginaryNumberFF[1] * ff2[k][0]);
                    if (imaginaryNumberFF[1] != 0 && ff2[k][1] != 0)
                    {
                        double tmp = imaginaryNumberFF[1] * ff2[k][1] * -1;
                        elementFF[0] += tmp;
                    }
                    y[k][0] = ff1[k][0] + elementFF[0];
                    y[k][1] = ff1[k][1] + elementFF[1];
                    y[k + (N / 2)][0] = ff1[k][0] - elementFF[0];
                    y[k + (N / 2)][1] = ff1[k][1] - elementFF[1];
                }
                return y;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            FsFF = double.Parse(txtFs.Text);
            DateTime timeBefore = DateTime.Now;
            XkFF = fastFourier(XnFF, XnFF.Count);
            DateTime timeAfter = DateTime.Now;
            txtTimeFourier.Text = (timeAfter - timeBefore).ToString();
            FileStream fs = new FileStream("D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\Fourier\\Fast Fourier Transform AmpTheta.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            FileStream fs1 = new FileStream("D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\Fourier\\Fast Fourier Transform Result.txt", FileMode.Append);
            StreamWriter s = new StreamWriter(fs1);
            for (int k = 0; k < XkFF.Count; k++)
            {
                double tmp = Math.Sqrt((Math.Pow(XkFF[k][0], 2) + Math.Pow(XkFF[k][1], 2)));
                amplitudeFF.Add(tmp);
                double angel = Math.Atan2(XkFF[k][1], XkFF[k][0]);
                if (XkFF[k][0] == 0)
                    angel = 0;
                thetaFF.Add(angel);
                string line = "[" + amplitudeFF[k].ToString() + "," + thetaFF[k].ToString() + "]";
                sw.WriteLine(line);
                string line2 = XkFF[k][0].ToString() + "," + XkFF[k][1].ToString();
                s.WriteLine(line2);
            }
            sw.Close();
            s.Close();
        }

        private void btnAmplitudeGraph_Click(object sender, EventArgs e)
        {
            Draw(amplitudeFF, "Segma VS Amplitude In Fast Fourier\n", "Amplitude\n", "Segma\n");
        }

        private void btnThetaGraph_Click(object sender, EventArgs e)
        {
            Draw(thetaFF, "Segma VS Theta In Fast Fourier\n", "Theta\n", "Segma\n");
        }

    }
}
