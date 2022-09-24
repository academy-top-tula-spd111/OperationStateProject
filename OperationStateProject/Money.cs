using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationStateProject
{
    public class Money
    {
        public int Rub { set; get; }
        public int Cop { set; get; }
        public Money()
        {
            Rub = 0;
            Cop = 0;
        }
        public Money(int rub, int cop)
        {
            Rub = rub;
            Cop = cop;
        }

        public Money Add(Money money)
        {
            return (new Money(Rub + money.Rub, Cop + money.Cop)).Service();
        }

        public static Money operator+(Money money1, Money money2)
        {
            return (new Money(money1.Rub + money2.Rub, money1.Cop + money2.Cop)).Service();
        }

        public static Money operator%(Money money, int procent)
        {
            int p = procent * (money.Rub * 100 + money.Cop) / 100;
            return new Money(p / 100, p % 100);
        }

        public override string ToString()
        {
            return $"{Rub} rub, {Cop} cop";
        }

        public static Money operator++(Money money)
        {
            return new Money(money.Rub + 1, money.Cop).Service();
        }

        public static bool operator>(Money money1, Money money2)
        {
            return money1.Rub * 100 + money1.Cop > money2.Rub * 100 + money2.Cop;
        }

        public static bool operator<(Money money1, Money money2)
        {
            return money1.Rub * 100 + money1.Cop < money2.Rub * 100 + money2.Cop;
        }

        public static bool operator true(Money money)
        {
            return money.Rub * 100 + money.Cop != 0;
        }

        public static bool operator false(Money money)
        {
            return money.Rub * 100 + money.Cop == 0;
        }

        public static implicit operator Money(int number)
        {
            return new Money(0, number).Service();
        }

        public static implicit operator Money(double number)
        {
            int r = (int)number;
            int c = (int)((number - r) * 100);
            return new Money(r, c).Service();
        }

        public static explicit operator int(Money money)
        {
            return money.Rub * 100 + money.Cop;
        }

        Money Service()
        {
            Rub += Cop / 100;
            Cop = Cop % 100;
            return new Money(Rub, Cop);
        }
    }
}
