namespace ConsoleApp1
{
    internal class NumericalExpression
    {
        private long Value;

        public NumericalExpression(long Value)
        {
            if (Value > 999999999999)
            {
                throw new ArgumentOutOfRangeException("NumericalExpression can't be greater than 999,999,999,999");
            }
            this.Value = Value;
        }

        public long GetValue()
        {
            return Value;
        }
        public static long SumLetters(long n)
        {
            long s = 0;

            for (long i = 0; i <= n; i++)
            {

                s += (new NumericalExpression(i)).ToString().Replace(" ", "").Length;
            }
            return s;
        }

        //7.f. function overloading
        public static long SumLetters(NumericalExpression ne) => SumLetters(ne.GetValue());

        public override string ToString()
        {
            string[] digits = {"Zero","One","Two","Three","Four","Five",
                               "Six","Seven","Eight","Nine"};
            string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] powers = { "One", "Thousand", "Million", "Milliard" };

            string s = "";
            if (Value < 10)
            {
                return digits[Value];
            }
            if (Value < 20)
            {
                return teens[Value - 10];
            }
            if (Value < 100)
            {
                s = tens[Value / 10];
                if (Value % 10 != 0)
                {
                    s += " " + digits[Value % 10];
                }
                return s;
            }
            if (Value < 1000)
            {
                s = digits[Value / 100] + " Hundred";
                if (Value % 100 != 0)
                {
                    s += " " + (new NumericalExpression(Value % 100));
                }
                return s;
            }

            int i = 0;
            while (Value > 0)
            {
                if (Value % 1000 > 0)
                {
                    s = (new NumericalExpression(Value % 1000)) + s;
                }
                Value /= 1000;
                if (Value > 0)
                {
                    s = " " + powers[i + 1] + " " + s;
                }
                i++;
            }

            return s;
        }
    }
}
