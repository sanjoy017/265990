using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator.Model
{
    class Refrigeartor
    {
        Refrigeartor()
        {

        }
        double weight=0;
        //double rWeight = 0;
        public  double MaximumWeight { get; set; }
        public  double WeightUnit { get; set; }

        public Refrigeartor(double maximumWeight)
        {
            this.MaximumWeight = maximumWeight;
        }

        

        public double CurrentWeight(double iweight)
        {
            this.weight += iweight;
            MaximumWeight -= iweight;
            return weight;

        }

        public double RemainingWeight()
        {
            return this.MaximumWeight;

        }

    }
}
