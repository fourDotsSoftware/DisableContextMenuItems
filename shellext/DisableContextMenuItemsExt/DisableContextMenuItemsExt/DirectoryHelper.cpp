#include "StdAfx.h"
#include <tlhelp32.h>

#include "DisableContextMenuItemsShellExt.h"
#include "DirectoryHelper.h"
#include "stdafx.h"
#include <atlconv.h>  // for ATL string conversion macros
#include "Resource.h"
#include <atlcom.h>
#include <atlstr.h>
#include <stdio.h>
#include <tchar.h>
#include <cwchar> 
#include <iostream>
#include <string>
#include <Algorithm>
#include "resource.h"       // main symbols
#include <sstream>
#include <vector>
#include "DisableContextMenuItemsExt_i.h"
#include <stdio.h>
#include <iostream>
#include <cstring>
#include <thread>
#include <chrono>
;
using namespace std;

DirectoryHelper::DirectoryHelper(void)
{
}

DirectoryHelper::~DirectoryHelper(void)
{
}

bool DirectoryHelper::DirectoryExists(LPWSTR directoryName)
{
    DWORD attributes = GetFileAttributes(directoryName);
    if (attributes != INVALID_FILE_ATTRIBUTES && 
        attributes & FILE_ATTRIBUTE_DIRECTORY)
        return true;

    return false;
}

EncryptHelper::EncryptHelper(void)
{
}

EncryptHelper::~EncryptHelper(void)
{
}

string EncryptHelper::encryptDecrypt(string toEncrypt) {
	char key = 'E'; //Any char will work
	string output = toEncrypt;

	for (int i = 0; i < toEncrypt.size(); i++)
		output[i] = toEncrypt[i] ^ key;

	return output;
}

ProcessHelper::ProcessHelper(void)
{
}

ProcessHelper::~ProcessHelper(void)
{
}

// Checks, if an application with this name is running
//
// bShow ..... TRUE: bring application to foreground, if running 
//             FALSE: only check, don't move to the application
//
// return: FALSE: application is not running
//         TRUE: application runs
bool ProcessHelper::AppIsAllreadyRunning(bool bShow/*=TRUE*/,string sAppName)
{	
	//wchar_t wc = L'DisableContextMenuItems.exe\0';
	//const wchar_t *processName=&wc;

	const wchar_t *processName=L"DisableContextMenuItems.exe";

	//const size_t len2 = 256;
    //const wchar_t *processName[len2];

    //swprintf(processName, len2, L"%s", sAppName.c_str());
    //std::wcout << processName << std::endl;
	//const wchar_t *processName;
		
    bool procrng = false;
    PROCESSENTRY32 entry;
    entry.dwSize = sizeof(PROCESSENTRY32);

    HANDLE snapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, NULL);

    if (Process32First(snapshot, &entry))
        while (Process32Next(snapshot, &entry))
		{
			//MessageBox ( NULL ,entry.szExeFile, _T("Running"),MB_ICONINFORMATION );			

            if (!wcsicmp(entry.szExeFile, processName))
			{
                procrng = true;
				break;
			}
		}

    CloseHandle(snapshot);
    return procrng;

	/*
    const size_t len2 = 256;
    wchar_t strAppName[len2];

    swprintf(strAppName, len2, L"%s", sAppName.c_str());
    std::wcout << strAppName << std::endl;

	//convert string=>const char *
	//const char* strAppName=sAppName.c_str();

    BOOL bRunning=FALSE;
    
    DWORD dwOwnPID = GetProcessId(GetCurrentProcess());
    HANDLE hSnapShot=CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS,0);
    PROCESSENTRY32* processInfo=new PROCESSENTRY32;
    processInfo->dwSize=sizeof(PROCESSENTRY32);
    int index=0;
    while(Process32Next(hSnapShot,processInfo)!=FALSE)
    {
		if (!wcsicmp(processInfo->szExeFile,strAppName))
        //if (!wcscmp (processInfo->szExeFile,strAppName))
        {
			bRunning=TRUE;
                break;
			/*
            if (processInfo->th32ProcessID != dwOwnPID)
            {
				
                if (bShow)
                    EnumWindows(ShowAppEnum,processInfo->th32ProcessID);
				
                bRunning=TRUE;
                break;
            }///
        }
    }
    CloseHandle(hSnapShot);
    delete processInfo;
    return bRunning;*/
}

