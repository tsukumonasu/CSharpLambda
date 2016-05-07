using System;

namespace CSharpLambda
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// ジェネリックなデリゲートの型 fibを定義
			Func<int, int> fib = null;
			// 三項演算子でdelegateを再定義 
			// xが1以下の場合、そのままの値を返す、その他の場合、再帰fib(x-1)とfib(x-2)を足した値を返す
			fib = x => x <= 1 ? x : fib(x - 1) + fib(x - 2);

			for (int i = 1; i <= 30; i++)
			{
				Console.WriteLine("引数{0}={1}", i, fib.Invoke(i));
			}
				
			Func<int, String> fizzbuzz = x =>
			{
				if (x % 15 == 0)
				{
					return "FizzBuzz";
				}
				else if (x % 3 == 0)
				{
					return "Fizz";
				}
				else if (x % 5 == 0)
				{
					return "Buzz";
				}
				else
				{
					return x.ToString();
				}
			};

			for (int i = 1; i <= 30; i++)
			{
				Console.WriteLine("引数{0}={1}", i, fizzbuzz.Invoke(i));
			}
		}
	}
}
