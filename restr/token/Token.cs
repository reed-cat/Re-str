using System.Collections.Generic;
namespace Re_str.restr.token
{
    public class Token
    {
        
        private static List<Token> _tokens = new List<Token>();
        public static bool Initialized { get; set; } = false;
        public static void Setup()
        {
            _tokens.Clear();
            _tokens.Add(new AliasToken());
            _tokens.Add(new EndToken());
            _tokens.Add(new ObjectStartToken());
            _tokens.Add(new ObjectEndToken());
            _tokens.Add(new StartToken());
            _tokens.Add(new EndToken());
            Initialized = true;
        }
        
        public string Regex { get; }

        public Token(string _regex)
        {
            Regex = _regex;
        }

        public virtual void Compile(string str, RestrFile restrFile)
        { }

        public static Token GetToken(string line)
        {
            foreach (var token in _tokens)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(line, token.Regex))
                {
                    return token;
                }
            }

            return null;
        }

    }
}