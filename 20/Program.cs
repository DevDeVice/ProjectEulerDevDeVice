using System.Numerics;

BigInteger a = 1;
int result = 0;
for (int i = 1; i < 101; i++)
{
     a *= i;
    Console.WriteLine(a);
}
string b = a.ToString();
for (int j = 0; j < b.Length; j++)
{
    result += Convert.ToInt32(b[j].ToString());
}
Console.WriteLine(result);