using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form1 : Form
    {
        System.Timers.Timer zegar;

        public Form1()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.Beep(1500, 50);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Alarm wyłączony";
            zegar = new System.Timers.Timer();
            zegar.Interval = 1000;
            zegar.Elapsed += CzasJakiMinal;
        }

        delegate void ZmienInformacje(Label label1, string wartosc);

        void ZmienInformacjeLabel(Label label1, string wartosc)
        {
            label1.Text = wartosc;
        }

        private void CzasJakiMinal(object sender, ElapsedEventArgs e)
        {
            DateTime biezacyCzas = DateTime.Now;
            DateTime wybranyCzas = Zegarek.Value;
            if (biezacyCzas.Hour == wybranyCzas.Hour && biezacyCzas.Minute == wybranyCzas.Minute &&
                biezacyCzas.Second == wybranyCzas.Second)
            {
                zegar.Stop();
                try
                {
                    ZmienInformacje zmien = ZmienInformacjeLabel;
                    if (label1.InvokeRequired)
                    {
                        Invoke(zmien, label1, "Alarm wyłączony");
                    }

                    Form2 f2 = new Form2();
                    



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd:", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zegar.Start();
            label1.Text = "Alarm włączony";
            Console.Beep(1200, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zegar.Stop();
            label1.Text = "Alarm wyłączony";
            Console.Beep(1200, 50);
            

        }
    }
}
