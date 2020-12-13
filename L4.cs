using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



class Program

{

public class B

{

private int[] myar = { 1, 2, 3, 4 };

private int[] notmyar= { 5, 6, 7, 8 };

public int this[int index1,int index2]

{

get

{

if (index1 == -1) { return notmyar[index2]; }

else if (index2 == -1) { return myar[index1]; }

else { return myar[index1] + notmyar[index2]; }

}

set

{

if (index1 == -1) { notmyar[index2]=value; }

else if (index2 == -1) { myar[index1]=value; }

}

}

}

public class MyClass

{

public static string str = "Анна";

}

static void Main(string[] args)

{

MyClass.str += " Страданченкова";

B example = new B();

for (int i = 0; i < 4; i++)

{

Console.Write(example[i, -1] + " ");

example[-1, i] += example[i, -1];

}

Console.WriteLine();

Console.WriteLine(MyClass.str);

MyClass.str += " Николаевна";

for (int i = 0; i < 4; i++)

{ Console.Write(example[-1, i] + " "); }

Console.WriteLine();

Console.WriteLine(MyClass.str);

for (int i = 0; i < 4; i++)

{ Console.Write(example[i, i] + " "); }

Console.ReadLine();

}

}
