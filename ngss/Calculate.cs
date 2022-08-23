using System.Runtime.InteropServices;

public partial class Ngss
{
    public class Calculate : ICalculate
    {
        public string? _card;
        public bool _isAffiliate;
        public int _yearRecorded;

        public string? _itemCategory;

        
        public Calculate(User user , Items item)
        {
            _card = user.Card;
            _isAffiliate = user.IsAffiliate;
            _yearRecorded = user.YearRecorded;

            _itemCategory = item.Category;
        }

        public double getDiscount(double price)
        {
            double discount = 0;
            double md , fp;
            if (_itemCategory != "phone" && price >= 0)
            { 
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
            }
            else
            {
                md = price * (discount / 100);
                fp = price - md;
            }
            

            int lastdiscount = ((int)price / 200) * 5;

            return fp - lastdiscount;

        }

    }    
}