using System;
using System.Windows.Forms;

namespace Pr11_12_WF
{
	class Money
	{
		private int _face_value;
		private int _number;
		public Money()
		{
			_face_value = 0;
			_number = 0;
		}
		public Money(int face_value, int number)
		{
			_face_value = face_value;
			_number = number;
		}
		public void input(TextBox face_value_box, TextBox number_box)
		{
			_face_value = Convert.ToInt32(face_value_box.Text);
			_number = Convert.ToInt32(number_box.Text);
		}
		public bool enough_money(double price)
		{
			if ((double)_face_value * (double)_number >= price)
			{
				return true;
			}
			else
			{
				
				return false;
			}
		}
		public int how_much(double price) => (int)((double)_face_value * (double)_number / price);
		public int face_value_
		{
			get => _face_value;
			set => _face_value = value;
		}

		public int number_of_
		{
			get => _number;
			set => _number = value;
		}
		public int TotalCash
		{
			get => _number * _face_value;
		}
		int this[int index]
		{
			set
			{
				if (index == 0) _face_value = value;
				else
				{
					if (index == 1) _number = value;
					else throw new Exception("Индекс находится за пределами допустимых значений");
				}
			}
			get
			{
				if (index == 0) return _face_value;
				else
				{
					if (index == 1) return _number;
					else throw new Exception("Индекс находится за пределами допустимых значений");
				}
			}
		}
		public static Money operator ++(Money cash)
		{
			cash._face_value++;
			cash._number++;
			return cash;
		}
		public static Money operator --(Money cash)
		{
			cash._face_value--;
			cash._number--;
			return cash;
		}
		public static bool operator !(Money cash)
		{
			if (cash._number != 0) return true;
			else return false;
		}
		public static int operator +(Money cash, int scalar)
		{
			return cash._number + scalar;
		}
		public override string ToString()
		{
			return $"У Вас есть {this._number} купюр номиналом {this._face_value}";
		}
		public void ToMoney(string str)
		{
			string[] buf = str.Trim().Split(' ');
			this[0] = Convert.ToInt32(buf[0]);
			this[1] = Convert.ToInt32(buf[1]);

		}
	}
}
