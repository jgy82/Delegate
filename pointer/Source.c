#include<stdio.h>

typedef int(*Calc)(int a, int b);		// 声明函数指针.函数指针名称Calc,函数返回值类型为int型,指向函数类型包含两个int型参数a和b,函数指针定义结束.
										// 最后把该指针定义为一种数据类型typedef.最终拥有一个函数指针数据类型

int Add(int a, int b)
{
	int result = a + b;
	return result;
}
int Sub(int a, int b)
{
	int result = a - b;
	return result;
}

int main()
{
	int x = 100;
	int y = 200;
	int z = 0;
	int z1 = 0;
	z = Add(x, y);		// 直接调用,通过函数名称直接调用函数
	printf("%d + %d = %d\n", x, y, z);
	z = Sub(x, y);
	printf("%d - %d = %d\n", x, y, z);
	system("pause");

	Calc funcPointer1 = &Add;		// 声明函数指针类型的变量
	Calc funcPointer2 = &Sub;
	z1 = funcPointer1(x, y);		// 通过指针调用函数
	printf("%d + %d = %d\n", x, y, z1);
	z1 = funcPointer2(x, y);
	printf("%d - %d = %d\n", x, y, z1);


	system("pause");
	return 0;
}