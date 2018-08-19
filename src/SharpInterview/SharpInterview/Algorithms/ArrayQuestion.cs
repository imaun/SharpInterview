namespace SharpInterview.Algorithms {
    public static class ArrayQuestion {
        public static double Average(params int[] input) {
            if (input == null || input.Length == 0)
                return double.NaN;
            int sum = 0;
            for (var i = 0; i <= input.Length; i++) {
                sum += input[i];
            }
            double result = (double)sum / input.Length;
            return result;
        }
    }
}
