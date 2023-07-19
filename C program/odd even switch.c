#include<stdio.h>
 void main()
{
	int num;
	printf("Enter num:");
	scanf("%d",&num);
	switch(num%2==0)
	{
		case 1:
		printf("num is even=%d",num);
		break;
		default:
			printf("num is odd=%d",num);
			break;
	}
		
}

//Algorithm
//1-start
//2-accept num
//3-if num is divided by 2 which is equal to 0 then print "num is even"
//4-otherwise print "number is odd"
//5-stop
