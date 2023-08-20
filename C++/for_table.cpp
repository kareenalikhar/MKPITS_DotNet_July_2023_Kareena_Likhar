#include<iostream>
using namespace std;
int main()
{
	int num,counter,result;
	cout<<"Enter number:";
	cin>>num;
	for(counter=1;counter<=10;counter++)
	{
		result=num*counter;
		cout<<num<<"x"<<counter<<"="<<result<<endl;
	}
	return 0;
}
