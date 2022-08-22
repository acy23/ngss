using System;

partial class Ngss
{   

    // Main Method
    static public void Main(String[] args)
    {
        double final_price;

        User user = new User();
        user.Name = "ahmet";
        user.Card = "gold";
        user.IsAffiliate = false;
        user.YearRecorded = 3;

        Items item = new Items();
        item.Id = 1;
        item.Name = "tyre";
        item.Category = "car";


        Calculate calculate = new Calculate(user , item);
        final_price = calculate.getDiscount(100);
        Console.WriteLine(final_price);
        

    }
}