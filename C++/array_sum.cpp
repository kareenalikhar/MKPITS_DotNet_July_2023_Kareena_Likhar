#include<iostream>
using namespace std;
int main()
{
	int i,sum=0,marks[5];
	for(i=0;i<5;i++)
	{
		cout<<"enter number:";
		cin>>marks[i];
	}
	for(i=0;i<5;i++)
	{
		cout<<"marks="<<marks[i]<<endl;
		sum=sum+marks[i];
	}
	cout<<"Total marks="<<sum;
	return 0;
}
