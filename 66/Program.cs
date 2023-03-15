int m = InputNum("Введите M: ");
int n = InputNum("Введите N: ");
int temp = n;

if (n > m) 
{
  n = m; 
  m = temp;
}

PrintSumm(n, m, temp=0);

void PrintSumm(int n, int m, int summ)
{
  summ = summ + m;
  if (m <= n)
  {
    Console.Write($"Сумма элементов = {summ} ");
    return;
  }
  PrintSumm(n, m - 1, summ);
}

int InputNum(string num) 
{
  Console.Write(num);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}