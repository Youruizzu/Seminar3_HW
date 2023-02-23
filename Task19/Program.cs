Console.Clear();

string PalyndromeNum(){
    string? userInputErrorTest = Console.ReadLine();
    string num = userInputErrorTest ?? "NullErrorException";
    bool flag = true;

    if (num == "NullErrorException") {
        return "Error";
    }
    
    for (int i = 0; i < num.Length/2; i++){
        if (num[i] == num[num.Length - 1 - i] && flag != false){
            flag = true;
        }
        else{
            flag = false;
        }
    }
    return (flag ? "Палиндром" : "Не палиндром");
}

Console.Write("Введите число: ");
Console.Write(PalyndromeNum());



