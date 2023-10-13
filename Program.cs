using System.Diagnostics.Contracts;
using System.Globalization;

static void PrintNumbers()
{
    // Print all of the integers from 1 to 255.

    for( int i = 1;  i<= 255; i++){
        Console.WriteLine(i);
    }
}

PrintNumbers();


static void PrintOdds()
{
    // Print all of the odd integers from 1 to 255.

    //impares

    for( int i = 1;  i<= 255; i++){
        if(i % 2 !=0){
            Console.WriteLine(i);
        }
    }
}

PrintOdds();



static void PrintSum()
{
    // Print all of the numbers from 0 to 255, 
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:
    
    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New number: 2 Sum: 3

    int suma = 0;
     for( int i = 0;  i<= 255; i++){
        suma = suma +i;
       Console.WriteLine($"New number: {i} Sum: {suma}");
    }
}

PrintSum();



static void LoopArray(int[] numbers)
{
    foreach(int number in numbers){
        Console.WriteLine(number);
    } 
}

int [] numbers = {1,2,3,4,5};

LoopArray(numbers);


static int FindMax(int[] numbers)
{
    int maximo=0;

for( int i = 0; i< numbers.Length; i++){

    if(i == 0){
        maximo = numbers[i];
    }else{
        if(numbers[i] > maximo){
            maximo = numbers[i];
        }
    }
}


    return maximo;
}



int resultado = FindMax(numbers);

Console.WriteLine($"el numero maximo es {resultado}");



static void GetAverage(int[] numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
int suma = 0;
    for( int i = 0; i< numbers.Length; i++){

        suma = suma + numbers[i];
    }
    int promedio =  suma/ numbers.Count();
    Console.WriteLine($"el numero promedio es {promedio}");
}


GetAverage(numbers);


static List<int> OddList()
{
    List<int> numeros = new List<int>();
    for(int i = 1; i<=255; i++){
        numeros.Add(i);
    }
    
    for (int i = 0; i< numeros.Count; i++){
        if(numeros[i] % 2 == 0){
            numeros.RemoveAt(i);
        }
    }
    return numeros;
    }
    // Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
    // When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].

List<int> numeroslist = new List<int>();

numeroslist = OddList();

foreach(int numero in numeroslist){
    Console.WriteLine(numero);
}



static int GreaterThanY(List<int> numbers, int y)
{
    int contador = 0;

    foreach(int number in numbers){
        if(number > y){
            contador++;
        }
    }
    return contador;
    // Write a function that takes an integer List, and an integer "y" and returns the number of values 
    // That are greater than the "y" value. 
    // For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
    // (since there are two values in the List that are greater than 3).
}

int mayor = GreaterThanY(numeroslist,3);

Console.WriteLine($"los cantidad de numeros mayores es {mayor}");




static void SquareArrayValues(List<int> numbers)
{
    // Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]

    for(int i = 0; i< numbers.Count; i++){
        numbers[i] = numbers[i] * numbers[i];
    }

    foreach(int number in numbers){
        Console.WriteLine(number);
    }
}


List<int> arrayvalues = new List<int>();
arrayvalues.Add(1);
arrayvalues.Add(5);
arrayvalues.Add(10);
arrayvalues.Add(-10);


SquareArrayValues(arrayvalues);


static void EliminateNegatives(List<int> numbers)
{
    // Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].

    for( int i =0; i< numbers.Count; i++ ){
        if(numbers[i] < 0){
            numbers[i] = 0;
        }
    }
    foreach(int number in numbers){
        Console.WriteLine(number);
    }
}

List<int> eliminatenegative = new List<int>(){1,5,10,-2};

EliminateNegatives(eliminatenegative);

