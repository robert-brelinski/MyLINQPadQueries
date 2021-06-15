<Query Kind="Program" />

void Main()
{
	new Tree.Builder.Build().exec().Dump();
	new Tree.Runtime.Run().exec().Dump();
}

namespace Tree
{
	namespace Builder
	{
		public class Build
		{
			public string exec() => "Build executed";
		}
	}
	
	namespace Runtime
	{
		public class Run
		{
			public string exec() => "Run executed";
		}
	}
}
