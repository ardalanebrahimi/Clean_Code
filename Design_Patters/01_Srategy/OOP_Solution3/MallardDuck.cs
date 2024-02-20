namespace _01_Srategy.OOP_Solution3
{
    class MallardDuck : Duck, Quackable, Flyable
    {
        public override string Display() => "I am Mallard Duck";
        public string Quack() => "Quack";
        public string Fly() => "I am Flying";
    }
}
