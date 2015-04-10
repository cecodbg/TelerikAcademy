namespace ArmyOfCreatures
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    public class DoubleDamage : Specialty
    {
        private int numberOfRound;

        public DoubleDamage(int theNumberOfRounds)
        {
            this.NumberOfRound = theNumberOfRounds;
        }
 
        public int NumberOfRound
        {
            get
            {
                return this.numberOfRound;
            }

            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("This value must be between 1 and 10!");
                }

                this.numberOfRound = value;
            }
        }

        public override decimal ChangeDamageWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender, decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty cannot be null");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender cannot be null");
            }

            if (this.NumberOfRound <= 0)
            {
                // Effect expires after fixed number of rounds
                return currentDamage;
            }

            this.NumberOfRound--;
            return currentDamage * 2;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.NumberOfRound);
        }
    }
}
