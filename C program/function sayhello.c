#include<stdio.h>
void sayhello()
{
	printf("Hello\n");
}
void main()
{
	printf("calling function\n");
	sayhello();
	printf("back in main function\n");
	sayhello();
	printf("bye");
}

//Algorithm:
//1)start
//2)define the function sayhello
//2.1)print Hello
//3)go to main function
//4)print calling function
//5)call function sayhello
//6)print back in main function
//7)call function sayhello
//8)print bye
//9)stop
