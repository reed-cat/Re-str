namespace Re_str.restr.token
{
    public class ObjectEndToken : Token
    {

        public ObjectEndToken() : base("[)]*([)])$")
        {}

        public override void Compile(string str, RestrFile restrFile)
        {
            restrFile._CompalingObject = null;
        }
    }
}