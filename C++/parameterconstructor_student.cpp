#include<iostream>
using namespace std;
class student
{
	public:
		string name;
		int clas,rollno;
		float grade,per,total;
	student(float grade,float per,float total)
	{
		grade=grade;
		per=per;
		total=total;
	}
	void getstudent()
	{
		cout<<"Enter student name,class,rollno:";
		cin>>name>>clas>>rollno;
	}
	void displaystudent()
	{
		cout<<"Student name:"<<name<<endl;
		cout<<"Student class:"<<clas<<endl;
		cout<<"Student roll no:"<<rollno<<endl;
	}
	float claculategrade()
	{
		float m1,m2,m3,per,total;
		cout<<"Enter 3 subject marks:";
		cin>>m1>>m2>>m3;
		total=m1+m2+m3;
		cout<<"Total marks:"<<total<<endl;
		per=(total)/300*100;
		cout<<"Percentage:"<<per<<endl;
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
	}
};
int main()
{
	float grade,per,total;
	student s1(grade,per,total);
	s1.getstudent();
	s1.displaystudent();
	s1.claculategrade();
	return 0;
}
