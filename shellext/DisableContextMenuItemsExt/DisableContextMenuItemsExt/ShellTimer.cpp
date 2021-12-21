#include "stdafx.h"
#include <iostream>
#include <thread>
#include <chrono>
#include "ShellTimer.h"

using namespace std;

#pragma once

	ShellTimer::ShellTimer()
	{
	}

	ShellTimer::~ShellTimer()
	{
	}  

    typedef std::chrono::milliseconds Interval;
    typedef std::function<void(void)> Timeout;

    void ShellTimer::start(const Interval &interval,
               const Timeout &timeout)
    {
        running = true;

        th = thread([=]()
        {
            while (running == true) {
                this_thread::sleep_for(interval);
                timeout();
            }
        });

// [*]
        th.join();
    }

    void ShellTimer::stop()
    {
        running = false;
    }

