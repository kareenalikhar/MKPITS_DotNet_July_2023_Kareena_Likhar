#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
void main()
{
	struct book b1;
	printf("Enter title,author and id:");
	scanf("%s%s%d",b1.title,b1.author,&b1.bookid);
	printf("title=%s\n",b1.title);
	printf("author=%s\n",b1.author);
	printf("bookid=%d",b1.bookid);
}

//Algorithm:
//1)start
//2)define structure book
//2.1)declare title,author,bookid
//3)in main function declare struct book b1
//4)accept title,author and id 
//5)print title,author,bookid
//6)stop
