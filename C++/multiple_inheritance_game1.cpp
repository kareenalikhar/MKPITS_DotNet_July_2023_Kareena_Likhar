#include<iostream>
using namespace std;
class Ability
{
	public:
		string abilityname;
		void getaname(string an)
		{
			abilityname=an;
		}
		void display()
		{
			cout<<"Ability:";
			cin>>abilityname;
		}
	
};
class Equipment
{
	public:
		string equipmentitem;
				void geteitem(string ei)
				{
					equipmentitem=ei;
				}
				void display()
				{
					cout<<"Equipment name:";
					cin>>equipmentitem;
				}
};
class character:public Ability,public Equipment
{
	public:
		string charactername;
			void getcname(string cn,string an,string ei)
			{
				charactername=cn;
				getaname(an);
				geteitem(ei);
			}
		void displayc()
		{
			cout<<"Character name:";
			cin>>charactername;
			Ability::display();
			Equipment::display();
		}
		void displaydata()
		{
			cout<<"character name:"<<charactername<<endl;
			cout<<"ability:"<<abilityname<<endl;
			cout<<"equipment item:"<<equipmentitem<<endl;
		}
};
int main()
{
	string charactername,abilityname,equipmentitem;
	character c1;
	c1.getcname(charactername,abilityname,equipmentitem);
	c1.displayc();
	c1.displaydata();
	return 0;
}
