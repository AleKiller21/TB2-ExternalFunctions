#include <string>
#include <iostream>

using namespace std;

int bin_to_decimal(string bin)
{
    int value = 0;
    int counter = 1;

    for(int i = bin.length() - 1; i >= 0; i--)
    {
        if(i == bin.length() - 1)
        {
            if(bin[i] == '1') value = 1;
            counter *= 2;
            continue;
        }
        if(bin[i] == '1') value += counter;
        counter *= 2;
    }

    return value;
}

int main()
{
    cout << bin_to_decimal("0") << endl;
}