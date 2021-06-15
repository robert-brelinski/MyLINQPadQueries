<Query Kind="Program">
  <RuntimeVersion>5.0</RuntimeVersion>
</Query>

void Main()
{
	Progress p = new();
	ProgressReporter r = p.InstanceProgress;
	r(99);
	
	r.Target.Dump();
	r.Method.Dump();
}

public delegate void ProgressReporter(int perc);

class Progress
{
	public void InstanceProgress(int perc) => perc.Dump();
}
