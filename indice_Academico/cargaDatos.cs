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
    public partial class cargaDatos : Form
    {
        public cargaDatos()
        {
            InitializeComponent();






            Timer t = new Timer();
            t.Enabled = false;

            WebBrowser web = new WebBrowser();
            web.Navigate("http://acadmedia.edu.do/");
            web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(datos);




        }


        public void datos(object o, WebBrowserDocumentCompletedEventArgs e)
        {

            WebBrowser web = (WebBrowser)o;

        }
    }
}
