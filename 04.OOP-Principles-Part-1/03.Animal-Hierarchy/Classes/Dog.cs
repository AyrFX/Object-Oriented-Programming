namespace Animal_Hierarchy.Classes
{
    public class Dog : Animal
    {
        public Dog(string name, Sex sex, int age) : base(name, sex, age)
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine(this.Name + " is barking.");
        }
    }
}
