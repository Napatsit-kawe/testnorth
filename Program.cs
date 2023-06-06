using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("โปรดป้อนจำนวนช่องกระเบื้องวัดจากด้านกว้าง (w):");
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine("โปรดป้อนจำนวนช่องกระเบื้องวัดจากด้านยาว (h):");
        int height = int.Parse(Console.ReadLine());

        int totalTiles = width * height;

        if (totalTiles >= 5 && (width >= 6 || height >= 6 || width * height >= 26))
        {
            Console.WriteLine("Too stuffy!");
        }
        else
        {
            Console.WriteLine("Okay!");
        }
    }
}

