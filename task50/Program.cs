// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
Console.Write("Введите кол-во строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] OurMatrix = GetMatrix(m,n,-10,10);
PrintMatrix(OurMatrix);

Console.Write("Введите индекс столбца : ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс строки : ");
int m1 = Convert.ToInt32(Console.ReadLine());
if (m1>=0&&m1<OurMatrix.GetLength(0)&&n1>=0&&n1<OurMatrix.GetLength(1)) {
Console.WriteLine($"Элемент массива ({n1}, {m1}) : {OurMatrix[m1,n1]}");}
else {Console.WriteLine($"Элемент массива ({n1}, {m1}) в заданном массиве отсутствует.");}

    void PrintMatrix(double[,] matrix){
    for (int i=0; i<matrix.GetLength(0); i++){
        for (int j=0; j<matrix.GetLength(1); j++){Console.Write(matrix[i,j]+" ");}
        Console.WriteLine();}}

double[,] GetMatrix(int Nstr, int NCol, int LefBorder, int RightBorder){
double[,] matrix = new double[Nstr,NCol];
Random rand = new Random();
for (int i=0; i<Nstr; i++){
    for (int j=0; j<NCol; j++){ 
        matrix[i,j] = rand.Next(LefBorder,RightBorder)+rand.NextDouble();
        matrix[i,j] = Convert.ToInt32(matrix[i,j]*100)/100.0;}
}
return matrix;}