using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;

namespace intento1
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una carrera en el ComboBox
            if (comboBoxCarrera.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una carrera");
                return;
            }

            // Obtener el año seleccionado del DateTimePicker
            int año = dateTimePicker1.Value.Year;

            // Obtener el código de carrera según la selección del ComboBox
            string codigoCarrera = "";
            switch (comboBoxCarrera.SelectedItem.ToString())
            {
                case "Ingeniería en Sistemas":
                    codigoCarrera = "08";
                    break;
                case "Ingeniería en Electrónica":
                    codigoCarrera = "07";
                    break;
                case "Ingeniería en Telecomunicaciones":
                    codigoCarrera = "14";
                    break;
                // Agrega más casos según sea necesario para otras opciones de carrera
                default:
                    // Esto no debería ocurrir si las opciones del ComboBox están bien definidas
                    MessageBox.Show("Carrera seleccionada no válida");
                    return;
            }

            // Obtener el número de carné actual del TextBox
            string carneActual = TxtCarneactual.Text;

            // Obtener los últimos 3 dígitos del número de carné actual
            string ultimosDigitos = carneActual.Substring(carneActual.Length - 3);

            // Construir el nuevo número de carné
            string nuevoCarne = $"{año}{codigoCarrera}{ultimosDigitos}";

            // Mostrar el nuevo número de carné en el TextBox correspondiente
            TxtNuevoCarne.Text = nuevoCarne;

            // Generar y mostrar el código UPC basado en el nuevo carné
            MostrarCodigoUPC(nuevoCarne);

            // Generar y mostrar el código QR basado en el nuevo carné
            MostrarCodigoQR(nuevoCarne);
        }

        private void comboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bottonqr_Click(object sender, EventArgs e)
        {
            // Verificar si se ha ingresado un número de carné válido en el TextBox
            if (string.IsNullOrEmpty(TxtNuevoCarne.Text))
            {
                MessageBox.Show("Por favor genera un número de carné primero");
                return;
            }

            // Obtener el número de carné generado
            string numeroCarne = TxtNuevoCarne.Text;

            // Generar y mostrar el código UPC basado en el número de carné
            MostrarCodigoUPC(numeroCarne);
        }

        private void MostrarCodigoUPC(string numeroCarne)
        {
            // Asegurar que el número de carné tenga 12 dígitos agregando ceros al principio si es necesario
            string numeroCarneConCeros = numeroCarne.PadLeft(12, '0');

            // Crear un objeto de configuración para el código UPC
            var options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = pictureBoxqr.Width,
                Height = pictureBoxqr.Height,
                Margin = 0
            };

            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.UPC_A;
            writer.Options = options;

            // Generar el código UPC basado en el número de carné con ceros adicionales
            Bitmap codigoUPC = writer.Write(numeroCarneConCeros);

            // Mostrar el código UPC en el PictureBox
            pictureBoxqr.Image = codigoUPC;
        }


        private void MostrarCodigoQR(string numeroCarne)
        {
            // Crear un objeto de configuración para el código QR
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;

            // Generar el código QR basado en el número de carné
            Bitmap codigoQR = writer.Write(numeroCarne);

            // Mostrar el código QR en el PictureBox
            pictureBoxqr.Image = codigoQR;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
    
    
}

