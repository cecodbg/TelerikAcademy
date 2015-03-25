namespace Generic
{
    using System;

    public class GenericList<T> where T : IComparable<T>
    {
        private const int CapacityDefault = 4;

        private T[] elements;

        public GenericList()
            : this(CapacityDefault)
        {
        }

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
            this.Index = 0;
            this.Capacity = capacity;
        }

        public int Capacity { get; private set; }

        public int Index { get; private set; }

        public T this[int indexer]
        {
            get
            {
                return this.elements[indexer];
            }

            private set
            {
                if (indexer < 0 || indexer > this.elements.Length)
                {
                    throw new IndexOutOfRangeException();   
                }

                this.elements[indexer] = value;
            }
        }

        public void AddElement(T element)
        {
            if (this.Index >= this.elements.Length)
            {
                this.DoubleCapacity();
            }

            this.elements[this.Index] = element;
            this.Index++;
        }

        public void Clear()
        {
            this.elements = new T[CapacityDefault];
            this.Index = 0;
            this.Capacity = CapacityDefault;
        }

        public T Min()
        {
            T min = this.elements[0];

            for (int i = 0; i < this.Index; i++)
            {
                if (this.elements[i].CompareTo(min) <= 0)
                {
                    min = this.elements[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.elements[0];

            for (int i = 0; i < this.Index; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            return string.Join(", ", this.elements);
        }

        private void DoubleCapacity()
        {
            int newCapacity = this.elements.Length * 2;
            T[] newElements = new T[newCapacity];

            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
            this.Capacity = newCapacity;
        }
    }
}
