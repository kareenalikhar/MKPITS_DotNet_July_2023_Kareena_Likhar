//function with parameter having no returning value
#include<stdio.h>
void average(float n1,float n2,float n3,float n4,float n5,float add)
{
	float result=add/5.0f;
	printf("Average=%f",result);
}
void main()
{
	float n1,n2,n3,n4,n5,add,result;
	printf("Enter 5 number");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
	add=n1+n2+n3+n4+n5;
	printf("\nAddition=%f",add);	
	average(n1,n2,n3,n4,n5,add);
}

//Algorithm:
//1)start
//2)call function average
//2.1)declare n1.n2,n3,n4,n4,add
//3)result=add/5.0
//4)print result
//5)declare main function
//6)declare n1,n2,n3,n4,n5,add,result
//7)accept n1,n2,n3,n4,n5
//8)add=n1+n2+n3+n4+n5
//9)print add
//10)call function average
//11)stop
