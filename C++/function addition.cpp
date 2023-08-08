#include<iostream>
using namespace std;
void addition(int n1,int n2,int *result)
{
	*result=n1+n2;
}
int main()
{
	int n1,n2,result;
	cout<<"Enter 2 number:";
	cin>>n1>>n2;
	addition(n1,n2,&result);
	cout<<"result="<<result;
	return 0;
}
