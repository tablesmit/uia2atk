// Permission is hereby granted, free of charge, to any person obtaining 
// a copy of this software and associated documentation files (the 
// "Software"), to deal in the Software without restriction, including 
// without limitation the rights to use, copy, modify, merge, publish, 
// distribute, sublicense, and/or sell copies of the Software, and to 
// permit persons to whom the Software is furnished to do so, subject to 
// the following conditions: 
//  
// The above copyright notice and this permission notice shall be 
// included in all copies or substantial portions of the Software. 
//  
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF 
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE 
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION 
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION 
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. 
// 
// Copyright (c) 2008 Novell, Inc. (http://www.novell.com) 
// 
// Authors: 
//	Mario Carrion <mcarrion@novell.com>
// 

using System;
using System.Windows.Automation;
using System.Windows.Automation.Provider;
using System.Windows.Forms;
using Mono.UIAutomation.Winforms.Behaviors;
using Mono.UIAutomation.Winforms.Navigation;
using Mono.UIAutomation.Winforms.Behaviors.ListItem;

namespace Mono.UIAutomation.Winforms
{

	internal class ListItemProvider : FragmentControlProvider
	{

		#region Constructors

		public ListItemProvider (ListProvider provider, ListControl control) 
			: base (control)
		{
			listProvider = provider;
			listControl = control;
			
			SetBehavior (SelectionItemPatternIdentifiers.Pattern,
			             new SelectionProviderBehavior (this));	
			SetBehavior (ScrollItemPatternIdentifiers.Pattern,
			             new ScrollProviderBehavior (this));
			
			if (listControl is CheckedListBox)
				SetBehavior (TogglePatternIdentifiers.Pattern,
				             new ToggleProviderBehavior (this));				
		}

		#endregion
		
		#region IRawElementProviderSimple Members
		
		public override object GetPropertyValue (int propertyId)
		{
			if (propertyId == AutomationElementIdentifiers.ControlTypeProperty.Id)
				return ControlType.ListItem.Id;
			else if (propertyId == AutomationElementIdentifiers.LocalizedControlTypeProperty.Id)
				return "list item";
			else if (propertyId == AutomationElementIdentifiers.NameProperty.Id)
				return nameProperty;
			else if (propertyId == AutomationElementIdentifiers.HasKeyboardFocusProperty.Id)
				return ListControl.Focused && Index == ListControl.SelectedIndex;
			else if (propertyId == AutomationElementIdentifiers.IsKeyboardFocusableProperty.Id)
				return ListProvider.GetPropertyValue (propertyId);
			else
				return base.GetPropertyValue (propertyId);
		}

		#endregion
		
		#region Public Methods

		public override void InitializeEvents ()
		{
			base.InitializeEvents (); 
			
			nameProperty = ListProvider.GetItemName (this);
		}
		
		#endregion

		#region Public Properties

		public int Index {
			get { return ListProvider.IndexOfItem (this); }
		}	
		
		public ListControl ListControl {
			get { return listControl; }
		}

		public ListProvider ListProvider {
			get { return listProvider; }
		}

		#endregion	

		#region IRawElementProviderFragment Interface 

		public override IRawElementProviderFragmentRoot FragmentRoot {
			get { return ListProvider; }			
		}

		#endregion
		
		#region Protected Methods
		
		protected override System.Drawing.Rectangle GetControlScreenBounds ()
		{
			return ListProvider.GetItemBoundingRectangle (this);
		}
		
		#endregion
		
		#region Private Fields

		private ListControl listControl;
		private ListProvider listProvider;
		private string nameProperty;
		
		#endregion
		
	}
}
