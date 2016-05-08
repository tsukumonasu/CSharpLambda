using System;

namespace CSharpLambda
{
	public class ExtendsTest
	{
		public  static void exec ()
		{
			Console.WriteLine("-------------------------");
			new Tank().printParts ();
			Console.WriteLine("-------------------------");
			new LT38 ().printParts ();
			Console.WriteLine("-------------------------");
			new Hetzer ().printParts ();
			Console.WriteLine("-------------------------");
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

		class LT38 : Tank
		{
			public LT38 ()
			{
				this._guns = "Pz.Kpfw 38(t) Ausf. G";
				this._turrets = "4,7 cm Kw.K. 38 (t) L/43";
				this._suspensions = "Pz.Kpfw 38(t) Ausf. E";
			}
		}

		class Hetzer : LT38
		{
			public Hetzer ()
			{
				this._guns = "10.5 cm Stu.H. 42 L/28";
				this._turrets = "ヘッツァー改装キット";
			}
		}

		class Tank : ITank
		{

			protected String _guns;
			protected String _turrets;
			protected String _suspensions;

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

