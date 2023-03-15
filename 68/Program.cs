int m = Num("Введите M: ");
int n = Num("Введите N: ");
int function = Func(m, n);
Console.Write($"Зачение по функции Аккермана = {function} ");
int Func(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Func(m - 1, 1);
  else return Func(m - 1, Func(m, n - 1));
}
int Num(string vvod) 
{
  Console.Write(vvod);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}