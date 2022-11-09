Console.WriteLine("Введите три числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(num1>num2){
    if(num1>num3){
        max=num1;
    }
    else{
       max=num3;
        }
}
else{if(num2>num3){
        max=num2;
    }
    else{max=num3;
    }
}
Console.Write("max=");
Console.Write(max);