namespace SharpInterview.Algorithms {
    public class BinarySearchTree {
        public static bool Contains(BinaryTreeNode root, int value) {
            if (root.Value == value)
                return true;
            if (root.Right != null && root.Value < value)
                return Contains(root.Right, value);
            if (root.Left != null && root.Value >= value)
                return Contains(root.Left, value);
            return false;
        }

        public BinaryTreeNode Add(BinaryTreeNode root, int value) {
            if (root == null) {
                root = new BinaryTreeNode { Value = value };
            }
            else if (value < root.Value) {
                root.Left = Add(root.Left, value);
            }
            else {
                root.Right = Add(root.Right, value);
            }
            return root;
        }

        public void Traverse(BinaryTreeNode root) {
            if (root == null) return;
            if (root.Left != null) Traverse(root.Left);
            if (root.Right != null) Traverse(root.Right);
        }

        public bool IsLeaf(BinaryTreeNode node) {
            return node.Right == null && node.Left == null;
        }

        public bool IsNull(BinaryTreeNode root) {
            return root == null;
        }
    }

    public class BinaryTreeNode {
        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public BinaryTreeNode(int value, BinaryTreeNode left, BinaryTreeNode right) {
            Value = value;
            Left = left;
            Right = right;
        }
        public BinaryTreeNode() { }
    }
}
