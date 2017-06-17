
char* compare_string(char* val1, char* val2)
{
    while(*val1 != '\0' && *val2 != '\0')
    {
        val1++;
        val2++;
    }

    if(*val1 == '\0' && *val2 == '\0') return "0";
    if(*val1 == '\0' && val2 != '\0') return "-1";
    return "1";
}

// int main()
// {
//     printf(compare_string("xz", "xxx"));
// }