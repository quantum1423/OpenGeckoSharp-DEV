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
// Generated by IDLImporter from file nsIDOMNSDocument.idl
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
	
	
	/// <summary>nsIDOMNSDocument </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("92f2c6f8-3668-4a47-8251-2a900afe11fa")]
	public interface nsIDOMNSDocument
	{
		
		/// <summary>Member GetCharacterSetAttribute </summary>
		/// <param name='aCharacterSet'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCharacterSet);
		
		/// <summary>Member GetDirAttribute </summary>
		/// <param name='aDir'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		/// <summary>Member SetDirAttribute </summary>
		/// <param name='aDir'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		/// <summary>Member GetLocationAttribute </summary>
		/// <returns>A nsIDOMLocation</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMLocation GetLocationAttribute();
		
		/// <summary>Member GetTitleAttribute </summary>
		/// <param name='aTitle'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		/// <summary>Member SetTitleAttribute </summary>
		/// <param name='aTitle'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		/// <summary>Member GetContentTypeAttribute </summary>
		/// <param name='aContentType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentType);
		
		/// <summary>Member GetReadyStateAttribute </summary>
		/// <param name='aReadyState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReadyStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aReadyState);
		
		/// <summary>Member GetLastModifiedAttribute </summary>
		/// <param name='aLastModified'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLastModifiedAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLastModified);
		
		/// <summary>Member GetReferrerAttribute </summary>
		/// <param name='aReferrer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReferrerAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aReferrer);
		
		/// <summary>Member HasFocus </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasFocus();
		
		/// <summary>Member GetActiveElementAttribute </summary>
		/// <returns>A nsIDOMElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetActiveElementAttribute();
		
		/// <summary>Member GetCurrentScriptAttribute </summary>
		/// <returns>A nsIDOMElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetCurrentScriptAttribute();
		
		/// <summary>
        /// Retrieve elements matching all classes listed in a
        /// space-separated string.
        ///
        /// See <http://whatwg.org/specs/web-apps/current-work/>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByClassName([MarshalAs(UnmanagedType.LPStruct)] nsAString classes);
		
		/// <summary>
        /// Returns the element from the caller's document at the given point,
        /// relative to the upper-left-most point in the (possibly scrolled)
        /// window or frame.
        ///
        /// If the element at the given point belongs to another document (such as
        /// an iframe's subdocument), the element in the calling document's DOM
        /// (e.g. the iframe) is returned. If the element at the given point is
        /// anonymous or XBL generated content, such as a textbox's scrollbars, then
        /// the first non-anonymous parent element (that is, the textbox) is returned.
        ///
        /// This method returns null if either coordinate is negative, or if the
        /// specified point lies outside the visible bounds of the document.
        ///
        /// Callers from XUL documents should wait until the onload event has fired
        /// before calling this method.
        ///
        /// See <http://www.w3.org/TR/cssom-view/#the-documentview-interface>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement ElementFromPoint(double x, double y);
		
		/// <summary>
        /// Release the current mouse capture if it is on an element within this
        /// document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReleaseCapture();
		
		/// <summary>
        /// Use the given DOM element as the source image of target |-moz-element()|.
        ///
        /// This function introduces a new special ID (called "image element ID"),
        /// which is only used by |-moz-element()|, and associates it with the given
        /// DOM element.  Image elements ID's have the higher precedence than general
        /// HTML id's, so if |document.mozSetImageElement(<id>, <element>)| is called,
        /// |-moz-element(#<id>)| uses |<element>| as the source image even if there
        /// is another element with id attribute = |<id>|.  To unregister an image
        /// element ID |<id>|, call |document.mozSetImageElement(<id>, null)|.
        ///
        /// Example:
        /// <script>
        /// canvas = document.createElement("canvas");
        /// canvas.setAttribute("width", 100);
        /// canvas.setAttribute("height", 100);
        /// // draw to canvas
        /// document.mozSetImageElement("canvasbg", canvas);
        /// </script>
        /// <div style="background-image: -moz-element(#canvasbg);"></div>
        ///
        /// @param aImageElementId an image element ID to associate with
        /// |aImageElement|
        /// @param aImageElement a DOM element to be used as the source image of
        /// |-moz-element(#aImageElementId)|. If this is null, the function will
        /// unregister the image element ID |aImageElementId|.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MozSetImageElement([MarshalAs(UnmanagedType.LPStruct)] nsAString aImageElementId, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aImageElement);
	}
	
	/// <summary>
    /// WARNING! This interface is currently not exposed to script in classinfo
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fee67aed-3b94-4136-ad7d-fb88ef23f45f")]
	public interface nsIDOMNSDocument_MOZILLA_2_0_BRANCH
	{
		
		/// <summary>
        /// WARNING! This interface is currently not exposed to script in classinfo
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetMozCurrentStateObjectAttribute();
	}
}
