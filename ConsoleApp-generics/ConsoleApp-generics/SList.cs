using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_generics
{
	public class SList<T>
	{
		private T[] _data;
		public void Add(T item)
		{
			if ((_data?.Length == 0) || (_data is null))
			{
				_data = new T[1]{
				item
			};
			}
			else
			{
				var _newData = new T[_data.Length + 1];
				for (int i = 0; i < _data.Length; i++)
				{
					_newData[i] = _data[i];	

				}
				_newData[_data.Length] = item;
				_data = _newData;

			}
		}
		public void RemoveAt(int position)
		{
			if (position <0||position>=_data.Length)
			{
				return;
			}
			var _newData = new T[_data.Length - 1];
			var index = 0;
			for (int i = 0; i < _data.Length; i++)
			{
				if (i == position) continue;
				_newData[index] = _data[i];
				index++;

			}
			_data = _newData;
		}
		public void Display()
		{
            
			Console.Write("[");
			for (int i = 0; i < _data.Length; i++)
			{
				Console.Write(_data[i]);
				if(i < _data.Length - 1) Console.Write(',');
            }
            Console.Write("]\n");
        }
		public bool IsEmpty => ((_data is null) || (_data?.Length == 0));
		public int Count => _data is null ? 0 : _data.Length;
    }
}
