// 
// ValueViewerDialog.cs
//  
// Author:
//       Lluis Sanchez Gual <lluis@novell.com>
// 
// Copyright (c) 2010 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Linq;
using System.Collections.Generic;
using Mono.Debugging.Client;

namespace MonoDevelop.Debugger.Viewers
{
	public partial class ValueVisualizerDialog : Gtk.Dialog
	{
		List<ValueVisualizer> visualizers;
		Gtk.Widget currentWidget;
		ValueVisualizer currentVisualizer;
		ObjectValue value;
		
		public ValueVisualizerDialog ()
		{
			this.Build ();
			this.Modal = true;
		}
		
		public void Show (ObjectValue val)
		{
			value = val;
			visualizers = new List<ValueVisualizer> (DebuggingService.GetValueVisualizers (val));
			visualizers.Sort ((v1, v2) => string.Compare (v1.Name, v2.Name, StringComparison.CurrentCultureIgnoreCase));

			int defaultVis = 0;
			int n = 0;

			foreach (ValueVisualizer vis in visualizers) {
				comboVisualizers.AppendText (vis.Name);
				if (vis.IsDefaultVisualizer (val))
					defaultVis = n;
				n++;
			}

			comboVisualizers.Active = defaultVis;
			if (val.IsReadOnly || !visualizers.Any (v => v.CanEdit (val))) {
				buttonCancel.Label = Gtk.Stock.Close;
				buttonSave.Hide ();
			}
		}
		
		protected virtual void OnComboVisualizersChanged (object sender, EventArgs e)
		{
			if (currentWidget != null)
				mainBox.Remove (currentWidget);

			if (comboVisualizers.Active == -1) {
				buttonSave.Sensitive = false;
				return;
			}

			currentVisualizer = visualizers [comboVisualizers.Active];
			currentWidget = currentVisualizer.GetVisualizerWidget (value);
			buttonSave.Sensitive = currentVisualizer.CanEdit (value);
			mainBox.PackStart (currentWidget, true, true, 0);
			currentWidget.Show ();
		}
		
		protected virtual void OnSaveClicked (object sender, EventArgs e)
		{
			if (currentVisualizer == null || currentVisualizer.StoreValue (value))
				Respond (Gtk.ResponseType.Ok);
		}
	}
}

