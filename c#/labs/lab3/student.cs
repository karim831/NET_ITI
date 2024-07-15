namespace lab3;

public class student{
    private int id;
    private string name;
    private int age;

    public student(){
        id = 0;
        name = "";
        age = 0;
    }

    public student(int id,string name,int age){
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