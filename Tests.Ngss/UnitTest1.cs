using NUnit.Framework;
using static Ngss;


namespace Tests.Ngss
{
    public class Tests
    {
        User user = new User();
        Items item = new Items();
        
        [Test]
        public void Test1()
        {   
            item.Id = 3;
            item.Name = "tyre";
            item.Category = "car";

            user.IsAffiliate = false;
            user.Card = "gold"; //gold card feature
            user.Name = "acy";
            user.YearRecorded = 3;

            Calculate calculate = new Calculate(user, item);
            var result = calculate.getDiscount(1000);
            const double expectedResult = 675.0;

            Assert.That(result, Is.EqualTo(expectedResult));    
        }

        [Test]
        public void Test2()
        {
            item.Id = 3;
            item.Name = "tyre";
            item.Category = "car";

            user.IsAffiliate = false;
            user.Card = "silver"; //silver card feature
            user.Name = "acy";
            user.YearRecorded = 3;

            Calculate calculate = new Calculate(user, item);
            var result = calculate.getDiscount(1000);
            const double expectedResult = 775.0;

            Assert.That(result, Is.EqualTo(expectedResult));

        }

        [Test]
        public void Test3()
        {
            item.Id = 3;
            item.Name = "tyre";
            item.Category = "car";

            user.IsAffiliate = false;
            user.Card = null; //can be nullable
            user.Name = "acy";
            user.YearRecorded = 3;

            Calculate calculate = new Calculate(user, item);
            var result = calculate.getDiscount(100);
            const double expectedResult = 95.0;

            Assert.That(result, Is.EqualTo(expectedResult));

        }

        [Test]
        public void Test4()
        {
            item.Id = 3;
            item.Name = "tyre";
            item.Category = "car";

            user.IsAffiliate = true; //user gets 10% discount if user is affiliate unless user has not any premium card.
            user.Card = "bronze"; 
            user.Name = "acy";
            user.YearRecorded = 0;

            Calculate calculate = new Calculate(user, item);
            var result = calculate.getDiscount(100);
            const double expectedResult = 90.0;

            Assert.That(result, Is.EqualTo(expectedResult));

        }

        [Test]
        public void Test5()
        {
            item.Id = 3;
            item.Name = "tyre";
            item.Category = "car";

            user.IsAffiliate = false; //user gets 10% discount if user is affiliate unless user has not any premium card.
            user.Card = "bronze";
            user.Name = "acy";
            user.YearRecorded = 0;

            Calculate calculate = new Calculate(user, item);
            var result = calculate.getDiscount(100);
            const double expectedResult = 100.0;

            Assert.That(result, Is.EqualTo(expectedResult));

        }
        [Test]
        public void Test6()
        {
            item.Id = 3;
            item.Name = "tyre";
            item.Category = "car";

            user.IsAffiliate = false;
            user.Card = "bronze";
            user.Name = "acy";
            user.YearRecorded = 3; // user gets %5 discount if user has been a member over 2 years.

            Calculate calculate = new Calculate(user, item);
            var result = calculate.getDiscount(100);
            const double expectedResult = 95.0;

            Assert.That(result, Is.EqualTo(expectedResult));

        }
        [Test]
        public void Test7()
        {
            //for every 200$ on a bill 5$ discount

            item.Id = 3;
            item.Name = "tyre";
            item.Category = "car";

            user.IsAffiliate = false;
            user.Card = "bronze";
            user.Name = "acy";
            user.YearRecorded = 0; 

            Calculate calculate = new Calculate(user, item);
            var result = calculate.getDiscount(1100);
            const double expectedResult = 1075.0;

            Assert.That(result, Is.EqualTo(expectedResult));

        }
        [Test]
        public void Test8()
        {
            //If item is a phone, no percentage based discount will be applied. 

            item.Id = 3;
            item.Name = "apple";
            item.Category = "phone";

            user.IsAffiliate = false;
            user.Card = "gold";
            user.Name = "acy";
            user.YearRecorded = 0; 

            Calculate calculate = new Calculate(user, item);
            var result = calculate.getDiscount(1100);
            const double expectedResult = 1075.0;

            Assert.That(result, Is.EqualTo(expectedResult));

        }

    }
}