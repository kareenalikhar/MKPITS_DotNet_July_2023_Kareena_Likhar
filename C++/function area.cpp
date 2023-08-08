#include<iostream>
using namespace std;
int area(int side)
{
	int result=side*side;
	return result;
}
int main()
{
	int side,result;
	cout<<"Enter side:";
	cin>>side;
	result=area(side);
	cout<<"Area of square="<<result;
	return 0;
}
