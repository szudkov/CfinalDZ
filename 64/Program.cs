int n= InputNum("Введите N: ");
int count = 2;
PrintNum( n, count );
Console.WriteLine(1);

void PrintNum( int n, int count )
{
  if (count > n) return;
  PrintNum(n, count + 1);
  Console.Write(count + ", ");
}

int InputNum( string vvod ) 
{
  Console.WriteLine( vvod );
  int vivod = Convert.ToInt32( Console.ReadLine() );
  return vivod;
}