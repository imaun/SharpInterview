namespace SharpInterview.Algorithms {
    public static class BinarySearch {
        public static int BinarySearchRecursive(int[] input, int key, int min, int max) {
            if (min > max) {
                return -1;
            }
            else {
                int mid = (min + max) / 2;
                if (key == input[mid]) {
                    return ++mid;
                }
                else if (key < input[mid]) {
                    return BinarySearchRecursive(input, key, min, mid - 1);
                }
                else {
                    return BinarySearchRecursive(input, key, mid + 1, max);
                }
            }
        }

        public static int BinarySearchNormal(int[] input, int key, int min, int max) {
            while (min <= max) {
                int mid = (min + max) / 2;
                if (key == input[mid]) {
                    return ++mid;
                }
                else if (key < input[mid]) {
                    max = mid - 1;
                }
                else {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
