#include <iostream>
#include <string>

using namespace std;

string repeat_word(string value, int n)
{
    string answer = "";
    for(int i = 0; i < n; i++)
    {
        answer += value;
    }

    return answer;
}
int main()
{
    cout << repeat_word("jack", 1) << endl;
}