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
// Copyright (c) 2009 Novell, Inc. (http://www.novell.com) 
// 
// Authors: 
//  Matt Guo <matt@mattguo.com>
// 

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Provider;
using Mono.UIAutomation.Services;
using Mono.UIAutomation.Source;
using DC = Mono.UIAutomation.UiaDbus;
using DCI = Mono.UIAutomation.UiaDbus.Interfaces;

namespace Mono.UIAutomation.UiaDbusSource
{
	public class UiaDbusWindowPattern : IWindowPattern
	{
		private DCI.IWindowPattern pattern;

		public UiaDbusWindowPattern (DCI.IWindowPattern pattern)
		{
			this.pattern = pattern;
		}

		public void Close ()
		{
			pattern.Close ();
		}

		public void SetWindowVisualState (WindowVisualState state)
		{
			pattern.SetVisualState (state);
		}

		public bool WaitForInputIdle (int milliseconds)
		{
			return pattern.WaitForInputIdle (milliseconds);
		}

		public WindowProperties Properties {
			get {
				try {
					WindowProperties properties = new WindowProperties () {
						WindowInteractionState = pattern.InteractionState,
						IsModal = pattern.IsModal,
						IsTopmost = pattern.IsTopmost,
						CanMaximize = pattern.Maximizable,
						CanMinimize = pattern.Minimizable,
						WindowVisualState = pattern.VisualState
					};
					return properties;
				} catch (Exception ex) {
					throw DbusExceptionTranslator.Translate (ex);
				}
			}
		}
	}
}