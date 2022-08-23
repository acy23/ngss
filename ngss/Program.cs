using System;

public partial class Ngss
{   
    // Main Method
    static public void Main(String[] args)
    {
        double final_price;

        User user = new User
        {
            Name = "ahmet",
            Card = "silver",
            IsAffiliate = false,
            YearRecorded = 3
        };

        Items item = new Items
        {
            Id = 1,
            Name = "tyre",
            Category = "car"
        };

        Calculate calculate = new Calculate(user , item);
        final_price = calculate.getDiscount(1000);
        Console.WriteLine(final_price);
        
    }
}