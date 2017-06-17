#include <math.h>

int binary_to_decimal(int *num){
    int decimalNumber = 0, i = 0, remainder;
    while ((*num) !=0)
    {
        remainder = (*num) %10;
        (*num) /= 10;
        decimalNumber += remainder*pow(2,i);
        ++i;
    }
    return decimalNumber;
}

int main()
{
    
}