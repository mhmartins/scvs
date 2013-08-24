using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaControleVendasSacoles
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //instância do formulário login
            Login frm = new Login();
            //Se o resultado do dialogo for ok
            //ou seja se o usuario e login constarem no bd
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //abro o formulário principal
                Application.Run(new Principal());
            }
            // else
            //{
            //Senão mostro a mensagem e fecho a aplicação
            //  MessageBox.Show("Usuário ou Login inválidos!");
            //Application.Run(new Login());
            //}
        }
    }

}
