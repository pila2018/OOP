using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;





class A

{

private int a;//поле

private int b;//поле

public int c// свойство

{

get { return a -= b/a; }

set { a = value; b = value; }

}

}

class Program

{

static void Main(string[] args)

{

A objectMy = new A();

objectMy.c = 2;

int q = objectMy.c;

Console.WriteLine(q);

Console.ReadLine();

}


}