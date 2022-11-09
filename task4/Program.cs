Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int Nstart=2;
if(N<2){
    Console.WriteLine("число не может быть меньше или равно 1");
}
else{
    while(Nstart<=N){
        Console.Write(Nstart + ", ");
        Nstart=Nstart+2;
    }
}