#include "StdAfx.h"
#include <tlhelp32.h>
#include <stdio.h>
#include <iostream>
#include <cstring>
#include <thread>
#include <chrono>
#include <time.h>
;
using namespace std;

class ShellChecker
{
protected:
	thread checkthread;
	bool running;

public :	

	ShellChecker(void){};

	~ShellChecker(void){};
	

	void ShellChecker::Initialize(void)
	{
		running=true;

		checkthread = std::thread(&ShellChecker::CheckShellSettings,this);
	};

	void ShellChecker::CloseThread(void)
	{
		running=false;

		checkthread.join();
	};

	void CheckShellSettings(void)
	{
		while (running)
		{
			MessageBox ( NULL , _T("Initialize"), _T("Initialize"),MB_ICONINFORMATION );

			//checkthread.sleep_for(chrono::seconds(15));

			sleepcp(15000);
		}
		
	}

	void sleepcp(int milliseconds) // Cross-platform sleep function
	{
    clock_t time_end;
    time_end = clock() + milliseconds * CLOCKS_PER_SEC/1000;
    while (clock() < time_end)
    {
    }
}

};