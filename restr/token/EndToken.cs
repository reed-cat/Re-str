namespace Re_str.restr.token
{
    public class EndToken : Token
    {
        public EndToken() : base("^[&<]*(<)") {}


        public override void Compile(string str, RestrFile restrFile)
        {
            restrFile.Reading = false;
        }
    }
}