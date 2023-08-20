#include<iostream>
using namespace std;
class student
{
	public:
		int rollno;
		string name;
		string course;
	void getdata()
	{
		cout<<"Roll no:"<<"name:"<<"course:";
		cin>>rollno>>name>>course;
	}
	void displaydata()
	{
		cout<<"Roll no="<<rollno<<endl;
		cout<<"Name="<<name<<endl;
		cout<<"Course="<<course<<endl;
	}
};
int main()
{
	student stud1,stud2;
	cout<<"Student 1"<<endl;
	stud1.getdata();
	stud1.displaydata();
	cout<<"Student 2"<<endl;
	stud2.getdata();
	stud2.displaydata();
	return 0;
}
