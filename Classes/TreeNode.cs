namespace Classes
{
    public class TreeNode
    {
        public string Identifier { get; set; }
        public int Number { get; set; }
        public TreeNode? Left { get; set; } = null;
        public TreeNode? Right { get; set; } = null;

        public TreeNode(string identifier, int number)
        {
            Identifier = identifier;
            Number = number;
        }
    }
}
