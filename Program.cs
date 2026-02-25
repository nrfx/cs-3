// Даны два слова. Для каждой буквы первого слова определить, входит ли она во второе слово. Повторяющиеся буквы первого слова не рассматривать.

Console.Write("Введите первое слово: ");
string word1 = Console.ReadLine();

Console.Write("Введите второе слово: ");
string word2 = Console.ReadLine();

string checkedLttrs = "";
string outMessage = "";

foreach(char letter in word1)
{
    if (checkedLttrs.Contains(letter) == false)
    {
        checkedLttrs += letter;
        if (word2.Contains(letter))
        {
            outMessage += "да ";
        }
        else { outMessage += "нет "; }
    }
}
outMessage = outMessage.TrimEnd(); // убрать пробел в конце 
Console.WriteLine(outMessage);