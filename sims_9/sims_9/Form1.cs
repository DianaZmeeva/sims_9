using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int i = 1;
        bool flag =true;
        int o;
        int money = 50;
        double [][] p =
        {
            new double[] { 0.3, 0.4, 0.3 },
            new double[] { 0.4, 0.2, 0.4 },
            new double[] { 0.3, 0.4, 0.3 },
        };

        private void button_yellow_Click(object sender, EventArgs e)
        {
            if (flag && money>= (int)col_money.Value)
            {
                labelrate.Visible = false;
                flag = false;
                o = 1;
                i = gen(i);
                pr(i, o);
                color();
            }
            else
            {
                labelrate.Visible = true;
            }
        }

        private void button_green_Click(object sender, EventArgs e)
        {
            if (flag && money >= (int)col_money.Value)
            {
                labelrate.Visible = false;
                flag = false;
                o = 0;
                i = gen(i);
                pr(i, o);
                color();
            }
            else
            {
                labelrate.Visible = true;
            }
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            if (flag && money >= (int)col_money.Value)
            {
                labelrate.Visible = false;
                flag = false;
                o = 2;
                i = gen(i);
                pr(i, o);
                color();
            }
            else
            {
                labelrate.Visible = true;
            }
        }

        private void color()
        {
            if (i==0)
            {
                label_color.Text = "Green";
                label_color.ForeColor = Color.Green;
            }

            if (i == 1)
            {
                label_color.Text = "Yellow";
                label_color.ForeColor = Color.Yellow;
            }

            if (i == 2)
            {
                label_color.Text = "Red";
                label_color.ForeColor = Color.Red;
            }
        }

        private void pr(int i, int o)
        {
            if (i==o)
            {
                money += (int)col_money.Value;
            }
            else
                money -= (int)col_money.Value;
            label1.Text = "Money: " + money;
            flag = true;
            if (money <= 0)
            {
                label2.Visible = true;
                flag = false;
            }
               
        }

        private int  gen(int i)
        {
            double alpha = rnd.NextDouble();
            if (alpha <= p[i][0])
                i = 0;
            else if (alpha <= p[i][0] + p[i][1])
                i = 1;
            else
                i = 2;
            return i;
        }


    }
}
