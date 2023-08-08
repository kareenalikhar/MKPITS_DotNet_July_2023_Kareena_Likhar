#include<iostream>
using namespace std;
int main()
{
	int num,fact=1;
	cout<<"Enter number:";
	cin>>num;
	while(num>0)
	{
		fact=fact*num;
		num=num-1;
	}
	cout<<"fact="<<fact;
	return 0;
}
