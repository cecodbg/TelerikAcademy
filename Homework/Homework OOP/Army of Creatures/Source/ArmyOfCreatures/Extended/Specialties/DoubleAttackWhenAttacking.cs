namespace ArmyOfCreatures
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    class DoubleAttackWhenAttacking : Specialty
    {
        private int numberOfRound;

        public DoubleAttackWhenAttacking(int numberOfRound)
        {
            this.NumberOfRound = numberOfRound;
        }

        public int NumberOfRound
        {
            get
            {
                return this.numberOfRound;
            }

            private set
            {
                if (value < 0 || value == null)
                {
                    throw new ArgumentNullException("This value cannot be null or negative!");
                }

                this.numberOfRound = value;
            }
        }

        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
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
                return;
            }

            attackerWithSpecialty.CurrentAttack *= 2;
            this.NumberOfRound--;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.NumberOfRound);
        }

    }
}
