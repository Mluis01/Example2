using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    public class clsCliente
    {

        private int m_iIdClient = 0;

        public int IIdClient
        {
            get { return m_iIdClient; }
            set { m_iIdClient = value; }
        }
        private string m_sName;

        public string SName
        {
            get { return m_sName; }
            set { m_sName = value; }
        }
        private string m_sLastName;

        public string SLastName
        {
            get { return m_sLastName; }
            set { m_sLastName = value; }
        }

       

    }
}
