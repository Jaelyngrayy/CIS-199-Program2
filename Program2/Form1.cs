//Grading ID: R5560
//Program 2
//Due Date: March 11, 2021
//Course Section CIS 199-01
/*Description: Depending on the entered data by the user, the program tells the user which food delivery
cost the least for their event */
using System;
using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class calculatorForm : Form
    {
        private double costA; //variable used to hold cost of company A
        private double costB; //variable used to hold cost of company B
        private double costC; //variable used to hold cost of company C
        public calculatorForm()
        {
            InitializeComponent();
        }
        //event handler that runs whenever the Calculate cost button is clicked. Calcuates the cost of each
        //company based on the data entered by the user. 
        private void CalculateCostButton_Click(object sender, EventArgs e)
        {
            int people, //entered by user. How many people are at event
                days, //entered by user. How many days for delivery
                peopleACost, //used to calculate the cost for the amount of people via company A
                daysACost, //used to calculate the cost for how many delivery days via company A
                daysBCost, //used to calculate the cost for how many delivery days via company B
                daysCCost; //used to calculate the cost for how many delivery days via company C
            double distance, //entered by user. How many miles is the delivery
                distanceACost, //used to calculate the cost for the distance in miles via company A
                distanceBCost, //used to calculate the cost for the distance in miles via company B
                distanceCCost, //used to calculate the cost for the distance in miles via company C
                peopleBCost, //used to calculate the cost for the amount of people via company B
                peopleCCost; //used to calculate the cost for the amount of people via company C

            //Tryparse to determine if entered data is acceptable.
            //intergers must be intergers, doubles must be doubles, and all inputs can not be negative
            //if so, runs the code to determine the prices of each variable and total cost for each company
            if (int.TryParse(peopleTxt.Text, out people) && (int.TryParse(daysTxt.Text, out days)) && (double.TryParse(distanceTxt.Text, out distance)) && (people >= 0) && (days >= 0) && (distance >= 0))
            {
                //starts finding price for Company A
                //price for people
                peopleACost = people * 1;
                //price for distance
                distanceACost = distance * .02;
                switch(days) //used switch here to determine price of delivery days for company A, could have used else if statements
                {
                    case 1: //if days equals 1
                        daysACost = 20;
                        break;
                    case 2: //2
                        daysACost = 17;
                        break;
                    case 3: //3
                        daysACost = 15;
                        break;
                    case 4: //etc
                        daysACost = 10;
                        break;
                    case 5:
                        daysACost = 10;
                        break;
                    case 6:
                        daysACost = 10;
                        break;
                    case 7:
                        daysACost = 10;
                        break;
                    default: //if not any of the previous
                        daysACost = 7;
                        break;
                }

                costA = peopleACost + distanceACost + daysACost; //adds prices of all other variable to get total cost for company A
                companyAOutputLbl.Text = $"${costA:F2}"; //outputs it into the corresponding label with 2 units of precision
                
                //starts finding price for company B
                //price for people
                //if statements for a range of numbers to determine price depending on the amount of people
                if (people < 10)
                    peopleBCost = people * 20;
                else if (people >= 10 && people < 50)
                    peopleBCost = people * 10;
                else if (people >= 50 && people < 100)
                    peopleBCost = people * 5;
                else if (people >= 100 && people < 200)
                    peopleBCost = people *3;
                else
                    peopleBCost = people *.15;

                //price for distance
                distanceBCost = distance * .10;
                
                //price for days
                if (days >= 1 && days <= 4) //if days is between 1 and 4 inclusive
                    daysBCost = 10;
                else //anything else
                    daysBCost = 7;

                costB = peopleBCost + distanceBCost + daysBCost; //totals costs for company B
                companyBOutputLbl.Text = $"${costB:F2}"; //output with 2 units of precision

                //starts finding price for company C
                //price for people
                peopleCCost = people * .25;
                //price for distance
                if (distance >= 1000)
                    distanceCCost = 40;
                else if (distance >= 750 && distance < 1000)
                    distanceCCost = 35;
                else if (distance >= 500 && distance < 750)
                    distanceCCost = 25;
                else if (distance >= 200 && distance < 500)
                    distanceCCost = 15;
                else
                    distanceCCost = 10;
                //price for days
                daysCCost = 20;

                costC = peopleCCost + distanceCCost + daysCCost; //total costs company C
                companyCOutputLbl.Text = $"${costC:F2}"; //output with 2 units of precision

                //if statements to determine which company costs the least and output that information to the user
                if (costA < costB & costA < costC) //if cost for company a is less than other 2
                    decisionOutputLbl.Text = $"The lowest cost company is: A";
                else if(costB < costA & costB < costC) // if cost for compnay b is less than other 2
                    decisionOutputLbl.Text = $"The lowest cost company is: B";
                else //if cost of c is less than other 2
                    decisionOutputLbl.Text = $"The lowest cost company is: C";
            }
            else //happens if the original tryparse and conditions are not met
            {
                //Message boxes that show if the data the user inputted is not accepted. IE: Not an integer or is a negative number
                if (int.TryParse(peopleTxt.Text, out people) == false || people <= 0) //if people input was not an int or was negative
                {
                    MessageBox.Show("Invalid Number of People"); //output in a message box
                }
                else if (int.TryParse(daysTxt.Text, out days) == false || (days < 0)) //if days input was not an integer or it was negative
                {
                    MessageBox.Show("Invalid Delivery Days"); //output message box
                }
                else if (double.TryParse(distanceTxt.Text, out distance) == false || (distance < 0)) //double is allowed to be a decimal, so if it was negaitve
                {
                    MessageBox.Show("Invalid Distance"); //output
                }

            }
        }   
    }
}
