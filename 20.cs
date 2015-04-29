public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c.Equals('(') || c.Equals('[') || c.Equals('{'))
                {
                    stack.Push(c);
                }
                if (c.Equals(')') || c.Equals(']') || c.Equals('}'))
                {
                    if (stack.Count != 0)
                    {
                        if (stack.Peek().Equals('(') && c.Equals(')')){
                            stack.Pop();
                            continue;
                        }
                        else if (stack.Peek().Equals('[') && c.Equals(']')){
                            stack.Pop();
                            continue;
                        }
                        else if (stack.Peek().Equals('{') && c.Equals('}')){
                            stack.Pop();
                            continue;
                        }
                    }
                        stack.Push(c);
                }
            }
            return stack.Count == 0 ? true : false;
        }
    }