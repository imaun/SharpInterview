namespace SharpInterview.Algorithms {
    public class BubbleSort {
        public static int[] Sort(int[] input) {
            int tmp;
            for (int j = 0; j <= input.Length - 2; j++) {
                for (int i = 0; i <= input.Length - 2; i++) {
                    if (input[i] > input[i + 1]) {
                        tmp = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = tmp;
                    }
                }
            }
            return input;
        }
    }
}
