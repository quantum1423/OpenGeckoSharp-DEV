// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsITraceRefcnt.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// nsITraceRefcnt is an interface between XPCOM Glue and XPCOM.
    ///
    /// @status DEPRECATED  Replaced by the NS_Log* functions.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("273dc92f-0fe6-4545-96a9-21be77828039")]
	public interface nsITraceRefcnt
	{
		
		/// <summary>
        /// nsITraceRefcnt is an interface between XPCOM Glue and XPCOM.
        ///
        /// @status DEPRECATED  Replaced by the NS_Log* functions.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogAddRef(System.IntPtr aPtr, int aNewRefcnt, [MarshalAs(UnmanagedType.LPStr)] string aTypeName, uint aInstanceSize);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogRelease(System.IntPtr aPtr, int aNewRefcnt, [MarshalAs(UnmanagedType.LPStr)] string aTypeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogCtor(System.IntPtr aPtr, [MarshalAs(UnmanagedType.LPStr)] string aTypeName, uint aInstanceSize);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogDtor(System.IntPtr aPtr, [MarshalAs(UnmanagedType.LPStr)] string aTypeName, uint aInstanceSize);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogAddCOMPtr(System.IntPtr aPtr, [MarshalAs(UnmanagedType.Interface)] nsISupports aObject);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogReleaseCOMPtr(System.IntPtr aPtr, [MarshalAs(UnmanagedType.Interface)] nsISupports aObject);
	}
}
