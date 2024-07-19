using lab6.calculators;
namespace lab6;

class Application{
    public static void Main(string [] args){
        task1();

        task2();

    }

    public static void task1(){
        BMI_Calculator<Double> bmi = new BMI_Calculator<Double>();
        System.Console.Write("Enter your hight in meter : ");
        Double hight = Convert.ToDouble(System.Console.ReadLine());
        
        System.Console.Write("Enter your weight in kilograms : ");
        Double weight = Convert.ToDouble(System.Console.ReadLine());

        System.Console.WriteLine(
            $"Your BMI is : {bmi.calculation(hight,weight)}\n"+
            $"Your Catagory is : {bmi.catagory(bmi.get_calculation())}\n"+
            $"Your history is : {bmi.history()}"
        );

    }

    public static void task2(){
        Calculator<Double> calculator = new Calculator<Double>();

        System.Console.WriteLine(
            $"Add resualt =         {calculator.Add(13.10,12,(Double input1,Double input2) => {return input1 + input2;})}\n"+
            $"substract resualt =   {calculator.Subtract(13.10,12,(Double input1,Double input2) => {return input1 - input2;})}\n"+
            $"multiply resualt =    {calculator.Multiply(13.10,12,(Double input1,Double input2) => {return input1 * input2;})}\n"+
            $"divide resualt =      {calculator.Divide(13.10,12,(Double input1,Double input2) => {return input1 / input2;})}"
        );
    }
    
}