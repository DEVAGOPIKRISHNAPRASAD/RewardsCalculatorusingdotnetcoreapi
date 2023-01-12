#The rest API to get customer rewards 

#Problem Statement: A retailer offers a rewards program to its customers, awarding points based on each recorded purchase. A customer receives 2 points for every dollar spent over $100 in each transaction, plus 1 point for every dollar spent over $50 in each transaction (e.g. a $120 purchase = 2x$20 + 1x$50 = 90 points). Given a record of every transaction during a three month period, calculate the reward points earned for each customer per month and total.

For this I have created the dot net core api end point to get both monthly and total rewards for customers.
I have created the dot net core api and configured the service layer into the ConfigureServices function in startup.cs
I have create the httpget end point to get the rewards of the customer
I have created the rewards interface and implemented this service with the logic to calculate the rewards.
Then in controller I have added the service layer as a dependency injection and then called the calculaterewards method by passing the customer information.
To test this I have created the dummy data where I have covered all 3 scenarios like having transaction amount between 0-50, 50-100, morethan 100 scenarios and calculated rewards for each scenario and also calculated total rewards at the end.
I have tested this end point using the postman and got response as expected.
