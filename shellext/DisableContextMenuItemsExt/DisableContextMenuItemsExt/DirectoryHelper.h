#pragma once
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
using namespace std;
class DirectoryHelper
{
public:
	DirectoryHelper(void);
	~DirectoryHelper(void);

	bool DirectoryExists(LPWSTR);
};

class EncryptHelper
{
public:
	EncryptHelper(void);
	~EncryptHelper(void);

	string encryptDecrypt(string);
};


class ProcessHelper
{
public:
	ProcessHelper(void);
	~ProcessHelper(void);
	bool ProcessHelper::AppIsAllreadyRunning(bool bShow/*=TRUE*/,string sAppName);
};