using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.ReadLine();
        }

        void Radius()
        {
            double radius = 1.23;

            Aresto(radius);
        }

        private static void Aresto(double radius)
        {
            double area = Math.PI * radius * radius;
        }

        public ActionResult ShipProduct(IProduct prod, int qty, ShippingUrgency urg, ShippingMethod meth)
        {
            IShippingStrategy sStrat = new OriginalShip();
            switch (meth)
            {
                case ShippingMethod.USPS:
                    sStrat = new USPSShip();
                    break;
                case ShippingMethod.FedEx:
                    sStrat = new FedexShip();
                    break;
                    //…другие способы доставки…
            }
            decimal shipCost = CalcShipCost(prod, qty, urg, sStrat);

            ShipAcceptModel model = new ShipAcceptModel();
            model.ShipCost = shipCost;
            return View(model);
        }

        private ActionResult View(ShipAcceptModel model)
        {
            throw new NotImplementedException();
        }

        private decimal CalcShipCost(IProduct prod, int qty, ShippingUrgency urg, IShippingStrategy sStrat)
        {
            throw new NotImplementedException();
        }

        static public (int, int) FirstPosition(int figure, int rotate)
        {
            int x = 0;
            int y = 0;
            if ((figure == 1) && (rotate == 1)) { x = 6; y = 2; }
            if ((figure == 1) && (rotate == 2)) { x = 6; y = 3; }
            if ((figure == 2) && (rotate == 1)) { x = 6; y = 2; }
            if ((figure == 2) && (rotate == 2)) { x = 6; y = 3; }
            if ((figure == 3) && (rotate == 1)) { x = 6; y = 2; }
            if ((figure == 3) && (rotate == 2)) { x = 6; y = 3; }
            if ((figure == 4) && (rotate == 1)) { x = 6; y = 2; }
            if ((figure == 4) && (rotate == 2)) { x = 6; y = 2; }
            if ((figure == 4) && (rotate == 3)) { x = 6; y = 2; }
            if ((figure == 4) && (rotate == 4)) { x = 6; y = 3; }
            if ((figure == 5) && (rotate == 1)) { x = 6; y = 2; }
            if ((figure == 5) && (rotate == 2)) { x = 6; y = 3; }
            if ((figure == 5) && (rotate == 3)) { x = 6; y = 2; }
            if ((figure == 5) && (rotate == 4)) { x = 6; y = 2; }
            if ((figure == 6) && (rotate == 1)) { x = 6; y = 3; }
            if ((figure == 6) && (rotate == 2)) { x = 6; y = 2; }
            if ((figure == 6) && (rotate == 3)) { x = 6; y = 2; }
            if ((figure == 6) && (rotate == 4)) { x = 6; y = 2; }
            if ((figure == 7) && (rotate == 1)) { x = 6; y = 3; }
            return (x, y);
        }                           //НАЧАЛЬНАЯ ПОЗИЦИЯ ЦЕНТРА ФИГУРЫ
        static public int[,] Position(int figure, int rotate, int[,] a, int x, int y)
        {
            if ((figure == 1) && (rotate == 1)) { a[x, y - 2] = 1; a[x, y - 1] = 1; a[x, y] = 1; a[x, y + 1] = 1; }
            if ((figure == 1) && (rotate == 2)) { a[x - 1, y] = 1; a[x, y] = 1; a[x + 1, y] = 1; a[x + 2, y] = 1; }
            if ((figure == 2) && (rotate == 1)) { a[x - 1, y - 1] = 1; a[x - 1, y] = 1; a[x, y] = 1; a[x, y + 1] = 1; }
            if ((figure == 2) && (rotate == 2)) { a[x - 1, y] = 1; a[x, y] = 1; a[x, y - 1] = 1; a[x + 1, y - 1] = 1; }
            if ((figure == 3) && (rotate == 1)) { a[x + 1, y - 1] = 1; a[x + 1, y] = 1; a[x, y] = 1; a[x, y + 1] = 1; }
            if ((figure == 3) && (rotate == 2)) { a[x - 1, y - 1] = 1; a[x, y - 1] = 1; a[x, y] = 1; a[x + 1, y] = 1; }
            if ((figure == 4) && (rotate == 1)) { a[x, y - 1] = 1; a[x, y] = 1; a[x, y + 1] = 1; a[x + 1, y + 1] = 1; }
            if ((figure == 4) && (rotate == 2)) { a[x + 1, y] = 1; a[x, y] = 1; a[x - 1, y] = 1; a[x - 1, y + 1] = 1; }
            if ((figure == 4) && (rotate == 3)) { a[x - 1, y - 1] = 1; a[x, y - 1] = 1; a[x, y] = 1; a[x, y + 1] = 1; }
            if ((figure == 4) && (rotate == 4)) { a[x - 1, y] = 1; a[x, y] = 1; a[x + 1, y] = 1; a[x + 1, y - 1] = 1; }
            if ((figure == 5) && (rotate == 1)) { a[x, y - 1] = 1; a[x, y] = 1; a[x, y + 1] = 1; a[x - 1, y + 1] = 1; }
            if ((figure == 5) && (rotate == 2)) { a[x - 1, y - 1] = 1; a[x - 1, y] = 1; a[x, y] = 1; a[x + 1, y] = 1; }
            if ((figure == 5) && (rotate == 3)) { a[x + 1, y - 1] = 1; a[x, y - 1] = 1; a[x, y] = 1; a[x, y + 1] = 1; }
            if ((figure == 5) && (rotate == 4)) { a[x - 1, y] = 1; a[x, y] = 1; a[x + 1, y] = 1; a[x + 1, y + 1] = 1; }
            if ((figure == 6) && (rotate == 1)) { a[x, y] = 1; a[x, y - 1] = 1; a[x - 1, y] = 1; a[x + 1, y] = 1; }
            if ((figure == 6) && (rotate == 2)) { a[x, y - 1] = 1; a[x + 1, y] = 1; a[x, y + 1] = 1; a[x, y] = 1; }
            if ((figure == 6) && (rotate == 3)) { a[x - 1, y] = 1; a[x, y + 1] = 1; a[x + 1, y] = 1; a[x, y] = 1; }
            if ((figure == 6) && (rotate == 4)) { a[x, y - 1] = 1; a[x - 1, y] = 1; a[x, y + 1] = 1; a[x, y] = 1; }
            if ((figure == 7) && (rotate == 1)) { a[x, y] = 1; a[x + 1, y] = 1; a[x + 1, y - 1] = 1; a[x, y - 1] = 1; }
            return (a);
        }


        private void Method()
        {
            throw new Exception(nameof(Method));
        }


    }
}

namespace ConsoleApp2
{
    enum ShippingMethod
    {
        USPS,
        FedEx
    }
}