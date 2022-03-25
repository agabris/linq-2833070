<Query Kind="Program" />

void Main()
{
	var demo = new Demo();
	var result = demo.GetMagicNumber() + 200;
	
	result.Dump("Call your own methods");
}

// Define other methods and classes here

public  class Demo
{
	public  int GetMagicNumber()
	{
		return 42;
	}
}