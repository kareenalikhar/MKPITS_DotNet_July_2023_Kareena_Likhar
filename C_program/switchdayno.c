#include<stdio.h>
void main()
{
	int day_no;
	printf("Enter day no:");
	scanf("%d",&day_no);
	switch(day_no)
	{
		case 1:
			printf("\nMonday");
			break;
			
			case 2:
			printf("\nTuesday");
			break;
			
			case 3:
			printf("\nWednesday");
			break;
			
			case 4:
			printf("\nThusday");
			break;
			
			case 5:
			printf("\nFriday");
			break;
			
			case 6:
			printf("\nSaturday");
			break;
			
			case 7:
			printf("\nSunday");
			break;
			
			default:
				printf("\nInvalid");
				break;
	}
}

//Algorithm
//1-start
//2-accept day no
//3-if day no=1 then print "monday"
//4-if day no=2 then print "Tuesday"
//5-if day no=3 then print "Wednesday"
//6-if day no=4 then print "Thusday"
//7-if day no=5 then print "Friday"
//8-if day no=6 then print "Saturday"
//9-if day no=7 then print "Sunday"
//10-if day no is not between 1 to 7 then print "Invalid dayno"
//11-stop
