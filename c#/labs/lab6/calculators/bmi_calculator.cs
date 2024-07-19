namespace lab6.calculators;


public class BMI_Calculator<T>{
    private Stack <Double> stack = new Stack<Double>();

    public Double get_calculation(){
        return stack.Peek();
    }
    
    public Double calculation(T hight, T weight){
        stack.Push(
            Convert.ToDouble(weight)/
            (Convert.ToDouble(hight) * Convert.ToDouble(hight))
        );
        return stack.Peek();
    }

    public String catagory(double bmi){
        if(bmi < 18.5)
            return "Underweight";
        else if(bmi >= 18.5 && bmi <24.9)
            return "Normal weight";
        else if(bmi >= 25 && bmi < 29.9)
            return "Overweight";
        else 
            return  "Obesity";
    }
    
    public String history(){
        String returned = "";
        Int16 i = 0;
        foreach(double s in stack){
            returned += $"In the {i+1} time : {s}\n";
            i++;
        }
        return returned;
    }


}