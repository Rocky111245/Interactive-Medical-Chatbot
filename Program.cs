using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{   //Global variables to be used in all methods
    public static class Globals
    {
        public static string name;
        public static bool k = false;
        public static bool a = false;
        public static bool b = false;
        public static bool c = false;

    }


    internal class Program
    {

        public static void firstdiagnosis()
        {   //Initializing some variables limited to this method
            string Inputvalue;
            string Sleepinput2;
            string healthinput;
            string InquiryInput;
            string RepeatInput;

            //Changing text colour of bot to green
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMed Bot: Hello.Thanks for contacting Nilai Hospital Malaysia. The time is now" + " " + DateTime.Now + "." + " " + "\nI am a medical helper bot. Let us get started by knowing your name first. What is your name?\n" +
                "Type:: Your name only\n");
            //Resetting colour to normal with user input
            Console.ResetColor();
            //Getting the global string name using a Globals.name
            Globals.name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");

            Console.WriteLine("Hi" + " " + Globals.name + "," + " " + "how can I help you?\nType:: Example- I want to visit a doctor or I want to know something.\n");
            Console.ResetColor();

            string s = Console.ReadLine();


            if (s.Contains("doctor") == true || s.Contains("something"))
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(".....................Please hang on there while we try to check for available doctors...........................");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("I am not sure what you mean, I will direct you back to the start");
                Console.ResetColor();
                firstdiagnosis();
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Med Bot: Hi" + " " + Globals.name + ", a doctor is currently unavailable,however I am certified to perform preliminary checks on you.\nDo you want to ask us about your health?\n" + "Type::Yes or No\n");
            Console.ResetColor();
            Inputvalue = Console.ReadLine();

            //If user wants to proceed, he will answer "Yes". String.equals code block is used to make it case insensitive. So yes would also work
            if (string.Equals(Inputvalue, "Yes", StringComparison.InvariantCultureIgnoreCase))
            {   //FIRST QUESTION
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Med Bot:So" + " " + Globals.name + " " + "please answer the following questions for me to help you\nThis is the first diagnostic step containing 3 questions\n" +
                    "1)How long do you sleep in hours?\n" + "Type:: Answer ONLY in float values such as 2 or 4.5. Will be automatically converted to hours\n");
                Console.ResetColor();

                //The method below is invoked to read an integer value in c#. It is the same as console.Readline() except for integers.
                //
                float Sleepinput1 = float.Parse(Console.ReadLine()); // Sleepinput1 takes float value as input for sleeping hours from the user

                //simple Calculation of sleep hours

                if (Sleepinput1 <= 8) //if user enters float below or equal to 8 as sleep hours 
                {
                    //if user enters float equal to 8 as sleep hours 
                    if (Sleepinput1 == 8)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Med Bot:You are getting recommended amount of sleep\n");
                        Console.ResetColor();
                        //This global.a bool is used later in AND OR statements to return a logic.
                        Globals.a = true;
                    }
                    //if user enters float greater than 5 and less than 8 as sleep hours 
                    if (Sleepinput1 >= 5 & Sleepinput1 < 8)
                    {   //A calculation to calculate how much more sleep is needed if sleeping hour is below 8 hours.
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Med Bot:You need to sleep" + " " + (8 - Sleepinput1) + " " + "hour more since doctors recommend an average of 8 hours of sleep per day\n");
                        Console.ResetColor();
                    }
                    //if user enters float less than 5
                    if (Sleepinput1 < 5)
                    {   //A calculation to calculate how much more sleep is needed if sleeping hour is below 5 hours.
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Med Bot:You are sleeping for a very short amount of time!" + " " + (8 - Sleepinput1) + " " + "hour more since doctors recommend an average of 8 hours of sleep per day\n");
                        Console.ResetColor();
                    }

                }

                //if user enters float greater than 8 as sleep hours 
                else if (Sleepinput1 > 8)
                {
                    if (Sleepinput1 > 8 & Sleepinput1 < 11)
                    {   //A calculation to calculate excessive sleep if sleeping hour is above 8 hours and below 11 hours.
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("This is still within the normal sleeping range pattern since you are only sleeping" + " " + (Sleepinput1 - 8) + " " + "hours more\n");
                        Console.ResetColor();
                        Globals.a = true;
                    }



                    if (Sleepinput1 >= 11)
                    {   //A calculation to calculate excessive sleep if sleeping hour is above 11 hours.
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You are sleeping more than an average person sleeps in a day!\n" + "You are sleeping" + " " + (Sleepinput1 - 8) + " " + "hours more since the recommended amount is 8 hours per day by the doctor\n");
                        Console.ResetColor();
                    }



                }



                //SECOND QUESTION

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2)Do you feel tired very soon after waking up?\n" + "Type:: Answer Yes or No or Y or N\n");
                Console.ResetColor();
                Sleepinput2 = Console.ReadLine();

                //The if statements checks for a "Yes" or "No" string from the user and proceeds accordingly.

                if (Sleepinput2 == "Yes" || Sleepinput2 == "Y")
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("There might be a lot of conditions affecting this but the primary one doctors mention is lack of quality sleep and you might wanna check on your bed mattress condition,for example\n");
                    Console.ResetColor();
                }
                if (Sleepinput2 == "No" || Sleepinput2 == "N")
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is a good thing to hear. That means you are having some quality sleep\n");
                    Console.ResetColor();
                    Globals.b = true;
                }


                //THIRD QUESTION
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("3)Do you feel light-headed or have blurry vision after eating?\n" + "Type:: Answer Yes or No\n");
                Console.ResetColor();
                healthinput = Console.ReadLine();

                //The if statements checks for a "Yes" or "No" string from the user and proceeds accordingly.

                if (healthinput == "Yes" || healthinput == "Y")
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You should check your blood sugar and insulin levels\n");
                    Console.ResetColor();
                }
                if (healthinput == "No" || healthinput == "N")
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is a good thing to hear. It means you do not have pre-diabetic symptoms\n");
                    Console.ResetColor();
                    Globals.c = true;
                }

            }

            //If user wants to not use the chatbot, he has the option to close the app

            //The statement inside else if removes case sensitivity for "No" string
            else if (string.Equals(Inputvalue, "No", StringComparison.InvariantCultureIgnoreCase))
            {
                Environment.Exit(0);
            }

            //Any other input other than Yes or No will return back to the method. This is a validation check so code does not get stuck.
            else
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please only answer in Yes or No\n");
                Console.ResetColor();
                firstdiagnosis();
            }




            //the if logic set below checks all the answers to the 3 questions asked (by using global booleans) and returns medical assessment accordingly. If any asnwer indicates bad health,it will ask for further diagnosis.
            //Otherwise if all answer indicates good health, the program will not ask for further question(2nd assessment) and will close down. This is again checked using the global booleans.



            if (Globals.a & Globals.b & Globals.c)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("I have diagnosed you for now and according to your answer to the 3 questions,you do not seem to have a problem\n");
                Console.ResetColor();
            }
            else if (Globals.a == false || Globals.b == false || Globals.c == false)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Based on your answer, it seems like you need further diagnosis\n" + "Do you wish to continue with further diagnosis?\n" + "Type:: Yes or No\n");
                Console.ResetColor();
                InquiryInput = Console.ReadLine();

                if (InquiryInput == "No" || InquiryInput == "N" || InquiryInput == "no")
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("It seems like you do not need me,shall I go back to the previous diagnosis or close the application?\n"
                        + "Type:: 'Go back' or 'Exit'\n");
                    Console.ResetColor();
                    RepeatInput = Console.ReadLine();

                    if (RepeatInput == "Go back")
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ok! I went back to the first diagnosis as you wished\n");//It goes back to the beginning of the program
                        Console.ResetColor();
                        firstdiagnosis();

                    }

                    else if (RepeatInput == "Exit")
                    {
                        Environment.Exit(0); //It closes the compiler
                    }

                }
                else if (InquiryInput == "Yes" || InquiryInput == "Y")
                {
                    seconddiagnosis();//It proceeds to the next phase of diagnosis which is the calculation of body adiposity index.
                }
            }


        }






        // making a new function
        public static void seconddiagnosis()
        {
            string InfoInput;
            string InquiryInput2;
            int age;
            //This function is used later for the logic
            var sd2 = new Action(() => {

                // A series of questions are being asked for calculate the Body Adiposity Index
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter your age\nType:: In integer values only.Example--> 21\n");
                Console.ResetColor();

                //The code below is conervting the integer age into readable input from the user
                age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter your waistsize in centimeters\nType:: Example- 94.5. No need to write cm after\n");
                Console.ResetColor();
                float waistcircumference = float.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter your height in metres\nType:: Example- 1.86. No need to write m after 1.86\n");
                Console.ResetColor();
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("");

                //BAI stands for Body Adiposity Index variable.Math.Abs returns absolute value.

                double BAI = Math.Abs((((waistcircumference) / (Math.Pow(height, 1.50))) - 18));
                BAI = Math.Round(BAI, 3);// rounding off the BAI to three decimal places

                //BAI has two calculations for two age ranges. This is the first range which is below 21 years old.
                if (age <= 21)
                {
                    if (BAI >= 20 & BAI <= 25)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Based on the measurements, you have a BAI of" + " " + BAI + " " + ", so you fall in the healthy range\n");
                        Console.ResetColor();

                    }
                    else if (BAI < 20)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You are underweight!.You have a BAI of" + " " + BAI + " " + "." + "This could also be a health issue. Please contact a dietician");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have a BAI of" + " " + BAI + " " + "." + "You should try to lose weight as you have a lot of body fat around your waist which might be contributing to your health problems\n");
                        Console.ResetColor();
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thanks for contacting Health Bot.We are happy to help you\nDo you wish to return to the first assessment,second assesment or exit the program?\nType::1 or 2 or Exit respectively\n");
                    Console.ResetColor();
                    InquiryInput2 = Console.ReadLine();
                    if (InquiryInput2 == "1")
                    {
                        firstdiagnosis();
                    }
                    else if (InquiryInput2 == "2")
                    {
                        seconddiagnosis();
                    }
                    else if (InquiryInput2 == "Exit")
                    {
                        Environment.Exit(0);
                    }



                }
                //This is the second range which is above 21 years old.
                else if (age > 21)
                {
                    if (BAI >= 15.0 & BAI <= 20.0)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Based on the measurements, you have a BAI of" + " " + BAI + " " + ", so you fall in the healthy range\n");
                        Console.ResetColor();
                    }

                    else if (BAI < 15)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You are underweight! because your BAI is" + " " + BAI + "." + " This could also be a health issue. Please contact a dietician\n");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You should try to lose weight because your BAI is" + " " + BAI + "." + " which means you have a lot of body fat around your waist which might be contributing to your health problems\n");
                        Console.ResetColor();
                    }








                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thanks for contacting Med Bot\nWe are happy to help you\nDo you wish to return to the first assessment,second assesment or exit the program?\nType::1 or 2 or Exit\n");
                    Console.ResetColor();
                    InquiryInput2 = Console.ReadLine();
                    if (InquiryInput2 == "1")
                    {
                        firstdiagnosis();
                    }
                    else if (InquiryInput2 == "2")
                    {
                        seconddiagnosis();
                    }
                    else if (InquiryInput2 == "Exit")
                    {
                        Environment.Exit(0);
                    }
                }

            });// function defining the second diagnosis

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWelcome to the second diagnosis. We will first start by measuring your Body Adiposity Index\n" +
                "Do you wish to know more about the Body Adiposity Index or proceed to the diagnosis directly?\n" +
                "Type:: Yes or No\n");
            Console.ResetColor();
            InfoInput = Console.ReadLine();

            //This describes what is BAI and goes directly to the 2nd assessment questions
            if (InfoInput == "Yes")
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The body adiposity index (BAI) is a method of estimating the amount of body fat in humans.\nThe BAI is calculated without using body weight, unlike the body mass index (BMI).\nInstead, it uses the size of the hips compared to the person's height.It is considered more accurate than BMI\nNote::Only measured for females in this app");
                Console.ResetColor();
                sd2();


            }





            //This does not describe what is BAI but instead goes directly to the 2nd assessment questions
            else if (InfoInput == "No")
            {
                sd2();

            }







        }










        static void Main(string[] args)
        {   //bool to stop compiler shutdown
            bool shutdown = false;
            //calls the whole function/method here.
            firstdiagnosis();

            while (!shutdown)
            {
                //prevents shutting down of compiler
            }
        }
    }
}







