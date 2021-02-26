using Bussiness.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //in memory çalışmak için
            //InMemoryCarDal_TestMetod(); 

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("Açıklama:" + color.Name);
            }
            //Console.WriteLine(Environment.MachineName+"###"+ Environment.UserDomainName + "###" + Environment.UserName + "###" + Environment.OSVersion + "###" + Environment.Version + "###" + Environment.WorkingSet);
            Console.WriteLine("araç açıklamaları listelendi.");
        }

        private static void InMemoryCarDal_TestMetod()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Açıklama:" + car.Description);
            }
        }
    }
}
