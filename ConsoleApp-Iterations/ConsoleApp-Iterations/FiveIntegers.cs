using System.Collections;

class FiveIntegers : IEnumerable
{
	private int[] _values;

	public FiveIntegers(int[] values)
	{
		_values = values;
	}

	public IEnumerator GetEnumerator()
	{
		//the easy way
		//foreach (var item in _fiveIntegers)
		//{
		//	yield return item;
		//}
		return new Enumertator(this);
	}

	class Enumertator : IEnumerator
	{
		private readonly FiveIntegers _fiveIntegers;
		private int currentIndex = -1;
		public Enumertator(FiveIntegers fiveIntegers)
		{
			_fiveIntegers = fiveIntegers;
		}
		public object Current
		{
			get
			{
				if (currentIndex == -1) { throw new InvalidOperationException(); }
				if (currentIndex == _fiveIntegers._values.Length) { throw new InvalidOperationException(); }
				return _fiveIntegers._values[currentIndex];
			}
		}

		public bool MoveNext()
		{
			if(currentIndex >=_fiveIntegers._values.Length-1) { return false; }
			return ++currentIndex<_fiveIntegers._values.Length;
		}

		public void Reset()
		{
			currentIndex = -1;
		}
	}
}