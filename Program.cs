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

string[] finalArr = newArray(originArr, LengthOfTheNewArray(originArr));
Console.WriteLine($"Your final array: [{String.Join(", ", finalArr)}]");