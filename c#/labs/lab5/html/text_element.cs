namespace lab5.html;

class TextElement : HTMLElement{
    private int font_size;
    private string font_color;




    public TextElement():this(5,"Red"){}
    
    public TextElement(int font_size,string font_color){
        this.font_size = font_size;
        this.font_color = font_color;
    }

    public TextElement(string val,int font_size,string font_color):base("Text",val){
        this.font_size = font_size;
        this.font_color = font_color;
    }



    public int Font_size{
        get => font_size;
        set{
            font_size = value;
        }
    }


    public string Font_color{
        get => font_color;
        set{
            font_color = value;
        }
    }
}