It is a basic solution of retail shop problem. For every feature of the person there would be applied discounts. 

Program is developed with .NET Core 3.1 and the program is a console application solution.
NUnit testing framework was used to unit testing.

RULES

1- If the user has gold card 30% discount will be applied.
2- If the user has silver car 30% discount will be applied.
3- If the user is affiliate 10% discount will be aplied.
4- If the user has been a member for over 2 years membership, 5% discount will be applied.

RESTRICTIONS

1- A user is supposed to take only 1 discount type which is the maximum one. 
2- If a user want to buy a phone, no discounts will be applied.

8 tests were written in order to handle all conditions. In the test methods, that's why code coverage is "lines of covered code / lines of executable codes",
I choosed to assign objects to see if they giving an error or not. In that way, I think I increased the coverage of test. 
According to Visual Studio 22 code metrics calculations for my project:
-Maintainablity index:77 which is OK.
-Lines of executable code:100

RUN TESTS

Tests can be run in Visual Studio, right click Test.Ngss -> Run Tests.
