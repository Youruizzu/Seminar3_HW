Console.Clear();

int Prompt(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double DistanceBetweenTwoPoints(int ax, int ay, int az, int bx, int by, int bz){
    Console.WriteLine($"A({ax}, {ay}, {az}), B({bx}, {by}, {bz})");
    return Math.Round(Math.Sqrt((ax-bx)*(ax-bx)+(ay-by)*(ay-by)+(az-bz)*(az-bz)), 2);
}

double distance = DistanceBetweenTwoPoints(
    Prompt("Введите Ax: "), 
    Prompt("Введите Ay: "), 
    Prompt("Введите Az: "), 
    Prompt("Введите Bx: "), 
    Prompt("Введите By: "), 
    Prompt("Введите Bz: ")
);

Console.Write($"Расстоние между точками A и B = {distance}");