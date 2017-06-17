#include <string>
#include <iostream>

using namespace std;

string compare_strings(string val1, string val2)
{
    if(val1.length() < val2.length()) return "-1";
    if(val1.length() == val2.length()) return "0";
    return "1";
}

int main()
{
    cout << compare_strings("dragon ball super", "dragon ball gt") << endl;
}