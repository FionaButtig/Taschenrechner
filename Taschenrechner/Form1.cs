using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        // Basics - Variablen
        double num1 = 0;
        double num2 = 0;
        string ergebnis = "0";
        //operator kann nicht als eigenname genommen werden also op
        string op = "";
        bool negativVorzeichenAktiv = false;

        public Form1()
        {
            InitializeComponent();
        }


        // Idee: User macht eingabe der ersten Zahl, dann Operator, dann zweite Zahl, dann =
        // also Trennstellen
        // man kann alles vor der Operator-Angabe als Zahl 1 nehmen
        // und alles zwischen dem Operator und dem = als Zahl 2 
        // Die Textbox1 ist für diese Funktion zuständig, während die Textbox2, welche sich
        // oberhalb der Textbox1 befindet, eine visuelle Hilfe für den Benutzer ist
        // (zeigt den Rechenweg)

        // mein Erster Ansatz war den gesamten String einer Eingabe für diese Trennstellen
        // zu durchsuchen, aber diese Form funktioniert schneller/einfacher
        private void zahlenEingabe(object sender, EventArgs e)
        {

            Button eingabe = (Button)sender;
            // pro Zahl nur 1 Decimalstelle 
            if (textBox1.Text == "0")
                textBox1.Text = "";
            {
                // wenn versucht wird eine Decimalstelle einzugeben
                if (eingabe.Text == ",")
                {
                    // nur durchführen wenn noch keine andere Decimalstelle in der Zahl
                    if (!textBox1.Text.Contains(","))

                        textBox1.Text = textBox1.Text + eingabe.Text;
                    // hier nicht für TextBox2 das selbe wie für Textbox1
                    // eingeben sonst schreibt es die Zahlen doppelt


                    // hier hatte ich das Problem, dass man mehrere Decimalzeichen in Textbox 2 setzen konnte,
                    // daher die getrennten if anweisungen
                    if (!textBox2.Text.Contains(","))
                        textBox2.Text += ",";
                }
                else
                {
                    textBox1.Text = textBox1.Text + eingabe.Text;
                    textBox2.Text += eingabe.Text;
                }
            }
        }





        // Großes Switch Statement - Hauptfunktion - eigentliches Berechnen
        // bekommt einfach von den einzelnen Operatoren Funktionen die Info, welche
        // Mathe-Operation vorgenommen werden soll

        private void ergebnisB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                num2 = Convert.ToDouble(textBox1.Text);

                switch (op)
                {
                    case "+":
                        {
                            ergebnis = (num1 + num2).ToString();
                            textBox1.Text = (num1 + num2).ToString();
                            textBox2.Clear();
                            break;
                        }
                    case "-":
                        ergebnis = (num1 - num2).ToString();
                        textBox1.Text = (num1 - num2).ToString();
                        textBox2.Clear();
                        break;

                    case "/":
                        ergebnis = (num1 / num2).ToString();
                        textBox1.Text = (num1 / num2).ToString();
                        textBox2.Clear();
                        break;

                    case "*":
                        ergebnis = (num1 * num2).ToString();
                        textBox1.Text = (num1 * num2).ToString();
                        textBox2.Clear();
                        break;
                    default:
                        break;
                }

                num1 = 0;
                num2 = 0;
            }
        }





        // Funktionen zur identifizierung der Mathe-Operationen für das Switch Statement
        // + mehrer Fail-Safes für die Operatoren Funktionen

        private void addB_Click(object sender, EventArgs e)
        {
            // wichtig!
            // Ohne diese nächste Zeile stürzt das Programm ab, wenn man versucht einen 
            // operator einzugeben, bevor man eine Zahl eingegeben hat
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!textBox2.Text.Contains("+") && !textBox2.Text.Contains("*") && !textBox2.Text.Contains("/"))
                {

                    num1 = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox2.Text += "+";
                    op = "+";


                }
            }
        }

        // sehr ähnliches Verfahren für die anderen Operatoren:

        private void minusB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!textBox2.Text.Contains("+") && !textBox2.Text.Contains("*") && !textBox2.Text.Contains("/"))
                {
                    num1 = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox2.Text += "-";
                    op = "-";
                }
            }
        }

        private void multiB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!textBox2.Text.Contains("+") && !textBox2.Text.Contains("*") && !textBox2.Text.Contains("/"))
                {
                    num1 = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox2.Text += "*";
                    op = "*";
                }
            }
        }

        private void divB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!textBox2.Text.Contains("+") && !textBox2.Text.Contains("*") && !textBox2.Text.Contains("/"))
                {
                    num1 = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox2.Text += "/";
                    op = "/";
                }
            }
        }


        // Funktionen zu Clear und Vorzeichen-setzung
        private void CB_Click(object sender, EventArgs e)
        {
            // Alle Eingaben entfernen / zurücksetzen
            textBox1.Clear();
            textBox2.Clear();
        }

        private void vorzeichenB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {

                double vor = Convert.ToDouble(textBox1.Text);

                // -1 damit es das Zeichen an den Anfang der Zahl setzt
                textBox1.Text = Convert.ToString(-1 * vor);
                textBox2.Text = Convert.ToString(-1 * vor);
                if (negativVorzeichenAktiv == false)
                {
                    negativVorzeichenAktiv = true;
                }
                else
                {
                    negativVorzeichenAktiv = false;
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    //Test
}
