using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



class A

{

protected int a;//поле

protected int b;//поле

public int c// свойство

{

get { if (a > b) return a - b; else return b - a; }

set { a = value; b = value; }

}

public A()//конструктор без параметров

{

a = 1;

b = 1;

}

public A(int a, int b)//конструктор с параметрами

{

this.a = a;

this.b = b;

}

}

class B : A

{

private int d;

public int c2// свойство

{

get { return a + b + d; }

set { a = value; b = value; d = value; }

}

public B()//конструктор без параметров(собственный, без наследования)

{

a = 1;

b = 1;

d = 1;

}

public B(int a, int b, int d):base(a, b)//конструктор с параметрами(унаследованный из А)

{

this.d = d;

}

}

class Program

{

static void Main(string[] args)

{

A objectMy = new A();

A objectMy1 = new A(2, 2);

B objectMy2 = new B();

B objectMy3 = new B(10, 10, 10);

objectMy.c = 2;

int q = objectMy.c;

int q1 = objectMy1.c;

int q2 = objectMy2.c2;

int q3 = objectMy3.c2;

Console.WriteLine(q + q1 + q2 + q3);

Console.ReadLine();

}

+}