using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public bool isClickMouse = false;
        private Point currentPosition = new Point(0, 0);



        
        #region SettingsForm

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isClickMouse) { return; }
            Point buf = new Point(this.Location.X, this.Location.Y);

            buf.X += e.X - currentPosition.X;
            buf.Y += e.Y - currentPosition.Y;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isClickMouse = true;
            currentPosition = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isClickMouse = false;
        }
        #endregion

        

        private bool isPoint = false;
        private bool isNum2 = false;

        private string Num1 = null;
        private string Num2 = null;

        private string currentOperation = "";

        private void AddNum(string txt)
        {
            if (isNum2)
            {
                Num2 += txt;
                textResult.Text = Num2;
            }
            else
            {
                Num1 += txt;
                textResult.Text = Num1;
            }

        }
        private void SetNum(string txt)
        {
            if (isNum2)
            {
                Num2 += txt;
                textResult.Text = Num2;
            }
            else
            {
                Num1 += txt;
                textResult.Text = Num1;
            }

        }

        private void buttonNumberClick(object obj, EventArgs e)
        {
            var txt = ((Button)obj).Text;
            {
                if (isPoint && txt == ",") { return; }
                if (txt == ",") { isPoint = true; }
            }

            if (txt == "+/-")
            {
                if (textResult.Text.Length > 0)
                    if (textResult.Text[0] == '-')
                    {
                        textResult.Text = textResult.Text.Substring(1, textResult.Text.Length - 1);
                    }
                    else
                    {
                        textResult.Text = "-" + textResult.Text;
                    }
                SetNum(textResult.Text);
                return;
            }
            AddNum(txt);
        }

        private void buttonOperationClick(object obj, EventArgs e)
        {
            if (Num1 == null) { if (textResult.Text.Length > 0) Num1 = textResult.Text; else return; }

            isNum2 = true;
            currentOperation = ((Button)obj).Text;
            SetResult(currentOperation); 
        }
    
        private void SetResult(string operation)
        {
            string result = null;

            
            
            switch (operation)
            {
                case "+": { result = MathOperations.Add(Num1, Num2); break; }
                case "-": { result = MathOperations.Sub(Num1, Num2); break; }
                case "×": { result = MathOperations.Mul(Num1, Num2); break; }
                case "÷": { result = MathOperations.Dev(Num1, Num2); break; }
                case "%": { result = MathOperations.Proc(Num1, Num2); break; }
                case "√": { result = MathOperations.Sqr(Num1); isNum2 = false; break; }
                case "1/x": { result = MathOperations.OneDev(Num1); isNum2 = false; break; }
                case "x²": { result = MathOperations.Pow(Num1); isNum2 = false; break; }
                default: break;
            }
            OutputResult(result, operation);      
            if (isNum2) { if (result != null) Num1 = result;} else { Num1 = null; }
            isPoint = false;
        }

        private void OutputResult(string result, string operation)
        {
            switch (operation)
            {
                case "√": { if (Num1 != null) textHistory.Text = "√" + Num1 + " = "; break; }
                case "x²": { if (Num1 != null) textHistory.Text = Num1 + "² = "; break; }
                case "1/x": { if (Num1 != null) textHistory.Text = "1/" + Num1 + " = "; break; }
                default:
                    {
                        if(Num2 != null)
                        {
                            textHistory.Text = Num1 + " " + operation + " " + Num2 + " = ";

                        } else
                        {
                            if(Num1 != null)
                            {
                                textHistory.Text = Num1 + " " + operation + " ";
                                break;
                            }
                        }
                    }
                    break;


            }

            Num2 = null;
            if (result != null)
            {
                textResult.Text = result;
            }
        
        
        }
         
        private void buttonClear(object obj, EventArgs e)
        {
            textResult.Text = "";
            textHistory.Text = "";
            isNum2 = false;
            currentOperation = null;
            Num1 = null;
            Num2 = null;
            isPoint = false;

        }

        private void buttonResultClick(object obj, EventArgs e)
        {
            SetResult(currentOperation);
            isNum2 = false;
            Num1 = null;
            Num2 = null;
            isPoint = false;
        }
    
        private void buttonResetNumber(object obj, EventArgs e)
        {
            if (textResult.Text.Length <= 0) { return; }
            textResult.Text = textResult.Text.Substring(0, textResult.Text.Length - 1);
            SetNum(textResult.Text);
        }

        private void textResult_Click(object sender, EventArgs e)
        {

        }
    }
}
