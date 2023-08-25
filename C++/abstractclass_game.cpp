#include<iostream>
using namespace std;
class game
{
	virtual void start()=0;
	virtual void play()=0;
	virtual void end()=0;
};
class tic_tac_toe:public game
{
	public:
		void start()
		{
			cout<<"tic tac toe is start"<<endl;
		}
		void play()
		{
			cout<<"tic tac toe is play"<<endl;
		}
		void end()
		{
			cout<<"tic tac toe is stop"<<endl;
		}
};
class chess:public game
{
	public:
		void start()
		{
			cout<<"chess is start"<<endl;
		}
		void play()
		{
			cout<<"chess is play"<<endl;
		}
		void end()
		{
			cout<<"chess is stop"<<endl;
		}
};
int main()
{
	tic_tac_toe t;
	chess c;
	t.start();
	t.play();
	t.end();
	c.start();
	c.play();
	c.end();
	return 0;
}
