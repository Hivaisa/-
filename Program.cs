// See https://aka.ms/new-console-template0 for more information
using System.Diagnostics;
using System.Threading.Channels;
//شیرزاد عیسی بیگلو
Console.WriteLine(" lotfan soalat ra fght ba yes ya no jvab dahid  ");
Console.WriteLine("aya be reshteyeh computer alaghe dari? ");
var answer1 = Console.ReadLine();
switch (answer1) {
    case "no":
        Console.WriteLine("aya be khatere khanevadat omadi computer?");
        var answer2 = Console.ReadLine();
        if (answer2 == "no")
        {
            Console.WriteLine("aya be khatere dramadesh omadi?");
            var answer3 = Console.ReadLine();
            if (answer3 == "no")
            {
                Console.WriteLine("aya be khater moshvert omadi?");
                var answer4 = Console.ReadLine();
                if (answer4 == "no")
                {
                    Console.WriteLine(" khob gosfand chera omadi ? nmikhad jvab bedi ");

                }
                else {
                    Console.WriteLine(" khob gosfand chera omadi ");
                }
            }
            else
            {
                Console.WriteLine("aya az daramadesh razi hasti?");
                var answer5 = Console.ReadLine();
                if (true) {
                    Console.WriteLine("khob gosfand nemikhad jvab bedi ");
                }
            }
        }
        else {
            Console.WriteLine("aya az karet pashimani?");
            var answer6 = Console.ReadLine();
            if (answer6 == "no")
            {
                Console.WriteLine("khob gosfandi dige");
            }
            else {
                Console.WriteLine("be darak");
            }
        }
            break;
    case "yes":
        Console.WriteLine("aya az reshteye computer razi hasti?");
        var ansvwer7 = Console.ReadLine();
        if (true) {
            Console.WriteLine("shayad bavaret nashe ama aslan bram mhem nist ");
        }
        break;
}



