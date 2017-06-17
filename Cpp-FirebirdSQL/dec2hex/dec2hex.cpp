#include <iostream>
#include <string>
#include <map>

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

map<string, string> init_map()
{
    map<string, string> hex_digits;
    hex_digits["0000"] = "0";
    hex_digits["0001"] = "1";
    hex_digits["0010"] = "2";
    hex_digits["0011"] = "3";
    hex_digits["0100"] = "4";
    hex_digits["0101"] = "5";
    hex_digits["0110"] = "6";
    hex_digits["0111"] = "7";
    hex_digits["1000"] = "8";
    hex_digits["1001"] = "9";
    hex_digits["1010"] = "A";
    hex_digits["1011"] = "B";
    hex_digits["1100"] = "C";
    hex_digits["1101"] = "D";
    hex_digits["1110"] = "E";
    hex_digits["1111"] = "F";
    
    return hex_digits;
}

string convert_dec_to_hex(int dec)
{
    map<string, string> hex_digits = init_map();
    string bin = dec_to_bin(dec);
    string answer = "";
    string pad_left = "";
    string final_bin = "";
    int counter = 0;

    for(int i = bin.length() - 1; i >= 0; i--)
    {
        counter++;
        if(counter == 4) counter = 0;
    }
    if(counter != 0)
    {
        for(int i = 4; i > counter; i--)
            pad_left += "0";
    }

    final_bin = pad_left + bin;
    for(int i = 0; i < final_bin.length(); i += 4)
    {
        string hex_digit = "";
        for(int x = 0; x < 4; x++)
        {
            if(x + i >= final_bin.length()) break;
            hex_digit += final_bin[i + x];
        }
        answer += hex_digits[hex_digit];
    }

    return answer;
}

int main()
{
    cout << convert_dec_to_hex(0) << endl;
}