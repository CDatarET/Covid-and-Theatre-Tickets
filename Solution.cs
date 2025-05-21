using System;

public class Test
{
	public static void Main()
	{
		int cases = int.Parse(Console.ReadLine());
		for(int c = 0; c < cases; c++){
		    string[] inputs = Console.ReadLine().Split();
		    int rows = int.Parse(inputs[0]);
		    int seats = int.Parse(inputs[1]);
		    
		    if(seats % 2 != 0){
		        seats++;
		    }
		    seats = seats/2;
		    
		    if(rows % 2 != 0){
		        rows++;
		    }
		    rows = rows/2;
		    Console.WriteLine(rows*seats);
		}
	}
}
