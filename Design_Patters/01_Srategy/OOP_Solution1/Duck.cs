namespace _01_Srategy.OOP_Solution1
{
    public class Duck
    {
        public string Quack() => "Quack";

        public string Swim() => "I am Swimming";

        public virtual string Display() => "I am Duck";

        //New Functionality
        public  string Fly() => "I am Flying";
    }
}
