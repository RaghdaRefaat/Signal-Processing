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
    public partial class InverseFourier : Form
    {
        List<double> Xn, amplitude, theta;
        List<List<double>> Xk;
        private double Fs;
        public List<double> result, realPart, ImagPart, exponetialPart ;
        double finalResult;

        private void InverseFourier_Load(object sender, EventArgs e)
        {
            Xn = new List<double>();
            amplitude = new List<double>();
            theta = new List<double>();
            Xk = new List<List<double>>();
            
            Fs = 0;
            realPart = new List<double>();
            ImagPart = new List<double>();
        }
        
        public InverseFourier()
        {
            InitializeComponent();
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
                string[] a = line[0].Split('[');
                string[] t = line[1].Split(']');
                amplitude.Add(double.Parse(a[1]));
                theta.Add(double.Parse(t[0]));
            }
            for (int i = 0; i < amplitude.Count; i++)
            {
                List<double> tmpXk = new List<double>();
                tmpXk.Add(amplitude[i] * Math.Cos(theta[i]));
                tmpXk.Add(amplitude[i] * Math.Sin(theta[i]));
                Xk.Add(tmpXk);
            }
        }

        private void inverseFourierTransform()
        {
            for (int n = 0; n < Xk.Count; n++)
            {
                result = new List<double>();
                result.Add(0); result.Add(0);
                for (int k = 0; k < Xk.Count; k++)
                {
                    exponetialPart = new List<double>();
                    double tmp;
                    double powerOfExp = (k * 2 * Math.PI * n) / Xk.Count;
                    exponetialPart.Add(Math.Cos(powerOfExp));
                    exponetialPart.Add(Math.Sin(powerOfExp));
                    exponetialPart[0] = Math.Truncate(exponetialPart[0] * Math.Pow(10, 13)) / Math.Pow(10, 13);
                    exponetialPart[1] = Math.Truncate(exponetialPart[1] * Math.Pow(10, 13)) / Math.Pow(10, 13);
                    realPart.Add(Xk[k][0] * exponetialPart[0]);
                    ImagPart.Add(Xk[k][0] * exponetialPart[1] + Xk[k][1] * exponetialPart[0]);
                    if (exponetialPart[1] != 0 && Xk[k][1] != 0)
                    {
                        tmp = exponetialPart[1] * Xk[k][1] * -1;
                        realPart[k] += tmp;
                    }
                }
                for (int k = 0; k < Xk.Count; k++)
                {
                    result[0] = result[0] + realPart[k];
                    result[1] = result[1] + ImagPart[k];
                    realPart[k] = 0;
                    ImagPart[k] = 0;
                }
                finalResult = result[0] / Xk.Count;
                finalResult = Math.Round(finalResult, 1);
                Xn.Add(finalResult);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Fs = double.Parse(txtFs.Text);
            inverseFourierTransform();
            FileStream fs = new FileStream("D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\Fourier\\Inverse Fourier Transform Result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < Xn.Count; i++)
                sw.WriteLine(Xn[i]);
            sw.Close();
            fs.Close();
        }
    }
}
