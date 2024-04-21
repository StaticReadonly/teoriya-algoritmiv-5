namespace Classes
{
    public class BinaryTree
    {
        private TreeNode? _Root { get; set; } = null;

        public void AddIdentifier(string identifier)
        {
            if (_Root == null)
            {
                _Root = new TreeNode(identifier, 1);
                return;
            }

            _AddIdentifier(_Root, identifier);
        }

        private void _AddIdentifier(TreeNode current, string identifier)
        {
            if (current.Identifier == identifier)
            {
                current.Number++;
                return;
            }

            int leftCompare = String.Compare(identifier, current.Identifier);

            if (leftCompare < 0)
            {
                if (current.Left == null)
                    current.Left = new TreeNode(identifier, 1);
                else
                    _AddIdentifier(current.Left, identifier);

            }
            else
            {
                if (current.Right == null)
                    current.Right = new TreeNode(identifier, 1);
                else
                    _AddIdentifier(current.Right, identifier);
            }
        }

        public List<Tuple<string, int>> TreeTraversal()
        {
            List<Tuple<string, int>> result = new();

            if (_Root != null)
            {
                _TreeTraversal(result, _Root);
            }

            return result;
        }

        private void _TreeTraversal(List<Tuple<string, int>> result, TreeNode current)
        {
            if (current.Left != null)
                _TreeTraversal(result, current.Left);

            result.Add(new Tuple<string, int>(current.Identifier, current.Number));

            if (current.Right != null)
                _TreeTraversal(result, current.Right);
        }
    }
}
