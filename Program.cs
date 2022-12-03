Console.Write("Enter the size of Array: ");
int arrSize = int.Parse(Console.ReadLine()!);

string[] originArr = Array(arrSize);
string[] finalArr = newArray(originArr, LengthOfTheNewArray(originArr));
Console.WriteLine($"Here is your arrays: [{String.Join(", ", originArr)}] -> [{String.Join(", ", finalArr)}]");

string[] Array (int size) {
    string[] tempArr = new string[size];
    for (int i=0; i < tempArr.Length; i++) {
        Console.Write($"Input the {i}-row: ");
        tempArr[i] = Console.ReadLine()!;
    }
    return tempArr;
}

int LengthOfTheNewArray (string[] gotedArr) {
    int getTheSizeOfTheNewArr = 0;
    for (int i=0; i < gotedArr.Length; i++) {
        if (gotedArr[i].Length<4) {
            getTheSizeOfTheNewArr++;
        }
    }
    return getTheSizeOfTheNewArr;
}

string[] newArray (string[] gotedArr, int size) {
    string tempItem = string.Empty;
    string[] tempArr = new string[size];
    for (int i = 0; i < size;) {
        for (int j = 0; j < gotedArr.Length; j++) {
            if (gotedArr[j].Length<4) {
                tempArr[i] = gotedArr[j];
                i++;
            }
        }
    }
    return tempArr;
}