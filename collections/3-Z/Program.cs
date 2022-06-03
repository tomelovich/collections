using System;
using System.Collections;
using System.Collections.Generic;

namespace _3_Z
{
    class Sport
    {
        public string w;
        public string g;
        public Sport(string w, string g)
        {
            this.w = w;
            this.g = g;
        }
        virtual public void PrintSport()
        {
            Console.WriteLine(g + ": раунд " +w);
        }
    }
    class GameScore : Sport
    {
        string score;
        public GameScore(string w, string g, string score): base(w, g)
        {
            this.score = score;
        }
        override public void PrintSport()
        {

            Console.WriteLine("Спорт - "+ g + "; раунд- " +w + "; счёт- " +score);
        }
    }
    class InfoObj
    {
        public static void Info<tip>(tip obj)
        where tip : Sport
        {
            obj.PrintSport();
        }
    }
    class Weth : IEnumerable
    {
        private ArrayList list;
        public Weth()
        {
            list = new ArrayList();
        }
        public Weth(ArrayList a)
        {
            list = a;
        }
        public void Add(GameScore m)
        {
            list.Add(m);
        }
        public Weth Clone()
        {
            return new Weth(list);
        }
        public void RemoveAt(int i)
        {
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- ");
            GameScore dem = new GameScore(" (Номер раунда) ","(Вид спорта) ", "(Счёт (пример- 3:1))");
            InfoObj.Info<GameScore> (dem);
            Console.WriteLine("--------------- ");
            Weth WethList = new Weth();
            Dictionary <int, string> KindOfSport = new Dictionary <int, string> (3);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите раунд");
                string w = Console.ReadLine();
                Console.WriteLine("Введите название спорта");
                string g = Console.ReadLine();
                Console.WriteLine("Введите счёт:");
                string t = Console.ReadLine();
                WethList.Add(new GameScore(w, g, t));

                KindOfSport[i + 1] = g;
            }
        Console.WriteLine("--------------");
        foreach (KeyValuePair <int, string> keyValue in KindOfSport)
        {
            Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
        }
        Console.WriteLine("--------------");
        Console.WriteLine("Введите номер элемента для удаления:");
        int numb = Convert.ToInt32(Console.ReadLine());
        foreach (GameScore x in WethList)
            x.PrintSport();
            WethList.RemoveAt(numb-1);
            Console.WriteLine("============");
            Weth cl = (Weth)WethList.Clone();
            foreach (GameScore x in cl) x.PrintSport();
                Console.ReadLine();
        }
    }
}

