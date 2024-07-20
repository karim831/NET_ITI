namespace linq;

public class Application{
    public static void Main(String[] args){
        // /* Given a list of integers, return the product of all numbers.*/
        // List<int> numbers = new List<int> { 1, 2, 3, 4 };
        // var product = numbers.Aggregate((acc,num) => acc * num);
        // System.Console.WriteLine(product);

        // /* Given a list of strings, return a single string that concatenates all the strings,separated by commas */
        // List<string> words = new List<string> { "apple", "banana","cherry" };
        // var concaten = words.Aggregate((acc,str) => acc+str);
        // System.Console.WriteLine(concaten);

        // /*Given a list of integers, return a list where each element is the square of the
        //     corresponding element in the input list.*/
        // List<int> numbers = new List<int> { 1, 2, 3, 4 };
        // var squares = numbers.Select((number) => number * number);
        // foreach(var square in squares){
        //     System.Console.Write(square+" ");
        // }
        // System.Console.WriteLine();


        // /*Given a list of strings, return a dictionary where the keys are the strings and
        //         the values are the lengths of those strings*/
        // List<string> words = new List<string> { "apple", "banana","cherry" };
        // var dictionaries = words.ToDictionary(key => key,value => value.Length);

        // foreach(var dictionary in dictionaries){
        //     System.Console.WriteLine(dictionary.Key +" "+ dictionary.Value);
        // }

        // /*Given two lists of integers, return a list of integers that are present in both lists*/
        // List<int> list1 = new List<int> { 1, 2, 3, 4 }; List<int> list2 = new List<int> { 3, 4, 5, 6 };
        // var collisions = list1.Intersect(list2);
        // foreach(var collision in collisions){
        //     System.Console.Write(collision +" ");
        // }
        // System.Console.WriteLine();


        /*  You have a list of employees. Return the name of the employee with the highest salary*/
        // List<Employee> employees = new List<Employee> { new Employee("Ali",60000), 
        // new Employee("Ramy", 45000), new Employee("Samy", 80000) };

        // var names = employees.Where((e) => e.Salary == employees.Max((e) => e.Salary)).Select((e) => e.Name);
        // foreach(var name in names){
        //     System.Console.WriteLine($"{name}");
        // }


        /*  You have a list of books. Return a list of books grouped by their authors*/
        // List<Book> books = new List<Book> { new Book("Book1", "Author1"),
        // new Book("Book2", "Author2"), new Book("Book3", "Author1") };

        // var groups = books.GroupBy((b) => b.Author);
        // foreach(var group in groups){
        //     System.Console.WriteLine($"Author {group.Key} :");
        //     foreach(var book in group){
        //         System.Console.WriteLine($"{book.Title}");
        //     }
        // }
        
        // /*  You have a list of sales data. Return the total sales amount for each
        //     salesperson.*/

        // List<Sale> sales = new List<Sale> { new Sale("Ali", 100), new Sale("Ramy", 200), new Sale("Ali", 150)};
        // var groups = sales.GroupBy((sale) => sale.Salesperson);
        // foreach(var group in groups){
        //     System.Console.WriteLine($"{group.Key} : {group.Sum((s) => s.Amount)}");
        // }


        /*  You have a list of students with their scores in different subjects. Return the highest score for each student*/
        // List<StudentScores> scores = new List<StudentScores> { new StudentScores("Ali", "Math", 90),
        //  new StudentScores("Ali", "Science", 85), new StudentScores("Ramy", "Math", 80) };

        // var datas = scores.GroupBy((sc) => sc.Student).Select((g) => 
        // new{Student = g.Key,Highest_score = g.Max((sc) => sc.Score)});

        // foreach(var data in datas){
        //     System.Console.WriteLine($"{data.Student} : {data.Highest_score}");
        // }

        // /*  You have a list of orders with prices. Return the average order price */
        // List<Order> orders = new List<Order> { new Order(101, 50), new Order(102, 200), new Order(103, 150) };
        // var avg = orders.Average((o) => o.Amount);
        // System.Console.WriteLine(avg);

  
        // /*Given a list of integers, return a list of tuples where each tuple contains an
        //     integer and its frequency in the list.*/

        // List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3 };

        // var tuble = numbers.GroupBy(num => num).Select(g => new{Number = g.Key , Freq = g.Count()});
        // System.Console.Write('[');
        // foreach(var element in tuble){
        //     System.Console.Write($"({element.Number},{element.Freq})");
        // }
        // System.Console.WriteLine(']');



        // /*Given a list of strings, return the first string that contains the letter 'e'*/

        //  List<string> words = new List<string> { "cat", "elephant", "dog", "tiger" };

        // System.Console.WriteLine(words.FirstOrDefault((s) => s.Contains('e')) ?? "NO Thing");



        // /* Given a list of integers, return a list of integers where each integer is multiplied by its index */

        // List<int> numbers = new List<int> { 1, 2, 3, 4 };
        // var list = numbers.Select((num,index) => num * index);
        // foreach(var number in list){
        //     System.Console.WriteLine(number);
        // }


        // /* Given a list of strings, return a list of the unique characters in all the strings.*/

        // List<string> words = new List<string> {"apple", "banana" };
        // var list = words.SelectMany((s) => s).GroupBy((c) => c);
        // foreach(var data in list){
        //     System.Console.WriteLine(data.Key);
        // }



        // /* Given a list of integers, return the count of even and odd numbers*/

        // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        // var ev_od = numbers.GroupBy((n) => n%2).Select((g) => g.Count());
        // int even =0 , odd =0;

        // foreach(var data in ev_od )
        //     System.Console.WriteLine(data);



        // /*  You have a list of employees with their departments. Return the department with the most employees. */
        // List<EmployeeD> employees = new List<EmployeeD> { new EmployeeD("Ali","HR"),
        // new EmployeeD("Ramy", "IT"), new EmployeeD("Samy", "HR"), new EmployeeD("Sara", "IT"), new EmployeeD("John", "IT") };

        // System.Console.WriteLine(employees.GroupBy((e) => e.Department)
        // .OrderByDescending((g) => g.Count())
        // .FirstOrDefault()?.Key ?? "NO thing");


        // /*You have a list of products with their categories and prices. 
        // Return the most expensive product in each category.*/
        // List<Product> products = new List<Product> { new Product("Laptop", "Electronics", 1000),
        //     new Product("Phone", "Electronics", 800), new Product("Shirt", "Clothing", 50),
        //     new Product("Pants", "Clothing", 60)
        // };

        // var list = products.GroupBy((p) => p.Category).Select((g) => g.OrderByDescending((p) => p.Price).First());

        // foreach(var product in list){
        //     System.Console.WriteLine($"Name : {product.Name}, Category : {product.Category}, Price : {product.Price}");
        // }
        

        // /*You have a list of students with their grades in different subjects. Return the
        //     average grade for each student. */

        //  List<StudentGrades> grades = new List<StudentGrades> { new StudentGrades("Ali", "Math", 90),
        //         new StudentGrades("Ali", "Science",85), new StudentGrades("Ramy", "Math", 80),
        //         new StudentGrades("Ramy","Science", 70) };


        // var avgs = grades.GroupBy((sg) => sg.Student).Select((g) => g.Average((sg) => sg.Grade));

        // foreach(var avg in avgs){
        //     System.Console.WriteLine(avg);
        // }





        // /* You have a list of transactions with their amounts and dates. Return the total transaction amount for each month*/
        // List<Transaction> transactions = new List<Transaction> { 
        //     new Transaction(new DateTime(2024, 1, 10), 100),
        //     new Transaction(new DateTime(2024, 1, 20), 200),
        //     new Transaction(new DateTime(2024, 2, 5),150)};

        // var amounts = transactions.GroupBy((t) => t.Date.Month).Select(
        //     (g) => new{Month = g.Key , Sum = g.Sum((t) => t.Amount)}
        // );
        // foreach(var amount in amounts){
        //     System.Console.WriteLine($"Month : {amount.Month} , Sum : {amount.Sum}");
        // }




        // /*You have a list of orders with their order dates and amounts. Return the order
        //     amounts for the last 7 days */


        //     List<Order1> orders = new List<Order1> { 
        //         new Order1(new DateTime(2024,7, 10), 50), 
        //         new Order1(new DateTime(2024, 7, 15), 200), 
        //         new Order1(new DateTime(2024, 7, 16), 150) 
        //     };


        //     var today = orders.Last().OrderDate.Day;
        //     System.Console.WriteLine(
        //         orders.Where((o) => (o.OrderDate.Day >= today-7)).Sum((o) => o.Amount)
        //     );
















    }
}



 public class Order1{
    public DateTime OrderDate { get; set; }
    public double Amount { get; set; }
    public Order1(DateTime orderDate, double amount)
    {
        OrderDate = orderDate;
        Amount = amount;
    }
}

