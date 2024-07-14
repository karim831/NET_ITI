namespace Labs;

public class Lab4{
    public static void Main(string [] args){
        // Task1 : username and age
        task1();
        // Task2 : multiblication ecept index
        task2();

    }





    public static void task1(){
        int length;
        System.Console.Write("Enter the number of users : ");
        length = int.Parse(System.Console.ReadLine());

        string [] users_name = new string [length];
        int [] users_age = new int [length];
        string [] tokens;

    
        System.Console.WriteLine("Enter the username and age respectively :");
        for(int i=0;i<length;i++){
            System.Console.Write($"User({i+1}) and his age : ");
            tokens = System.Console.ReadLine().Split();
            users_name[i] = tokens[0];
            users_age[i] = int.Parse(tokens[1]);
        }


        System.Console.Write("Enter the number of user you want his data : ");
        int number = int.Parse(System.Console.ReadLine());
        while(number <= 0 || number > length){
            System.Console.Write("Enter a valid number : ");
            number  = int.Parse(System.Console.ReadLine());
        }

        System.Console.WriteLine(
            $"username is {users_name[number-1]}\n"+
            $"age is {users_age[number-1]}"
        );
    }


    public static void task2(){
        System.Console.WriteLine("Enter array of integer in format with , between numbers : ");
        string [] tokens = System.Console.ReadLine().Split(',');
        List<int> numbers = new List<int>();
        int mul = 1;
        foreach(string token in tokens){
            numbers.Add(int.Parse(token));
            mul *= int.Parse(token);
        }

        int size = numbers.Count();

        System.Console.Write('[');
        for(int i=0;i<size;i++){
            System.Console.Write(mul/numbers[i] + "" +(i != size-1 ? ", " : ']'));
        }
    }



}
