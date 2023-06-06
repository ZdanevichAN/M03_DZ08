Console.Clear();//-очистка
//НАЧ:ТЗ
    TZ();
    void TZ(){
        Console.WriteLine("Задача 58 от 01/06/23:\n"
                           +"!1!---Задайте две матрицы\n"
                           +"       Напишите программу, которая будет находить\n"
                           +"!2!---произведение двух матриц.\n");
            // Например, даны 2 матрицы:
            // 2 4 | 3 4
            // 3 2 | 3 3
            // Результирующая матрица будет:
            // 18 20
            // 15 18   
    }
//КОН:ТЗ

//НАЧ:ФУНКЦИИ И ПРОЦЕДУРЫ
    //-функция ПРИНИМАЕТ int-тект & ВЫВОДИТ текст & ОТКРЫВАЕТ ВВОД числа пользователю & ВОЗРАЩАЕТ int-число:
    int Prompt(string message){
        int result = 0;
            try{
                Console.Write(message);
                result = int.Parse(Console.ReadLine());
            }
            catch{Console.WriteLine("ошибка функции Prompt");}
        return result;
    }
    //-функция ПРИНИМАЕТ int-строк,колонок,макс и мин &  НАПОЛНЯЕТ int-матрицу ранд числами & ВОЗВРАЩАЕТ матрицу:
    int[,] FilMatrixRand(int row,int col,int min,int max){
        int[,] result = new int[row,col];
        Console.WriteLine($"\n-создан двумерный массив строк={row}|колонок={col}|наполнен числами от {min} до {max}");
            try{
                for(int i=0;i<row;i++){
                    for(int j=0;j<col;j++){
                        result[i,j] = new Random().Next(min,max+1);
                    }
                }
            }
            catch{Console.WriteLine("ошибка функции FilMatrixRand");}
        return result;
    }
    //-процедура ПРИНИМАЕТ int-двумерный массив &  ВЫВОДИТ его в консоль
    void PrintMatrix(int[,] result){
            try{
                for(int i=0;i<result.GetLength(0);i++){
                    for(int j=0;j<result.GetLength(1);j++){
                        Console.Write($"{result[i,j]} | ");
                    }
                    Console.WriteLine();
                }
            }
            catch{Console.WriteLine("ошибка функции GetTwoDecIntArrayAndPrint");}
    }    
    //-
    int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);  // Количество строк в первой матрице
        int cols1 = matrix1.GetLength(1);  // Количество столбцов в первой матрице
        int cols2 = matrix2.GetLength(1);  // Количество столбцов во второй матрице

        // Создаем новую матрицу для хранения результата перемножения
        int[,] result = new int[rows1, cols2];

        // Выполняем перемножение матриц
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }


      
//КОН:ФУНКЦИИ И ПРОЦЕДУРЫ

//НАЧ:РЕШЕНИЕ
    //-задайте двумерный массивA:
    int[,] arrayA = FilMatrixRand(Prompt("\nВведите количество строк: "),
                                    Prompt("Введите количество колонок: "),
                                    Prompt("Введите количество максимум для рандомных чисел массива: "),
                                    Prompt("Введите количество минимум для рандомных чисел массива: "));
    //-задайте двумерный массивB:
    int[,] arrayB = FilMatrixRand(Prompt("\nВведите количество строк: "),
                                    Prompt("Введите количество колонок: "),
                                    Prompt("Введите количество максимум для рандомных чисел массива: "),
                                    Prompt("Введите количество минимум для рандомных чисел массива: "));
    
    
    //-вывод массива в консоль
    PrintMatrix(arrayA);
    Console.WriteLine();
    PrintMatrix(arrayB);

    //-перемножение матриц
    Console.WriteLine();
    PrintMatrix(MultiplyMatrix(arrayA,arrayB));

//КОН:РЕШЕНИЕ
//-процедура-ПРИНИМАЕТ int-двумерный массив & ДЕЛАЕТ построчную сортироку с убыванием & ВЫВОДИТ массив


//НАЧ:
//КОН: