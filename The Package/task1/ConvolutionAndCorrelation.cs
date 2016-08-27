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
    public partial class ConvolutionAndCorrelation : Form
    {
        public static List<double> signal1, signal2, convolutedSignal, correlatedSignal, resultOfFastCorrelation;
        public double[][] corrSignal1, corrSignal2 , corrResult ;
        public List<List<double>> s1, s2, cResult;
        bool periodic = false , convolution = false ;
        int counter = 4; 

        public ConvolutionAndCorrelation()
        {
            InitializeComponent();
        }

        private void ConvolutionAndCorrelation_Load(object sender, EventArgs e)
        {
            signal1 = new List<double>();
            signal2 = new List<double>();
            convolutedSignal = new List<double>();
            correlatedSignal = new List<double>();
            resultOfFastCorrelation = new List<double>();
            s1 = new List<List<double>>();
            s2 = new List<List<double>>();
            cResult = new List<List<double>>();
            corrSignal1 = new double[counter][];
            corrSignal2 = new double[counter][];
            corrResult = new double[counter][];
            for (int i = 0; i < counter; i++)
            {
                corrSignal1[i] = new double[2];
                corrSignal2[i] = new double[2];
                corrResult[i] = new double[2];
            }
        }

        private void Draw(List<double> x)
        {
            GraphOfConvolutionAndCorrelation g = new GraphOfConvolutionAndCorrelation(x);
            g.Show();
        }

        public void SaveInFile(string path, List<double> y)
        {
            FileStream fs = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < y.Count; i++)
                sw.WriteLine(y[i]);
            sw.Close();
            fs.Close();
        }

        public List<double> Convolution(List<double> x, List<double> h)
        {
            List<double> y = new List<double>();
            int counter ;
            if (x.Count > h.Count)
                counter = x.Count * 2;
            else
                counter = h.Count * 2;

            for (int i = x.Count; i < counter+1; i++)
                x.Add(0);
            for (int i = h.Count; i < counter+1; i++)
                h.Add(0);

            for (int n = 0; n < counter+1; n++)
            {
                double sum = 0;
                for (int k = 0; k <= n; k++)
                    sum += x[k] * h[n - k];
                y.Add(sum);
            }
            return y;
        }

        private int CheckSize()
        {
            if (signal1.Count != signal2.Count)
            {
                int numberOfPoints = signal1.Count + signal2.Count - 1;
                for (int i = signal1.Count; i < numberOfPoints; i++)
                    signal1.Add(0);
                for (int i = signal2.Count; i < numberOfPoints; i++)
                    signal2.Add(0);
                return numberOfPoints;
            }
            else
                return signal1.Count();
        }

        private List<double> Normalization(List<double> r, List<double> x1, List<double> x2 , int N)
        {
            List<double> row = new List<double>();
            double x1Squared = 0  , x2Squared = 0;
            for (int i = 0; i < N; i++)
                x1Squared += Math.Pow(x1[i],2);
            for (int i = 0; i < N; i++ )
                x2Squared += Math.Pow(x2[i], 2);
            double tmp = (1.0 / N) * Math.Pow((x1Squared * x2Squared), 0.5);
            for (int i = 0; i < N; i++)
                row.Add(r[i] / tmp);
            return row;
        }

        private List<double> DirectCrossCorrelation(List<double> x1, List<double> x2 , int N)
        {
            List<double> r = new List<double>();
            List<List<double>> xShifted = new List<List<double>>();
            if (periodic == true)
            {
                for (int j = 0; j < N; j++)
                {
                    List<double> tmp = new List<double>();
                    for (int i = j; i < x2.Count; i++)
                        tmp.Add(x2[i]);
                    for (int k = 0; k < j; k++)
                        tmp.Add(x2[k]);
                    xShifted.Add(tmp);
                }
            }
            else
            {
                for (int j = 0; j < N; j++)
                {
                    List<double> tmp = new List<double>();
                    for (int i = j; i < x2.Count; i++)
                    {
                        tmp.Add(x2[i]);
                        for (int k = 0; k < j; k++)
                            tmp.Add(0);
                    }
                    xShifted.Add(tmp);
                }
            }
            for (int j = 0; j < N; j++)
            {
                double sum = 0;
                for (int n = 0; n < N; n++)
                    sum += x1[n] * xShifted[j][n];
                r.Add((1.0 / N) * sum);
            }
            return r;
        }

        private List<List<double>> conjunction(List<List<double>> x)
        {
            List<List<double>> con = new List<List<double>>();
            for (int i = 0; i < x.Count; i++)
            {
                List<double> conjTmp = new List<double>();
                conjTmp.Add(x[i][0]);
                conjTmp.Add(-x[i][1]);
                con.Add(conjTmp);
            }
            return con;
        }

        private List<double> FastCrossCorrelation(List<double> X1, List<double> X2, int N)
        {
            FastFourier ff = new FastFourier();
            List<List<double>> x1 = new List<List<double>>();
            List<List<double>> x2 = new List<List<double>>();
            x1 = ff.fastFourier(X1, X1.Count);//iam in frequency domain now
            x2 = ff.fastFourier(X2, X2.Count);
            List<List<double>> result = new List<List<double>>();
            List<double> finalResult = new List<double>();
            List<List<double>> conj = new List<List<double>>();
            List<List<double>> mul = new List<List<double>>();
            if (convolution == true)
                conj = x1;
            else
                conj = conjunction(x1);
            for (int i = 0; i < N; i++) //multiplication
            {
                List<double> mulTmp = new List<double>();
                mulTmp.Add(conj[i][0] * x2[i][0]);
                mulTmp.Add((conj[i][1] * x2[i][0]) + (conj[i][1] * x2[i][1]) + (conj[i][0] * x2[i][1]));
                mul.Add(mulTmp);
                if (conj[i][1] != 0 && x2[i][1] != 0)
                    mul[i][0] += -(conj[i][1] * x2[i][1]);
            }
            Inverse_Fast_Fourier iff = new Inverse_Fast_Fourier();
            result = iff.InvFastFourier(mul, N);
            for (int i = 0; i < result.Count; i++)
            {
                result[i][0] = result[i][0] / N;
                result[i][1] = result[i][1] / N;
            }
            for (int i = 0; i < result.Count; i++) //if you convolution
                finalResult.Add(result[i][0]);
            if(convolution == false)
                for (int i = 0; i < N; i++)
                    finalResult[i] = finalResult[i] / N;
            return finalResult;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (cmboxOperations.SelectedIndex == 0 || cmboxOperations.SelectedIndex == 1 || cmboxOperations.SelectedIndex == 3 || cmboxOperations.SelectedIndex == 5)
            {
                MessageBox.Show("Please Choose 2 Files", "Alert", MessageBoxButtons.OK);
                FirstTask f = new FirstTask();
                string[] path = f.showDialog();
                f.readFile(path[0], signal1);
                f.readFile(path[1], signal2);
            }
            else
            {
                MessageBox.Show("Please Choose only 1 File", "Alert", MessageBoxButtons.OK);
                FirstTask f = new FirstTask();
                string[] path = f.showDialog();
                f.readFile(path[0], signal1);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (rbtnPer.Checked)
                periodic = true;
            if (cmboxOperations.SelectedIndex == 0) //Direct convolution
            {
                convolutedSignal = Convolution(signal1, signal2);
                string p = "D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\Convolution\\Direct\\My Result.txt" ;
                SaveInFile(p , convolutedSignal);
                MessageBox.Show("The File Of Convolution Is Added Sucessfully!!");
                Draw(convolutedSignal);
            }
            else if (cmboxOperations.SelectedIndex == 1) //Direct Cross Correlation
            {
                int N = CheckSize();
                correlatedSignal = DirectCrossCorrelation(signal1, signal2, N);
                if(normalRB.Checked)
                    correlatedSignal = Normalization(correlatedSignal, signal1, signal2, N);
                string p = "D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\Correlation\\Cross Correlation\\Direct\\My Result.txt";
                SaveInFile(p, correlatedSignal);
                MessageBox.Show("The File Of Direct Cross Correlation Is Added Sucessfully!!");
                Draw(correlatedSignal);
            }
            else if (cmboxOperations.SelectedIndex == 2) //Direct Auto Correlation
            {
                correlatedSignal = DirectCrossCorrelation(signal1, signal1, signal1.Count);
                if (normalRB.Checked)
                    correlatedSignal = Normalization(correlatedSignal, signal1, signal1, signal1.Count);
                string p = "D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\Correlation\\Auto Correlation\\Direct\\My Result.txt";
                SaveInFile(p, correlatedSignal);
                MessageBox.Show("The File Of Direct Auto Correlation Is Added Sucessfully!!");
                Draw(correlatedSignal);
            }
            else if (cmboxOperations.SelectedIndex == 3) //fast cross correlation
            {
                int N = CheckSize();
                resultOfFastCorrelation = FastCrossCorrelation(signal1, signal2, N);
                if (normalRB.Checked)
                    resultOfFastCorrelation = Normalization(resultOfFastCorrelation, signal1, signal2, N);
                string p = "D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\Correlation\\Cross Correlation\\Fast\\My Result.txt";
                SaveInFile(p, resultOfFastCorrelation);
                MessageBox.Show("The File Of Fast Cross Correlation Is Added Sucessfully!!");
                Draw(resultOfFastCorrelation);
            }
            else if (cmboxOperations.SelectedIndex == 4) // fast Auto correlation
            {
                resultOfFastCorrelation = FastCrossCorrelation(signal1, signal1, signal1.Count);
                if (normalRB.Checked)
                    resultOfFastCorrelation = Normalization(resultOfFastCorrelation, signal1, signal1, signal1.Count);
                string p = "D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\Correlation\\Auto Correlation\\Fast\\My Result.txt";
                SaveInFile(p, resultOfFastCorrelation);
                MessageBox.Show("The File Of Fast Auto Correlation Is Added Sucessfully!!");
                Draw(resultOfFastCorrelation);
            }
            else if (cmboxOperations.SelectedIndex == 5) // fast convolution
            {
                convolution = true;
                int N = CheckSize();
                convolutedSignal = FastCrossCorrelation(signal1, signal2, N);
                string p = "D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\Convolution\\Fast\\My Result.txt";
                SaveInFile(p, convolutedSignal);
                MessageBox.Show("The File Of Fast Convolution Is Added Sucessfully!!");
                Draw(convolutedSignal);
            }
        } 
    }
}
