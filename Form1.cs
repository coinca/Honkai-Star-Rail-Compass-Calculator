using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 星穹铁道罗盘计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(textBox1.Text);
            int a0 = Convert.ToInt32(textBox2.Text);
            int b1 = Convert.ToInt32(textBox4.Text);
            int b0 = Convert.ToInt32(textBox3.Text);
            int c1 = Convert.ToInt32(textBox6.Text);
            int c0 = Convert.ToInt32(textBox5.Text);
            int r1 = 0, r2 = 0, r3 = 0; //每种组合圈的旋转次数，内中/内外/中外
            int stepCount = 9999;
            for (int n1 = 0; n1 < 99; n1++)
            {
                for (int n2 = 0; n2 < 99; n2++)
                {
                    for (int n3 = 0; n3 < 99; n3++)
                    {
                        if (Math.Abs(n1) + Math.Abs(n2) + Math.Abs(n3) > stepCount) { continue; }
                        if ((a0 + a1*n1+a1*n2) % 6 == 0 && (b0 + b1*n1+b1*n3) % 6 == 0 && (c0 + c1*n2+c1*n3) % 6 == 0)
                        {
                            r1 = n1;
                            r2 = n2;
                            r3 = n3;
                            stepCount = Math.Abs(n1) + Math.Abs(n2) + Math.Abs(n3);
                        }
                    }
                }
            }
            if (stepCount < 9999)
            {
                result.Text = "内中" + r1.ToString() + "次，中外" + r3.ToString() + "次，内外" + r2.ToString()+"次";
                MessageBox.Show(result.Text, "qq2715887819");
            }
            else
            {
                MessageBox.Show("没算出结果", "qq2715887819");
            }
        }
    }
}
