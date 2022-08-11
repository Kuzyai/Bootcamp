const int THREADS_NUMBER = 10; //число потоков
const int N = 50; //размер массива
object lock_object = new object();

Random rand = new Random();
int[] resSerial = new int[N].Select(r => rand.Next(1, 50)).ToArray();
int[] resParallel = new int[N];

Array.Copy(resSerial, resParallel, N);

CountingSortExtended(resSerial);
PrepareParallelCountingSort(resParallel);
Console.WriteLine(EqualityMatrix(resSerial, resParallel));

Console.WriteLine(string.Join(", ", resSerial));
Console.WriteLine(string.Join(", ", resParallel));

void PrepareParallelCountingSort(int[] inputArray)
{
	int max = inputArray.Max();
	int min = inputArray.Min();

	int offset = -min;
	int[] counters = new int[max + offset + 1];

	int eachThreadCalc = N / THREADS_NUMBER;
	var threadsParall = new List<Thread>();

	for (int i = 0; i < THREADS_NUMBER; i++)
	{
		int startPos = i * eachThreadCalc;
		int endPos = (i + 1) * eachThreadCalc;
		if (i == THREADS_NUMBER - 1) endPos = N;
		threadsParall.Add(new Thread(() => CountingSortParallel(inputArray, counters, offset, startPos, endPos)));
		threadsParall[i].Start();
	}

	foreach (var thread in threadsParall)
	{
		thread.Join();
	}

	int index = 0;
	for (int i = 0; i < counters.Length; i++)
	{
		for (int j = 0; j < counters[i]; j++)
		{
			inputArray[index] = i - offset;
			index++;
		}
	}
}


void CountingSortParallel(int[] inputArray, int[] counters, int offset, int startPos, int endPos)
{
	for (int i = startPos; i < endPos; i++)
	{
		lock (lock_object)
		{
			counters[inputArray[i] + offset]++;
		}
	}
}

void CountingSortExtended(int[] inputArray)
{
	int max = inputArray.Max();
	int min = inputArray.Min();

	int offset = -min;
	int[] counters = new int[max + offset + 1];


	for (int i = 0; i < inputArray.Length; i++)
	{
		counters[inputArray[i] + offset]++;
	}

	int index = 0;
	for (int i = 0; i < counters.Length; i++)
	{
		for (int j = 0; j < counters[i]; j++)
		{
			inputArray[index] = i - offset;
			index++;
		}
	}
}

bool EqualityMatrix(int[] fmatrix, int[] smatrix)
{
	bool res = true;

	for (int i = 0; i < N; i++)
	{
		res = res && (fmatrix[i] == smatrix[i]);
	}

	return res;
}