namespace _01_Srategy.OOP_Solution2
{
    class ReubberDuck : Duck
    {
        public override string Display() => "I am Reubber Duck";
        public override string Fly() => "I can't Fly";

        //Even more!
        public override string Quack() => "Squeak";
    }
}
