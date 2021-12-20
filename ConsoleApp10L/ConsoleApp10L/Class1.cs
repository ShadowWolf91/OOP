using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10L
{
    class Services
    {
        public int numberots { get; private set; }
        public int cost { get; private set; }
        public string date { get; set; }
        public string nameoftheservic { get; private set; }
        public Services(int numberots_arg = 891, int cost_arg = 1000, string date_arg = "12.10.2021", string nameoftheservic_arg = "Сантехника") => (numberots, cost, date, nameoftheservic) = (numberots_arg, cost_arg, date_arg, nameoftheservic_arg);

        public void Check(int cost_arg, int maxpeople_arg = 2000)
        {
            if (cost_arg > maxpeople_arg)
            {
                throw new ArgumentException("Oversize!");
            }
            else
            {
                Console.WriteLine("No oversize");
            }
        }

        public override string ToString()
        {
            return $"Номер услуги: {numberots}(Цена: {cost}р.); Дата: {date}; Название услуги: {nameoftheservic}";
        }
    }
}
