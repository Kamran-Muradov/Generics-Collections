namespace Generics
{
    public class IntList
    {
        private int[] _intArray;

        public IntList()
        {
            _intArray = Array.Empty<int>();
        }

        public void Add(int num)
        {
            Array.Resize(ref _intArray, _intArray.Length + 1);
            _intArray[_intArray.Length - 1] = num;
        }

        public int[] GetAll()
        {
            return _intArray;
        }
    }
}
