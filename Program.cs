/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandomArray(int size = 8){
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int GetCount(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0){
            count += 1;
        }
    }    
    return count;
}
int[] arr = RandomArray();

Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(GetCount(arr)); 



Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. 

int[] RandomArray(int size = 8){
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int GetCount(int[] arr){
    int count = 0;
    for (int i = 1; i < arr.Length; i += 2){
        count += arr[i];
    }    
    return count;
}
int[] arr = RandomArray();

Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(GetCount(arr)); 




Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. */


double[] GetArray(int size = 8){
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(1, 100) / 10.0;
    }
    return array;
}

double GetMaxMin(double[] array){
    double res = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++){
        if (array[i] > max){
            max = array[i];
        }        
        if (array[i] < min){
            min = array[i];
        }
    }
    res = max - min;
    return res;
}
double[] arr = GetArray();
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(GetMaxMin(arr));