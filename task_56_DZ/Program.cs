Console.Clear();//-очистка
//НАЧ:ТЗ
    TZ();
    void TZ(){
        Console.WriteLine("Задача 56 от 01/06/23:\n"
                           +"!1!---задайте прямоугольный двумерный массив\n"
                           +"       напишите программу,которая\n"
                           +"!2!---находить строку\n"
                           +"!3!---с наименьшей суммой элементов.\n");
        // Например,:
                          
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
    //-функция ПРИНИМАЕТ int-строк,колонок,макс и мин & ПРОВЕРЯЕТ прямоугольность &  НАПОЛНЯЕТ int-матрицу ранд числами & ВОЗВРАЩАЕТ матрицу:
    int[,] FilMasRandIfRectang(int row,int col,int min,int max){
        int[,] result = new int[row,col];
        if(row==col)
        { 
            Console.WriteLine("по условию задачи массив НЕ должен быть прямоугольный");
            result = FilMasRandIfRectang(Prompt("\nВведите количество строк: "),
                                        Prompt("Введите количество колонок: "),
                                        Prompt("Введите количество максимум для рандомных чисел массива: "),
                                        Prompt("Введите количество минимум для рандомных чисел массива: "));
        }
        else
        {
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
    //-функция-ПРИНИМАЕТ int-двумерный массив & ПЕРЕДАЁТ СУММУ в одномерный массив & ВЫВОДИТ индекс минимального элемента:
    void FindIndexRowMinSum(int[,] array)
    {
        int result=0;
            int[] arraySum = new int[array.GetLength(0)];
                for(int i = 0;i < array.GetLength(0);i++)
                {
                    for(int j=0;j < array.GetLength(1); j++)
                    {
                        arraySum[i] += array[i,j];
                    }
                }
        result =arraySum[0];
            for(int i = 0;i<arraySum.Length-1;i++)
            {
                if(arraySum[i]>arraySum[i+1]) result = i;
                else result = i+1;

            }  
        Console.Write($"суммы строк равны \n{String.Join("\n",arraySum)}");
        Console.WriteLine($"\n индекс строки массива с наименьшей суммой равен {result}");
    }
    
//КОН:ФУНКЦИИ И ПРОЦЕДУРЫ

//НАЧ:РЕШЕНИЕ
    //-задайте двумерный массив:
    int[,] array = FilMasRandIfRectang(Prompt("\nВведите количество строк: "),
                                        Prompt("Введите количество колонок: "),
                                        Prompt("Введите количество максимум для рандомных чисел массива: "),
                                        Prompt("Введите количество минимум для рандомных чисел массива: "));
    //-вывод массива в консоль
    PrintMatrix(array);
    //-нахождение индекса наименьшей по сумме строки массива
    FindIndexRowMinSum(array);

//КОН:РЕШЕНИЕ
//-процедура-ПРИНИМАЕТ int-двумерный массив & ДЕЛАЕТ построчную сортироку с убыванием & ВЫВОДИТ массив


//НАЧ:
//КОН: