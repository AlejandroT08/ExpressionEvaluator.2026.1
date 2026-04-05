using System.Globalization;
using System.Text;

namespace ExpressionEvaluator.Core;

public class Evaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        return EvaluatePostfix(postfix);
    }

    private static List<string> InfixToPostfix(string infix)
    {
        var postFix = new List<string>();
        var stack = new Stack<char>();

        for (int i = 0; i < infix.Length; i++)
        {
            char item = infix[i];

            if (char.IsWhiteSpace(item)) continue;

            if (char.IsDigit(item) || item == '.')
            {
                var number = new StringBuilder();
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                {
                    number.Append(infix[i]);
                    i++;
                }
                i--;
                postFix.Add(number.ToString());
            }
            else if (IsOperator(item))
            {
                if (item == '(')
                {
                    stack.Push(item);
                }
                else if (item == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postFix.Add(stack.Pop().ToString());
                    }
                    if (stack.Count > 0) stack.Pop();
                }
                else
                {
                    while (stack.Count > 0 && PriorityStack(stack.Peek()) >= PriorityInfix(item))
                    {
                        if (stack.Peek() == '(') break;
                        postFix.Add(stack.Pop().ToString());
                    }
                    stack.Push(item);
                }
            }
        }

        while (stack.Count > 0)
        {
            postFix.Add(stack.Pop().ToString());
        }
        return postFix;
    }

    private static int PriorityStack(char item) => item switch
    {
        '^' => 3,
        '*' or '/' => 2,
        '+' or '-' => 1,
        '(' => 0,
        _ => 0,
    };

    private static int PriorityInfix(char item) => item switch
    {
        '^' => 3,
        '*' or '/' => 2,
        '+' or '-' => 1,
        _ => 0,
    };

    private static double EvaluatePostfix(List<string> postfix)
    {
        var stack = new Stack<double>();
        foreach (string token in postfix)
        {
            if (token.Length == 1 && IsOperator(token[0]))
            {
                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(token[0] switch
                {
                    '+' => a + b,
                    '-' => a - b,
                    '*' => a * b,
                    '/' => a / b,
                    '^' => Math.Pow(a, b),
                    _ => throw new Exception("Sintax error."),
                });
            }
            else
            {
                stack.Push(double.Parse(token, CultureInfo.InvariantCulture));
            }
        }
        return stack.Pop();
    }

    private static bool IsOperator(char item) => "+-*/^()".Contains(item);
}