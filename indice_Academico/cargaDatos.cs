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

        private string matricula;
        private string contra;


        public cargaDatos()
        {
            InitializeComponent();

            WebBrowser web = webBrowser1;
            web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(datos);


        }


        public void datos(object o, WebBrowserDocumentCompletedEventArgs e)
        {

            WebBrowser web = (WebBrowser)o;
            web = webBrowser1;
            web.Navigate("http://acadmedia.itsc.edu.do/");
            HtmlDocument html = web.Document;
            HtmlElement matricula = html.GetElementById("LoginBox_UserName");
            HtmlElement contra = html.GetElementById("LoginBox_Password");
            matricula.SetAttribute("value", this.matricula);
            contra.SetAttribute("value", this.contra);
            html.GetElementById("LoginBox_LoginButton").InvokeMember("click");


            Timer t = new Timer();
            t.Enabled = false;

        }


        public void insertar(string matricula, string contra)
        {
            this.matricula = matricula;
            this.contra = contra;
        }



    }
}
