using System.Reflection;

namespace Re_str.restr.token
{
    public class AliasToken : Token
    {

        public AliasToken() : base("([a-zA-Z])+:") {}

        public override void Compile(string str, RestrFile restrFile)
        {
            string aliasName = str.Split(':')[0].Trim();
            int startIndex = str.IndexOf('"') + 1;
            int endIndex = str.LastIndexOf('"');
            string aliasValue = str.Substring(startIndex , endIndex - startIndex);
            restrFile._CompalingObject.Aliases.Add(aliasName, aliasValue);
        }
    }
}