namespace Generics
{
    public class StringList
    {
        private string[] _intArray;

        public StringList()
        {
            _intArray = Array.Empty<string>();
        }

        public void Add(string num)
        {
            Array.Resize(ref _intArray, _intArray.Length + 1);
            _intArray[_intArray.Length - 1] = num;
        }

        public string[] GetAll()
        {
            return _intArray;
        }
    }
}
