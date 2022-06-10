using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatarCompear
{
    public class Teatar : IPrint, IComparable<Teatar>
    {
        private string name;
        private string grad;
        private int count;
        private double price;
        public string Name
        {
            get { return name;}
            set { name = value; }
        }
        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Teatar(string name,string grad,int count,double price)
        {
            this.name = name;
            this.grad = grad;
            this.count = count;
            this.price = price;
        }

        public int CompareTo(Teatar teatar)
        {
            return this.name.CompareTo(teatar.name);
        }

        public  string Print()
        {
            return $"Teatar {this.name} from {this.grad}" +
                $"  {this.count} {this.price}";
        }
    }
}
