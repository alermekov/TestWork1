
string[] input = new string[] {"hello", "2", ":-)"};

int temp = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3) temp++;
}

string[] output = new string[temp];
int j = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        output[j] = input[i];
        j++;
    }
    
}

Console.WriteLine("[{0}]", string.Join(", ", output));
