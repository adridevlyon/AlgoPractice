namespace BinarySearchTree
{
    public class Tree
    {
        public Tree(int value)
        {
            Value = value;
        }

        public int Value { get; }
        public Tree Left { get; set; }
        public Tree Right { get; set; }

        public override bool Equals(object obj)
        {
            var objTree = obj as Tree;
            if (objTree == null) return false;
            return Value == objTree.Value
                && ((Left == null && objTree.Left == null) || (Left?.Equals(objTree.Left) ?? false))
                && ((Right == null && objTree.Right == null) || (Right?.Equals(objTree.Right) ?? false));
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode() + (Left?.GetHashCode() ?? 0) + (Right?.GetHashCode() ?? 0);
        }
    }
}
