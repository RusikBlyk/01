using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3 {
	class Program{


		static void Main (string[] args) {
			int speed = 1;
			int distance =20;
			int time = 0;
			while (distance>=0)//16;11;5;
			{
				distance -= speed;//16-5=11;11-6=5;5-7=-2;
				speed++;//6;7;8;
				time++;//1;2;3;

			}
			Console.WriteLine(time);
			Console.Read ();
		}

	}
}

