#include <stdio.h>

char* trim(char * s, char *val) {
    int l = strlen(s);

    while(s[l - 1] == *val) --l;
    while(* s && * s == *val) ++s, --l;

    return strndup(s, l);
}

int main()
{
    printf(trim("heello worldhh", "h"));
}