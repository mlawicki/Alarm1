using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Alarmuj();
        }

        public void Alarmuj()
            {
                for (;;)
                {
                    Random rnd = new Random();
                    int przypadkowy = rnd.Next(500, 2500);
                    Console.Beep(przypadkowy, 100);
                    Console.Beep(1500, 100);
                    Console.Beep(2000, 100);
                    Console.Beep((przypadkowy + 300), 200);
                    Console.Beep(1000, 800);
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }


