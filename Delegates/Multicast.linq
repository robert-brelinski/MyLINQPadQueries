<Query Kind="Program" />

void Main()
{
	ProgressReporter p = WriteProgressToConsole;
	p += WriteProgressToFile;
	
	Util.HardWork(p);
	
	static void WriteProgressToConsole(int percentComplete) => percentComplete.Dump();
	static void WriteProgressToFile(int percentComplete) => File.WriteAllText(@"C:\tmp\progress.txt", percentComplete.ToString());
}

public delegate void ProgressReporter(int percentComplete);

class Util
{
	public static void HardWork(ProgressReporter p)
	{
		for(int i = 0; i < 10; i++)
		{
			p(i * 10);
			System.Threading.Thread.Sleep(100);
		}
	}
}
