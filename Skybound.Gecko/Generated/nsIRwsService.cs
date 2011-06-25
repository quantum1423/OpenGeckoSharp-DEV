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
// Generated by IDLImporter from file nsIRwsService.idl
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
	
	
	/// <summary>nsIRwsService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("74a1105c-7e5a-418e-9a57-a0fc8cc992fc")]
	public interface nsIRwsService
	{
		
		/// <summary>
        /// Retrieves the icon given to files with the specified extension
        ///
        /// @param aExt        The extension without the leading dot;
        /// if the dot is present, it will be ignored.
        /// @param aNeedMini   Retrieve a mini icon if true; a standard icon if false.
        /// @return            An HPOINTER representing the icon.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint IconFromExtension([MarshalAs(UnmanagedType.LPStr)] string aExt, [MarshalAs(UnmanagedType.Bool)] bool aNeedMini);
		
		/// <summary>
        /// Retrieves the icon for a specific file or abstract object.
        ///
        /// @param aPath       The fully-qualified name of the file or object.
        /// @param aAbstract   False for filesystem objects, true for abstract objects.
        /// @param aNeedMini   Retrieve a mini icon if true; a standard icon if false.
        /// @return            An HPOINTER representing the icon.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint IconFromPath([MarshalAs(UnmanagedType.LPStr)] string aPath, [MarshalAs(UnmanagedType.Bool)] bool aAbstract, [MarshalAs(UnmanagedType.Bool)] bool aNeedMini);
		
		/// <summary>
        /// Retrieves a file or abstract object's icon using its WPS object handle.
        ///
        /// @param aHandle     The file or object's WPS object handle.
        /// @param aNeedMini   Retrieve a mini icon if true; a standard icon if false.
        /// @return            An HPOINTER representing the icon.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint IconFromHandle(uint aHandle, [MarshalAs(UnmanagedType.Bool)] bool aNeedMini);
		
		/// <summary>
        /// Returns the name of the default handler for files with the
        /// specified extension.  If the handler is a program, it also
        /// retrieves the handler's WPS object handle;  if the default
        /// handler is provided by a WPS class, aHandle will be zero.
        ///
        /// @param aExt        The extension without the leading dot;
        /// if the dot is present, it will be ignored.
        /// @param aHandle     Returns a WPS object handle for programs or
        /// zero for class-based handlers.
        /// @return            Either the unqualified title of a program or
        /// the name of the WPS class' default viewer/player.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandlerFromExtension([MarshalAs(UnmanagedType.LPStr)] string aExt, out uint aHandle, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Returns the name of the default handler for a specific file.
        /// If the handler is a program, it also retrieves the handler's
        /// WPS object handle;  if the default handler is provided by a
        /// WPS class, aHandle will be zero.
        ///
        /// @param aPath       The fully-qualified name of a file.
        /// @param aHandle     Returns a WPS object handle for programs or
        /// zero for class-based handlers.
        /// @return            Either the unqualified title of a program or
        /// the name of the WPS class' default viewer/player.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandlerFromPath([MarshalAs(UnmanagedType.LPStr)] string aPath, out uint aHandle, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Returns the unqualified title of the specified object.
        ///
        /// @param aHandle     A WPS object handle.
        /// @return            The title of this object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TitleFromHandle(uint aHandle, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Displays the WPS object menu for the specified file or abstract object.
        ///
        /// @param aPath       The fully-qualified name of the file or object.
        /// @param aAbstract   False for filesystem objects, true for abstract objects.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MenuFromPath([MarshalAs(UnmanagedType.LPStr)] string aPath, [MarshalAs(UnmanagedType.Bool)] bool aAbstract);
		
		/// <summary>
        /// Opens a file using the specified program file.  The effect
        /// is identical to dropping the file on the program's icon.
        ///
        /// @param aFilePath   The fully-qualified name of a file.
        /// @param aAppPath    The fully-qualified name of a program file.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenWithAppPath([MarshalAs(UnmanagedType.LPStr)] string aFilePath, [MarshalAs(UnmanagedType.LPStr)] string aAppPath);
		
		/// <summary>
        /// Opens a file using the specified WPS object handle.  The effect
        /// is identical to dropping the file on the object's icon.
        ///
        /// @param aFilePath   The fully-qualified name of a file.
        /// @param aAppHandle  A WPS object handle.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenWithAppHandle([MarshalAs(UnmanagedType.LPStr)] string aFilePath, uint aAppHandle);
	}
}