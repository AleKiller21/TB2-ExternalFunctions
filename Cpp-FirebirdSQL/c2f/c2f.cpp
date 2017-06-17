#include <iostream>

using namespace std;

double convert_to_fahrenheit(double celcius)
{
    return celcius * 9/5 + 32;
}

int main()
{
    cout << convert_to_fahrenheit(0) << endl;
}