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
    public partial class FIR : Form
    {
        int filterType , m , l;
        double samplingFreq, cutOffFreq1, cutOffFreq2, stopbandAtten, transitionWidth;
        List<double> signal, result, downSamplingResult , upSamplingResult , finalResult;

        public FIR()
        {
            InitializeComponent();
            signal = new List<double>();
            result = new List<double>();
            downSamplingResult = new List<double>();
            upSamplingResult = new List<double>();
            finalResult = new List<double>();
        }

        private List<double> calculateFilterFunction(int filter_type , double cutF1 , double cutF2 , double fs, double tw, int N)
        {
            List<double> Hd = new List<double>();
            cutF1 = cutF1 / fs; // to normalize cutF1
            if (filter_type == 0)
            {
                cutF1 = (cutF1 + (0.5 * tw)); // fc dash
                Hd.Add(2 * cutF1);
                for (int i = 1; i <= N ; i++)
                {
                    double tmp = ((2 * cutF1) / (2 * i * Math.PI * cutF1)) * Math.Sin(2 * i * Math.PI * cutF1);
                    Hd.Add(tmp);
                }
            }
            else if (filter_type == 1)
            {
                cutF1 = (cutF1 - (0.5 * tw));
                Hd.Add(1 - (2 * cutF1));
                for (int i = 1; i <= N ; i++)
                {
                    double tmp = ((-2 * cutF1) / (2 * i * Math.PI * cutF1)) * Math.Sin(2 * i * Math.PI * cutF1);
                    Hd.Add(tmp);
                }
            }
            else if (filter_type == 2)
            {
                cutF2 = cutF2 / fs;
                cutF1 = (cutF1 - (0.5 * tw));
                cutF2 = (cutF2 + (0.5 * tw));
                Hd.Add(2 * (cutF2 - cutF1));
                for (int i = 1; i <= N ; i++)
                {
                    double tmp = (((2 * cutF2) / (2 * i * Math.PI * cutF2)) * Math.Sin(2 * i * Math.PI * cutF2)) - (((2 * cutF1) / (2 * i * Math.PI * cutF1)) * Math.Sin(2 * i * Math.PI * cutF1));
                    Hd.Add(tmp);
                }
            }
            else if (filter_type == 3)
            {
                cutF2 = cutF2 / fs;
                cutF1 = (cutF1 + (0.5 * tw));
                cutF2 = (cutF2 - (0.5 * tw));
                Hd.Add(1 - (2 * (cutF2 - cutF1)));
                for (int i = 1; i <= N ; i++)
                {
                    double tmp = (((2 * cutF1) / (2 * i * Math.PI * cutF1)) * Math.Sin(2 * i * Math.PI * cutF1)) - (((2 * cutF2) / (2 * i * Math.PI * cutF2)) * Math.Sin(2 * i * Math.PI * cutF2));
                    Hd.Add(tmp);
                }
            }
            return Hd;
        }

        private List<double> calculatWindowFunction(double st_Attenuation , double TW , ref int N , ref int fullSize)
        {
            List<double> Wn = new List<double>();
            if (st_Attenuation <= 32)
            {
                fullSize = (int)Math.Round(0.9 / TW);
                if (fullSize % 2 == 1) // odd
                    N = (fullSize - 1) / 2;
                else // even
                    N = fullSize / 2;
                for (int i = 0; i <= N ; i++)
                    Wn.Add(1);
            }
            else if (st_Attenuation > 32 && st_Attenuation <= 48)
            {
                fullSize = (int)Math.Round(3.1 / TW);
                if (fullSize % 2 == 1)
                    N = (fullSize - 1) / 2;
                else
                    N = fullSize / 2;
                for (int i = 0; i <= N ; i++)
                {
                    double tmp = 0.5 + (0.5 * (Math.Cos((2 * Math.PI * i) / fullSize)));
                    Wn.Add(tmp);
                }
            }
            else if (st_Attenuation > 48 && st_Attenuation <= 63)
            {
                fullSize = (int)Math.Round(3.3 / TW);
                if (fullSize % 2 == 1)
                    N = (fullSize - 1) / 2;
                else
                    N = fullSize / 2;
                for (int i = 0; i <= N ; i++)
                {
                    double tmp = 0.54 + (0.46 * (Math.Cos((2 * Math.PI * i) / fullSize)));
                    Wn.Add(tmp);
                }
            }
            else if (st_Attenuation > 63)
            {
                fullSize = (int)Math.Round(5.5 / TW);
                if (fullSize % 2 == 1)
                    N = (fullSize - 1) / 2;
                else
                    N = fullSize / 2;
                for (int i = 0; i <= N ; i++)
                {
                    double tmp = 0.42 + (0.5 * (Math.Cos((2 * Math.PI * i) / (fullSize - 1)))) + (0.08 * (Math.Cos((4 * Math.PI * i) / (fullSize - 1))));
                    Wn.Add(tmp);
                }
            }
            return Wn;
        }

        private List<double> fIRFilter(List<double> Xn , int filter_type , double fc1 , double fc2 , double t_width , double stop_attenuation , double fs)
        {
            List<double> res = new List<double>();
            List<double> Hd = new List<double>();
            List<double> Wn = new List<double>();
            List<double> Hn = new List<double>();
            int N = 0 , fullSize = 0;
            Wn = calculatWindowFunction(stop_attenuation, t_width, ref N , ref fullSize);
            Hd = calculateFilterFunction(filter_type, fc1, fc2, fs, t_width, N);
            for (int i = 0; i <= N; i++)
                Hn.Add(Hd[i] * Wn[i]);

            //int j = N - 1;
            //for (int i = N + 1; i < fullSize; i++)
            //{
            //    Hn.Add(Hn[j]);
            //    j--;
            //}
            ConvolutionAndCorrelation obj = new ConvolutionAndCorrelation();
            string p = "D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\FIR\\CoffOfFIR.txt";
            obj.SaveInFile(p, Hn);
            

            ConvolutionAndCorrelation c = new ConvolutionAndCorrelation();
            res = c.Convolution(Xn, Hn);

            p = "D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\FIR\\AfterConvolution.txt";
            obj.SaveInFile(p, Hn);
            return res;
        }

        private List<double> downSampling(List<double> list, int factor)
        {
            List<double> sampled = new List<double>();
            for (int i = 0; i < list.Count; i += factor)
                sampled.Add(list[i]);
            return sampled;
        }

        private List<double> upSampling(List<double> list, int factor)
        {
            List<double> sampled = new List<double>();
            for (int i = 0; i < list.Count; i++)
            {
                sampled.Add(list[i]);
                for (int j = 0; j < (factor - 1); j++)
                    sampled.Add(0);
            }
            ConvolutionAndCorrelation obj = new ConvolutionAndCorrelation();
            string p = "D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\FIR\\UpsampledData.txt";
            obj.SaveInFile(p, sampled);

            return sampled;

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            filterType = comboBox1.SelectedIndex ;
            cutOffFreq1 = double.Parse(txtboxFC1.Text);
            if (filterType == 2 || filterType == 3)
                cutOffFreq2 = double.Parse(txtBoxFC2.Text);
            transitionWidth = double.Parse(txtBoxTransitionWidth.Text);
            stopbandAtten = double.Parse(txtBoxStopbandAttenuation.Text);
            samplingFreq = double.Parse(txtBoxSamplingFrequency.Text);
            transitionWidth = transitionWidth / samplingFreq; //DeltaF

            if (rbuttonDownSampling.Checked)
            {
                m = int.Parse(txtBoxDownSampling.Text);
                result = fIRFilter(signal, filterType, cutOffFreq1, cutOffFreq2, transitionWidth, stopbandAtten, samplingFreq);
                downSamplingResult = downSampling(result, m);
                finalResult = downSamplingResult;
            }
            else if (rbuttonUpSampling.Checked)
            {
                l = int.Parse(txtBoxUpSampling.Text);
                upSamplingResult = upSampling(signal, l);

                result = fIRFilter(upSamplingResult,filterType, cutOffFreq1, cutOffFreq2, transitionWidth, stopbandAtten, samplingFreq);
                finalResult = result;
            }
            else if (rbuttonUpDownSampling.Checked)
            {
                m = int.Parse(txt2DownSampling.Text);
                l = int.Parse(txt1UpSampling.Text);
                upSamplingResult = upSampling(signal, l);
                result = fIRFilter(upSamplingResult, filterType, cutOffFreq1, cutOffFreq2, transitionWidth, stopbandAtten, samplingFreq);
                downSamplingResult = downSampling(result, m);
                finalResult = downSamplingResult;
            }
            else
            {
                result = fIRFilter(signal, filterType, cutOffFreq1, cutOffFreq2, transitionWidth, stopbandAtten, samplingFreq);
                finalResult = result;
            }

            ConvolutionAndCorrelation obj = new ConvolutionAndCorrelation();
            string p = "D:\\My Collage's Stages\\Fourth Year\\Second Semester\\Signal Processing\\Labs\\The Package\\Results\\FIR\\resultOfFIR.txt";
            obj.SaveInFile(p, finalResult);
            MessageBox.Show("the filter have done and the file is saved successfully :D","Done",MessageBoxButtons.OK);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FirstTask f = new FirstTask();
            string[] path = f.showDialog();
            f.readFile(path[0], signal);
        }
    }
}
