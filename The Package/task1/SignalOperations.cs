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
    public partial class SignalOperations : Form
    {
        //struct MyAxis
        //{
        //    public List<double> xAxis ;
        //    public List<double> yAxis ;
               
        //    public MyAxis(List<double> x , List<double> y)
        //    {
        //        xAxis = new List<double>();
        //        yAxis = new List<double>();
        //        xAxis = x;
        //        yAxis = y;
        //    }
        //    public MyAxis()
        //    {
        //        xAxis = new List<double>();
        //        yAxis = new List<double>();
        //    }
        //}

        //MyAxis axis = new MyAxis();
        List<KeyValuePair<double, double>> pair = new List<KeyValuePair<double, double>>();
        public static List<double> x1, x2 , result ;
        public static int kMulConstant , kShiftConstant ;
        bool folded = false;

        public SignalOperations()
        {
            InitializeComponent();
        }

        private void SignalOperations_Load(object sender, EventArgs e)
        {
            x1 = new List<double>();
            x2 = new List<double>();
            result = new List<double>();
        }

        private void Draw(List<KeyValuePair<double,double>> p)
        {
            GraphOfSignalsOperation gso = new GraphOfSignalsOperation(p);
            gso.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < x1.Count(); i++)
            {
                result[i] = x1[i] + x2[i];
                KeyValuePair<double, double> tmp = new KeyValuePair<double, double>(i, result[i]);
                pair[i] = tmp;
            }
            Draw(pair);
        }

        private List<KeyValuePair<double, double>> shift(List<KeyValuePair<double, double>> p , int constant)
        {
            List<KeyValuePair<double, double>> res = new List<KeyValuePair<double, double>>();
            int k = Math.Abs(constant);
            if (constant < 0)//shift right
            {
                int j = 0;
                for (int i = 0; i < (p.Count + k); i++)
                {
                    if (i < k)
                    {
                        KeyValuePair<double, double> tmp = new KeyValuePair<double, double>(i, 0);
                        res.Add(tmp);
                    }
                    else
                    {
                        KeyValuePair<double, double> tmp = new KeyValuePair<double, double>(i, p[j].Value);
                        res.Add(tmp);
                        j++;
                    }
                }
            }
            else // shift left
            {
                int j = 0;
                for (int i = ((int)p[0].Key - k); i < (p.Count + ((int)p[0].Key - k)); i++)
                {
                    KeyValuePair<double, double> tmp = new KeyValuePair<double, double>(i, p[j].Value);
                    res.Add(tmp);
                    j++;
                }
            }
            return res;
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < x1.Count(); i++)
            {
                result[i] = x1[i] * x2[i];
                KeyValuePair<double, double> tmp = new KeyValuePair<double, double>(i, result[i]);
                pair[i] = tmp;
            }
            Draw(pair);
        }

        private void multiConstantBtn_Click(object sender, EventArgs e)
        {
            kMulConstant = int.Parse(txtMulConstant.Text);
            for (int i = 0; i < x1.Count(); i++)
            {
                result[i] = kMulConstant * x1[i];
                KeyValuePair<double, double> tmp = new KeyValuePair<double, double>(i, result[i]);
                pair[i] = tmp;
            }
            Draw(pair);
        }

        private void foldBtn_Click(object sender, EventArgs e)
        {
            folded = true;
            for (int i = 0; i < pair.Count; i++)
            {
                KeyValuePair<double, double> tmp = new KeyValuePair<double, double>(-pair[i].Key, pair[i].Value);
                pair[i] = tmp;
            }
            Draw(pair);
        }

        private void shiftBtn_Click(object sender, EventArgs e)
        {
            kShiftConstant = int.Parse(txtConstantShift.Text);
            if (folded == true)
            {
                for (int i = 0; i < pair.Count; i++)
                {
                    KeyValuePair<double, double> tmp = new KeyValuePair<double, double>(-pair[i].Key, pair[i].Value);
                    pair[i] = tmp;
                }
            }
            pair = shift(pair , kShiftConstant);
            if (folded == true)
            {
                for (int i = 0; i < pair.Count; i++)
                {
                    KeyValuePair<double, double> tmp = new KeyValuePair<double, double>(-pair[i].Key, pair[i].Value);
                    pair[i] = tmp;
                }
            }
            Draw(pair);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FirstTask f = new FirstTask();
            string[] path = f.showDialog();
            f.readFile(path[0], x1);
            f.readFile(path[1], x2);
            for (int i = 0; i < x1.Count; i++)
                result.Add(0);
            for (int i = 0; i < x1.Count; i++)
            {
                KeyValuePair<double, double> tmp = new KeyValuePair<double, double>(i,x1[i]);
                pair.Add(tmp);
            }
        }
    }
}
