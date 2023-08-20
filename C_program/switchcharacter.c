#include<stdio.h>
void main()
{
	char ch;
	printf("Enter Character:");
	scanf("%c",&ch);
	switch(ch)
	{
		case 'a':
		case 'e':
		case 'i':
		case 'o':
		case 'u':
			printf("it is vowel");
			break;
			default:
				printf("it is not vowel");
				break;
	}
}

//Algorithm
//1-start
//2-accept ch
//3-if a,e,i,o,u then print "it is vowel"
//4-if consonant then print "it is not vowel"
//5-stop 
