// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    
    internal partial class SelectReferenceDialog {
        
        private Gtk.VBox vbox5;
        
        private Gtk.VPaned vpaned1;
        
        private Gtk.Notebook mainBook;
        
        private Gtk.Label label7;
        
        private Gtk.Label label6;
        
        private Gtk.VBox vbox76;
        
        private Gtk.Label label114;
        
        private Gtk.HBox hbox4;
        
        private Gtk.ScrolledWindow scrolledwindow2;
        
        private Gtk.TreeView ReferencesTreeView;
        
        private Gtk.VBox vbox70;
        
        private Gtk.Button RemoveReferenceButton;
        
        private Gtk.Image but;
        
        private Gtk.Button cancelbutton;
        
        private Gtk.Button okbutton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget MonoDevelop.Ide.Gui.Dialogs.SelectReferenceDialog
            this.WidthRequest = 640;
            this.HeightRequest = 520;
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.SelectReferenceDialog";
            this.Title = "Edit References";
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.Modal = true;
            this.BorderWidth = ((uint)(6));
            this.DefaultWidth = 520;
            this.DefaultHeight = 570;
            this.DestroyWithParent = true;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.SelectReferenceDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog-vbox2";
            w1.Spacing = 6;
            // Container child dialog-vbox2.Gtk.Box+BoxChild
            this.vbox5 = new Gtk.VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Spacing = 12;
            this.vbox5.BorderWidth = ((uint)(6));
            // Container child vbox5.Gtk.Box+BoxChild
            this.vpaned1 = new Gtk.VPaned();
            this.vpaned1.Name = "vpaned1";
            this.vpaned1.Position = 256;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.mainBook = new Gtk.Notebook();
            this.mainBook.Name = "mainBook";
            this.mainBook.CurrentPage = 0;
            // Container child mainBook.Gtk.Notebook+NotebookChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.Xalign = 0F;
            this.label7.Yalign = 0F;
            this.label7.LabelProp = "label7";
            this.mainBook.Add(this.label7);
            Gtk.Notebook.NotebookChild w2 = ((Gtk.Notebook.NotebookChild)(this.mainBook[this.label7]));
            w2.TabExpand = false;
            // Notebook tab
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.Xalign = 0F;
            this.label6.Yalign = 0F;
            this.label6.LabelProp = "label6";
            this.mainBook.SetTabLabel(this.label7, this.label6);
            this.vpaned1.Add(this.mainBook);
            Gtk.Paned.PanedChild w3 = ((Gtk.Paned.PanedChild)(this.vpaned1[this.mainBook]));
            w3.Resize = false;
            w3.Shrink = false;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.vbox76 = new Gtk.VBox();
            this.vbox76.Name = "vbox76";
            this.vbox76.Spacing = 6;
            // Container child vbox76.Gtk.Box+BoxChild
            this.label114 = new Gtk.Label();
            this.label114.Name = "label114";
            this.label114.Xalign = 0F;
            this.label114.LabelProp = Mono.Unix.Catalog.GetString("Selected references:");
            this.vbox76.Add(this.label114);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox76[this.label114]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox76.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.HeightRequest = 150;
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 12;
            // Container child hbox4.Gtk.Box+BoxChild
            this.scrolledwindow2 = new Gtk.ScrolledWindow();
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            this.ReferencesTreeView = new Gtk.TreeView();
            this.ReferencesTreeView.Name = "ReferencesTreeView";
            this.ReferencesTreeView.HeadersClickable = true;
            this.scrolledwindow2.Add(this.ReferencesTreeView);
            this.hbox4.Add(this.scrolledwindow2);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox4[this.scrolledwindow2]));
            w6.Position = 0;
            // Container child hbox4.Gtk.Box+BoxChild
            this.vbox70 = new Gtk.VBox();
            this.vbox70.Name = "vbox70";
            // Container child vbox70.Gtk.Box+BoxChild
            this.RemoveReferenceButton = new Gtk.Button();
            Gtk.Tooltips w7 = new Gtk.Tooltips();
            w7.SetTip(this.RemoveReferenceButton, "Remove", "Remove");
            this.RemoveReferenceButton.Name = "RemoveReferenceButton";
            // Container child RemoveReferenceButton.Gtk.Container+ContainerChild
            this.but = new Gtk.Image();
            this.but.Name = "but";
            this.but.Xalign = 0F;
            this.but.Yalign = 0F;
            this.but.Pixbuf = Stetic.IconLoader.LoadIcon("gtk-remove", 20);
            this.RemoveReferenceButton.Add(this.but);
            this.RemoveReferenceButton.Label = null;
            this.vbox70.Add(this.RemoveReferenceButton);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox70[this.RemoveReferenceButton]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            this.hbox4.Add(this.vbox70);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.hbox4[this.vbox70]));
            w10.Position = 1;
            w10.Expand = false;
            w10.Fill = false;
            this.vbox76.Add(this.hbox4);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vbox76[this.hbox4]));
            w11.Position = 1;
            this.vpaned1.Add(this.vbox76);
            Gtk.Paned.PanedChild w12 = ((Gtk.Paned.PanedChild)(this.vpaned1[this.vbox76]));
            w12.Resize = false;
            this.vbox5.Add(this.vpaned1);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vbox5[this.vpaned1]));
            w13.Position = 0;
            w1.Add(this.vbox5);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(w1[this.vbox5]));
            w14.Position = 0;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.SelectReferenceDialog.ActionArea
            Gtk.HButtonBox w15 = this.ActionArea;
            w15.Name = "dialog-action_area2";
            w15.Spacing = 10;
            w15.BorderWidth = ((uint)(5));
            w15.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog-action_area2.Gtk.ButtonBox+ButtonBoxChild
            this.cancelbutton = new Gtk.Button();
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.UseStock = true;
            this.cancelbutton.UseUnderline = true;
            this.cancelbutton.Label = "gtk-cancel";
            this.AddActionWidget(this.cancelbutton, -6);
            // Container child dialog-action_area2.Gtk.ButtonBox+ButtonBoxChild
            this.okbutton = new Gtk.Button();
            this.okbutton.Name = "okbutton";
            this.okbutton.UseStock = true;
            this.okbutton.UseUnderline = true;
            this.okbutton.Label = "gtk-ok";
            this.AddActionWidget(this.okbutton, -5);
            Gtk.ButtonBox.ButtonBoxChild w17 = ((Gtk.ButtonBox.ButtonBoxChild)(w15[this.okbutton]));
            w17.Position = 1;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.RemoveReferenceButton.Clicked += new System.EventHandler(this.RemoveReference);
        }
    }
}
