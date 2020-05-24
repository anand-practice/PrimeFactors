using System.Collections.Generic;

public class PrimeFactorsSut{

    public bool Test()
    {
        return true;
    }

    public List<int> GetFactors(int number)
    {
        List<int> arr = new List<int>();
        Factors(number,arr);
        return arr;
    }

    private void Factors(int dividend, List<int> arr)
    {
        if(dividend == 1) return;

        for(int divisor=2; divisor<=dividend; divisor++)
        {
            if(dividend % divisor ==0) {
                int quotient = dividend/divisor;
                arr.Add(divisor);
                Factors(quotient, arr);
                break;
            }
        }
    }
}