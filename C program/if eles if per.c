#include<stdio.h>
int main()
{
	int m1,m2,m3,total;
	float per;
	printf("enter 3 subject marks:");
	scanf("%d%d%d",&m1,&m2,&m3);
	total=m1+m2+m3;
	per=(total/300.0f)*100.0f;
	printf("total marks:=%d",total);
	printf("\npercentage:=%f",per);
	if(per>=75)
	{
		printf("\ngrade=A");
	}
	else if(per<75 && per>=60)
	{
		printf("\ngrade=B");
	}
	else if(per<60 && per>=40)
	{
		printf("\ngrade=C");
	}
	else
	{
		printf("\nFail");
	}
	return 0;
}

//Algorithm
//step1-start
//step2-m1,m2,m3,total,per
//step3-if percentage is greater than 75 then print "grade=A"
//step4-else if percentage is less than 75 and greater than equal to 60 then print "grade=B"
//step5-else if percentage is less than 60 and greater than equal to 40 theb print "grade=C"
//step6-else print "Fail"
//step7-stop

