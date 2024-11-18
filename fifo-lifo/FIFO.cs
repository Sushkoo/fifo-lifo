using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifo_lifo
{
    internal class FIFO
    {
        private double[] array;
        private int front;
        private int rear;
        private int size;
        private int capacity;

        public FIFO()
        {
            capacity = 50;
            array = new double[capacity];
            front = 0;
            rear = 0;
            size = 0;
        }

        public FIFO(int capacity)
        {
            this.capacity = capacity;
            array = new double[capacity];
            front = 0;
            rear = 0;
            size = 0;
        }

        public void Push(double element)
        {
            if (size == capacity)
            {
                throw new InvalidOperationException("Queue is full.");
            }

            array[rear] = element;
            rear = (rear + 1) % capacity;
            size++;
        }

        public double Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            double value = array[front];
            front = (front + 1) % capacity;
            size--;
            return value;
        }

        public void Clear()
        {
            front = 0;
            rear = 0;
            size = 0;
        }

        public int Length()
        {
            return size;
        }

        public int GetSize()
        {
            return capacity;
        }
    }
}
