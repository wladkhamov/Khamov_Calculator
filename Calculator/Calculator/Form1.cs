using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            double sumkre = Convert.ToDouble(sumkr.Text);
            double prstavk = Convert.ToDouble(prstavka.Text);
            double cpokvgo = Convert.ToDouble(srokvgo.Text);
            double cpokvme = (cpokvgo * 12);
            srokvme.Text = "" + Math.Round(cpokvme, 2);
            double viplatavmec = -1*sumkre*prstavk/100 / 12 * Math.Pow(1 + prstavk/100 / 12, cpokvme) / (Math.Pow(1 + prstavk/100 / 12, cpokvme) - 1);
            viplatavme.Text = "" + Math.Round(viplatavmec, 2);
            double sumaviplat = viplatavmec * cpokvme;
            Summaviplat.Text = "" + Math.Round(sumaviplat, 2);
            double summapereplati = sumaviplat - sumkre;
            Summaperepla.Text = "" + Math.Round(summapereplati, 2);

            double body = sumkre;

            for(int period = 1; period <= cpokvme; period++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[period-1].Cells[0].Value = period;
                double vk = viplatavmec * Math.Pow(1 + prstavk/100/12, period - cpokvme - 1);
                dataGridView1.Rows[period-1].Cells[1].Value = Math.Round(vk,2);
                double vp = viplatavmec * (1 - Math.Pow(1 + prstavk / 100/12, period - cpokvme - 1));
                dataGridView1.Rows[period-1].Cells[2].Value = Math.Round(vp, 2);
                dataGridView1.Rows[period-1].Cells[3].Value = Math.Round(vk + vp,2);
                body += vk;
                dataGridView1.Rows[period-1].Cells[4].Value = Math.Round(body,2);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
