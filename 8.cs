public class Solution
    {
        public int Atoi(string str)
        {
            int flag = 0;
            int i = 0;
            long tmp = 0;
            if (str == "")
                return 0;
            while (str[i] == ' ')
                i++;
            while (i < str.Length)
            {
                switch (str[i])
                {
                    case '+': if (flag == 0) flag = 1; else return 0; i++; break;
                    case '-': if (flag == 0) flag = -1; else return 0; i++; break;
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0': tmp = tmp * 10 + str[i] - '0'; i++;
                        
                    if ((tmp)  > int.MaxValue&&flag!=-1)
                            return int.MaxValue;
                    if ((tmp) -int.MaxValue>1&&flag==-1)
                            return int.MinValue; break;
                    default: goto tag; break;
                }
            }
        tag: if (flag == 0)
                flag = 1;
            if ((tmp) > int.MaxValue && flag != -1)
                return int.MaxValue;
            if ((tmp) - (int.MaxValue)>0 && flag == -1)
                return int.MinValue; 
            return (int)(tmp) * flag;
        }
    }‍