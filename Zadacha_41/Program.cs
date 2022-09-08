Console.WriteLine("Сколько чисел будем проверять?  ");
int quantity = Convert.ToInt32(Console.ReadLine());

int count = 0;
int i = 0;

while(i < quantity)
{
Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());

  if (num > 0)
  {
    count++;
  }
 i++;
}
Console.WriteLine("Количество чисел больше 0: " + count);