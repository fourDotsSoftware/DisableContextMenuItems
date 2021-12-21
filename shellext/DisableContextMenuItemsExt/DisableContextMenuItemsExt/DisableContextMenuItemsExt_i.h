

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 8.00.0595 */
/* at Sat May 25 15:19:29 2019
 */
/* Compiler settings for DisableContextMenuItemsExt.idl:
    Oicf, W1, Zp8, env=Win64 (32b run), target_arch=AMD64 8.00.0595 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __DisableContextMenuItemsExt_i_h__
#define __DisableContextMenuItemsExt_i_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __IDisableContextMenuItemsShellExt_FWD_DEFINED__
#define __IDisableContextMenuItemsShellExt_FWD_DEFINED__
typedef interface IDisableContextMenuItemsShellExt IDisableContextMenuItemsShellExt;

#endif 	/* __IDisableContextMenuItemsShellExt_FWD_DEFINED__ */


#ifndef __DisableContextMenuItemsShellExt_FWD_DEFINED__
#define __DisableContextMenuItemsShellExt_FWD_DEFINED__

#ifdef __cplusplus
typedef class DisableContextMenuItemsShellExt DisableContextMenuItemsShellExt;
#else
typedef struct DisableContextMenuItemsShellExt DisableContextMenuItemsShellExt;
#endif /* __cplusplus */

#endif 	/* __DisableContextMenuItemsShellExt_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

#ifdef __cplusplus
extern "C"{
#endif 


#ifndef __IDisableContextMenuItemsShellExt_INTERFACE_DEFINED__
#define __IDisableContextMenuItemsShellExt_INTERFACE_DEFINED__

/* interface IDisableContextMenuItemsShellExt */
/* [unique][helpstring][uuid][object] */ 


EXTERN_C const IID IID_IDisableContextMenuItemsShellExt;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("C9E97CDF-D49E-4B37-9D4C-6CFB7F7A5A15")
    IDisableContextMenuItemsShellExt : public IUnknown
    {
    public:
    };
    
    
#else 	/* C style interface */

    typedef struct IDisableContextMenuItemsShellExtVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IDisableContextMenuItemsShellExt * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IDisableContextMenuItemsShellExt * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IDisableContextMenuItemsShellExt * This);
        
        END_INTERFACE
    } IDisableContextMenuItemsShellExtVtbl;

    interface IDisableContextMenuItemsShellExt
    {
        CONST_VTBL struct IDisableContextMenuItemsShellExtVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IDisableContextMenuItemsShellExt_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IDisableContextMenuItemsShellExt_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IDisableContextMenuItemsShellExt_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IDisableContextMenuItemsShellExt_INTERFACE_DEFINED__ */



#ifndef __DisableContextMenuItemsExtLib_LIBRARY_DEFINED__
#define __DisableContextMenuItemsExtLib_LIBRARY_DEFINED__

/* library DisableContextMenuItemsExtLib */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_DisableContextMenuItemsExtLib;

EXTERN_C const CLSID CLSID_DisableContextMenuItemsShellExt;

#ifdef __cplusplus

class DECLSPEC_UUID("838B42D9-1410-40D5-A880-01DCDE63FE97")
DisableContextMenuItemsShellExt;
#endif
#endif /* __DisableContextMenuItemsExtLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


