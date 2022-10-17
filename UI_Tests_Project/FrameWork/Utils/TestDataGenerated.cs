using Bogus;

namespace UI_Tests_Project.FrameWork.Utils
{
    public class TestDataGenerated
    {
        private static Faker Faker => new();
        
        public static string GenerateSomeName()
        {
            return Faker.Person.UserName;
        }

        public static int GenerateSomeNumber(int minValue,int maxValue)
        {
            return Faker.Random.Int(minValue, maxValue);
        }
    }
}