using System;

partial class Ngss
{   

    public class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }

    // Main Method
    static public void Main(String[] args)
    {
        double final_price;

        User user = new User();
        user.Name = "Ahmet";
        user.Card = "gold";
        user.IsAffiliate = false;
        user.YearRecorded = 3;


        Calculate calculate = new Calculate(user);
        final_price = calculate.getDiscount(150);
        Console.WriteLine(final_price);
        

    }
}