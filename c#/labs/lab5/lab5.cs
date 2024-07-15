using lab5.html;
namespace lab5;


public class Lab5{

    public static void Main(string [] args){
        List<HTMLElement> list = new List<HTMLElement> {
            new H1Element("H1","FFFF"),
            new H2Element("H2","0000"),
            new ImageElement()
        };
        

        foreach(HTMLElement element in list){
            System.Console.WriteLine(element.render());
        }


    }

}