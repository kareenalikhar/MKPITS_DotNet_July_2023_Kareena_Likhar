#include<stdio.h>
void main()
{
	int counter=2,num,rem=0;
	for(num=3;num<=20;num++)
	{
		counter=2;
		while(counter<num)
		{
			rem=num%counter;
			if(rem==0)
   		{
		break;
		}
	counter++;
}
	{
		if(num==counter)
		{
			printf("%d is a prime no\n",num);
		}
	}
	
}
}

//Algorithm
//1)start
//2)declare num,counter=2,rem=0
//3)for num=3;num<=20;num++
//4)counter=2
//5)counter<num
//6)rem=num%counter
//7)if rem==0
//8)counter++
//9)if num == counter
//10) print num is a prime
//11)stop
