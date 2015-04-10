namespace ArmyOfCreatures
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    public class AddAttackWhenSkip : Specialty
    {
        private int attackPoints;

        public AddAttackWhenSkip(int attackPoints)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }

            private set
            {
                if (value <= 0 || value >= 10)
                {
                    throw new ArgumentOutOfRangeException("This value must be between 1 and 10!");
                }

                this.attackPoints = value;
            }
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature cannot be null");
            }

            skipCreature.PermanentAttack += this.AttackPoints;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.AttackPoints);
        }
    }
}
