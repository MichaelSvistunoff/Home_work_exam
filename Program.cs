Console.WriteLine("Enter the size of Array:");
int arrSize = int.Parse(Console.ReadLine()!);

string[] Array (int size) {
    string[] tempArr = new string[size];
    for (int i=0; i < tempArr.Length; i++) {
        Console.WriteLine($"Input the {i}-row");
        tempArr[i] = Console.ReadLine()!;
    }
    return tempArr;
}

string[] originArr = Array(arrSize);
Console.WriteLine($"You've inputed next array: [{String.Join(", ", originArr)}]");