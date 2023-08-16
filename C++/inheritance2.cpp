#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string address;
};
class employee:public person
{
	public:
		int salary;
		string dep;
		int empno;
};
int main()
{
	int name,address,salary,dep,empno;
	employee e1;
	cout<<"Name,address,Salary,Department,empno:";
	cin>>e1.name>>e1.address>>e1.salary>>e1.dep>>e1.empno;
	cout<<"Name:"<<e1.name<<endl;
	cout<<"Address:"<<e1.address<<endl;
	cout<<"Salary:"<<e1.salary<<endl;
	cout<<"Department:"<<e1.dep<<endl;
	cout<<"Empno:"<<e1.empno<<endl;
	return 0;
}
