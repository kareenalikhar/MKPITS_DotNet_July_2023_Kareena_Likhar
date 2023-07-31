//function with parameter having returning value
#include<stdio.h>
float average(float n1,float n2,float n3,float n4,float n5,float add)
{
	float result=add/5.0f;
	return result;
}
void main()
{
	float n1,n2,n3,n4,n5,add,result;
	printf("Enter 5 number");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
	add=n1+n2+n3+n4+n5;
	printf("Addition=%f",add);
	result=average(n1,n2,n3,n4,n5,add);
	printf("\nAverage=%f",result);
}

//Algorithm:
//1)start
//2)declare function n1,n2,n3,n4,n5,add
//3)result=add/5.0
//4)declare main function
//5)declare n1,n2,n3,n4,n5,add,result
//6)accept n1,n2,n3,n4,n5
//7)add=n1+n2+n3+n4+n5
//8)print add
//9)call function average
//10)print result
//11)stop
