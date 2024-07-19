namespace lab6.calculators;

public class Calculator<T> where T : struct,
IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>{

    public T Add(T input1,T input2,Func<T,T,T> func){
        return func(input1,input2);
    }
    public T Subtract(T input1,T input2,Func<T,T,T> func){
        return func(input1,input2);
    }
    public T Multiply(T input1,T input2,Func<T,T,T> func){
        return func(input1,input2);
    }
    public T Divide(T input1,T input2,Func<T,T,T> func){
        return func(input1,input2);
    }


}