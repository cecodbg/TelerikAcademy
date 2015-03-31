namespace RangeExceptions
{
    using System;

    class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end)
            : base(string.Format("{0}: Range is from {1} to {2}", message, start, end))
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get
            {
                return this.start;
            }

            private set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }

            private set
            {
                this.end = value;
            }
        }
    }
}
