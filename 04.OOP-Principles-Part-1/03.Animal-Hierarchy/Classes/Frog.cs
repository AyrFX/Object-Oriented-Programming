namespace Animal_Hierarchy.Classes
{
    public class Frog : Animal
    {
        public Frog(string name, Sex sex, int age)
            : base(name, sex, age)
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine(this.Name + " is croaking.");
        }
    }
}
