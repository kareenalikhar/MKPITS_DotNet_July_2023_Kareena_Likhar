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
	strcpy(b1.title,"donet");
	strcpy(b1.author,"ashish");
	b1.bookid=123;
	printf("Title=%s\n",b1.title);
	printf("author=%s\n",b1.author);
	printf("bookid=%d",b1.bookid);
}

//Algorithm:
//1)start
//2)define structure book
//2.1)declare title,author,bookid
//3)declare main function
//4)struct book b1
//5)strcpy b.title
//6)strcpy b1.author
//7)b1.bookid
//8)print b1.title,b1.author,b1.bookid
//9)stop
