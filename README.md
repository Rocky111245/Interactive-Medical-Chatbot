# Interactive-Medical-Chatbot
This chatbot utilizes the asp.net console application using C# to make a reliable chatbot that can also perform multiple calculations. This can be a stepping stone for a clinic to reduce high inquiry pressure during peak times.

The name of this chat bot is Med Bot. This is a medical assistant bot. The text color of the chatbot response is green and user input is white to distinguish it better. There are 2 diagnostic phases in the med bot.
Throughout the whole session the Chat bot guides the user on how to conduct the inquiry. It is recommended to follow the instructions given by the chatbot as the inputs after the first few inputs are case sensitive.

First Diagnosis:
First the chatbot will ask the user’s name, and after taking that input the chatbot will address the user with his/her name thought-out the whole Q/A session. 
The user will be asked if they would like to know how to improve their health. If the user types yes, then the chat bot will ask basic health question such as how many hours they sleep, 
whether they feel tired very soon after waking up, and based on the answer from the user, the chatbot will proceed to next question related to that answer.
And based on the answers the chatbot will inform the user that they need further diagnosis, and will ask the user whether he/she would like to continue the second diagnosis, if the user types No,
the chat bot asks if they would like to go back to the previous diagnosis or close the application by typing “Go back” or “Exit” respectively. If the user types Go back, the program will start from the beginning,
and if they type exit, then the compiler will be closed. The chatbox replies are completely different if the user answers, for example, 4 hours of sleeping instead of 8 which increases realism. 

Second Diagnosis:
Boolean checks are performed to check on the user’s health condition. If returned true, it activates the second stage of diagnosis. 
If no health issues are found the chatbot says everything is fine and asks the user if it wants to perform the first diagnosis again or close the application.
If the user chooses yes for further diagnosis, he/she will be asked questions about their age, their waist size and their height to calculate the Body adiposity index calculation (BAI). 
Depending on the answer, the chatbot will inform the user whether they are under weight or obese, and what might be the root cause of their health issues.

After the second assessment the chat bot will ask the user if they wish to return to the first assessment, second assessment or exit the program. The user needs to choose 1, 2 or exit respectively.
BAI information taken from https://www.omnicalculator.com/health/bai



This chatbot mainly contains 2 calculations:
1. Sleep time calculation: for the sleep calculation, the user will be asked to enter the number of hours they get to sleep,
and based on the input the med bot will tell the user how many more or less hours they should sleep and what is the recommended hours a person should sleep for a healthy lifestyle. Recommended sleeping hours is 8 hours.
2. Body adiposity index calculation (BAI): The body adiposity index (BAI) is a method of estimating the amount of body fat in humans.
   The BAI is calculated without using body weight, unlike the body mass index (BMI). Instead, it uses the size of the hips compared to the person's height. It is considered more accurate than BMI.
   https://www.omnicalculator.com/health/bai

