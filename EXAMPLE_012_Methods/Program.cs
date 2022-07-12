// Виды методов

// Вид 1. Ничего не принимает, ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор: Елена");
}
//Method1();

// Вид 2. Что-то принимает, ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст сообщения", count: 3);
//Method21(count: 3, msg: "Новый текст сообщения");

// Вид 3. ничего не принимает, что-то возвращает
int Method3()
{
    return DateTime.Now.Year;

}

int year = Method3();
//Console.WriteLine(year);

// Вид 4. Что-то принимает, что-то возвращает
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Qwerty");
Console.WriteLine(res);