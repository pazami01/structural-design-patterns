namespace Flyweight
{
    public class Code
    {
        private string _code;

        public Code(string code)
        {
            this._code = code;
        }

        public override string ToString()
        {
            return _code;
        }
    }
}