#include<stdio.h>
float average()
{
	float n1,n2,n3,n4,n5,add,result;
	printf("Enter 5 number");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
	add=n1+n2+n3+n4+n5;
	printf("Addition=%f",add);
	result=add/5.0f;
	return result;
}
void main()
{
	float n1,n2,n3,n4,n5,add,result;
	result=average(n1,n2,n3,n4,n5,add,result);
	printf("\nAverage=%f",result);

}

//Algorithm:
//1)Start
//2)declare function average
//3)declare n1,n2,n3,n4,n5,add,result
//4)accept n1,n2,n3,n4,n5
//5)add=n1+n2+n3+n4+n5
//6)print add
//7)result=add/5.0
//8)declare main function
//9)declare n1,n2,n3,n4,n5,add,result
//10)call function average
//11)print result
//12)stop

