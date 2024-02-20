namespace _01_Srategy.OOP_Solution2
{
    public class Duck
    {
        public virtual string Quack() => "Quack";

        public string Swim() => "I am Swimming";

        public virtual string Display() => "I am Duck";

        //New Functionality
        public virtual string Fly() => "I am Flying";
    }
}
