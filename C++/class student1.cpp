#include<iostream>
using namespace std;
class student
{
	public:
		string name;
		int clas,rollno;
	void getstudent()
	{
	cout<<"Enter Student name,class,roll no:";
	cin>>name>>clas>>rollno;
}
void displaystudent()
{
	cout<<"student name:"<<name<<endl;
	cout<<"student class:"<<clas<<endl;
	cout<<"student roll no:"<<rollno<<endl;
}
float calculategrade()
{
	float m1,m2,m3,per,total;
	cout<<"Enter 3 subject marks:";
	cin>>m1>>m2>>m3;
	total=m1+m2+m3;
	cout<<"Total marks:"<<total<<endl;
	per=(total)/300*100;
	cout<<"percentage:"<<per<<endl;
	if(per>=75)
	{
		cout<<"Grade is distinction"<<endl;
	}
	else if(per>=60)
	{
		cout<<"Grade is first"<<endl;
	}
	else if(per>=40)
	{
		cout<<"Grade is second"<<endl;
	}
	else
	{
		cout<<"Fail"<<endl;
	}
	return per;
}	
};
int main()
{
	student s1;
	s1.getstudent();
	s1.displaystudent();
	s1.calculategrade();
	return 0;
}
