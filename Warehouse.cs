using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualTaskThree
{
    internal class Warehouse
    {
        private string name;
        private uint price;
        private uint amount;
        private string manufactureDate;
        private string description;

        public string Name { get; set; }
        public uint Price { get; set; }
        public uint Amount { get; set; }
        public string ManufactureDate { get; set; }
        public string Description { get; set; }

        public Warehouse() {}

        public Warehouse(string name)
        {
            Name = name;
        }

        public Warehouse(string name, uint price)
        {
            Name = name;
            Price = price;
        }

        public Warehouse(string name, uint price, uint amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public Warehouse(string name, uint price, uint amount, string manifactureDate)
        {
            Name = name;
            Price = price;
            Amount = amount;
            ManufactureDate = manifactureDate;
        }

        public Warehouse(string name, uint price, uint amount, string manifactureDate, string description)
        {
            Name = name;
            Price = price;
            Amount = amount;
            ManufactureDate = manifactureDate;
            Description = description;
        }

        public void DeleteObject(Warehouse item)
        {
            item.Name = null;
            item.Name = null;
            item.Price = 0u;
            item.Amount = 0u;
            item.ManufactureDate = null;
            item.Description = null;
        }

        public double GetQuality(uint price, uint amount)
        {
            double quality = 0;

            quality = (double) price / amount;

            return quality;
        }

        public string GetInfo()
        {
            return $"Название: {Name}\nЦена: {Price}\nКоличество: {Amount}\nДата изготовления: {ManufactureDate}\nОписание: {Description}";
        }


    }
}
