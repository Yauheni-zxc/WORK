/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

//  int  [] array = {345, 897, 568, 234,446,574};
//  int count = 0;
//  for(int i =0; i<array.Length; i++){
    //  if(array[i]%2 ==0){count+=1;}
   

//  }
//  Console.WriteLine( $" {count}");

/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


//  int  [] array = {3, 7, 23, 12};
//   int sum = 0;
//  for(int i =0; i<array.Length; i++){
    //  if(i%2 !=0){sum+=array[i];}
   

//  }
//   Console.WriteLine( $" {sum}");
/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

 double [] array = {3 ,7 ,22, 2, 78};
 double sum=0;
 double max = array[0];
 double min = array[1];
 for (int i=0;i<array.Length;i++){
     if(array[i] >max){
        max = array[i];
         
     }
     else if(array[i] <min){
         min = array[i];
       
     }
     sum= max -min;
 }
 Console.WriteLine( $" {sum}");
