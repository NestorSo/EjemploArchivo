using BibliotecaDeBanco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrearArchivo
{
    public partial class frmCrearArchivos : frmBancoUI
    {
        private StreamWriter archivoWriter; //Escribe datos en el archivo de texto
        private FileStream salida; // Mantiene la conexion con el archivo

        public frmCrearArchivos()
        {
            InitializeComponent();
        }
        //manejo de eventos para el boton guardar 
        private void btnGuardar_Click(object sender, EventArgs e)
        {

           //crea un cuadro de dialogo que permite guardar el archivo 
           SaveFileDialog selectorArchivo = new SaveFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();
            string nombreDeArchivo; //Nombre del archivo en el que se van a guardar los datos 

            selectorArchivo.CheckFileExists = false; //Permite al usuario crear el archivo 

            //sale dl manejador de eventos 
            if(resultado == DialogResult.Cancel)
            {
                return; 


            }
            nombreDeArchivo = selectorArchivo.FileName; // Obtiene el nombre del archivo especificado 

            //
        }
    }
}
