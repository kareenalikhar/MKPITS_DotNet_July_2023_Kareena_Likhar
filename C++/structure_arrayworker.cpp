#include<iostream>
using namespace std;
struct workers
{
	int wage,workday,salary;
	char name[20];
};
int main()
{
	struct workers w1[2];
	int counter;
	for(counter=0;counter<2;counter++)
	{
		cout<<"Enter worker name,daily wage and working days:";
		cin>>w1[counter].name>>w1[counter].wage>>w1[counter].workday;
	}
	cout<<"Enter worker's details:"<<endl;
	for(counter=0;counter<2;counter++)
	{
		w1[counter].salary=w1[counter].wage*w1[counter].workday;
	}
	for(counter=0;counter<2;counter++)
	{
		cout<<"Total salary="<<w1[counter].salary<<endl;
	}
	return 0;
}
