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
    public partial class Fourier : Form
    {
        public static List<double> Xn , amplitude , theta;
        public List<List<double>> Xk;
        public List<double> element, imaginaryNumber , result ,real , imaginary;
        public static double Fs;

        public Fourier()
        {
            InitializeComponent();
        }

        private void Fourier_Load(object sender, EventArgs e)
        {
            Xn = new List<double>();
            amplitude = new List<double>();
            theta = new List<double>();
            Xk = new List<List<double>>();
            
            
            
            
            Fs = 0;
        }

        private void Draw(List<double> x, string t, string yt, string xt)
        {
            GraphAmpOrThetaVSsegma g = new GraphAmpOrThetaVSsegma(x, t, yt, xt);
            g.Show();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FirstTask f = new FirstTask();
            string[] path = f.showDialog();
            f.readFile(path[0], Xn);
        }

        private void fourierTransform()
        {
            for (int k = 0; k < Xn.Count; k++)
            {
                result = new List<double>();//2elements
                result.Add(0); result.Add(0);
                real = new List<double>(); // size of counter
                imaginary = new List<double>();// size of counter
                for (int i = 0; i < Xn.Count; i++)
                {
                    real.Add(0);
                    imaginary.Add(0);
                }
                for (int n = 0; n < Xn.Count; n++)
                {
                    imaginaryNumber = new List<double>(); //2elements
                    element = new List<double>(); //2elements
                    double powerOfExp = (k * 2 * Math.PI * n) / Xn.Count;
                    imaginaryNumber.Add(Math.Cos(powerOfExp));
                    imaginaryNumber.Add(-Math.Sin(powerOfExp));
                    imaginaryNumber[0] = Math.Truncate(imaginaryNumber[0] * Math.Pow(10, 13)) / Math.Pow(10, 13);
                    imaginaryNumber[1] = Math.Truncate(imaginaryNumber[1] * Math.Pow(10, 13)) / Math.Pow(10, 13);
                    element.Add(Xn[n] * imaginaryNumber[0]); // real part
                    element.Add(Xn[n] * imaginaryNumber[1]); // imaginary part
                    real[n] = real[n] + element[0];
                    imaginary[n] = imaginary[n] + element[1];
                }
                for (int i = 0; i < Xn.Count; i++)
                {
                    result[0] = result[0] + real[i];
                    result[1] = result[1] + imaginary[i];
                    real[i] = 0;
                    imaginary[i] = 0;
                }
                Xk.Add(result);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Fs = double.Parse(txtFs.Text);
            DateTime timeBefore = DateTime.Now ;
            fourierTransform();
            DateTime timeAfter = DateTime.Now ;
            txtTimeFourier.Text = (timeAfter - timeBefore).ToString();
            FileStream fs = new FileStream("D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\Fourier\\Fourier Transform AmpTheta.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            FileStream fs1 = new FileStream("D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\Fourier\\Fourier Transform Result.txt", FileMode.Append);
            StreamWriter s = new StreamWriter(fs1);
            for (int k = 0; k < Xk.Count; k++)
            {
                double tmp = Math.Sqrt((Math.Pow(Xk[k][0], 2) + Math.Pow(Xk[k][1], 2)));
                amplitude.Add(tmp);
                double angel = Math.Atan2(Xk[k][1] , Xk[k][0]);
                if (Xk[k][0] == 0)
                    angel = 0;
                theta.Add(angel);
                string line = "[" + amplitude[k].ToString() + "," + theta[k].ToString() + "]";
                sw.WriteLine(line);
                string line2 = Xk[k][0].ToString() + "," + Xk[k][1].ToString();
                s.WriteLine(line2);
            }
            sw.Close();
            s.Close();
            MessageBox.Show("The Fourier Trasform Is Calculated Successfully :D", "Sucsses", MessageBoxButtons.OK);
        }

        private void btnAmplitudeGraph_Click(object sender, EventArgs e)
        {
            Draw(amplitude, "Segma VS Amplitude\n", "Amplitude\n", "Segma\n");
        }

        private void btnThetaGraph_Click(object sender, EventArgs e)
        {
            Draw(theta, "Theta VS Segma\n", "Theta\n", "Segma\n");
        }

    }
}
