#include <iostream>
#include <math.h>

using namespace std;

double get_pmt(double annual_rate, int periods, double loan)
{
    double r = (annual_rate / 100) / 12;
    return (loan * r) / (1 - pow((1 + r), (-periods)));
}

int main()
{
    cout << get_pmt(15, 10, 4200) << endl;
}