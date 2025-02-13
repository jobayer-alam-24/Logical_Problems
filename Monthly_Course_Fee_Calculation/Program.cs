namespace Monthly_Course_Fee_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            float SpokenEnglishCourseFee, KidsSpokenCourseFee, EnglishGrammerCourseFee, DisCount;
            SpokenEnglishCourseFee = 550.5f;
            KidsSpokenCourseFee = 1200.44f;
            EnglishGrammerCourseFee = 555.55f;
            DisCount = 15;
            PrintCourseDetails(SpokenEnglishCourseFee, KidsSpokenCourseFee, EnglishGrammerCourseFee, DisCount);
        }
        static void PrintCourseDetails(float spokenFee, float KidsSpokenFee, float englishGrammerFee, float discount)
        {
            float total = spokenFee + KidsSpokenFee + englishGrammerFee;
            float subtotal = total - (total * (discount / 100));
            float monthlyFee = subtotal / 12.0f;
            Console.WriteLine($"-------Bundle Courses-----");
            Console.WriteLine($"Course Name: Spoken English");
            Console.WriteLine($"Course Fee: {spokenFee}$");
            Console.WriteLine($"Course Name: Kid's Spoken English");
            Console.WriteLine($"Course Fee: {KidsSpokenFee}$");
            Console.WriteLine($"Course Name: English Grammar");
            Console.WriteLine($"Course Fee: {englishGrammerFee}$");
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"Total: {total}$");
            Console.WriteLine($"Discount: {discount}$");
            Console.WriteLine($"Sub Total: {subtotal}$");
            Console.WriteLine($"Monthly Fee: {monthlyFee}$");
        }
    }
}