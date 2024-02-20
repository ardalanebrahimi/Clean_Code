namespace _01_Srategy.OOP_Solution3
{
    class RedHeadDuck : Duck, Quackable, Flyable
    {
        public override string Display() => "I am RedHead Duck";
        public string Quack() => "Quack";
        public string Fly() => "I am Flying";
    }
}
