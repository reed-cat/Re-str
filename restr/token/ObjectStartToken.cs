using Re_str.restr.obj;

namespace Re_str.restr.token
{
    public class ObjectStartToken : Token
    {

        public ObjectStartToken() : base("\\w*[(]")
        {
        }

        public override void Compile(string str, RestrFile restrFile)
        {
            RestrObject restObject = new RestrObject(str.Substring(0, str.LastIndexOf('(')));
            restrFile.RestrObjects.Add(restObject.Name, restObject);
            restrFile._CompalingObject = restObject;
        }
    }
}