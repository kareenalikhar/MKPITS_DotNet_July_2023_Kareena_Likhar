#include<stdio.h>
int main()
{
	int num;
	printf("Enter num:");
	scanf("%d",&num);
	if(num<0)
	{
		printf("num is negative");
	}
	else if(num==0)
	{
		printf("num is equal to 0");
	}
	else
	{
		printf("num is positive");
	}
	return 0;
}

//Algorithm
//step1-start
//step2-accept num
//step3-if num is less than 0 
//3.1- printf "num is negative"
//step4-else if num is equal to zero than
//4.1- printf "num is equal to zero"
//step5-else "print num is positive"
//step 6- stop
