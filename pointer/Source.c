#include<stdio.h>

typedef int(*Calc)(int a, int b);		// ��������ָ��.����ָ������Calc,��������ֵ����Ϊint��,ָ�������Ͱ�������int�Ͳ���a��b,����ָ�붨�����.
										// ���Ѹ�ָ�붨��Ϊһ����������typedef.����ӵ��һ������ָ����������

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
	z = Add(x, y);		// ֱ�ӵ���,ͨ����������ֱ�ӵ��ú���
	printf("%d + %d = %d\n", x, y, z);
	z = Sub(x, y);
	printf("%d - %d = %d\n", x, y, z);
	system("pause");

	Calc funcPointer1 = &Add;		// ��������ָ�����͵ı���
	Calc funcPointer2 = &Sub;
	z1 = funcPointer1(x, y);		// ͨ��ָ����ú���
	printf("%d + %d = %d\n", x, y, z1);
	z1 = funcPointer2(x, y);
	printf("%d - %d = %d\n", x, y, z1);


	system("pause");
	return 0;
}