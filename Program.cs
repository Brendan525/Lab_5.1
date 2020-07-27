using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_5._1
{

    class GameCharacter
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }

        public GameCharacter(string thename, int theintelligence, int thestrength)
        {
            name = thename;
            strength = thestrength;
            intelligence = theintelligence;
        }

        public virtual void Play()
        {
            Console.WriteLine();
        }
    }


    class MagicUsingCharacter : GameCharacter
    {
        public int magicalEnergy { get; set; }

        public MagicUsingCharacter(string thename, int theintelligence, int thestrength, int themagicalenergy) : base(thename, theintelligence, thestrength)
        {
            magicalEnergy = themagicalenergy;
        }

        public override void Play()
        {
            Console.WriteLine($"{name} (int {intelligence}, strength {strength}, {magicalEnergy})");
        }
    }

    class Wizard : MagicUsingCharacter
    {
        public int spellNumber { get; set; }

        public Wizard(string thename, int theintelligence, int thestrength, int themagicalenergy, int thespellnumber) : base(thename, theintelligence,  thestrength, themagicalenergy)
        {
            spellNumber = thespellnumber;
        }
        public override void Play()
        {
            Console.WriteLine($"{name} (int {intelligence}, strength {strength}, magic {magicalEnergy}) {spellNumber} spells");
        }
    }

    class Warrior : GameCharacter
    {
        public string weaponType { get; set; }

        public Warrior(string thename, int theintelligence, int thestrength, string theweapontype) : base(thename, theintelligence, thestrength)
        {
            weaponType = theweapontype;
        }

        public override void Play()
        {
            Console.WriteLine($"{name} (int {intelligence}, strength {strength}) {weaponType}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> characterList = new List<GameCharacter>();

            characterList.Add(new Warrior("Tnarg the Barbarian", 9, 16, "Axe"));
            characterList.Add(new Warrior("Kincaid the Fighter", 16, 15, "Longsword"));
            characterList.Add(new Warrior("Grant the Viking", 16, 15, "Spear"));
            characterList.Add(new Wizard("Lady Witherell the Wizard", 18, 11, 10, 5));
            characterList.Add(new Wizard("Peral the Magician", 17, 12, 9, 4));

            Console.WriteLine("Welcome to World of Dev.Buildcraft!");
            Console.WriteLine();

            foreach (GameCharacter character in characterList)
            {
                Console.WriteLine();
                character.Play();
            }

        }
    }
}
