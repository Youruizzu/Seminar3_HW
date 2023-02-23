Console.Clear();

int Prompt(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string CubeLine(int number){
    string cubeLine = $"{number} -> ";
    if (number > 0){
        for(int i=1; i<=number; i++){
        cubeLine += Convert.ToString(i*i*i) + " ";
        }
    }
    else{
        for(int i=-1; i>=number; i--){
        cubeLine += Convert.ToString(i*i*i) + " ";
        }
    }
    return cubeLine;
}

Console.WriteLine(CubeLine(Prompt("Введите число: ")));