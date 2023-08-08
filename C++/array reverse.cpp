#include<iostream>
using namespace std;
int main()
{
	int i,n,nums[i];
	cout<<"Enter number:";
	cin>>n;
	for(i=0;i<n;i++)
	{
		cout<<"Enter numbers:";
		cin>>nums[i];
	}
	for(i=n-1;i>=0;i--)
	{
		cout<<nums[i]<<endl;
	}
}
