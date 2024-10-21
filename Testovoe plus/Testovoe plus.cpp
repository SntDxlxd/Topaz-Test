#include <iostream>
#include <vector>
#include <stack>
#include <string>

using namespace std;

vector<string> get_substring(const string text) {
    vector<string> result;
    stack<int> stack;


    for (int i = 0; i < text.length(); i++) {
        if (text[i] == '(') {
            stack.push(i);
        }
        else if (text[i] == ')') {
            if (!stack.empty()) {
                result.push_back(text.substr(stack.top() + 1, i - stack.top() - 1));
                stack.pop();
            }
        }
    }

    return result;
}


int main()
{  
    string text = "";
    cout << "Input your text:\n";
    std :: getline(cin, text);

    vector<string> substrings = get_substring(text);
    
    cout << "Substrings in line:\n";
    for (const auto str : substrings) {
        cout << str << endl;
    }
}

