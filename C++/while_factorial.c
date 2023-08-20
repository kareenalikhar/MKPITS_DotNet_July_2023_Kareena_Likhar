#include<iostream>
using namespace std;
int main()
{
	int num,fact;
	cout<<"Enter number:";
	cin>>num;
	while(fact>0)
	{
		fact=fact*num;
		num=num+1;
	}
	cout<<"fact="<<fact;
	return 0;
}
