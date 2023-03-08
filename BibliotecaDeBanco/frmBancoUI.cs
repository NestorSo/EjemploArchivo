using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaDeBanco
{
    public partial class frmBancoUI : Form
    {
        protected int cuentaTexbox = 4;// Nùmero de texbox en el formulario 
        //las constantes de la enumeraciòn especifican los indicios de los controles de TexBox

        public enum IndicesTexBox
        {
            CUENTA,
            NOMBRE,
            APELLIDO,
            SALDO

        }

        public frmBancoUI()
        {
            InitializeComponent();
        }

        //Limpia los TexBox
        public void LimpiarControlesTexBox()
        {

            //Itera a travès de cada control en el formulario 
            for(int i =0; i<Controls.Count; i++)
            {
                Control miControl = Controls[i];//Obtiene el control 
                if (miControl is TextBox)
                {

                    //Determina si el control es TexBox 
                    miControl.Text = ""; 
                }
            }
        }

        //Establece los valores de los controles de TexBox con el arreglo string valores 
        public void EstablecerValorescontrolesTexBox(string[] valores)
        {
            //Determina si el arreglo string tiene la longitud correcta 
            if (valores.Length != cuentaTexbox)
            {
                //Lanza Excepcion si no tiene longitud correcta 
                throw (new ArgumentException("Debe haber" + (cuentaTexbox + 1) + " Objetos string en el arreglo"));
            }
            //Establece valores si el arreglo tiene longitud correcta 
            else
            {
                txtCuenta.Text = valores[(int)IndicesTexBox.CUENTA];
                txtNombre.Text = valores[(int)IndicesTexBox.NOMBRE];
                txtApellido.Text = valores[(int)IndicesTexBox.APELLIDO];
                txtSaldo.Text = valores[(int)IndicesTexBox.SALDO];
                

            }

        }

        public string[] OBtenerValoresControlesTexBox()
        {
            string[] valores = new string[cuentaTexbox];

            //copia los campos de los controles texbox como un arreglo string 
            valores[(int)IndicesTexBox.CUENTA] = txtCuenta.Text;
            valores[(int)IndicesTexBox.NOMBRE] = txtNombre.Text;
            valores[(int)IndicesTexBox.APELLIDO] = txtApellido.Text;
            valores[(int)IndicesTexBox.SALDO] = txtSaldo.Text;
            return valores;
        }


    }
}
