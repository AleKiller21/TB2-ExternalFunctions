#include <stdio.h>

int hex2dec(char *input)
{
    int number = 0;
    while(*input){
        number *= 16;
        const char c = *input;
        char A = 'A';
        char a = 'a';
        char O = '0';
        if( c>='A' && c<='F' ) number += c-(int)A+10;
        if( c>='a' && c<='f' ) number += c-(int)a+10;
        if( c>='0' && c<='9' ) number += c-(int)O;
        input++;
    }
    return number;
}

int main()
{
    printf("%d", hex2dec("85698"));
}