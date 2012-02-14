using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;

using Juice.Framework;


namespace Juice {
	[PersistChildren(true)]
	[ParseChildren(typeof(AccordionPanel), DefaultProperty = "AccordionPanels", ChildrenAsProperties = true)]
	public class Accordion : JuiceScriptControl {

		public Accordion() : base("accordion") { }

		#region Widget Options

		/// <summary>
		/// Selector for the active element. Set to false to display none at start. Needs collapsible: true.
		/// Reference: http://jqueryui.com/demos/accordion/#active
		/// </summary>
		[WidgetOption("active", "0")]
		public string Active { get; set; }

		/// <summary>
		/// Choose your favorite animation, or disable them (set to false). In addition to the default, 'bounceslide' and all defined easing methods are supported ('bounceslide' requires UI Effects Core).
		/// Reference: http://jqueryui.com/demos/accordion/#animated
		/// </summary>
		[WidgetOption("animated", "slide")]
		public string Animated { get; set; }

		/// <summary>
		/// If set, the highest content part is used as height reference for all other parts. Provides more consistent animations.
		/// Reference: http://jqueryui.com/demos/accordion/#autoHeight
		/// </summary>
		[WidgetOption("autoHeight", true)]
		public bool AutoHeight { get; set; }

		/// <summary>
		/// If set, clears height and overflow styles after finishing animations. This enables accordions to work with dynamic content. Won't work together with autoHeight.
		/// Reference: http://jqueryui.com/demos/accordion/#clearStyle
		/// </summary>
		[WidgetOption("clearStyle", false)]
		public bool ClearStyle { get; set; }

		/// <summary>
		/// Whether all the sections can be closed at once. Allows collapsing the active section by the triggering event (click is the default).
		/// Reference: http://jqueryui.com/demos/accordion/#collapsible
		/// </summary>
		[WidgetOption("collapsible", false)]
		public bool Collapsible { get; set; }

		/// <summary>
		/// The event on which to trigger the accordion.
		/// Reference: http://jqueryui.com/demos/accordion/#event
		/// </summary>
		[WidgetOption("event", "click")]
		public string Event { get; set; }

		/// <summary>
		/// If set, the accordion completely fills the height of the parent element. Overrides autoheight.
		/// Reference: http://jqueryui.com/demos/accordion/#fillSpace
		/// </summary>
		[WidgetOption("fillSpace", false)]
		public bool FillSpace { get; set; }

		/// <summary>
		/// Selector for the header element.
		/// Reference: http://jqueryui.com/demos/accordion/#header
		/// </summary>
		[WidgetOption("header", "> li > :first-child,> :not(li):even")]
		public string Header { get; set; }

		/// <summary>
		/// Icons to use for headers. Icons may be specified for 'header' and 'headerSelected', and we recommend using the icons native to the jQuery UI CSS Framework manipulated by jQuery UI ThemeRoller
		/// Reference: http://jqueryui.com/demos/accordion/#icons
		/// </summary>
		[WidgetOption("icons", "{}", Eval = true)]
		public string Icons { get; set; }

		/// <summary>
		/// If set, looks for the anchor that matches location.href and activates it. Great for href-based state-saving. Use navigationFilter to implement your own matcher.
		/// Reference: http://jqueryui.com/demos/accordion/#navigation
		/// </summary>
		[WidgetOption("navigation", false)]
		public bool Navigation { get; set; }

		/// <summary>
		/// Overwrite the default location.href-matching with your own matcher.
		/// Reference: http://jqueryui.com/demos/accordion/#navigationFilter
		/// </summary>
		[WidgetOption("navigationFilter", "{}", Eval = true)]
		public string NavigationFilter { get; set; }

		#endregion

		[PersistenceMode(PersistenceMode.InnerProperty)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public List<AccordionPanel> AccordionPanels { get; set; }

		protected override HtmlTextWriterTag TagKey {
			get {
				return HtmlTextWriterTag.Div;
			}
		}

		protected override void Render(HtmlTextWriter writer) {
			
			this.RenderBeginTag(writer);

			foreach(AccordionPanel panel in AccordionPanels) {
				// Write out the header <h3><a>Title</a></h3> structure.
				writer.WriteFullBeginTag("h3");

				writer.WriteBeginTag("a");

				writer.AddAttribute("href", "#");

				writer.Write(HtmlTextWriter.TagRightChar);

				writer.Write(panel.Title);

				writer.WriteEndTag("a");

				writer.WriteEndTag("h3");

				// Write out the <div> that contains the panel's content.
				writer.WriteFullBeginTag("div");

				panel.TemplateContainer.RenderControl(writer);

				writer.WriteEndTag("div");
			}

			this.RenderEndTag(writer);
		}
	}
}
