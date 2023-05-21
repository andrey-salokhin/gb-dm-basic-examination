string [] getArrayWithLessOrEqualThreeCharacterElems(string [] array) {

    string[] resultArray = new string[0];

    foreach (string item in array)
    {
        if (item.Length <= 3) {
                Array.Resize(ref resultArray, resultArray.Length+1);
                resultArray[resultArray.Length-1] = item;
        }
    }

    return resultArray;
}

void showArray(string [] array){
    foreach (string item in array)
    {
        Console.Write($"{item} ");
    }

    Console.WriteLine();
}

string[] array1  = new string[] {"Hello", "2", "world", ":-)"};
showArray(getArrayWithLessOrEqualThreeCharacterElems(array1));
string[] array2  = new string[] {"1234", "1567", "-2", "computer science"};
showArray(getArrayWithLessOrEqualThreeCharacterElems(array2));
string[] array3  = new string[] {"Russia", "Denmark", "Kazan"};
showArray(getArrayWithLessOrEqualThreeCharacterElems(array3));