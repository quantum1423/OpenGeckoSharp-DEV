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
// Generated by IDLImporter from file nsIDOMNSHTMLElement.idl
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
	
	
	/// <summary>nsIDOMNSHTMLElement </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f0ffe1d2-9615-492b-aae1-05428ebc2a70")]
	public interface nsIDOMNSHTMLElement
	{
		
		/// <summary>Member GetOffsetTopAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetTopAttribute();
		
		/// <summary>Member GetOffsetLeftAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetLeftAttribute();
		
		/// <summary>Member GetOffsetWidthAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetWidthAttribute();
		
		/// <summary>Member GetOffsetHeightAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetHeightAttribute();
		
		/// <summary>Member GetOffsetParentAttribute </summary>
		/// <returns>A nsIDOMElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetOffsetParentAttribute();
		
		/// <summary>Member GetInnerHTMLAttribute </summary>
		/// <param name='aInnerHTML'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInnerHTMLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aInnerHTML);
		
		/// <summary>Member SetInnerHTMLAttribute </summary>
		/// <param name='aInnerHTML'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInnerHTMLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aInnerHTML);
		
		/// <summary>
        /// Indicates that the element is not yet, or is no longer, relevant.
        ///
        /// See <http://www.whatwg.org/html5/#the-hidden-attribute>.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHiddenAttribute();
		
		/// <summary>
        /// Indicates that the element is not yet, or is no longer, relevant.
        ///
        /// See <http://www.whatwg.org/html5/#the-hidden-attribute>.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHiddenAttribute([MarshalAs(UnmanagedType.Bool)] bool aHidden);
		
		/// <summary>Member GetTabIndexAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTabIndexAttribute();
		
		/// <summary>Member SetTabIndexAttribute </summary>
		/// <param name='aTabIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTabIndexAttribute(int aTabIndex);
		
		/// <summary>Member GetContentEditableAttribute </summary>
		/// <param name='aContentEditable'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentEditableAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentEditable);
		
		/// <summary>Member SetContentEditableAttribute </summary>
		/// <param name='aContentEditable'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentEditableAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentEditable);
		
		/// <summary>Member GetIsContentEditableAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsContentEditableAttribute();
		
		/// <summary>
        /// for WHAT-WG drag and drop
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDraggableAttribute();
		
		/// <summary>
        /// for WHAT-WG drag and drop
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDraggableAttribute([MarshalAs(UnmanagedType.Bool)] bool aDraggable);
		
		/// <summary>Member Blur </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Blur();
		
		/// <summary>Member Focus </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Focus();
		
		/// <summary>Member ScrollIntoView </summary>
		/// <param name='top'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollIntoView([MarshalAs(UnmanagedType.Bool)] bool top);
		
		/// <summary>Member GetSpellcheckAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSpellcheckAttribute();
		
		/// <summary>Member SetSpellcheckAttribute </summary>
		/// <param name='aSpellcheck'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpellcheckAttribute([MarshalAs(UnmanagedType.Bool)] bool aSpellcheck);
	}
}
