namespace ValutInterpreter {
    internal class ToDollars : IExpression {

        public double Interpreter (Context c) {
            c.Output = CurrencyRateUsd * c.Output;
            return c.Output;
        }

        public double CurrencyRateUsd = 1.2;
    }
}