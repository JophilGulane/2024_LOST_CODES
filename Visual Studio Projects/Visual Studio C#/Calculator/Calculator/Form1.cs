using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private TextBox displayTextBox;
        private Button[] numberButtons;
        private Button addButton, subtractButton, multiplyButton, divideButton, equalsButton, clearButton;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            displayTextBox = new TextBox();
            displayTextBox.ReadOnly = true;
            displayTextBox.TextAlign = HorizontalAlignment.Right;
            displayTextBox.Location = new System.Drawing.Point(10, 10);
            displayTextBox.Size = new System.Drawing.Size(200, 30);

            numberButtons = new Button[10];
            for (int i = 0; i < 10; i++)
            {
                numberButtons[i] = new Button();
                numberButtons[i].Text = i.ToString();
                numberButtons[i].Click += NumberButton_Click;
            }

            addButton = CreateOperatorButton("+");
            subtractButton = CreateOperatorButton("-");
            multiplyButton = CreateOperatorButton("*");
            divideButton = CreateOperatorButton("/");
            equalsButton = new Button();
            equalsButton.Text = "=";
            equalsButton.Click += EqualsButton_Click;
            clearButton = new Button();
            clearButton.Text = "C";
            clearButton.Click += ClearButton_Click;

            int buttonSize = 40;
            int margin = 5;

            int x = 10, y = 50;

            for (int i = 1; i <= 9; i++)
            {
                numberButtons[i].Size = new System.Drawing.Size(buttonSize, buttonSize);
                numberButtons[i].Location = new System.Drawing.Point(x, y);
                x += buttonSize + margin;
                if (i % 3 == 0)
                {
                    x = 10;
                    y += buttonSize + margin;
                }
            }

            numberButtons[0].Size = new System.Drawing.Size(buttonSize * 2 + margin, buttonSize);
            numberButtons[0].Location = new System.Drawing.Point(x, y);

            addButton.Size = multiplyButton.Size = divideButton.Size = subtractButton.Size = equalsButton.Size = clearButton.Size = new System.Drawing.Size(buttonSize, buttonSize);

            addButton.Location = new System.Drawing.Point(10 + buttonSize * 3 + margin * 2, 50);
            subtractButton.Location = new System.Drawing.Point(10 + buttonSize * 3 + margin * 2, 95);
            multiplyButton.Location = new System.Drawing.Point(10 + buttonSize * 3 + margin * 2, 140);
            divideButton.Location = new System.Drawing.Point(10 + buttonSize * 3 + margin * 2, 185);
            equalsButton.Location = new System.Drawing.Point(10 + buttonSize * 2 + margin, 230);
            clearButton.Location = new System.Drawing.Point(10, 230);

            Controls.Add(displayTextBox);
            Controls.AddRange(numberButtons);
            Controls.Add(addButton);
            Controls.Add(subtractButton);
            Controls.Add(multiplyButton);
            Controls.Add(divideButton);
            Controls.Add(equalsButton);
            Controls.Add(clearButton);
        }

        private Button CreateOperatorButton(string text)
        {
            Button button = new Button();
            button.Text = text;
            button.Click += OperatorButton_Click;
            return button;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            displayTextBox.Text += " " + button.Text + " ";
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                displayTextBox.Text = EvaluateExpression(displayTextBox.Text).ToString();
            }
            catch (Exception ex)
            {
                displayTextBox.Text = "Error";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = "";
        }

        private double EvaluateExpression(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, string.Empty));
        }
    }
}