public class Transaction
{
    public DateTime Date { get; set; }
    public double Amount { get; set; }

    public Transaction(DateTime date, double amount)
    {
        Date = date;
        Amount = amount;
    }
}


public class StudentGrades
{
    public string Student { get; set; }
    public string Subject { get; set; }
    public int Grade { get; set; }

    public StudentGrades(string student, string subject, int grade)
    {
        Student = student;
        Subject = subject;
        Grade = grade;
    }
}





public class EmployeeD
{
    public string Name { get; set; }
    public string Department { get; set; }

    public EmployeeD(string name, string department)
    {
        Name = name;
        Department = department;
    }
}




public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

public class Sale
{
    public string Salesperson { get; set; }
    public int Amount { get; set; }

    public Sale(string salesperson, int amount)
    {
        Salesperson = salesperson;
        Amount = amount;
    }
}

public class StudentScores
{
    public string Student { get; set; }
    public string Subject { get; set; }
    public int Score { get; set; }

    public StudentScores(string student, string subject, int score)
    {
        Student = student;
        Subject = subject;
        Score = score;
    }
}


public class Order
{
    public int OrderId { get; set; }
    public double Amount { get; set; }

    public Order(int orderId, double amount)
    {
        OrderId = orderId;
        Amount = amount;
    }
}

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }

    public Product(string name, string category, double price)
    {
        Name = name;
        Category = category;
        Price = price;
    }
}



