#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
void printbook(struct book *ptr);
void main()
{
	struct book b1;
	printf("Enter Title,author and bookid:");
	scanf("%s%s%d",b1.title,b1.author,&b1.bookid);
	printbook(&b1);
	}
void printbook(struct book *ptr)
{
	printf("Title=%s\n",ptr->title);
	printf("Author=%s\n",ptr->author);
	printf("Bookid=%d",ptr->bookid);
}

//Algorithm:
//1)start
//2)define structure book
//3)declare title,author,bookid
//4)in main function declare struct book b1
//5)accept title,author,bookid
//6)call function printbook(&b1)
//7)declare printbook(struct book *ptr)
//8)print title,author,bookid
//9)stop
