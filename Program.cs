// Даны два слова. Для каждой буквы первого слова определить, входит ли она во второе слово. Повторяющиеся буквы первого слова не рассматривать.

Console.Write("Введите первое слово: ");
string word1 = Console.ReadLine();

Console.Write("Введите второе слово: ");
string word2 = Console.ReadLine();

string checkedLttrs = "";

foreach(char letter in word1) // перебираю побуквенно первое слово 
{
    if (checkedLttrs.Contains(letter) == false) // если в переменной проверенных букв нет буквы то добавляем
    {
        checkedLttrs += letter;
        if (word2.Contains(letter))
        {
            Console.Write("да ");
        }
        else { Console.Write("нет "); }
    }
}
