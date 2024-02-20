namespace _01_Srategy.OOP_Solution3
{
    class ReubberDuck : Duck, Quackable
    {
        public override string Display() => "I am Reubber Duck";
        public string Quack() => "Squeak";
    }
}
