#include<iostream>
using namespace std;
class Engine
{
	private:
		int power;
		public:
			void getpower(int p)
			{
				power=p;
			}
			void start()
			{
				cout<<"Engine is start"<<endl;
			}
			void stop()
			{
				cout<<"Engine is stop"<<endl;
			}
			void displayp()
			{
				cout<<"Engine power:"<<power<<endl;
			}
			
};
class Vehicle
{
	private:
		string brand;
		public:
			void getbrand(string b)
			{
				brand=b;
			}
			void accelerator()
			{
				cout<<"Accelerating"<<endl;
			}
			void brake()
			{
				cout<<"Brake"<<endl;
			}
			void displayb()
			{
				cout<<"Brand: "<<brand<<endl;
			}
};
class Car:public Engine,public Vehicle
{
	public:
		void drive()
		{
			cout<<"Car is driving"<<endl;
		}
		void park()
		{
			cout<<"Car is parking"<<endl;
		}
};
int main()
{
	Car c1;
	c1.getbrand("Scorpion");
	c1.displayb();
	c1.getpower(150);
	c1.displayp();
	c1.start();
	c1.accelerator();
	c1.drive();
	c1.brake();
	c1.park();
	c1.stop();
	return 0;
}
