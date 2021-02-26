using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodParameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //get values for question 1 and send them to the Add method
            int num1 = Convert.ToInt16(q1Num1Input.Text);
            int num2 = Convert.ToInt16(q1Num2Input.Text);
            Add(num1, num2);

            //get value for question 2 and send it to the CanVote method
            int age = Convert.ToInt16(ageInput.Text);
            CanVote(age);

            //get values for question 3 and send them to the WelcomeUser method
            string username = userInput.Text;
            int pinNumber = Convert.ToInt32(pinInput.Text);
            Welcomeuser(username, pinNumber);

            //get value for question 4 and send it to the InchToCm method
            double inches = Convert.ToDouble(inchesInput.Text);
            InchToCm();

        }

        // 1. Create a method called Add, that accepts 2 int parameters, x and y,
        //    adds them together, and then displays the result.
        //
        //    Sample input and output:
        //
        //    Input: 4, 5
        //    4 + 5 = 9
        //
        //    Input: 6, 1
        //    6 + 1 = 7;

        public void Add(int x, int y)
        {
            int sum = x + y;

            q1Output.Text = $"{x} + {y} = {sum}";
        }

        // 2. Create a method called CanVote, that accepts an int parameter, 
        //    voterAge, and uses it to determine if the user is old enough to vote.
        //    
        //    Sample input and output:
        //
        //    Input: 19
        //    You are eligible to vote
        //
        //    Input: 15
        //    You are not eligible to vote

        public void CanVote(int voterAge)
        {
            if(voterAge >= 18)
            {
                q2Output.Text = "you are eligible to vote";
            }
            else
            {
                q2Output.Text = "you are not eligible to vote";
            }
        }

        // 3. Create a method called WelcomeUser, that accepts 2 string 
        //    parameters, name and pin. If the PIN is 1234 the program welcomes
        //    the user. If not an error message is displayed.
        //    
        //    Sample input and output:
        //
        //    Input: Mr. T, 1111
        //    Incorrect PIN
        //
        //    Input: Mr. T, 1234
        //    Welcome Mr. T
        public void Welcomeuser(string name, int pin)
        {
            if(pin == 1234)
                {
                q3Output.Text = $"Welcome {name}";
            }
            else
            {
                q3Output.Text = $"Incorrect pin";
            }
        }


        // 4. Create a method called InchToCm, that accepts a double 
        //    parameter, inches, converts it to cm, (*2.54), and displays
        //    the result.
        //
        //    Sample input and output:
        //
        //    Input: 2
        //    2 inches is 5.08 cms
        //
        //    Input: 3.4
        //    3.4 inches is 8.636 cms
        public void InchToCm()
        {
            double cm = inches * 2.54;

            q4Output.Text = $"{inches} inches is {cm} cms";
        }
   

    }
}
