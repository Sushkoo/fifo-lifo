using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace fifo_lifo
{
    public class LIFO
    {
        double[] array;
        private int stackPointer;

        public LIFO()
        {
            stackPointer = 0;
            array = new double[50];
        }

        public LIFO(int size)
        {
            stackPointer = 0;
            array = new double[size];
        }

        public void Pop(double element) 
        {
            array[stackPointer] = element;
            if (stackPointer < array.Length)
            {
                 
            }
            else
            {
                throw new Exception("Üres");
            }
        }

        public void Push(double element)
        {
            if (stackPointer < array.Length)
            {
                array[stackPointer++] = element;
            }
            else
            {
                throw new StackOverflowException("SAJÁT : Stack overflow!");
            }
            
        }

        public void Clear(int size)
        {
            stackPointer = 0;
        }

        public int Length()
        {
            int seged = 0;
            for (int i = 0; i < array.Length; i++)
            {
                seged += i;
            }
            return seged;
        }

        public void GetSize()
        {
            array.Count();
        }


    }
}
