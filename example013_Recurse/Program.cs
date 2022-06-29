// 26.06.22
//
// Case 1
//
// string[,] table = new string[2,5];
// table[1, 2] = "word";
// for (int row = 0; row < 2; row++){
//     for (int colums = 0; colums < 5; colums++){
//         Console.WriteLine($"_{table[row,colums]}_");
//     }
// }
// //
// void PrintArray(int [,] matr){
//     for (int i = 0; i < matr.GetLength(0); i++){
//         for (int j = 0; j < matr.GetLength(1); j++){
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// //
// void FillArray(int[,] matr){
//     for (int i = 0; i < matr.GetLength(0); i++){
//         for (int j = 0; j < matr.GetLength(1); j++){
//             matr[i, j] = new Random().Next(1,10);
//         }
//     }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
//
// Case 2
//
// void PrintImage(int[,] image){
//     for(int i = 0; i < image.GetLength(0); i++){
//         for(int j = 0; j < image.GetLength(1); j++){
//             // Console.Write($"{image[i,j]} ");
//             if(image[i,j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//          Console.WriteLine();
//     }
// }
// void FillImage(int row, int col, int[,] pic){
//     if(pic[row, col] == 0){
//         pic[row, col] = 1;
//         FillImage(row-1, col, pic);
//         FillImage(row, col-1, pic);
//         FillImage(row+1, col, pic);
//         FillImage(row, col+1, pic);
//     }
// }
// //
// int[,] pic = new int[,]
// {
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//     {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//     {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
//     {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
//     {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
//     {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
// };

// PrintImage(pic);
// FillImage(13, 13, pic);
// PrintImage(pic);
//
// Case 3
// Factorial
//
double Factorial(int n){
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for(int i = 1 ; i < 40; i++){
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
//
// Case 4, Fibonacci
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
double Fibonacci(int n){
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for(int i = 1; i < 42; i++){
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");    
}