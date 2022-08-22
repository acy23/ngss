partial class Ngss
{
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
}