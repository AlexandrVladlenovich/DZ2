﻿Console.WriteLine("Введите трехзначное число.\nДля выхода из программы команда exit.");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }