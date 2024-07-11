namespace lab2;
public class Task
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("\t\t -- Multiplication_table --\n");
        multi_table();
        System.Console.WriteLine("------------------------------------------------------");
        // ----------------------------------------


        System.Console.WriteLine("\t\t -- Employee_age --\n");
        employee_data();
        System.Console.WriteLine("------------------------------------------------------");
        // ----------------------------------------


        System.Console.WriteLine("\t\t -- Instances --\n");
        Student st = new Student(1,"karim",15,"01012423");
        System.Console.WriteLine(st.ssn + " " + st.name + " " + st.age + " " + st.phone);
        System.Console.WriteLine("------------------------------------------------------"); 
        
    }


    public static void employee_data(){
        System.Console.WriteLine("Enter Your data id,name,age resp: ");
        string [] tokens = System.Console.ReadLine().Split();
        int id = int.Parse(tokens[0]),age = int.Parse(tokens[2]);
        string name = tokens[1];

        while(age <= 0){
            System.Console.WriteLine("INVALID_AGE");
            age = int.Parse(System.Console.ReadLine());
        }
        
        System.Console.WriteLine(
            $"id : {id}\n" +
            $"name : {name}\n"+
            $"age : {age}\n" 
        );
    }



    public static void multi_table()
    {
        System.Console.Write("Enter the number : ");

        int num = int.Parse(System.Console.ReadLine());

        for (int i = 0; i <= 12; i++)
            System.Console.WriteLine($"multibly by {i} = " + num * i);
    }
}

class Student{
    public int ssn,age;
    public string name,phone;
    public Student(int ssn,string name,int age,string phone){
        this.ssn = ssn;
        this.name = name;
        this.age = age;
        this.phone = phone;
    }
}



