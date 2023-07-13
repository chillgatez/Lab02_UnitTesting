# Lab02_UnitTesting: Code Crew Credit Union Consonsole ATM

## Summary
Lab02_UnitTesting is a console application that simulates the functionality of an ATM. It allows users to perform transactions such as viewing the balance, making withdrawals, and making deposits. This application was developed using Test Driven Development (TDD) to ensure its functionality and reliability.

## Visuals
![console app](https://github.com/chillgatez/Lab02_UnitTesting/blob/master/Assets/Screenshot%20(24).png?raw=true)
![console app](https://github.com/chillgatez/Lab02_UnitTesting/blob/master/Assets/Screenshot%20(25).png?raw=true)
![tests ran](https://github.com/chillgatez/Lab02_UnitTesting/blob/master/Assets/Screenshot%20(27).png?raw=true)

## Usage
  **Prerequisites:**
    Ensure that you have the .NET runtime installed on your machine.
    
  **Installation:**
    Clone or download the Lab02_UnitTesting repository to your local machine.

  **Running the Application:**
    Open a command prompt or terminal and navigate to the project directory.
    Build the application by running the command: dotnet build
    Run the application by executing the command: dotnet run

  **Using the Application:**
  Upon running the application, you will be presented with a menu of available transactions.
  ```
  Enter the corresponding letter for the desired transaction.
  'v' to view the balance  
  'w' to make a withdrawal
  'd' to make a deposit
  'e' to exit the application
  ```
  Follow the prompts and instructions provided by the application to perform the selected transaction. The application will validate inputs, ensure sufficient funds for withdrawals, and display appropriate messages.
   
  **Additional Details:**

  - The Lab02_UnitTesting application utilizes the decimal data type to represent monetary values, ensuring accurate calculations.

  - The application enforces validation rules to prevent negative values for deposits and withdrawals and ensures the balance does not go below zero.

  - Test Driven Development (TDD) approach was followed during the development of this application to ensure its functionality and reliability.

  - The associated unit tests can be found in the Lab02Test project, which validates the behavior of the application's methods.
