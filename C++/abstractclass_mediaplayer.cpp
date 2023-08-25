#include<iostream>
using namespace std;
class media_player
{
	public:
		virtual void play()=0;
		virtual void pause()=0;
		virtual void stop()=0;
};
class audio_player:public media_player
{
	public:
		void play()
		{
			cout<<"audio player is start:"<<endl;
		}
		void pause()
		{
			cout<<"audio player is pause:"<<endl;
		}
		void stop()
		{
			cout<<"audio player is stop:"<<endl;
		}
};
class video_player:public media_player
{
	public:
		void play()
		{
			cout<<"video player is start:"<<endl;
		}
		void pause()
		{
			cout<<"video player is pause:"<<endl;
		}
		void stop()
		{
			cout<<"video player is stop:"<<endl;
		}
};
int main()
{
	audio_player a;
	video_player v;
	a.play();
	a.pause();
	a.stop();
	v.play();
	v.pause();
	v.stop();
	return 0;
}
