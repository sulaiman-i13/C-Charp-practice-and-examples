using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Attributes
{
	[DebuggerDisplay("no: {_no}, title: {_title}")]
	internal class Update
	{
		
		
			private readonly int _no;
			private readonly string _title;
			public Update(int no, string title)
			{
				_no = no; _title = title;
			}
		
	}
}
