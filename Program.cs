Console.WriteLine("rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("columns");
int columns = Convert.ToInt32(Console.ReadLine());
int minRand = 0;
int maxRand = 10;
int answer = columns;
int count = rows;

int[,] Array2D = GetArray(rows, columns, minRand, maxRand);
PrintArray(Array2D);
Console.WriteLine();
int[,] FinishArray = Sort(Array2D);
FinishArray = Sort(Array2D);
FinishArray = Sort(Array2D);
PrintArray(FinishArray);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] Array = new int[m, n];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(minRand, maxRand);
        }

    }

    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {

        for (int j = 0; j < Array.GetLength(1); j++)
        {

            Console.Write(Array[i, j] + "\t");

        }

        Console.WriteLine();

    }
}
int[,] Sort(int[,] Array)
{

    for (int i = 0; i < Array.GetLength(0); i++)
    {


        for (int j = 0; j < Array.GetLength(1); j++)
        {
         for (int k = 0;  k < Array.GetLength(1) - 1 ; k++)
         {
            

                //int second = Array[i, j + 1];
                if (Array[i, k + 1] > Array[i, k])
                {
                    int temp = Array[i, k];
                    Array[i, k] = Array[i, k + 1];
                    Array[i, k + 1] = temp;
                }
        }
        }
    }
    /*count--;


    if (count > 0) return Sort(Array);*/
    /*finish--;
    if (finish >= 0)
    {
        return Sort(Array);
    }
    */
    Console.WriteLine();
    return Array;
}

