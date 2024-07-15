namespace lab5.html;

class ImageElement : HTMLElement{
    private string src;


    public ImageElement():this("https://example.com/"){}
    public ImageElement(string src):base("Img","Example.PNG"){
        this.src = src;
    }

    public string Src{
        get => src;
        set{
            src = value;
        }
    }

    public override string render(){
        return $"{this.Type} src=\"{this.Src}{this.Val}\"";
    }

}