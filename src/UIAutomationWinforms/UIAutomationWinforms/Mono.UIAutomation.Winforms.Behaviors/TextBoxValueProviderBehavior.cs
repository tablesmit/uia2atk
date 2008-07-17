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

namespace Mono.UIAutomation.Winforms.Behaviors
{

	internal class TextBoxValueProviderBehavior 
		: ProviderBehavior, IValueProvider
	{

		#region Constructor
		
		public TextBoxValueProviderBehavior (FragmentControlProvider provider)
			: base (provider)
		{
		}

		#endregion
		
		#region ProviderBehavior: Specialization

		public override AutomationPattern ProviderPattern { 
			get { return ValuePatternIdentifiers.Pattern; }
		}

		public override void Connect (Control control)
		{
		}

		public override void Disconnect (Control control)
		{
		}

		public override object GetPropertyValue (int propertyId)
		{
			if (propertyId == AutomationElementIdentifiers.ControlTypeProperty.Id)
				return ControlType.Edit.Id;
			else if (propertyId == AutomationElementIdentifiers.LocalizedControlTypeProperty.Id)
				return "edit";
			else if (propertyId == ValuePatternIdentifiers.IsReadOnlyProperty.Id)
				return IsReadOnly;
			else if (propertyId == ValuePatternIdentifiers.ValueProperty.Id)
				return Value;
			else
				return null;
		}
		
		#endregion

		#region IValueProvider: Specialization
		
		public bool IsReadOnly {
			get { return ((TextBoxBase) Provider.Control).ReadOnly; }
		}
		
		public string Value {
			get { return Provider.Control.Text; }
		}

		public void SetValue (string value)
		{
			if (IsReadOnly)
				throw new ElementNotEnabledException ();

			Provider.Control.Text = value;
		}
		
		#endregion

	}
}
