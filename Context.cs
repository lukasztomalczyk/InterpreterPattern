namespace ValutInterpreter {
    internal class Context {
        public Context (double value) {
            this.Output = value;
        }
        public double Output { get; set; }
    }
}