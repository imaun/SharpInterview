namespace SharpInterview.Algorithms {
    public class MergeSort {
        public static void Sort(int[] input, int left, int right) {
            int mid = 0;
            if (right > left) {
                mid = (right + left) / 2;
                Sort(input, left, mid);
                Sort(input, (mid + 1), right);
                Merge(input, left, (mid + 1), right);
            }
        }

        static public void Merge(int[] input, int left, int mid, int right) {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right)) {
                if (input[left] <= input[mid])
                    temp[tmp_pos++] = input[left++];
                else
                    temp[tmp_pos++] = input[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = input[left++];

            while (mid <= right)
                temp[tmp_pos++] = input[mid++];

            for (i = 0; i < num_elements; i++) {
                input[right] = temp[right];
                right--;
            }
        }


    }
}
