namespace lab5.html;

class H2Element : TextElement{

    public H2Element(string val,string font_color):base(val,5,font_color){}

    public override string render(){
        return 
        $"<H2 fontSize=\"{this.Font_size}px\" color=\"#{this.Font_color}\">{this.Val}</H2>";
    }

}