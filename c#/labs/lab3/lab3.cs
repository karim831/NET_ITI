namespace lab3;

public class Lab3{
    public static void Main(string[] args){

        // Task1 : 
        // task1();
        // -----------------------------------
        //  Task2 : 
        // task2();
        //-------------------------------------
        // Task3 :
        // task3();
        //-------------------------------------
    
    }

    public static void task1(){
        student s1 = new student();
        student s2 = new student();

        
        s1.set_data(id : 1,name : "karim", age :20);
        s2.set_data(id : 2,name : "mohamed", age : 24);
        

        System.Console.WriteLine(s1.get_data() + "\n" + s2.get_data());
        if(s2.got_graduated())
            System.Console.WriteLine("Graduated!");
        else
            System.Console.WriteLine("Student!");
    }

    public static void task2(){
        student2 s1 = new student2(id : 1,name : "karim", age :20);
        student2 s2 = new student2(id : 2,name : "mohamed", age : 24);
        System.Console.WriteLine(s1.get_data() + "\n" + s2.get_data());
        if(s2.got_graduated())
            System.Console.WriteLine("Graduated!");
        else
            System.Console.WriteLine("Student!");
    }


    public static void task3(){
        Book b1 = new Book(id : 1,name : "karim",created_on : new DateTime(2008, 6, 1, 7, 47, 0));
        System.Console.WriteLine(b1.get_data_book() + "\n" + Book.numbers_of_books_bought());
        Book b2 = new Book(id : 2,name : "osama",created_on : new DateTime(2008, 6, 1, 7, 47, 0));
        System.Console.WriteLine(b2.get_data_book() + "\n" + Book.numbers_of_books_bought());

    }
}




