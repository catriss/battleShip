using System;
using System.Collections.Generic;

namespace battleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            byte shipOneAmount, shipTwoAmount, shipThreeAmount;
            Console.WriteLine("Podaj rozmiar x tablicy");
            byte x = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Podaj rozmiar y tablicy");
            byte y = Convert.ToByte(Console.ReadLine());
            Board board = new Board(x,y);

            Console.WriteLine("Podaj ilość statków jednomasztowych");
            shipOneAmount = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Podaj ilość statków dwumasztowych");
            shipTwoAmount = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Podaj ilość statków trójmasztowych");
            shipThreeAmount = Convert.ToByte(Console.ReadLine());
            List<Ship> ShipList=new List<Ship>();

            createShips(shipOneAmount, 1, ShipList);
            createShips(shipTwoAmount, 2, ShipList);
            createShips(shipThreeAmount, 3, ShipList);
                       
        }


        public static void createShips(byte shipType,byte lives,List<Ship>ShipList)
        {
            for (int i = 0; i < shipType; i++)
            {
                Ship newShip = new Ship(lives);
                ShipList.Add(newShip);
            }
        }

        public void locateShips(Ship ship)
        {
            byte xRand;
            byte yRand;
            
        }
    }

}


