# CLI_Application

# MustafaEraslan

Hello,

I have completed a CLI application that meets the requirements in the subsection. Gets tc on first boot. If existing is defined in the array, the customer's name is displayed, otherwise the new customer registration screen is displayed. (name, surname, gsm, etc.) The product to be sold is selected, the quantity is selected. 

The application console screen is as follows;

If the TR ID number entered from the user is not 11 digits or starts with the number 0, then you need to try again and the number of digits you entered is displayed as a warning on the console screen.

![image](https://user-images.githubusercontent.com/44713722/174433153-985351a0-7553-44a9-be03-a7c71831b2ae.png)

On the other hand, if you have entered a tc that is not in the Dictionary structure, then your name, surname, gsm information is taken from you to save the user, and it throws the successfully saved message to the console screen. Then it lists the products and you are asked to choose. Then, along with the productcode information, the quantity information is also requested. If the ProductCode is not a value that the program generates, you are asked to try again. If the productCode is correct, the program goes to the next stage and asks for stock information. Here again there is a check on stock information. If the stock information is smaller, it is requested to enter the value again.

![image](https://user-images.githubusercontent.com/44713722/174433085-5a155904-ab15-4335-9fb8-9cbf446541e9.png)

If the entered tc is available in the system, first the name of that number is printed, then the products are listed. The product details from the previous step are repeated.

![image](https://user-images.githubusercontent.com/44713722/174432454-98e71b0d-5362-422a-8eaf-d75334cea3bf.png)

So I'm starting to talk about how I completed the project, the methodology and methods I used.

I determined my algorithm so that I could see all the steps in the project and select the structures I used.

It was not desired to use any database for the application and for this reason I preferred the Dictionary structure. With the Dictionary structure, I registered the registered members with their name information. In my research, I realized that it is important to use validation and that there are structures where we can find answers to the questions of whether we get the value I want from the user, and I chose to use it.

On the other hand, I generated a unique 32-character value for the products. I could have valued the products myself here, but I decided to include them in my project because I thought it was important to use such a structure in the future. In addition, I tried to use my definitions for personnel, product and order by opening a separate class instead of program.cs and making my project more visible. I decided where I should use validation and after this step I started to write code and completed my project.

Thanks, 




