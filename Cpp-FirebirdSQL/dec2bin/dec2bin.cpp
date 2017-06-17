#include <iostream>
#include <string>

using namespace std;

string dec_to_bin(int number)
{
    string bin = "";
    string answer = "";

    if(number == 0) return "0";
    while(number > 0)
    {
        if(number % 2 != 0) bin = bin + "1";
        else bin = bin + "0";
        number /= 2;
    }
    for(int i = bin.length() - 1; i >= 0; i--)
    {
        answer = answer + bin[i];
    }

    return answer;
}

int main()
{
    cout << dec_to_bin(1256) << endl;
}