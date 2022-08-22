using System;

class ngss
{
    public class User
    {
        public string Name { get; set; }
        public string Card { get; set; }
        public bool IsAffiliate { get; set; }
        public int YearRecorded { get; set; }

    }

    public interface ICalculate 
    {
        public double getDiscount(double price);
    }
    class Calculate : ICalculate
    {
        public string _card;
        public bool _isAffiliate;
        public int _yearRecorded;
        public Calculate (User u)
        {
            _card = u.Card;
            _isAffiliate = u.IsAffiliate;
            _yearRecorded = u.YearRecorded;
        }

        public double getDiscount(double price)
        {
            int total = 0;

            if (_card == "gold")
            {
                total = total + 30;
            }
            else if (_card == "silver")
            {
                total = total + 20;
            }

            if (_isAffiliate)
                total += 10;

            if (_yearRecorded >= 2)
                total += 5;

            return price-total;
            
        }

    }


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