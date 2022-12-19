//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int [] TrueArrey(int size, int minValue, int maxValue){
    int [] array = new int [size];
    
    for(int i = 0; i <size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void SwowArrey (int [] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int Even (int [] arr){
    int count = 0;
    for(int i = 0; i < arr.Length; i++){
       if (arr[i] % 2 == 0 ){
        count += 1;
       }
    }
    return count;
}

int min = 100;
int max = 999;
Console.WriteLine("Введите размер масива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = TrueArrey(size, min, max );
SwowArrey(array);
Console.WriteLine($"Количество четных чисел {Even(array)} ");

*/

//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
/*
int [] TrueArrey(int size){
    int [] array = new int [size];
    
    for(int i = 0; i <size; i++)
    {
        array[i] = new Random().Next(0, 123);
    }
    return array;
}

void SwowArrey (int [] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int Even (int [] arr){
    int count = 0;
    for(int i = 0; i < arr.Length; i++){
       if ((arr[i] > 9) & (arr[i] < 100)){
        count += 1;
       }
    }
    return count;
}


int size = 123;
int[] array = TrueArrey(size );
SwowArrey(array);
Console.WriteLine($"Количество чисел которые лежат в отрезке [10,99] {Even(array)} ");
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
int [] TrueArrey(int size){
    int [] array = new int [size];
    
    for(int i = 0; i <size; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void SwowArrey (int [] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int NonEven (int [] arr){
    int count = 0;
    for(int i = 1; i < arr.Length; i=i+2){
       
        count += arr[i];
       }
    return count;
}


Console.WriteLine("Введите размер масива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = TrueArrey(size );
SwowArrey(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {NonEven(array)} ");
*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
double [] TrueArrey(double size){
    double[] array = new double [10];
    
    for(int i = 0; i <size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void SwowArrey (double [] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
double Even (double[] arr){
    double minValue = arr[0];
    double maxValue = arr[0];
    double sum;
    for(int i = 0; i < arr.Length; i++){
       if (arr[i] < minValue)
       {
       minValue = arr[i];
       }
       if (arr[i] > maxValue){
       maxValue = arr[i];
       }
    }
       sum = maxValue-minValue;
    
    return sum;
}


double size = 10;
double[] array = TrueArrey(size);
SwowArrey(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива {Even(array)} ");
*/
//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
//последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int [] TrueArrey(int size){
    int [] array = new int [size];
    
    for(int i = 0; i <size; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void SwowArray (int [] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int Numbers (int [] array){

    int b = array.Length;
    int sum = 0;
    for(int i = 0; i < b/2; i++){
       int  num = array[i];
       array[i] = array[b-1-i];
       sum += array[i] * num;
       Console.Write($" {sum} ");
       }
       
    return sum;
}
int NumbArray (int [] array){
    for(int i = 0; i < array.Length; i++){
        
    }
        
    return array;
    
}


Console.WriteLine("Введите размер масива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = TrueArrey(size );
SwowArray(array);
Numbers(array);
NumbArray(array);
Console.Write($"{array} ");

