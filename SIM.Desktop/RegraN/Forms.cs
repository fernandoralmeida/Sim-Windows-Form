using System.Windows.Forms;

namespace Sim.Desktop.RegraN
{
    class Forms
    {
        public static void CloseForms()
        {
            foreach (Form owndForms in Form.ActiveForm.OwnedForms)
            {
                if (owndForms != null)
                {
                    if (owndForms.Name != "FmInfo")
                        owndForms.Close();
                }
            }
        }
    }
}
