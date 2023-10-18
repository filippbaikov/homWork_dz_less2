Console.Clear();

dz10();
dz13();
dz15();

static void dz10()
{
    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//dz10();
    System.Console.WriteLine("введи трёхзначное число : ");
    int randomNum = Convert.ToInt32(Console.ReadLine());
    if (100 < randomNum && randomNum < 1000)
        System.Console.WriteLine("вторая цифра: " + (randomNum / 10) % 10);
    else
        System.Console.WriteLine("нормально делай, нормально будет");
}

static void dz13(){
//     Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//      что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326791123 -> 6
System.Console.WriteLine("введи любое число не менее трёхзначного : ");
    int randomNum = Convert.ToInt32(Console.ReadLine());
    if (randomNum<100)
      System.Console.WriteLine("я сказал не менее трёхзначного"); 
      else 
      {   
    while (randomNum>999){        
         randomNum /=10;         
    }
    System.Console.WriteLine(randomNum%10);
    
      }
}
void dz15(){
//     Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
String [] week= {"пн","вт","ср","чт","пт","сб","вс"};
System.Console.WriteLine("выбери день недели");
byte a=Convert.ToByte(Console.ReadLine());
if(a>week.Length)
System.Console.WriteLine("ты чё, не знаешь сколько дней в неделе?");
else if(a==7 ||a==6)
System.Console.Write("выходной сегодня: ");
System.Console.WriteLine(week[a-1]);
}

