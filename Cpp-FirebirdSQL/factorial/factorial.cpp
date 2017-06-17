#include <iostream>

using namespace std;

int get_factorial(int number)
{
    if(number == 0) return 1;

    int answer = 1;
    for(int i = 1; i < number; i++)
    {
        answer *= (i + 1);
    }

    return answer;
}

int main()
{
    cout << get_factorial(6) << endl;
}