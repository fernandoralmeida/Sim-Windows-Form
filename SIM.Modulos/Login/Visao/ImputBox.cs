using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
//using Sim.Componentes.Controles;
//using Sim.Componentes.Formularios;
//using Sim.Controles;
//using Sim.Forms;

namespace Login.Visao
{
    class Dialog
    {
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            var form = new Sim.Gui.Forms.OwnedForm();
            var label = new Sim.Gui.Controls.Label();
            var textBox = new Sim.Gui.Controls.TextBox();
            var buttonOk = new Sim.Gui.Controls.Button();
            var buttonCancel = new Sim.Gui.Controls.Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;
            textBox.PsswChar = '*';
            label.Visible = false;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 25);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
