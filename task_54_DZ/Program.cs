Console.Clear();//-очистка
//НАЧ:ТЗ
    TZ();
    void TZ(){
        Console.WriteLine("Задача 54 от 01/06/23:\n"
                           +"!1!---задайте двумерный массив\n"
                           +"       напишите программу,которая\n"
                           +"!2!---упорядочит по убыванию!!!\n"
                           +"!3!---элементы каждой строки\n");
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4                           
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
    //-функция-ПРИНИМАЕТ int-двумерный массив & ДЕЛАЕТ построчную сортироку с убыванием & ВЫВОДИТ массив:
    int[,] BubleSortMatrixRow(int[,] result){
        Console.WriteLine("\nприменен метод сортировки пузырьком(строчно по убыванию):");
        try
        {
            for(int row = 0;row<result.GetLength(0);row++)
            {
                for(int i=0;i<result.GetLength(1)-1;i++)
                {
                    for(int j=0+i;j<result.GetLength(1)-1;j++)
                    {
                       if(result[row,i]<result[row,j+1])
                       {
                        int temp = result[row,i];
                        result[row,i] = result[row,j+1];
                        result[row,j+1] = temp;
                       } 
                    }
                }
            }
        }
        catch{Console.WriteLine("ошибка метода BubleSortMatrixRow");}
        return result;
    }     
//КОН:ФУНКЦИИ И ПРОЦЕДУРЫ

//НАЧ:РЕШЕНИЕ
    //-задайте двумерный массив:
    int[,] array = FilMatrixRand(Prompt("\nВведите количество строк: "),
                                Prompt("Введите количество колонок: "),
                                Prompt("Введите количество максимум для рандомных чисел массива: "),
                                Prompt("Введите количество минимум для рандомных чисел массива: "));
    PrintMatrix(array);
    //-сортировка каждой строки массива по убыванию:
    PrintMatrix(BubleSortMatrixRow(array));
//КОН:РЕШЕНИЕ
//-процедура-ПРИНИМАЕТ int-двумерный массив & ДЕЛАЕТ построчную сортироку с убыванием & ВЫВОДИТ массив


//НАЧ:
//КОН: