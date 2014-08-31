using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indice_Academico
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            
        }

       public void iniciar_Click(object sender, EventArgs e)
       { 
        


        

            cargaDatos datos = new cargaDatos();

            datos.insertar(matricula.Text, contra.Text);

            datos.Show();

       }


        

    }

}
