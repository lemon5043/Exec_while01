using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_while01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1+2+3+...+N <105 N的整數最大值
			//使用公式  N(N+1)/2

			int N = 1;
			while (N * (N + 1) / 2 < 105)
			{
				N++;
			}

			//因為要求的解答為小於，因此N最後要再-1
			Console.WriteLine(N-1);
		}
	}
}
