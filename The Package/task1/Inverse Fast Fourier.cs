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
    public partial class Inverse_Fast_Fourier : Form
    {
        private List<List<double>> XkIFF , XnIFF;
        public double[] elementFF, imaginaryNumberFF;

        public Inverse_Fast_Fourier()
        {
            InitializeComponent();
        }

        private void Inverse_Fast_Fourier_Load(object sender, EventArgs e)
        {
            XkIFF = new List<List<double>>();
            XnIFF = new List<List<double>>();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FirstTask f = new FirstTask();
            string[] path = f.showDialog();
            FileStream fs = new FileStream(path[0], FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while(sr.Peek() != -1)
            {
                string tmp = sr.ReadLine();
                string[] line = tmp.Split(',');
                List<double> t = new List<double>();
                t.Add(double.Parse(line[0]));
                t.Add(double.Parse(line[1]));
                XkIFF.Add(t);
            }
            sr.Close();
            fs.Close();
        }

        public List<List<double>> InvFastFourier(List<List<double>> xk, int N)
        {
            elementFF = new double[2];
            imaginaryNumberFF = new double[2];
            List<List<double>> xn = new List<List<double>>();
            List<List<double>> l1 = new List<List<double>>();
            List<List<double>> l2 = new List<List<double>>();
            List<List<double>> ff1 = new List<List<double>>();
            List<List<double>> ff2 = new List<List<double>>();
            if (N == 2)
            {
                List<double> t1 = new List<double>();
                List<double> t2 = new List<double>();
                t1.Add(xk[0][0] + xk[1][0]);
                t1.Add(xk[0][1] + xk[1][1]);
                xn.Add(t1);
                t2.Add(xk[0][0] - xk[1][0]);
                t2.Add(xk[0][1] - xk[1][1]);
                xn.Add(t2);
                return xn;
            }
            else
            {
                for (int i = 0; i < (N / 2); i++)
                {
                    List<double> t1 = new List<double>();
                    List<double> t2 = new List<double>();
                    t1.Add(xk[2 * i][0]);//put in l1 the even samples
                    t1.Add(xk[2 * i][1]);
                    ff1.Add(t1);
                    t2.Add(xk[(2 * i) + 1][0]); // put in l2 the odd samples
                    t2.Add(xk[(2 * i) + 1][1]);
                    ff2.Add(t2);
                }
                l1 = InvFastFourier(ff1, N / 2);
                l2 = InvFastFourier(ff2, N / 2);
                for (int i = 0; i < xk.Count; i++) 
                {
                    List<double> tmp = new List<double>();
                    tmp.Add(0);
                    tmp.Add(0);
                    xn.Add(tmp);
                }
                for (int n = 0; n < (N / 2); n++)
                {
                    double powerOfWeight = (n * 2 * Math.PI) / N;
                    imaginaryNumberFF[0] = Math.Cos(powerOfWeight);
                    imaginaryNumberFF[1] = Math.Sin(powerOfWeight);
                    imaginaryNumberFF[0] = Math.Truncate(imaginaryNumberFF[0] * Math.Pow(10, 13)) / Math.Pow(10, 13);
                    imaginaryNumberFF[1] = Math.Truncate(imaginaryNumberFF[1] * Math.Pow(10, 13)) / Math.Pow(10, 13);
                    elementFF[0] = l2[n][0] * imaginaryNumberFF[0];
                    elementFF[1] = (imaginaryNumberFF[0] * l2[n][1]) + (imaginaryNumberFF[1] * l2[n][0]);
                    if (imaginaryNumberFF[1] != 0 && l2[n][1] != 0)
                    {
                        double tmp = imaginaryNumberFF[1] * l2[n][1] * -1;
                        elementFF[0] += tmp;
                    }
                    xn[n][0] = (l1[n][0] + elementFF[0]); //* (1.0 / N);
                    xn[n][1] = (l1[n][1] + elementFF[1]); //* (1.0 / N);
                    xn[n + N / 2][0] = (l1[n][0] - elementFF[0]); //* (1.0 / N);
                    xn[n + N / 2][1] = (l1[n][1] - elementFF[1]); //* (1.0 / N);
                }
                    return xn;
                }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            XnIFF = InvFastFourier(XkIFF, XkIFF.Count());
            for (int i = 0; i < XnIFF.Count; i++)
            {
                XnIFF[i][0] = XnIFF[i][0] / XnIFF.Count;
                XnIFF[i][1] = XnIFF[i][1] / XnIFF.Count;
            }
            FileStream f = new FileStream("D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\Fourier\\Inv FF Result.txt",FileMode.Append);
            StreamWriter s = new StreamWriter(f);
            for (int i = 0; i < XnIFF.Count; i++)
            {
                string tmp = XnIFF[i][0] + " , " + XnIFF[i][1];
                s.WriteLine(tmp);
            }
            s.Close();
            f.Close();
        }
    }
}
