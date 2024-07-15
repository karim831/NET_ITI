namespace lab3;

public class Book{
    private int id;
    private string name;
    private string type;
    private DateTime created_on;
    private bool is_deleted;
    private string price;
    private static int bk_bought = 13;

    static Book(){
        System.Console.WriteLine("WELCOME_TO_BOOK_STORE!");
    }

    public Book(){
        this.id = 0;
        this.name = "";
        this.type = "";
        this.is_deleted = true;
        this.price = "";
    }


    public Book(
        int id ,string name, DateTime created_on,
        string type = "comic",bool is_deleted = false, 
        string price = "10"
        ){
            this.id = id;
            this.name = name;
            this.type = type;
            this.created_on = created_on;
            this.is_deleted = is_deleted;
            this.price = price;
            bk_bought--;
    }

    public Book(int id,string name){
        this.id = id;
        this.name = name;
    }


    public static int numbers_of_books_bought(){
        return bk_bought;
    }

    public bool is_deleted_func(){
        return is_deleted;
    }

    public string get_data_book(){
        return 
        $"ID is {id}\n" +
        $"Name is {name}\n"+
        $"Type is {type}\n"+
        $"Date of creation {created_on}\n"+
        $"is_deleted {is_deleted}\n"+
        $"price {price}\n";
    }
}