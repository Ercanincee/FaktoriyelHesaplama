string faktoriyelstr;
Console.WriteLine("bir sayi giriniz");
int carpim = 1;

faktoriyelstr = Console.ReadLine();
if(!string.IsNullOrWhiteSpace(faktoriyelstr) )
{
    if(int.TryParse(faktoriyelstr,out int result)) {
        for (int i = result;i>=1;i--)
        {
            carpim = carpim * i;
        }
        Console.WriteLine(carpim);

    }
    else { Console.WriteLine("lütfen gecerli bir sayi giriniz"); }
}