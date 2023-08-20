#include<iostream>
using namespace std;
class employee
{
	public:
	int empno,salary;
	string name;
	string designation;
	void getemp()
	{
		cout<<"Emp no:"<<"Name:"<<"designation:"<<"Salary:";
		cin>>empno>>name>>designation>>salary;
	}
	void displayemp()
	{
		cout<<"Emp no:"<<empno<<endl;
		cout<<"Name:"<<name<<endl;
		cout<<"Designation:"<<designation<<endl;
		cout<<"Salary:"<<salary<<endl;
	}
};
int main()
{
	employee emp1,emp2;
	cout<<"Employee 1:"<<endl;
	emp1.getemp();
	emp1.displayemp();
	cout<<"Employee 2:"<<endl;
	emp2.getemp();
	emp2.displayemp();
	return 0;
}
