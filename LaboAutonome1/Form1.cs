using FractionBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboAutonome1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ArithMultBtn_Click(object sender, EventArgs e)
        {
            Fraction fraction1 = Fraction.MathSimplification(new Fraction(
                 (int.Parse(this.ArithMultFracDen1.Text)),
                 int.Parse(this.ArithMultFrac1.Text) *
                 int.Parse(this.ArithMultFracNum1.Text)
               ));
            Fraction fraction2 = Fraction.MathSimplification(new Fraction(
                (int.Parse(this.ArithMultFracDen2.Text)),
                (int.Parse(this.ArithMultFrac2.Text)) *
                (int.Parse(this.ArithMultFracNum2.Text))
                ));

            Fraction fraction = new Fraction(1, 1);
            switch (this.ArithMultFracComboBox.SelectedItem.ToString())
            {
                case "+":
                    fraction = fraction1 + fraction2;
                    break;
                case "-":
                    fraction = fraction1 - fraction2;
                    break;
                case "*":
                    fraction = fraction1 * fraction2;
                    break;
                case "/":
                    fraction = fraction1 / fraction2;
                    break;
            }
            Tuple<int, int, int> tuple = Fraction.UserSimplification(fraction);
            this.ArithMultFracRes.Text = StringConstruction(tuple);
            if (this.ArithValidation.Checked) 
            {
                SavingBLL.CallDALMethodArith(fraction1, fraction2, this.ArithMultFracComboBox.SelectedItem.ToString(), fraction);
            }



        }
        private static string StringConstruction(Tuple<int, int, int> tuple) 
        {
            string a;
            if (tuple.Item2 == 0 || tuple.Item3 == 0)
            {
                a = tuple.Item1.ToString();
            }
            else if (tuple.Item1 == 0)
            {
                a = tuple.Item2 + "/" + tuple.Item3;
            }
            else if (tuple.Item1 == 0 && tuple.Item2 == 0 && tuple.Item3 == 0)
            {
                a = "0";
            }
            else
            {
                a = tuple.Item1 + " " + tuple.Item2 + "/" + tuple.Item3;
            }
            return a;
        }

        private void CompaFractBtn_Click(object sender, EventArgs e)
        {
            Fraction fraction1 = Fraction.MathSimplification(new Fraction(
                 (int.Parse(this.CompaFractDen1.Text)),
                 int.Parse(this.CompaMultFract1.Text) *
                 int.Parse(this.CompaFractNum1.Text)
               ));
            Fraction fraction2 = Fraction.MathSimplification(new Fraction(
                 (int.Parse(this.CompaFractDen2.Text)),
                 int.Parse(this.CompaMultFract2.Text) *
                 int.Parse(this.CompaFractNum2.Text)
               ));
            bool result = true;
            switch (this.CompaFractComboBox.SelectedItem.ToString())
            {
                case "<":
                    result = fraction1 < fraction2;
                    break;
                case ">":
                    result = fraction1 > fraction2;
                    break;
                case "<=":
                    result = fraction1 <= fraction2;
                    break;
                case ">=":
                    result = fraction1 >= fraction2;
                    break;
                case "==":
                    result = fraction1 == fraction2;
                    break;
                case "!=":
                    result = fraction1 != fraction2;
                    break;
            }
            Tuple<int, int, int> tuple1 = Fraction.UserSimplification(fraction1);
            Tuple<int, int, int> tuple2 = Fraction.UserSimplification(fraction2);

            this.CompaFractRes.Text = StringConstruction(tuple1)
                + " " + this.CompaFractComboBox.SelectedItem.ToString() 
                + " " + StringConstruction(tuple2)
                + " == " + result;
            if (this.CompaBox.Checked)
            {
                SavingBLL.CallDALMethodCompa(fraction1, fraction2, this.CompaFractComboBox.SelectedItem.ToString(), result.ToString());
            }

        }
    }
}
