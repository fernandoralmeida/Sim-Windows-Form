using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Permissions;

namespace Sim.Componentes.Classes
{
    [HostProtectionAttribute(SecurityAction.LinkDemand, SharedState = true)]
    public class MaskedTextProvider : ICloneable
    {

        public void CellNumber()
        {
            /*
            MaskedTextProvider provider = new MaskedTextProvider("(999)-999-9999").;

            string text = textBox1.Text;

            bool result = provider.VerifyString(text);
             * */
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

    }
}
