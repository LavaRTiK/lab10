using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            string inpattern = @"https?://[a-zA-Zа-яА-Я0-9]+(-?\.?[a-zA-Zа-яА-Я0-9]+)+";
            string unpattern = @"w{3}.[a-zа-яA-ZА-Я 0-9]+-?\.?[a-zа-яA-ZА-Я0-9]+";

            string text = @"Звичайно! Ось трохи більше тексту з валідними та невалідними посиланнями без розділення на пункти:
                            Вибір правильного джерела інформації на Інтернеті є важливим завданням для отримання достовірної і актуальної інформації.Сайт https://site.com став добре відомим джерелом новин та аналітики з останніх технологічних трендів. Для бажаючих ознайомитися з можливостями програмного забезпечення, https://test.site.ua пропонує демонстраційні версії продуктів, які можна випробувати безкоштовно. А для пізнання більш докладної інформації про компанію C4U, https://my.site.c4u є відмінним вибором.
                            https://my.site-site.retd.ua
                            Проте, не все, що знаходиться в мережі, є надійним або корисним. Наприклад, посилання типу www.some-site.може привести вас до сторінки, на якій немає корисної інформації або вона навіть може бути шкідливою. Так само, sitelink._ * ^# або www.invalid.12 є прикладами неправильних посилань, які можуть вводити в оману або просто не працювати.
Т                           ож завжди перевіряйте правильність URL-адреси перед її використанням, щоб упевнитися в достовірності та безпеці ваших даних.";
            Regex rg = new Regex(inpattern);

            MatchCollection result = rg.Matches(text);

            Console.WriteLine(text);
            Console.WriteLine("Список знайдених сайтів");
            for(int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i].Value);
            }
            Console.WriteLine("Невалідних");
            rg = new Regex(unpattern);
            result= rg.Matches(text);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i].Value);
            }
            Console.ReadLine();
        }
    }
}
