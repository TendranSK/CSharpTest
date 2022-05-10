

Console.Write("Введите количество элементов массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
string[] arrayOfSymbols = new string[numberOfElements];
int valueBelow = 0;
//Объявление переменных. int valueBelow служит переменной для сортировки и для
//определения количество переменных в новом массиве.


for(int i = 0 ; i < arrayOfSymbols.Count();i++)
{
    arrayOfSymbols[i] = Console.ReadLine();      

    if(arrayOfSymbols[i].Length<=3)
    {
        valueBelow++;           //подсчет количества элементов массива, в который символов меньше или равно 3-ем.
    }

}

string[] arraySort = new string[valueBelow];
valueBelow = 0;
for(int i = 0 ; i < arrayOfSymbols.Count();i++)
{ 
    if(arrayOfSymbols[i].Length<=3)
    {
        arraySort[valueBelow]=arrayOfSymbols[i];
        valueBelow++;
    }


}
for (int i = 0; i < arraySort.Count(); i++)
{
    Console.Write("{0} ", arraySort[i]);
}

