public class student2{
    private int id;
    private string name;
    private int age;

    static student2(){
        System.Console.WriteLine("Hello!");
    }

    public student2(int id,string name,int age){
        this.id = id;
        this.name = name;
        this.age = age;
    }

    public void set_data(int id,string name,int age){
        this.id = id;
        this.name = name;
        this.age = age;
    }

    public string get_data(){
        return 
        $"Student id is : {id}\n"+
        $"Student name is : {name}\n"+
        $"Student age is : {age}\n";
    }

    public bool got_graduated(){
        return age > 23 ? true : false; 
    }


}