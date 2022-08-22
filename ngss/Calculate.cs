using System.Runtime.InteropServices;

partial class Ngss
{
    class Calculate : ICalculate
    {
        public string _card;
        public bool _isAffiliate;
        public int _yearRecorded;

        public string _itemCategory;

        
        public Calculate(User user)
        {
            _card = user.Card;
            _isAffiliate = user.IsAffiliate;
            _yearRecorded = user.YearRecorded;
        }

        public double getDiscount(double price)
        {
            double discount = 0;
            double md , fp;

            if (_card == "gold")
            {
                discount = discount + 30;
            }
            else if (_card == "silver")
            {
                discount = discount + 20;
            }
            else
            {
                if (_isAffiliate)
                    discount += 10;
                else
                {
                    if (_yearRecorded >= 2)
                        discount += 5;
                }
            }

            md = price * (discount / 100);
            fp = price - md;

            int lastdiscount = ((int)price / 200) * 5;

            return fp - lastdiscount;

        }

    }    
}