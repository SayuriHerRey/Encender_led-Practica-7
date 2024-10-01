using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encender_led_Practica_7
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort {get;}

        public Form1()
        {
            InitializeComponent();
            //Crear Serial Port
            ArduinoPort = new System.IO.Ports. SerialPort();
            ArduinoPort.PortName = "COM5";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            //Vincular eventos
            this.FormClosing += CerrandoForm1;
            this.Apagar.Click += Apagar_Click;
            this.Encender.Click += Encender_Click;

        }

        private void CerrandoForm1(object sender, FormClosingEventArgs e)
        {
            //Cerrar puerto
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }

        private void Encender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");

        }
        private void Apagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }
    
    }
}
