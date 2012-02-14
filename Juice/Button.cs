using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Juice.Framework;

namespace Juice {

	/// <summary>
	/// Extend a TextBox with the jQuery UI Button http://jqueryui.com/demos/button/
	/// </summary>
	/// <remarks>Click Events should be handled on the extended control, natively.</remarks>
	[TargetControlType(typeof(HtmlAnchor))]
	[TargetControlType(typeof(HtmlGenericControl))] // supporting HtmlGenericControl to allow people to use on <div runat="server"/>
	[TargetControlType(typeof(HtmlButton))]
	[WidgetEvent("create")]
	public class Button : JuiceExtender {

		public Button() : base("button") { }

		#region Widget Options

		/// <summary>
		/// Disables (true) or enables (false) the button. Can be set when initialising (first creating) the button.
		/// Reference: http://jqueryui.com/demos/button/#disabled
		/// </summary>
		[WidgetOption("disabled", false)]
		public bool Disabled { get; set; }

		/// <summary>
		/// Whether to show any text - when set to false (display no text), icons (see icons option) must be enabled, otherwise it'll be ignored.
		/// Reference: http://jqueryui.com/demos/button/#text
		/// </summary>
		[WidgetOption("text", true)]
		public bool Text { get; set; }

		/// <summary>
		/// Icons to display, with or without text (see text option). The primary icon is displayed by default on the left of the label text, the secondary by default is on the right. Value for the primary and secondary properties must be a classname (String), eg. "ui-icon-gear". For using only one icon: icons: {primary:'ui-icon-locked'}. For using two icons: icons: {primary:'ui-icon-gear',secondary:'ui-icon-triangle-1-s'}
		/// Reference: http://jqueryui.com/demos/button/#icons
		/// </summary>
		[WidgetOption("icons", "{}", Eval = true)]
		public string Icons { get; set; }

		/// <summary>
		/// Text to show on the button. When not specified (null), the element's html content is used, or its value attribute when it's an input element of type submit or reset; or the html content of the associated label element if its an input of type radio or checkbox
		/// Reference: http://jqueryui.com/demos/button/#label
		/// </summary>
		[WidgetOption("label", null)]
		public string Label { get; set; }

		#endregion

		#region Widget Events


		#endregion

	}
}