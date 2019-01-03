namespace ValutInterpreter {
    internal class ToPounds : IExpression {
        public double Interpreter (Context c) {
            c.Output = CurrencyRateUsd * c.Output;
            return c.Output;
        }

        public double CurrencyRateUsd = 1.1;
    }

}