#include<iostream>
using namespace std;
int main()
{
	int n1,n2,result;
	char op;
	cout<<"Enter 2 number:";
	cin>>n1>>n2;
	cout<<"Enter operator(+,-,*,/):";
	cin>>op;
	switch(op)
	{
	case '+':
	result=n1+n2;
	break;
	case '-':
	result=n1-n2;
	break;
	case '*':
	result=n1*n2;
	break;
	case '/':
	result=n1/n2;
	break;	
	}
	cout<<"result="<<result;
	return 0;
}
