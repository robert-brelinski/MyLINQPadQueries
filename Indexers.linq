<Query Kind="Program" />

void Main()
{
	var t = new TempRecord();
	t[1].Dump();
	t[1] = 66.6F;
	t[1].Dump();
	
	var d = new DayCollection();
	d["Sun"].Dump();
	d["Fri"].Dump();
	
	var w = new DayOfTheWeek();
	w[System.DayOfWeek.Monday].Dump();
}

public class TempRecord
{
	 float[] temps = new float[10]
	 {
	    56.2F, 56.7F, 56.5F, 56.9F, 58.8F, 61.3F, 65.9F, 62.1F, 59.2F, 57.5F
	 };
	 
	 public float this[int index]
	 {
	 	get => temps[index];
		set => temps[index] = value;
	 }
}

public class DayCollection
{
	string[] days = {"Sun", "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat"};
	
	public int this[string day] => FindDayIndex(day);
	
	private int FindDayIndex(string day)
	{
		for(int i = 0; i < days.Length; i++)
		{
			if (days[i] == day)
			{
				return i;
			}
		}
		
		throw new ArgumentOutOfRangeException(nameof(day), $"Day {day} is not found.");
	}
}

public class DayOfTheWeek
{
	System.DayOfWeek[] days = 
	{
		System.DayOfWeek.Sunday, System.DayOfWeek.Monday, System.DayOfWeek.Tuesday, System.DayOfWeek.Wednesday, System.DayOfWeek.Thursday, System.DayOfWeek.Friday, System.DayOfWeek.Saturday
	};
	
	public int this[System.DayOfWeek day] => FindDayIndex(day);
	
	private int FindDayIndex(System.DayOfWeek day)
	{
		for(int i = 0; i < days.Length; i++)
		{
			if (days[i] == day)
			{
				return i;
			}
		}
		
		throw new ArgumentOutOfRangeException(nameof(day), $"Day {day} is not found.");
	}
}
