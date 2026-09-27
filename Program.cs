using System;
using System.IO.Pipelines;
using System.Numerics;

class Program
{
    static void Main()
    {
        int[] masive1 = {2,-2,3,-4,5};
        int[] masive2 = {2,-5,8,4,-1};
        int[] masive3 = {5,4,3,2,1}; // 2 масива

        System.Console.WriteLine(Sum(masive1));
        System.Console.WriteLine(Sum(masive2));
        
    }
    static int Sum(int[] numbers) 
    {
        int limit = 0;
        int result = 0;
        foreach(int number in numbers) //перебираем  массив и сохраняем перебираемое число в переменную(обьект) number
        {
            if(IsPassed(number)) result += number; // если подходит требованиям в коменте снизу то возвращаем result
        }
        return result;

        bool IsPassed(int nums) // если число которое передадим больше рлимита то возвращаем иначе null ну может не null но оно нечего не сделает
        {
            return nums > limit;
        }
    }
}
