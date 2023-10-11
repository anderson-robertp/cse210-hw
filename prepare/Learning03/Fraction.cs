using System.Formats.Asn1;

public class Fraction
{
    // Declare variables
    private int _top;
    private int _bottom;

    // Constructor
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }


    // Methods
    public int GetTop(){
        
        return _top;
    }

    public void SetTop(int top){
        
        _top = top;
    }

    public int GetBottom(){
        return _bottom;
    }

    public void GetBottom(int bottom){
        _bottom = bottom;
    }

    public string GetFractionString(){
        string topString = _top.ToString();
        string bottomString = _bottom.ToString();
        string fractionString = $"{topString}/{bottomString}";
        
        return fractionString;
    }

    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }



    
}