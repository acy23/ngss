using System;

partial class Ngss
{   

    // Main Method
    static public void Main(String[] args)
    {
        double final_price;

        User u = new User();
        u.Name = "Ahmet";
        u.Card = "gold";
        u.IsAffiliate = false;
        u.YearRecorded = 3;


        Calculate calculate = new Calculate(u);
        final_price = calculate.getDiscount(100);
        Console.WriteLine(final_price);

    }
}