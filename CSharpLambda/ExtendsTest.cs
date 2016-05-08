using System;

namespace CSharpLambda
{
	public class ExtendsTest
	{
		public  static void exec ()
		{
			new Tank().printParts();
		}

		interface ITank
		{
			String guns {
				get;
				set;
			}

			String turrets {
				get;
				set;
			}

			String suspensions {
				get;
				set;
			}
			void printParts();
		}

		class Tank : ITank
		{

			private String _guns;
			private String _turrets;
			private String _suspensions;

			public void printParts ()
			{
				Console.WriteLine("砲は{0}",this._guns);
				Console.WriteLine("砲塔は{0}", this._turrets);
				Console.WriteLine("履帯は{0}",this._suspensions);
			}

			public Tank ()
			{
				this._guns = "なし";
				this._turrets = "なし";
				this._suspensions = "なし";
			}

			public string guns {
				get {
					return _guns;
				}
				set {
					_guns = value;
				}
			}

			public string turrets {
				get {
					return _turrets;
				}
				set {
					_turrets = value;
				}
			}

			public string suspensions {
				get {
					return _suspensions;
				}
				set {
					_suspensions = value;
				}
			}
		}
	}
}

