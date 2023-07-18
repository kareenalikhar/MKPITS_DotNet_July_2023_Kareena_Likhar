#include<stdio.h>
int main()
{
	int n1,n2,n3;
	printf("Enter 3 numbers:");
	scanf("%d%d%d",&n1,&n2,&n3);
	if(n1>n2 && n1>n3)
	{
		printf("%d is greater",n1);
	}
	else if(n2>n3)
	{
		printf("%d is greater",n2);
	}
	else
	{
		printf("%d is greater",n3);
	}
	return 0;
}


//Algorithm
//step1-start
//step2-accept 3 numbers, input num1,num2,num3
//step3-check wheather num1>num2 and num1>num3 if yes than
//3.1- printf "num1 is greater"
//3.2-go to step 6
//step4-check num2>num1 and num2>num3 if yes than
//4.1- printf "num2 is greater"
//4.2- go to step 6
//step5-else "num3 is greater"
//step 6- stop
