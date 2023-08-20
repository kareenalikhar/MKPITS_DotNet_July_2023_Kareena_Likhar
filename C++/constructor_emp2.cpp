#include<iostream>
using namespace std;
class employee
{
	public:
		int empno;
		string empname;
	employee(int eno,string en)
	{
		empno=eno;
		empname=en;
	}
	void display()
	{
		cout<<"Enter employee no:"<<empno<<endl;
		cout<<"Enter employee name:"<<empname;
	}
};
int main()
{
	int eno;
	string en;
	cout<<"Enter employee no and name:";
	cin>>eno>>en;
	employee emp1(eno,en);
	emp1.display();
	return 0;
}
