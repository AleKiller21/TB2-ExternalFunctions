#include <stdio.h>

char* dec2hex(int *number)
{
    int remainder,quotient;
	int i=1,j,temp,x;
	char hexadecimalNumber[25];
	quotient = *number;
	while(quotient!=0) {
		temp = quotient % 16;
		if(temp < 10)
	        temp =temp + 48; 
        else
		    temp = temp + 55;
		hexadecimalNumber[i++]= temp;
		quotient = quotient / 16;
	}
    char* result = (char*)malloc(25 + 1 * sizeof(char));
    for(x = 0; x < 25; x++) result[x] = '\0';
    result[25] = '\0';
    int k = 0;
    for(j = i - 1; j > 0; j--){
        result[k] = hexadecimalNumber[j]; 
        k++;
    }
    return result;
}

int main()
{
    int num = 546456;
    printf(dec2hex(&num));
}