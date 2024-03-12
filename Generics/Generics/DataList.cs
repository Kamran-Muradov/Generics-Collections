using System.Collections;

namespace Generics
{
    public class DataList<T>
    {
        private T[] _datas;

        public DataList()
        {
            _datas = Array.Empty<T>();
        }

        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;
        }

        public T[] GetAll()
        {
            return _datas;
        }

        //Generic movzusuna aid sinifde yazdiqlarimin praktikasi ve elave olaraq datalist ucun delete methodu yazmaq.
        public void Delete(T data)
        {
            //var temp = _datas[Array.FindIndex(_datas, m => m.Equals(data))];
            //_datas[Array.FindIndex(_datas, m => m.Equals(data))] = _datas[_datas.Length - 1];
            //_datas[_datas.Length] = temp;

            //Array.Resize(ref _datas, _datas.Length - 1);

            //int foundIndex = Array.IndexOf(_datas, data);

            //if (foundIndex >= 0)
            //{
            //    for (int i = foundIndex; i < _datas.Length - 1; i++)
            //    {
            //        _datas[i] = _datas[i + 1];
            //    }

            //    Array.Resize(ref _datas, _datas.Length - 1);

            //    return true;
            //}

            //return false;

            _datas = _datas.Where(m => !m.Equals(data)).ToArray();
        }
    }
}
