using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Sim.Controles
{
    public partial class cTextBox : TextBox
    {

        public MascarasTextBox _MascaraTBox = new MascarasTextBox();
        eFormato vformato;

        public cTextBox()
        {
            Sim.Componentes.Classes.ColorTheme.GetTheme();
            InitializeComponent();
        }

        public void Limpar()
        {
            this.Text = string.Empty;
            this.Refresh();
        }

        public enum eFormato // enunciado Formato
        {
            Normal = 0,
            Numero = 1,
            Moeda = 2,
            RG = 3,
            CPF = 4,
            CNPJ = 5,
            Texto = 6,
            Data = 7,
            CEP = 8
        }

        public eFormato Formato // propriedade Formato
        {
            get { return vformato; }
            set
            {
                this.vformato = value;

                if ((vformato == eFormato.Moeda) || (vformato == eFormato.Data) || (vformato == eFormato.CNPJ) || (vformato == eFormato.CPF) || (vformato == eFormato.Numero))
                    this.TextAlign = HorizontalAlignment.Right;
                else
                    this.TextAlign = HorizontalAlignment.Left;

                Invalidate();
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            //this.SelectAll();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.LightYellow;
            this.SelectAll();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.White;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (vformato == eFormato.Moeda)
            {
                this.Text = _MascaraTBox._REAL(this.Text);
                this.SelectionStart = this.TextLength;
            }

            //this.Text = this.Text;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar != Convert.ToSingle(Keys.Back))
            {

                #region Só Numeros
                if (vformato == eFormato.Numero)
                {
                    if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                        e.Handled = true;
                }
                #endregion

                #region Mascara Moeda - 00.000.000,00
                else if (vformato == eFormato.Moeda)
                {

                    if (!(Char.IsNumber(e.KeyChar) && (this.TextLength < 18) || Char.IsControl(e.KeyChar)))
                        e.Handled = true;

                }
                #endregion

                #region Mascara RG
                else if (vformato == eFormato.RG)
                {

                    if (!(Char.IsLetterOrDigit(e.KeyChar) && (this.TextLength < 14) || Char.IsControl(e.KeyChar)))
                        e.Handled = true;

                }
                #endregion

                #region Mascara CPF - 000.000.000-00
                else if (vformato == eFormato.CPF)
                {

                    if (!(Char.IsNumber(e.KeyChar) && (this.TextLength < 14) || Char.IsControl(e.KeyChar)))
                        e.Handled = true;

                    else
                        this.AppendText(_MascaraTBox._CPF(this.Text));

                }
                #endregion

                #region Mascara CNPJ - 00.000.000/0000-00
                else if (vformato == eFormato.CNPJ)
                {

                    if (!(Char.IsNumber(e.KeyChar) && (this.TextLength < 18) || Char.IsControl(e.KeyChar)))
                        e.Handled = true;

                    else
                        this.AppendText(_MascaraTBox._CNJP(this.Text));

                }
                #endregion

                #region Mascara Data - 00/00/0000
                else if (vformato == eFormato.Data)
                {

                    if (!(Char.IsNumber(e.KeyChar) && (this.TextLength < 10) || Char.IsControl(e.KeyChar)))
                        e.Handled = true;

                    else
                        this.AppendText(_MascaraTBox._DATA(this.Text));

                }
                #endregion

                #region Só Letras
                else if (vformato == eFormato.Texto)
                {
                    if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)))
                        e.Handled = true;
                }
                #endregion

                #region Normal - todos os caracteres
                else if (vformato == eFormato.Normal)
                    e.Handled = false;
                //cTextBox.AppendText(cTextBox.Text);
                #endregion

            }
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.SetStyle(ControlStyles.UserPaint, true);
            
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            float[] dashValues = { 1, 1, 1, 1 };


            Rectangle areaFill = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
            LinearGradientBrush ngrad = new LinearGradientBrush(areaFill, Color.White, Color.White, LinearGradientMode.Vertical);

            Rectangle area0 = new Rectangle(new Point(0, 0), new Size((this.Width - 1), (this.Height - 1))); // coordenadas para desenhar a borda do controle
            Rectangle area1 = new Rectangle(new Point(1, 1), new Size((this.Width - 3), (this.Height - 3))); // area1, area2 e area3, definem a borda interna com efeito degradê
            Rectangle area2 = new Rectangle(new Point(2, 2), new Size((this.Width - 5), (this.Height - 5)));
            Rectangle area3 = new Rectangle(new Point(3, 3), new Size((this.Width - 7), (this.Height - 7)));

            if (this.Focused == false)
            {
                e.Graphics.FillRectangle(ngrad, areaFill);
            }
            if (this.Focused == true)
            {
                e.Graphics.FillRectangle(ngrad, areaFill); // desenhe fundo
                e.Graphics.DrawRectangle(Sim.Componentes.Classes.ColorTheme.PenDark, area1);
                //e.Graphics.DrawRectangle(Pens.WhiteSmoke, area2);
                //e.Graphics.DrawRectangle(Pens.White, area3);

                //e.ClipRectangle.Inflate(10, 10);
                /*Pen bluePen = new Pen(Color.CornflowerBlue, 1);
                bluePen.DashPattern = dashValues;
                e.Graphics.DrawRectangle(bluePen, area2);*/
            
            }
            
        
            this.BackColor = Sim.Componentes.Classes.ColorTheme.WindowColor;
        }

    }

    public class MascarasTextBox
    {

        ValidacoesTextBox Validar = new ValidacoesTextBox();

        public string _REAL(string vreal) // Mascara Reais
        {

            StringBuilder valor = new StringBuilder(vreal);

            if (vreal.Length > 2)
            {
                valor.Replace(",", "");
                valor.Replace(".", "");
                valor.Insert(valor.Length - 2, ",");
            }
            else if (vreal.Length < 3)
                valor.Replace(",", "");

            if (vreal.Length > 6)
            {
                valor.Replace(".", "");
                valor.Insert(valor.Length - 6, ".");
            }

            if (vreal.Length > 10)
                valor.Insert(valor.Length - 10, ".");

            if (vreal.Length > 14)
                valor.Insert(valor.Length - 14, ".");

            return valor.ToString();

        }

        public string _CPF(string vlcpf) // Mascara para CPF
        {
            string valor = "";

            if (vlcpf.Length == 3)
                valor = ".";
            if (vlcpf.Length == 7)
                valor = ".";
            if (vlcpf.Length == 11)
                valor = "-";

            return valor;
        }

        public string _CNJP(string vcnpj) // Mascara para CNPJ
        {

            string valor = "";

            if (vcnpj.Length == 2)
                valor = ".";
            if (vcnpj.Length == 6)
                valor = ".";
            if (vcnpj.Length == 10)
                valor = "/";
            if (vcnpj.Length == 15)
                valor = "-";

            return valor;
        }

        public string _DATA(string vdata) // Mascara para Data
        {
            string valor = "";

            if (vdata.Length == 2)
                valor = "/";
            if (vdata.Length == 5)
                valor = "/";

            return valor;
        }

    }

    public class ValidacoesTextBox
    {

        public bool CPFValido(string vlCPF) // Verifica se o CPF é válido ou inválido
        {
            string valor = vlCPF.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
            {
                if (numeros[10] != 11 - resultado)
                    return false;
            }
            return true;
        }

        public bool CNPJValido(string vlCNJP) // Verifica se o CNPJ é válido ou inválido
        {

            string CNPJ = vlCNJP.Replace(".", "");
            CNPJ = CNPJ.Replace("/", "");
            CNPJ = CNPJ.Replace("-", "");

            int[] digitos, soma, resultado;
            int nrDig;
            string ftmt;
            bool[] CNPJOk;

            ftmt = "6543298765432";
            digitos = new int[14];
            soma = new int[2];
            soma[0] = 0;
            soma[1] = 0;
            resultado = new int[2];
            resultado[0] = 0;
            resultado[1] = 0;
            CNPJOk = new bool[2];
            CNPJOk[0] = false;
            CNPJOk[1] = false;

            try
            {
                for (nrDig = 0; nrDig < 14; nrDig++)
                {
                    digitos[nrDig] = int.Parse(CNPJ.Substring(nrDig, 1));
                    if (nrDig <= 11)
                        soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));

                    if (nrDig <= 12)
                        soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
                }

                for (nrDig = 0; nrDig < 2; nrDig++)
                {
                    resultado[nrDig] = (soma[nrDig] % 11);

                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                        CNPJOk[nrDig] = (digitos[12 + nrDig] == 0);

                    else
                        CNPJOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
                }

                return (CNPJOk[0] && CNPJOk[1]);

            }
            catch
            {
                return false;
            }
        }

        public bool DATAValida(string vDATA)
        {
            return false;
        }

    }

}
