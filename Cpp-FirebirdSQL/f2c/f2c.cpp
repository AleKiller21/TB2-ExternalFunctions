#include <iostream>

using namespace std;

double get_celcius(double fahrenheit)
{
    return (fahrenheit - 32) * 5/9;
}

int main()
{
    cout << get_celcius(48) << endl;
}