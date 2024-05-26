using System;

namespace InsectSimulation
{
    // Base form class
    public class BaseForm
    {
        // Attributes
        public int Size { get; set; }
        public int Hitpoints { get; set; }
        public int Senses { get; set; }
        public int Damage { get; set; }
        public int Resistance { get; set; }
        public int Mobility { get; set; }

        // Methods (lite hjälp från google och chat)
        public virtual int SetSize() => 200;
        public virtual int SetHitpoint() => 500;
        public virtual int SetSenses() => 250;
        public virtual int SetDamage() => 150;
        public virtual int SetResistance() => 50;
        public virtual int SetMobility() => 100;
    }

    // Insect class inheriting from BaseForm
    public class Insect : BaseForm
    {
        // Attributes
        public bool Exoskeleton { get; set; }
        public bool Mandibles { get; set; }

        // Methods
        public bool SetExoskeleton() => true;
        public bool ExoskeletonFunctionality() => Exoskeleton;
        public bool SetMandibles() => true;
    }

    // Lone Insect class inheriting from Insect
    public class LoneInsect : Insect
    {
        // Attributes
        public bool HpRegen { get; set; }
        public bool ThornyLegs { get; set; }

        // Methods
        public bool SootheRegen(bool time)
        {
            if (time)
            {
                HpRegen = true;
                return true;
            }
            return false;
        }

        public void ThornyLegsFunctionality()
        {
            if (ThornyLegs)
            {
                Size = 100;
                SelfReliance();
            }
        }
    }

    // Queen class inheriting from Insect
    public class Queen : Insect
    {
        // Attributes
        public bool Reproduction { get; set; }
        public bool RoyalCry { get; set; }

        // Methods
        public bool SelfReproductionFunction() => Reproduction;

        public void RoyalCryFunctionality()
        {
            if (RoyalCry)
            {
                Size = 50;
                SelfReliance();
                SustenanceEyesight();
                SelfDamage();
            }
        }
    }

    // Main program (Med hjälp från chatGPT)
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            LoneInsect loneInsect = new LoneInsect
            {
                Size = 10,
                Vitality = 100,
                Senses = 50,
                Damage = 25,
                Resistance = 30,
                Mobility = 20,
                Exoskeleton = true,
                Mandibles = true,
                HpRegen = true,
                ThornyLegs = true
            };

            Console.WriteLine("Lone Insect HP Regen: " + loneInsect.SootheRegen(true));
            loneInsect.ThornyLegsFunctionality();
            Console.WriteLine("Lone Insect Size after Thorny Legs Functionality: " + loneInsect.Size);

            Queen queen = new Queen
            {
                Size = 20,
                Vitality = 200,
                Senses = 100,
                Damage = 50,
                Resistance = 60,
                Mobility = 40,
                Exoskeleton = true,
                Mandibles = true,
                Reproduction = true,
                RoyalCry = true
            };

            queen.RoyalCryFunctionality();
            Console.WriteLine("Queen Size after Royal Cry Functionality: " + queen.Size);
        }
    }
}
