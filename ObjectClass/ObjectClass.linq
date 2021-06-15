<Query Kind="Statements" />

public class Object
{
	public Object() {}
	
	public extern Type GetType();
	
	public virtual bool Equals(object obj);
	public static bool Equals(object objA, object objB);
	public static bool ReferenceEquals(object objA, object objB);
	public virtual int GetHashCode();
	public virtual string ToString();
	protected virtual void Finalize();
	protected extern object MemberwiseClone();
}