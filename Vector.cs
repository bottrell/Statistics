using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{

    //Expectation is that vector will be a series of int32 variables 
    internal class Vector
    {
        private List<int> data = new();

        //Member functions

        //returns the last value of the data set
        public int Size()
        {
            return data.Count;
        }

        //returns the last value in the vector
        public int Pop()
        {
            int lastitem = data[(Size()) - 1];
            data.RemoveAt((Size() - 1));
            return lastitem;
        }

        //adds indicated value to the beginning of the vecotr
        public void Push_back(int input)
        {
            data.Add(input);
        }

        //returns the maximum value of the vector
        public int Max()
        {
            return data.Max();
        }

        //returns the minimum value of the vector
        public int Min()
        {
            return data.Min();
        }

        //returns the average of the vector
        public double Average()
        {
            return data.Average();
        }

        public double Sum()
        {
            double sum = 0;

            foreach (int item in data)
            {
                sum += item;
            }
            return sum;
        }

        //returns the median value of the vector
        public double Median()
        {
            double numEntries = Size();
            return Sum() / numEntries;
        }

        //removes all the data from the vector
        public void Clear()
        {
            data.Clear();
        }

        //sorts the data from smallest to largest
        public void Sort()
        {
            data.Sort();
        }

    }
}
