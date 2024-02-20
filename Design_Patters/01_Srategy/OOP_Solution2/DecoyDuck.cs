namespace _01_Srategy.OOP_Solution2
{
    class DecoyDuck : Duck
    {
        public override string Display() => "I am Decoy Duck";
        public override string Fly() => "I can't Fly";

        // Wooden Duck does not sounds at all!
        public override string Quack() => "MUTE!";
    }
}
