using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



class Program

{

/// <summary>

///

/// </summary>

public class A

{

protected float a; //поле

protected float b; //поле

public float c// свойство

{

get { return a / b; }

}

public A(float _a, float _b)

{

this.a = _a;

this.b = _b;

}

public A()

{

this.a = 0;

this.b = 0;

}

}

public class B : A

{

protected float d;

public float[] arr;

public float c2

{

get

{

if (b == 0)

{

return d = -1;

}

else

{

return d = a / b;

}

}

}

public B(float _a, float _b)

{

this.a = _a;

this.b = _b;

this.d = 0;

this.arr = new float[(int)this.a];

for (int i = 0; i < this.arr.Length; i++)

{

this.arr[i] = i * this.c2;

}

}

}

static void Main(string[] args)

{

A forExample = new A(10, 2);

B forExample3 = new B(100, 50);

Console.WriteLine(forExample3.c2);

foreach (var item in forExample3.arr)

{

Console.Write(item + " ");

}

Console.ReadLine();

}

}