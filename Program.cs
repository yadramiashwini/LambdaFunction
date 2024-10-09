namespace LambdaFunction
{

   
        public class lambdaFunction
        {
            public delegate string PrintDelegate(string name);     //declaring delegate function

            static void Main(string[] args)
            {

            PrintDelegate p = name => { return name; };              //lamdba expression object using delegate function
            
                string str = p("Ashwini");
                Console.WriteLine("name is:" + str);

            }
        }
    }

