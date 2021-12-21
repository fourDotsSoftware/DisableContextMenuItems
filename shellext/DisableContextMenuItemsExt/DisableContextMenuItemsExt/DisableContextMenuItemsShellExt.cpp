// DisableContextMenuItemsShellExt.cpp : Implementation of CDisableContextMenuItemsShellExt

#include "stdafx.h"
#include "DisableContextMenuItemsShellExt.h"
#include <atlconv.h>  // for ATL string conversion macros
#include "Resource.h"
#include <atlcom.h>
#include <atlstr.h>
#include <stdio.h>
#include <tchar.h>
#define BUFSIZE 65536
#include <cwchar> 
#include <iostream>
#include <string>
#include <Algorithm>
#include "DirectoryHelper.h"
#include <windows.h>
#include <Lmcons.h>
;
using namespace std;

//#include "ShobjIdl.h"
//#include "Shellapi.h"

// CDisableContextMenuItemsShellExt
CDisableContextMenuItemsShellExt::CDisableContextMenuItemsShellExt()
{	
				
}

CDisableContextMenuItemsShellExt::~CDisableContextMenuItemsShellExt()
{	
	//DoubleClickShellChecker.CloseThread();
}


STDMETHODIMP CDisableContextMenuItemsShellExt::Initialize ( 
	LPCITEMIDLIST pidlFolder,
	LPDATAOBJECT pDataObj,
	HKEY hProgID )
{
	HRESULT hr = S_OK;		

	//DoubleClickShellChecker.Initialize();

	return hr;
}

