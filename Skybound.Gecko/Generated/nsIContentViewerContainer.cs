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
// Generated by IDLImporter from file nsIContentViewerContainer.idl
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
	
	
	/// <summary>nsIContentViewerContainer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ea2ce7a0-5c3d-11d4-90c2-0050041caf44")]
	public interface nsIContentViewerContainer
	{
		
		/// <summary>Member Embed </summary>
		/// <param name='aDocViewer'> </param>
		/// <param name='aCommand'> </param>
		/// <param name='aExtraInfo'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Embed(System.IntPtr aDocViewer, [MarshalAs(UnmanagedType.LPStr)] string aCommand, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtraInfo);
		
		/// <summary>
        /// Allows the PrintEngine to make this call on
        /// an internal interface to the DocShell
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsPrinting([MarshalAs(UnmanagedType.Bool)] bool aIsPrinting);
	}
}