namespace lab5.html;

class HTMLElement{
    private string type,val;

    public HTMLElement():this("Text","Hello World"){}

    public HTMLElement(string type,string val){
        this.type = type;
        this.val = val;
    }

    public string Type{
        get => type;
        set{
            type = value;
        }
    }

    public string Val{
        get => val;
        set{
            val = value;
        }
    }

    public virtual string render(){
        return 
        $"Type is {this.Type}\n"+
        $"Value is {this.Val}";
    }

}