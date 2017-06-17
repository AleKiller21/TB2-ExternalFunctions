#include <stdio.h>

char *repeat(char* word, int *n)
{
    int i = 0;
    int counter = 0;

    while(word[counter] != '\0') ++counter;

    char *result = malloc(counter * (*n) + 1);
    if(result){
        char *na = result;
        for(i = 0; i < *n; ++i) {
            const char *p=word;
            while(*p)
                *na++ = *p++;
        }
        *na = '\0';
    }
    return result;
}

int main()
{
    char* word = "Dragon Ball Z";
    int n = 3;
    printf(repeat(word, &n));
}