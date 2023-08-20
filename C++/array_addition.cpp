#include<iostream>
using namespace std;
int main()
{
	int arr1[2][2],arr2[2][2],arr3[2][2],row,col;
	cout<<"Enter arr1 matrices:";
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			cin>>arr1[row][col];
		}
}
cout<<"Enter arr2 matrices:";
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			cin>>arr2[row][col];
		}
}
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			arr3[row][col]=arr1[row][col]+arr2[row][col];
		}
	}
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			cout<<arr3[row][col]<<endl;
		}
	}
	return 0;
}
