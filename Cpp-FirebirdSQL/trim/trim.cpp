#include <iostream>

using namespace std;

string trim_word(string value, string character)
{
    int i = 0;
    for(; i < value.length(); i++)
        if(value[i] != character[0]) break;

    value = value.substr(i);
    for(i = value.length() - 1; i >= 0; i--)
        if(value[i] != character[0]) break;
    
    return value.substr(0, i + 1);
}

int main()
{
    cout << trim_word("heello worldhh", "");
}