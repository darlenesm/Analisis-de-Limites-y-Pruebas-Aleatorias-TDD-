namespace prueba
{
    public class Program
    {

        public static bool Person(string name, string lastn, string age) =>
            name == "Darlene" && lastn == "Sanz" && age == "20" ? true : false;

        
        public  PersonInf()
        {
            string name = "Darlene";
            string lastn = "Sanz";
            int age = 20;
        }

        public static bool length(string name, string lastn, int age)
        {
            if (name.Length < 2 | name.Length > 64)
            {
                return false;
            }
            else
                return true;

            if (lastn.Length < 2 | lastn.Length > 128)
            {
                return false;
            }
            else
                return true;

            if (age < 2 | age > 128)
            {
                return false;
            }
            else
                return true;
        }
    }

 
}
