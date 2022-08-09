/* int size = 5;
int[] input = { 5, 3, 7, 4, 6 };
Console.Write("Введите коэффициент смещения: ");
int k = Convert.ToInt32(Console.ReadLine());
int[] output = new int[size];
Console.WriteLine("Начальный массив: [" + string.Join(", ", input) + "]");
int temp = 0;
if (k > 0)
	for (int i = 0; i < k; i++)
		for (int j = 0; j < size; j++)
		{
			if (j == size - 1)
			{
				temp = input[j];
				input[j] = output[j];
				output[0] = temp;
				input[0] = output[0];
				continue;
			}
			temp = input[j];
			input[j] = output[j];
			output[j + 1] = temp;
		}
else
	for (int i = 0; i > k; i--)
		for (int j = size - 1; j >= 0; j--)
		{
			if (j == 0)
			{
				temp = input[j];
				input[j] = output[j];
				output[size - 1] = temp;
				input[size - 1] = output[size - 1];
				continue;
			}
			temp = input[j];
			input[j] = output[j];
			output[j - 1] = temp;
		}

Console.WriteLine("Конечный массив: [" + string.Join(", ", output) + "]"); */

/* int[] array = { 5, 3, 2, 4, 1 };
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
	for (int j = 1; j < array.Length; j++)
	{
		if (array[j - 1] > array[j])
		{
			int temp = array[j - 1];
			array[j - 1] = array[j];
			array[j] = temp;
		}
	}
	Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
} */

/*
1. arr = {1, 0, -6, 2, 5, 3, 2} 
2. pivot = arr[6]  (опорный элемент)
3. Вызвать шаги 1-2 для подмассива слева от pivot и справа от pivot
*/
/* int[] arr = { 0, -5, 2, 3, 5, 9, -1, 7 };
QuickSort(arr, 0, arr.Length - 1);
Console.Write($"Отсортированный массив {string.Join(", ", arr)}");

static void QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
	if (minIndex >= maxIndex) return;
	int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
	QuickSort(inputArray, minIndex, pivot - 1);
	QuickSort(inputArray, pivot + 1, maxIndex);
	return;
}
static int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
	int pivotIndex = minIndex - 1;
	for (int i = minIndex; i <= maxIndex; i++)
	{
		if (inputArray[i] < inputArray[maxIndex])
		{
			pivotIndex++;
			Swap(inputArray, i, pivotIndex);
		}
	}
	pivotIndex++;
	Swap(inputArray, pivotIndex, maxIndex);
	return pivotIndex;
}
static void Swap(int[] inputArray, int leftValue, int rightValue)
{
	int temp = inputArray[leftValue];
	inputArray[leftValue] = inputArray[rightValue];
	inputArray[rightValue] = temp;
} */

/* static void BubbleSort(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		for (int j = 0; j < array.Length - i - 1; j++)
			if (array[j] > array[j + 1])
			{
				int t = array[j + 1];
				array[j + 1] = array[j];
				array[j] = t;
			}
}
static void Main()
{
	int[] array = { 5, 3, 4, 9, 7, 2, 1, 8, 6 };
	BubbleSort(array);
	foreach (int e in array)
		Console.Write(e);
}
Main(); */

/* using System;

namespace QuickSortAlgorithm
{
	class Program
	{
		static void Main()
		{
			int[] inputArray = { 9, 12, 9, 2, 17, 1, 6 };
			int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);
			Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}");
		}
		private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
		{
			if (minIndex >= maxIndex) return array;
			int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);
			QuickSort(array, minIndex, pivotIndex - 1);
			QuickSort(array, pivotIndex + 1, maxIndex);
			return array;
		}
		private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
		{
			int pivotIndex = minIndex - 1;
			for (int i = minIndex; i < maxIndex; i++)
				if (array[i] < array[maxIndex]) Swap(ref array[++pivotIndex], ref array[i]);
			Swap(ref array[++pivotIndex], ref array[maxIndex]);
			return pivotIndex;
		}
		private static void Swap(ref int leftItem, ref int rightItem)
		{
			int temp = leftItem;
			leftItem = rightItem;
			rightItem = temp;
		}
	}
} */


