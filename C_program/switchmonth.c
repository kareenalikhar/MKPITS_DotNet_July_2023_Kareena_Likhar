#include<stdio.h>
int main()
{
	int month;
	printf("Enter Month:",month);
	scanf("%d",&month);
	
	switch(month)
	{
		case 1:		
		case 3:
        case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			printf("31 days");
			break;
		case 4:
		case 6:
		case 9:
		case 11:
			printf("30 days");
			break;
			case 2:
		 		printf("This month have either 28 or 29 days");
				break;
		default:
			printf("invalid month");
			break;
	}
	return 0;
}

//Algorithm
//1-start
//2-accept month
//3-if 1,3,5,7,8,10,12 month then print 31 days
//4-if 4,6,9,11 month then print 30 days
//5-if 2 month then print either 28 or 29 days
//6-stop 
