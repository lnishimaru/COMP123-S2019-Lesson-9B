using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson_9B
{
    public partial class CalculatorForm : Form
    {
        public string outputString { get; set; }
        public bool decimalExists { get; set; }
        public float outputValue { get; set; }
        public CalculatorForm()
        {
            InitializeComponent();
        }
        private void ButtonEq_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int buttonValue;
            bool resultCondition = int.TryParse(tag, out buttonValue);
            // if the user pressed a number button   
            if (resultCondition)
            {
                var maxSize = 3;
                if (decimalExists)
                {
                    maxSize = 5;
                }
                if ((outputString != "0") && (ResultLabel.Text.Count() < maxSize))
                {
                    outputString += tag;
                    ResultLabel.Text = outputString;
                }
            }
            // if the use pressed a number thar is not a number
            if (!resultCondition)
            {
                switch(tag)
                {
                    case "clear":
                        clearNumericKeyboard();
                        break;
                    case "back":
                        removeLastCharacterFromResultLabel();
                        break;
                    case "done":
                        finalizeOutput();
                        break;
                    case "decimal":
                        addDecimalToResultLabel();
                        break;
                }
                //ResultLabel.Text += TheButton.Text;
            }
            //else
            //{
            //    ResultLabel.Text = "Not a Number (NAN)";
           // }
        }
        /// <summary>
        /// This method adds a decimal to the ResultLabel
        /// </summary>
        private void addDecimalToResultLabel()
        {
            if (!decimalExists)
            {
                if (ResultLabel.Text == "0")
                {
                    outputString += "0";
                }
                outputString += ".";
                decimalExists = true;
            }
        }
        /// <summary>
        /// This method finalizes calculation on the ResultLabel
        /// </summary>
        private void finalizeOutput()
        {
            if (outputString == string.Empty)
            {
                outputString = "0";
            }
            outputValue = float.Parse(outputString);
            HeightLabel.Text = outputValue.ToString();
            clearNumericKeyboard();
            CalculatorTableLayoutPanel.Visible = false;
        }

        /// <summary>
        /// This method removes the last character from the ResultLabel
        /// </summary>
        private void removeLastCharacterFromResultLabel()
        {
            if (outputString.Length > 0)
            {
                var lastChar = outputString.Substring(outputString.Length - 1);
                if (lastChar == ".")
                {
                    decimalExists = false;
                }
                outputString = outputString.Remove(outputString.Length - 1);
                if (outputString.Length == 0)
                {
                    outputString = "0";
                }
                ResultLabel.Text = outputString;
            }
        }

        /// <summary>
        /// Clear the numeric keyboard
        /// </summary>
        private void clearNumericKeyboard()
        {
            ResultLabel.Text = "0";
            outputString = String.Empty;
            decimalExists = false;
            outputValue = 0.0f;
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This is the event handler that triggers when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            clearNumericKeyboard();
            CalculatorTableLayoutPanel.Visible = true;
        }
    }
}
