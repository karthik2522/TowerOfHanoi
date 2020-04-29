using System;
using System.Collections;
namespace TowerofHanoi
{
	class Program
	{
		static readonly Stack A = new Stack();
		static readonly Stack B = new Stack();
		static readonly Stack C = new Stack();

		static void Main(string[] args )
		{
			A.Push(4);
			A.Push(3);
			A.Push(2);
			A.Push(1);
			PrintStacks();
			Move(4, A, C, B);

			Console.ReadLine();
		}
		public static void Move(int num, Stack from, Stack to, Stack interchange)
		{
			if (num > 0)
			{
				Move(num - 1, from, interchange, to);
				Movedisc(from, to);
				Move(num - 1, interchange, to, from);
			}
		}

		public static void Movedisc(Stack from, Stack to)
		{
			var temp = from.Pop();
			to.Push(temp);
			PrintStacks();
		}
		public static void PrintStacks()
		{
			Console.Write("A: ");
			foreach (var item in A)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.Write("B: ");
			foreach (var item in B)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.Write("C: ");
			foreach (var item in C)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine("\n");
		}
	}
}
