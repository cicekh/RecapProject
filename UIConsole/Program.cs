using Bussiness.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate.InMemory;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Açıklama:" + car.Description);
            }

            Console.WriteLine("araç açıklamaları listelendi.");
        }
    }
}
