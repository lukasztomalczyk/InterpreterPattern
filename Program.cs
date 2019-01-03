using System;
using System.Collections.Generic;

namespace ValutInterpreter {
    class Program {
        static void Main (string[] args) {
            var context = new Context (12);
            var expressions = new List<IExpression> { new ToDollars (), new ToPounds () };
            foreach (var item in expressions) {
                var result = item.Interpreter (context);
                System.Console.WriteLine (result);
            }
        }
    }
}