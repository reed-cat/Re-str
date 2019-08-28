namespace Re_str.restr.token
{
    public class StartToken : Token
    {
        public StartToken() : base("&>")
        {
        }

        public override void Compile(string str, RestrFile restrFile)
        {
            restrFile.Reading = true;
        }
    }
}