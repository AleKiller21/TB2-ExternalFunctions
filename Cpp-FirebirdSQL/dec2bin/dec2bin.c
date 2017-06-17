#include <stdio.h>
#include <stdlib.h>

char* dec_to_bin(int* number)
{
    int counter = 0;
    int temp = *number;

    if(temp == 0) return "0";
    while(temp > 0)
    {
        temp /= 2;
        counter++;
    }

    char* bin = (char*)malloc(counter);
    char* answer = (char*)malloc(counter);
    memset(bin, '\0', counter);
    memset(answer, '\0', counter);
    temp = *number;
    for(int i = 0; i < counter; i++)
    {
        if(temp % 2 != 0) bin[i] = '1';
        else bin[i] = '0';
        temp /= 2;
    }
    for(int i = counter - 1, x = 0; i >= 0; i--, x++)
    {
        answer[x] = bin[i];
    }

    return answer;
}

// int main()
// {
//     int num = 1;
//     dec_to_bin(&num);
// }