/* int[] InputArray(int size)
{
	int[] array = new int[size];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(-99, 100);
	}
	return array;
}

void Swap(ref int leftItem, ref int rightItem)
{
	int temp = leftItem;
	leftItem = rightItem;
	rightItem = temp;
}

int GetPivotIndex(int[] array, int minIndex, int maxIndex)
{
	int pivot = maxIndex + 1;
	for (int i = maxIndex; i > minIndex; i--)
		if (array[i] > array[minIndex]) Swap(ref array[--pivot], ref array[i]);
	Swap(ref array[--pivot], ref array[minIndex]);
	return pivot;
}

int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
	if (minIndex >= maxIndex) return array;
	int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);
	QuickSort(array, minIndex, pivotIndex - 1);
	QuickSort(array, pivotIndex + 1, maxIndex);
	return array;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] inputArray = InputArray(size);
Console.WriteLine($"Начальный массив: [{string.Join(", ", inputArray)}]");
inputArray = QuickSort(inputArray, 0, inputArray.Length - 1);
Console.WriteLine($"Конечный массив: [{string.Join(", ", inputArray)}]"); */

/* int[] InputArray(int size, Random random)
{
	int[] array = new int[size];
	for (int i = 0; i < array.Length; i++) array[i] = random.Next(-99, 100);
	return array;
}
int SearchNumber(int[] inputArray, int num, int min, int max)
{
	if (min > max || num < inputArray[0] || num > inputArray[inputArray.Length - 1]) return -2;
	int midle = (min + max) / 2;
	if (num == inputArray[midle]) return midle;
	if (num < inputArray[midle]) return SearchNumber(inputArray, num, min, midle - 1);
	return SearchNumber(inputArray, num, midle + 1, max);
}
Random random = new Random();
int size = random.Next(1, 10);
int[] inputArray = InputArray(size, random);
Console.WriteLine($"Неотсортированный массив чисел: [{string.Join(", ", inputArray)}]");
Console.Write("Введите число которое хотите найти: ");
int num = Convert.ToInt32(Console.ReadLine());
Array.Sort(inputArray);
int index = SearchNumber(inputArray, num, 0, inputArray.Length - 1);
Console.WriteLine($"Искомое число {num} в отсортированном массиве чисел [{string.Join(", ", inputArray)}] на {index + 1} позиции."); */

/* int[,] MatrixGeneration(int rows, int columns)
{
	Random rand = new Random();
	int[,] matrix = new int[rows, columns];
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < columns; j++) matrix[i, j] = rand.Next(1, 10);
	return matrix;
}
int[,] SerialMatrixMul(int[,] matrix1, int[,] matrix2)
{
	int[,] serialMulRes = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
	if (matrix1.GetLength(0) != matrix2.GetLength(1))
		Console.WriteLine("Умножение матриц невозможно так как количество строк первой матрицы не равно количеству столбцов второй матрицы.");
	else
	{
		for (int i = 0; i < matrix1.GetLength(0); i++)
			for (int j = 0; j < matrix2.GetLength(1); j++)
				for (int k = 0; k < matrix2.GetLength(0); k++)
					serialMulRes[i, j] += matrix1[i, k] * matrix2[k, j];
	}
	return serialMulRes;
}
void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
			Console.Write($"{matrix[i, j]} ");
		Console.WriteLine();
	}
}

Console.Write("Введите количество строк матрицы: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int size2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = MatrixGeneration(size1, size2);
int[,] matrix2 = MatrixGeneration(size2, size1);
int[,] serialMulRes = SerialMatrixMul(matrix1, matrix2);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(serialMulRes); */

