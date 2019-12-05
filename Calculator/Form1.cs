using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Calculator : Form
    {

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing Methods
        private void Calculator_Load(object sender, EventArgs e)
        {
            //focus the user input text
            focusInputText();
        }
        /// <summary>
        /// clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //Clears the text from the UserInputText box
            this.UserInputText.Text = string.Empty;

            //focus the user input text
            focusInputText();
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //focus the user input text
            focusInputText();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Delete the value before the selected position
            deleteTextValue();

            // Focus the user input text
            focusInputText();
        }


        #endregion

        #region Operator Methods
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        private void DivButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("/");

            //focus the user input text
            focusInputText();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("*");

            //focus the user input text
            focusInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("-");

            //focus the user input text
            focusInputText();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("+");

            //focus the user input text
            focusInputText();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            // Calculates the equation at the user input text.
            calculateEquation();

            //focus the user input text
            focusInputText();
        }


        private void RemainderButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("%");

            //focus the user input text
            focusInputText();
        }

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        #endregion

        #region Number Methods
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        private void DotButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue(".");

            //focus the user input text
            focusInputText();
        }
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("0");

            //focus the user input text
            focusInputText();
        }
        private void OneButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("1");

            //focus the user input text
            focusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("2");

            //focus the user input text
            focusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("3");

            //focus the user input text
            focusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("4");

            //focus the user input text
            focusInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("5");

            //focus the user input text
            focusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("6");

            //focus the user input text
            focusInputText();
        }


        private void SevenButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("7");

            //focus the user input text
            focusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("8");

            //focus the user input text
            focusInputText();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position.
            insertTextValue("9");

            //focus the user input text
            focusInputText();
        }

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        #endregion

        #region Calculations
        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label.
        /// </summary>
        private void calculateEquation() 
        {
            

            this.calculationResultText.Text = ParseOperation();


            //focus the user input text
            focusInputText();
        }

        /// <summary>
        /// Parses the users equation and calculates the result.
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            
            try
            {
                //Get the users equation input
                var input = this.UserInputText.Text;

                //Remove all the spaces
                input = input.Replace(" ", "");

                //Create a new top level operation
                var operation = new Operation();
                var leftSide = true;

                //Loop through each character of the input
                //starting from left working to the right
                for(int i=0; i<input.Length; i++)
                {
                    // TODO: Handle order priority 4 + 5 * 3 = 19 != 27

                    //check if the current character is a number                  
                    if ("0123456789.".Any(c => input[i] == c))
                    {
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        else
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                    }

                    //If it is an operator (+ - * / %) set the operator type
                    else if ("+-*/%.".Any(c => input[i] == c))
                    {
                        //if we are on the right side already, we now need to calculate our current operation
                        //and set the result to the left side of the next operation
                        if (!leftSide)
                        {
                            //Get the operator type
                            var operatorType = GetOperationType(input[i]);

                            if (operation.RightSide.Length == 0)
                            {
                                //check the operator is not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator specified without a right side number");

                                // If we got here, the operator type is a minus, and there is no number currently, so add the minus to the number
                                operation.RightSide += input[i];
                            }
                            else
                            {
                                //Calculating previous equation and set to the left side
                                operation.LeftSide = CalculateOperation(operation);

                                //Set new operator
                                operation.OperationType = operatorType;

                                //Clear the previous right number
                                operation.RightSide = string.Empty;


                            }
                        }
                        else
                        {
                            //Get the operator type
                            var operatorType = GetOperationType(input[i]);

                            //Check if we actually have a left side number
                            if (operation.LeftSide.Length == 0)
                            {
                                //check the operator is not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator specified without a left side number");

                                // If we got here, the operator type is a minus, and there is no number currently, so add the minus to the number
                                operation.LeftSide += input[i];
                            }
                            else
                            {
                                // If we get here we have a left number and now an operator, so we want to move to the right side

                                //set the operation type
                                operation.OperationType = operatorType;

                                //Move to the right side
                                leftSide = false;
                            }
                        }

                    }
                }

                // If we are done parsing , and there were no exceptions
                //calculate the current operation
                
                return CalculateOperation(operation);
            }
            catch(Exception ex)
            {
                
                return $"Invalid equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Calculates a <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation"></param>
        private string CalculateOperation(Operation operation)
        {
            // Store the number values of the string representation
            decimal left = 0;
            decimal right = 0;

            //check if we have a valid left side number 
            if(string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.LeftSide}");

            //check if we have a valid right side number 
            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Right side of the operation was not a number. {operation.RightSide}");

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();

                    case OperationType.Minus:
                        return (left - right).ToString();

                    case OperationType.Multiply:
                        return (left * right).ToString();

                    case OperationType.Divide:
                        return (left / right).ToString();

                    case OperationType.Remainder:
                        return (left % right).ToString();

                    default:
                        throw new InvalidOperationException($"The operator was not recognized as a calculating operator. {operation.OperationType}");

                }
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate the operation.{operation.LeftSide} {operation.OperationType} {operation.RightSide} {ex.Message}");

            }

        }

        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="v">The character to pass</param>
        /// <returns></returns>
        private OperationType GetOperationType(char v)
        {
            switch (v)
            {
                case '+':
                    return OperationType.Add;
                   
                case '-':
                    return OperationType.Minus;

                case '*':
                    return OperationType.Multiply;

                case '/':
                    return OperationType.Divide;

                case '%':
                    return OperationType.Remainder;
                default:
                    throw new InvalidProgramException($"Unknown operator Type {v}");

            }
        }
       
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            //check if there is already a . in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added.");

            return currentNumber + newCharacter;
        }
        #endregion

        #region Private Helpers
        /// <summary>
        /// Focuses the user's input text.
        /// </summary>
        private void focusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the given text into the UserInputText box.
        /// </summary>
        /// <param name="s">The string value inserted where the curser is within the UserInputText box.</param>
        private void insertTextValue(string s)
        {
            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;
            
            // Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, s);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + s.Length;

            // Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Inserts the given text into the UserInputText box.
        /// </summary>
        /// <param name="s">The string value inserted where the curser is within the UserInputText box.</param>
        private void deleteTextValue()
        {
            //If the UserInputText box is empty then return (No value to delete).
            if (this.UserInputText.SelectionStart == 0)
                return;

            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart - 1;
            
            // Delete the character to the right of the selection
            this.UserInputText.Text = this.UserInputText.Text.Remove(selectionStart, 1);
          

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            // Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }

        #endregion

    }
}
