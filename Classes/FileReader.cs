using System.Text.RegularExpressions;

namespace Classes
{
    public class FileReader
    {
        private static readonly HashSet<string> ExcludeList = new HashSet<string>() 
        { 
            "int", "double", "float", "short", "unsigned", "string", "long", "include", "return", "void"
        };

        public async Task<BinaryTree> ReadFile(string file)
        {
            BinaryTree result = new BinaryTree();

            using FileStream stream = File.OpenRead(file);
            using StreamReader reader = new StreamReader(stream);

            Regex regex = new Regex("(<\\s*[a-zA-Z_0-9]+\\s*>)|(\\\"\\s*[a-zA-Z_0-9]+\\s*\\\")|([a-zA-Z_0-9]+::)|([a-zA-Z_0-9]+)");

            while (!reader.EndOfStream)
            {
                string line = (await reader.ReadLineAsync())!;
                
                var matches = regex.Matches(line);
                
                foreach(var m in matches)
                {
                    Match match = (Match)m;
                    string value = match.Value;

                    if (value.StartsWith('\"') || char.IsNumber(value[0]) || value[0] == '<' || value.EndsWith("::"))
                        continue;

                    if (!ExcludeList.Contains(value))
                        result.AddIdentifier(value);
                }
            }

            return result;
        }
    }
}
