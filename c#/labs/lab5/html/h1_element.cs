namespace lab5.html;

class H1Element : TextElement{
    

    public H1Element(string val,string font_color):base(val,10,font_color){}

    public override string render(){
        return 
        $"<H1 fontSize=\"{this.Font_size}px\" color=\"#{this.Font_color}\">{this.Val}</H1>";
    }
}