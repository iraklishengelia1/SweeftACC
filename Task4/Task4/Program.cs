
string sequence1 = "(()())";
bool result1 = IsProperly(sequence1);
Console.WriteLine(result1); 

string sequence2 = "())()";
bool result2 = IsProperly(sequence2);
Console.WriteLine(result2); 


static bool IsProperly(string sequence)
{
    Stack<char> stack = new Stack<char>();

    foreach (char item in sequence)
    {
        if (item == '(')
        {
            stack.Push(item);
        }
        else if (item == ')')
        {
            if (stack.Count == 0)
            {
                return false;
            }

            stack.Pop();
        }
    }

    return stack.Count == 0;
}
