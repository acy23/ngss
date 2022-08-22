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
        public Calculate(User u)
        {
            _card = u.Card;
            _isAffiliate = u.IsAffiliate;
            _yearRecorded = u.YearRecorded;
        }

        public double getDiscount(double price)
        {
            double discount = 0;
            double md;

            if (_card == "gold")
            {
                discount = discount + 30;
            }
            else if (_card == "silver")
            {
                discount = discount + 20;
            }

            if (_isAffiliate)
                discount += 10;

            if (_yearRecorded >= 2)
                discount += 5;

            md = price * (discount / 100);

            return price - md;

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