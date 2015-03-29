namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Teachers : People
    {
        private List<Disciplines> discipline;

        public Teachers(string name)
            : base(name)
        {
            this.Discipline = new List<Disciplines>(discipline);
        }

        public List<Disciplines> Discipline
        {
            get
            {
                return new List<Disciplines>(this.discipline);
            }

            private set
            {
                this.discipline = value;
            }
        }
    }
}
