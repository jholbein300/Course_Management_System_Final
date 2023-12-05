using System;
using System.Collections.Generic;


public class List<T>
{
	private LinkedList<T> linkedList;
	public List()
	{
		linkedList = new LinkedList<T> ();
	}
}
