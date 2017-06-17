#include <iostream>
#include <map>
#include <string>

using namespace std;

map<char, string> init_map()
{
    map<char, string> hex_digits;
    hex_digits['0'] = "0000";
    hex_digits['1'] = "0001";
    hex_digits['2'] = "0010";
    hex_digits['3'] = "0011";
    hex_digits['4'] = "0100";
    hex_digits['5'] = "0101";
    hex_digits['6'] = "0110";
    hex_digits['7'] = "0111";
    hex_digits['8'] = "1000";
    hex_digits['9'] = "1001";
    hex_digits['A'] = "1010";
    hex_digits['B'] = "1011";
    hex_digits['C'] = "1100";
    hex_digits['D'] = "1101";
    hex_digits['E'] = "1110";
    hex_digits['F'] = "1111";

    return hex_digits;
}

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

int convert_hex_to_dec(string hex)
{
    string bin = "";
    map<char, string> hex_digits = init_map();
    
    for(int i = 0; i < hex.length(); i++)
    {
        bin += hex_digits[hex[i]];
    }

    return bin_to_decimal(bin);
}

int main()
{
    cout << convert_hex_to_dec("000A") << endl;
}