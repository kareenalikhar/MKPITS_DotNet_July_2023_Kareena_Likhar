#include<iostream>
using namespace std;
int main()
{
	int row,col,spc,k;
	spc=row+3-1;
	for(row=1;row<=3;row++)
	{
		for(k=spc;k>=1;k--)
		{
			cout<<" ";
		}
		for(col=1;col<=row;col++)
		{
			cout<<"* ";
		}
		spc--;
		cout<<endl;
	}
}
