using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    public class clsCliente_Ventas : clsCliente 
    {

        private string m_sRuc;

        public string SRuc
        {
            get { return m_sRuc; }
            set { m_sRuc = value; }
        }
        private string m_sAdress;

        public string SAdress
        {
            get { return m_sAdress; }
            set { m_sAdress = value; }
        }
        private bool m_bCredit;

        public bool BCredit
        {
            get { return m_bCredit; }
            set { m_bCredit = value; }
        }

        

    }
}
