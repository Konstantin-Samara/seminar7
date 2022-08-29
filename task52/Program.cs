// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.Write("Введите кол-во строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] OurMatrix = GetMatrix(m,n,0,10);
PrintMatrix(OurMatrix);

for (int i=0; i<n; i++) {Console.Write(GetSumCol(OurMatrix,i)+" ");}
Console.WriteLine();


double GetSumCol(int[,] matrix, int NCol){
    double sum = 0;
    for (int i=0; i<matrix.GetLength(0); i++) {sum = sum+matrix[i,NCol];}
    sum = Convert.ToInt32((double)(sum/matrix.GetLength(0))*100)/100.0;
    return sum;
}

    void PrintMatrix(int[,] matrix){
    for (int i=0; i<matrix.GetLength(0); i++){
        for (int j=0; j<matrix.GetLength(1); j++){Console.Write(matrix[i,j]+"   ");}
        Console.WriteLine();}}

int[,] GetMatrix(int Nstr, int NCol, int LefBorder, int RightBorder){
int[,] matrix = new int[Nstr,NCol];
Random rand = new Random();
for (int i=0; i<Nstr; i++){
    for (int j=0; j<NCol; j++){ 
        matrix[i,j] = rand.Next(LefBorder,RightBorder);}
}
return matrix;}
