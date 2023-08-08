#include<iostream>
using namespace std;
int main()
{
	int n1,n2,result=0;
	char op;
	cout<<"Enter 2 numbers:";
	cin>>n1>>n2;
	cout<<"Enter operators(+,-,*,/):";
	cin>>op;
	do
	{
	if(op=='+')
	{
		result=n1+n2;
	}
	else if(op=='-')
	{
		result=n1-n2;
	}
	else if(op=='*')
	{
		result=n1*n2;
	}
	else if(op=='/')
	{
		result=n1/n2;
	}
}
	while(n1>0 && n2>0);
	cout<<"result="<<result;
	return 0;
}



