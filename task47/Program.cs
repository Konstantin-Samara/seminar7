// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Write("Введите кол-во строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] OurMatrix = GetMatrix(m,n,-10,10);
PrintMatrix(OurMatrix);
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

