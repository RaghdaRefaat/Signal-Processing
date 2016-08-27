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
    public partial class Start_Form : Form
    {
        public Start_Form()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            FirstTask f = new FirstTask();
            f.Show();
            
        }

        private void btnQuantization_Click(object sender, EventArgs e)
        {
            Quantization q = new Quantization();
            q.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fourier f = new Fourier();
            f.Show();
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            InverseFourier i = new InverseFourier();
            i.Show();
        }

        private void btnFastFourier_Click(object sender, EventArgs e)
        {
            FastFourier ff = new FastFourier();
            ff.Show();
        }

        private void btnSignalsOperations_Click(object sender, EventArgs e)
        {
            SignalOperations s = new SignalOperations();
            s.Show();
        }

        private void btnCovolution_Click(object sender, EventArgs e)
        {
            ConvolutionAndCorrelation c = new ConvolutionAndCorrelation();
            c.Show();
        }

        private void btnIFFT_Click(object sender, EventArgs e)
        {
            Inverse_Fast_Fourier i = new Inverse_Fast_Fourier();
            i.Show();
        }

        private void btnFIR_Click(object sender, EventArgs e)
        {
            FIR fir = new FIR();
            fir.Show();
        }

    }
}
