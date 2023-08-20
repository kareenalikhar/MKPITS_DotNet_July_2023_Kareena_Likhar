#include<stdio.h>
int main()
{
	int num1,num2,result=0;
	char op;
	printf("Enter 2 numbers:");
	scanf("%d%d",&num1,&num2);
	printf("enter (+,-,*,/)");
	fflush(stdin);
	scanf("%c",&op);	
	switch(op)
	{
		case '+':
			result=num1+num2;
			break;
			case '-':
				result=num1-num2;
				break;
				case '*':
					result=num1*num2;
					break;
					case '/':
						result=num1/num2;
						break;
						default:
							printf("Invalid op");
							break;
						}
						printf("\nresult=%d",result);
							
}

//Algorithm
//1-Start
//2-Accept num1,num2,result,op
//3-if operator is + then result= num1+num2
//4-if operator is - then result= num1-num2
//5-if operator is * then result= num1*num2
//6-if operator is / then result= num1/num2
//7-if operator is not =,-,*,/ then print invalid op
//8-stop