HRESULT CDisableContextMenuItemsShellExt::QueryContextMenu (
	HMENU hmenu, UINT uMenuIndex, UINT uidFirstCmd,
	UINT uidLastCmd, UINT uFlags )
{
	// If the flags include CMF_DEFAULTONLY then we shouldn't do anything.

	if ( uFlags & CMF_DEFAULTONLY )
		return MAKE_HRESULT ( SEVERITY_SUCCESS, FACILITY_NULL, 0 );	

	string sDelete=("Delete");
	bool bDelete=false;
	string sRename=("Rename");
	bool bRename=false;
	string sCut=("Cut");
	bool bCut=false;
	string sCopy=("Copy");
	bool bCopy=false;
	string sPaste=("Paste");
	bool bPaste=false;
	string sProperties=("Properties");
	bool bProperties=false;

	EncryptHelper ench;

	CRegKey reg;
	LONG    lRet;

	lRet = reg.Open ( HKEY_LOCAL_MACHINE,
		_T("Software\\4dots Software\\Disable Context Menu Items"),KEY_QUERY_VALUE);    

	CRegKey reg2;
	LONG    lRet2;

	lRet2 = reg2.Open ( HKEY_LOCAL_MACHINE,
		_T("Software\\4dots Software\\Disable Context Menu Items"),KEY_QUERY_VALUE);    

	WCHAR szFp[MAX_PATH];		

	WCHAR szFp2[MAX_PATH];		

	bool suc=true;

	bool suc2=true;

	if (lRet!=ERROR_SUCCESS)
	{
		suc=false;			
	}

	if (lRet2!=ERROR_SUCCESS)
	{
		suc2=false;			
	}

	DWORD dwSizeFp = sizeof(szFp) / sizeof(WCHAR); // # of characters in the buffer 

	lRet=reg.QueryStringValue(_T("ContextMenuItemsDisable"),szFp,&dwSizeFp);

	if (lRet!=ERROR_SUCCESS)
	{
		suc=false;			
	}

	DWORD dwSizeFp2 = sizeof(szFp2) / sizeof(WCHAR); // # of characters in the buffer 

	lRet2=reg2.QueryStringValue(_T("Usernames"),szFp2,&dwSizeFp2);

	if (lRet2!=ERROR_SUCCESS)
	{
		suc2=false;			
	}

	TCHAR username[UNLEN + 1];
	DWORD size = UNLEN + 1;
	GetUserName((TCHAR*)username, &size);

	TCHAR szFp3[MAX_PATH];
	lstrcpyW(szFp3,_T("|||"));
	lstrcatW(szFp3,username);
	lstrcatW(szFp3,_T("|||"));

	TCHAR szFp4[MAX_PATH];
	lstrcpyW(szFp4,_T("|||"));
	lstrcatW(szFp4,_T("All Users"));	
	lstrcatW(szFp4,_T("|||"));

	std::wstring w1(szFp2);
	std::wstring w2(szFp3);
	std::wstring w3(szFp4);

	bool suc3=false;

	//MessageBox ( NULL, _T("a"), w1.c_str(),MB_ICONINFORMATION );
	//MessageBox ( NULL, _T("a"), w2.c_str(),MB_ICONINFORMATION );
	//MessageBox ( NULL, _T("a"), w3.c_str(),MB_ICONINFORMATION );

	if (w1.length() >= w2.length())
	{	
		std::wstring::size_type found = w1.find(w2);
		if (found!=std::string::npos)
		{
			//MessageBox ( NULL, _T("OK3"), _T("01"),MB_ICONINFORMATION );
			suc3=true;	
		}
	}
	else if (w1.length() >= w3.length())
	{
		std::wstring::size_type found = w1.find(w3);
		if (found!=std::string::npos)
		{
			//MessageBox ( NULL, _T("OK3"), _T("02"),MB_ICONINFORMATION );
			suc3=true;
		}
	}

	if (!suc3)
	{
		return E_INVALIDARG;
	}

	//MessageBox ( NULL, _T("OK3"), _T("03"),MB_ICONINFORMATION );

	if (suc)
	{		
		// convert WCHAR => string
		wstring ws(szFp);
		string regval(ws.begin(), ws.end());

		wstring ws2(szFp2);
		string regval2(ws2.begin(), ws2.end());

		// convert string => LPCWSTR
		std::wstring stemp = std::wstring(regval.begin(), regval.end());
		LPCWSTR sw = stemp.c_str();

		//MessageBox ( NULL , sw, sw, MB_ICONINFORMATION );

		//regval=ench.encryptDecrypt(regval);

		std::wstring stemp2 = std::wstring(regval.begin(), regval.end());
		LPCWSTR sw2 = stemp2.c_str();

		//MessageBox ( NULL , sw2, sw2, MB_ICONINFORMATION );

		if(strstr(regval.c_str(),sDelete.c_str()))
		{
			bDelete=true;
		}			

		if(strstr(regval.c_str(),sRename.c_str()))
		{
			bRename=true;
		}

		if(strstr(regval.c_str(),sCut.c_str()))
		{
			bCut=true;
		}

		if(strstr(regval.c_str(),sCopy.c_str()))
		{
			bCopy=true;
		}

		if(strstr(regval.c_str(),sPaste.c_str()))
		{
			bPaste=true;
		}					

		if(strstr(regval.c_str(),sProperties.c_str()))
		{
			bProperties=true;
		}					
	}
	else
	{	
		lRet = reg.Open ( HKEY_CURRENT_USER,
			_T("Software\\4dots Software\\Disable Context Menu Items"),KEY_QUERY_VALUE);

		WCHAR szFp2[MAX_PATH];		

		DWORD dwSizeFp2 = sizeof(szFp2) / sizeof(WCHAR); // # of characters in the buffer 

		lRet=reg.QueryStringValue(_T("ContextMenuItemsDisable"),szFp2,&dwSizeFp2);

		if (lRet!=ERROR_SUCCESS)
		{
			suc=false;			

			return MAKE_HRESULT ( SEVERITY_SUCCESS, FACILITY_NULL, 1 );
		}
		else
		{
			// convert WCHAR => string
			wstring ws2(szFp2);
			string regval2(ws2.begin(), ws2.end());

			// convert string => LPCWSTR
			std::wstring stemp3 = std::wstring(regval2.begin(), regval2.end());
			LPCWSTR sw3 = stemp3.c_str();

			//MessageBox ( NULL , sw3, sw3, MB_ICONINFORMATION );

			//regval2=ench.encryptDecrypt(regval2);

			std::wstring stemp4 = std::wstring(regval2.begin(), regval2.end());
			LPCWSTR sw4 = stemp4.c_str();

			//MessageBox ( NULL , sw4, sw4, MB_ICONINFORMATION );			

			if(strstr(regval2.c_str(),sDelete.c_str()))
			{
				bDelete=true;
			}			

			if(strstr(regval2.c_str(),sRename.c_str()))
			{
				bRename=true;
			}

			if(strstr(regval2.c_str(),sCut.c_str()))
			{
				bCut=true;
			}

			if(strstr(regval2.c_str(),sCopy.c_str()))
			{
				bCopy=true;
			}

			if(strstr(regval2.c_str(),sPaste.c_str()))
			{
				bPaste=true;
			}					
		}								
	}

	int myPos1=GetMenuItemCount(hmenu);
	int myPos;
	/*
	LPCWSTR sMutexName = L"Local\\07DisableContextMenuItemsMutex521";

	// Create mutex, because there cannot be 2 instances of the same application
	//HANDLE m_hMutex = OpenMutex(NULL, FALSE, sMutexName); 
	HANDLE m_hMutex = OpenMutex(MUTEX_ALL_ACCESS , FALSE, sMutexName); 

	DWORD error = GetLastError();
	if (error)
	{
		LPVOID lpMsgBuf;
		DWORD bufLen = FormatMessage(
			FORMAT_MESSAGE_ALLOCATE_BUFFER | 
			FORMAT_MESSAGE_FROM_SYSTEM |
			FORMAT_MESSAGE_IGNORE_INSERTS,
			NULL,
			error,
			MAKELANGID(LANG_NEUTRAL, SUBLANG_DEFAULT),
			(LPTSTR) &lpMsgBuf,
			0, NULL );
		if (bufLen)
		{
			LPCSTR lpMsgStr = (LPCSTR)lpMsgBuf;
			std::string result(lpMsgStr, lpMsgStr+bufLen);

			LocalFree(lpMsgBuf);

			USES_CONVERSION;		
			LPCWSTR werror = A2W(lpMsgStr);
			std::wcout << werror << std::endl;

			MessageBox ( NULL ,  (LPCTSTR)lpMsgStr,  (LPCTSTR)lpMsgStr,MB_ICONINFORMATION );			    
		}
	}

	bool bAppRunning=(m_hMutex!=NULL);

	/*
	// Check if mutex is created succesfully
	switch (GetLastError())
	{
	case ERROR_SUCCESS:
	// Mutex created successfully. There is no instance running
	bAppRunning=false;
	ReleaseMutex(m_hMutex);
	CloseHandle(m_hMutex);
	MessageBox ( NULL , _T("MUTEX SUCCESS"), _T("MUTEX SUCCESS"),MB_ICONINFORMATION );			
	break;

	case ERROR_ALREADY_EXISTS:
	// Mutex already exists so there is a running instance of our app.
	bAppRunning=true;

	MessageBox ( NULL , _T("MUTEX FAILED"), _T("MUTEX FAILED"),MB_ICONINFORMATION );			
	break;

	default:
	// Failed to create mutex by unknown reason
	bAppRunning=false;

	MessageBox ( NULL , _T("MUTEX FAILED 2"), _T("MUTEX FAILED 2"),MB_ICONINFORMATION );			
	break;
	}	
	*/

	
	ProcessHelper phelper;

	//bool bAppRunning=phelper.AppIsAllreadyRunning(false,"DisableContextMenuItems.exe");

	bool bAppRunning=true;

	if (bAppRunning)
	{
		//MessageBox ( NULL , _T("Running"), _T("Running"),MB_ICONINFORMATION );			
	}
	else
	{
		//MessageBox ( NULL , _T("not Running"), _T("not Running"),MB_ICONINFORMATION );			
	}

	if (bAppRunning)
	{
		for( myPos=myPos1; myPos >= 0; myPos-- )
		{			
			UINT itemid=GetMenuItemID(hmenu,myPos);

			std::wstringstream wss;
			std::wstring smsg;
			wss << itemid;
			wss >> smsg;
			LPCWSTR  lmsg= smsg.c_str();

			//MessageBox ( NULL , lmsg, lmsg, MB_ICONINFORMATION );			

			/*
			MENUITEMINFO mii; 	

			//char szString[256];
			LPWSTR szString;

			memset(&mii,0, sizeof(mii));		

			mii.cbSize = sizeof(mii);	

			mii.fMask = MIIM_STRING;
			//mii.fType=MFT_STRING;

			mii.cch = 256;

			mii.dwTypeData=TEXT('\0');

			GetMenuItemInfo(hmenu, myPos, TRUE, &mii); 

			wchar_t buffer[256];
			wsprintfW(buffer, L"%d", itemid);		

			//LPTSTR itemtxt=mii.dwTypeData;
			//LPCWSTR itemtxtw = (LPCWSTR) itemtxt;					

			//33 and 33
			*/

			//if (myPos>=33 && myPos<=34)		

			if (itemid==30995)
			{
				EnableMenuItem(hmenu,itemid,MF_BYCOMMAND | MF_ENABLED);
				if (bRename)					
					EnableMenuItem(hmenu,itemid,MF_BYCOMMAND | MF_GRAYED);
			}
			else if (itemid==30994)
			{			
				EnableMenuItem(hmenu,itemid,MF_BYCOMMAND | MF_ENABLED);
				if (bDelete)					
					EnableMenuItem(hmenu,itemid,MF_BYCOMMAND | MF_GRAYED);
			}
			else if (itemid==30996 && bProperties)
			{			
				EnableMenuItem(hmenu,itemid,MF_BYCOMMAND | MF_ENABLED);
				if (bProperties)					
					EnableMenuItem(hmenu,itemid,MF_BYCOMMAND | MF_GRAYED);
			}
			else if (itemid==31003 && bPaste)
			{			
				EnableMenuItem(hmenu,itemid,MF_BYCOMMAND | MF_ENABLED);
				if (bPaste)					
					EnableMenuItem(hmenu,itemid,MF_BYCOMMAND | MF_GRAYED);
			}
			else if (itemid==31002 && bCopy)
			{			
				EnableMenuItem(hmenu,itemid,MF_BYCOMMAND | MF_ENABLED);
				if (bCopy)					
					EnableMenuItem(hmenu,itemid,MF_BYCOMMAND | MF_GRAYED);
			}
			else if (itemid==31001 && bCut)
			{			
				EnableMenuItem(hmenu,itemid,MF_BYCOMMAND | MF_ENABLED);
				if (bCut)					
					EnableMenuItem(hmenu,itemid,MF_BYCOMMAND | MF_GRAYED);
			}		
		}
	}

	//return MAKE_HRESULT ( SEVERITY_SUCCESS, FACILITY_NULL, uID - uidFirstCmd );

	return MAKE_HRESULT ( SEVERITY_SUCCESS, FACILITY_NULL, 0 );
}


HRESULT CDisableContextMenuItemsShellExt::GetCommandString (
	UINT_PTR idCmd, UINT uFlags, UINT* pwReserved,
	//  UINT idCmd, UINT uFlags, UINT* pwReserved,
	LPSTR pszName, UINT cchMax )

{
	USES_CONVERSION;		

	//return E_INVALIDARG;

	return S_OK;
}

HRESULT CDisableContextMenuItemsShellExt::InvokeCommand(
	LPCMINVOKECOMMANDINFO pCmdInfo)
{	
	return S_OK;
}