// DisableContextMenuItemsExt.cpp : Implementation of DLL Exports.


#include "stdafx.h"
#include "Resource.h"
#include "resource.h"
#include "DisableContextMenuItemsExt_i.h"
//#include "dllmain.h"

class CDisableContextMenuItemsExtModule : public CAtlDllModuleT< CDisableContextMenuItemsExtModule >
{
public :
	DECLARE_LIBID(LIBID_DisableContextMenuItemsExtLib)
	
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_DisableContextMenuItemsEXT, "{1EAE0BEE-C90B-4F9E-ACAA-8DD88F0C5E8B}")
};

CDisableContextMenuItemsExtModule _AtlModule;


#ifdef _MANAGED
#pragma managed(push, off)
#endif

// DLL Entry Point
extern "C" BOOL WINAPI DllMain(HINSTANCE hInstance, DWORD dwReason, LPVOID lpReserved)
{
	hInstance;
    return _AtlModule.DllMain(dwReason, lpReserved); 
}

#ifdef _MANAGED
#pragma managed(pop)
#endif




// Used to determine whether the DLL can be unloaded by OLE
STDAPI DllCanUnloadNow(void)
{
    return _AtlModule.DllCanUnloadNow();
}


// Returns a class factory to create an object of the requested type
STDAPI DllGetClassObject(REFCLSID rclsid, REFIID riid, LPVOID* ppv)
{
    return _AtlModule.DllGetClassObject(rclsid, riid, ppv);
}


// DllRegisterServer - Adds entries to the system registry
STDAPI DllRegisterServer(void)
{
	// If we're on NT, add ourselves to the list of approved shell extensions.

    // Note that you should *NEVER* use the overload of CRegKey::SetValue with
    // 4 parameters.  It lets you set a value in one call, without having to 
    // call CRegKey::Open() first.  However, that version of SetValue() has a
    // bug in that it requests KEY_ALL_ACCESS to the key.  That will fail if the
    // user is not an administrator.  (The code should request KEY_WRITE, which
    // is all that's necessary.)

    if ( 0 == (GetVersion() & 0x80000000UL) )
        {
        CRegKey reg;
        LONG    lRet;

        lRet = reg.Open ( HKEY_LOCAL_MACHINE,
                          _T("Software\\Microsoft\\Windows\\CurrentVersion\\Shell Extensions\\Approved"),
                          KEY_SET_VALUE );

        if ( ERROR_SUCCESS != lRet )
            return E_ACCESSDENIED;

        lRet = reg.SetValue ( _T("DisableContextMenuItemsExt extension"), 
                              _T("{838B42D9-1410-40D5-A880-01DCDE63FE97}") );

        if ( ERROR_SUCCESS != lRet )
            return E_ACCESSDENIED;
        }


    // registers object, typelib and all interfaces in typelib
    HRESULT hr = _AtlModule.DllRegisterServer(FALSE);
	return hr;
}


// DllUnregisterServer - Removes entries from the system registry
STDAPI DllUnregisterServer(void)
{
	// If we're on NT, remove ourselves from the list of approved shell extensions.
    // Note that if we get an error along the way, I don't bail out since I want
    // to do the normal ATL unregistration stuff too.

    if ( 0 == (GetVersion() & 0x80000000UL) )
        {
        CRegKey reg;
        LONG    lRet;

        lRet = reg.Open ( HKEY_LOCAL_MACHINE,
                          _T("Software\\Microsoft\\Windows\\CurrentVersion\\Shell Extensions\\Approved"),
                          KEY_SET_VALUE );

        if ( ERROR_SUCCESS == lRet )
            {
            lRet = reg.DeleteValue ( _T("{838B42D9-1410-40D5-A880-01DCDE63FE97}") );
            }
        }

	HRESULT hr = _AtlModule.DllUnregisterServer(FALSE);
	return hr;
}