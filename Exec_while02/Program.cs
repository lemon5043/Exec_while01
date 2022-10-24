using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_while02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//顯示所有可整除300的整數
			int i = 2;
			while (i <= 300)
			{
				if (300 % i == 0)
				{
					Console.WriteLine(i);
				}

				i++;
			}
		}
	}
}
