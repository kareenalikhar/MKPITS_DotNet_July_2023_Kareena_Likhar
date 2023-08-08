#include<iostream>
using namespace std;
void prime(int num,int counter,int rem)
{
	while(counter<num)
	{
		rem=num%counter;
		if(rem==0)
		{
			cout<<"not a prime no";
			break;
		}
		counter=counter+1;
	}
if(num==counter)
{
	cout<<"it is a prime no";
}
}
int main()
{
	int num,counter=2,rem=0;
	cout<<"Enter a number:";
	cin>>num;
	prime(num,counter,rem);
	
return 0;
}
