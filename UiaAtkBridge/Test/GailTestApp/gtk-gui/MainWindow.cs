// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.UIManager UIManager;
    
    private Gtk.Action XFileAction;
    
    private Gtk.Action GimmeHelpAction;
    
    private Gtk.Action AboutAction;
    
    private Gtk.Action QuitAction;
    
    private Gtk.Action SomeEditMenuAction;
    
    private Gtk.Action NewAction;
    
    private Gtk.Action Action1;
    
    private Gtk.Action indexAction;
    
    private Gtk.Action cdromAction;
    
    private Gtk.RadioAction RadioInToolBarTest1Action;
    
    private Gtk.RadioAction RadioInToolBarTest2Action;
    
    private Gtk.VBox vbox1;
    
    private Gtk.MenuBar menubar1;
    
    private Gtk.Toolbar toolbar1;
    
    private Gtk.Notebook notebook1;
    
    private Gtk.HBox hbox1;
    
    private Gtk.ScrolledWindow GtkScrolledWindow;
    
    private Gtk.TreeView treeview2;
    
    private Gtk.Table table1;
    
    private Gtk.Button btnTest1;
    
    private Gtk.Button btnWithImg;
    
    private Gtk.ComboBoxEntry cbeTest;
    
    private Gtk.ComboBox cbxTest;
    
    private Gtk.CheckButton checkbutton1;
    
    private Gtk.CheckButton chkTest;
    
    private Gtk.Label lblTest1;
    
    private Gtk.Entry maskedEntry;
    
    private Gtk.RadioButton radiobutton1;
    
    private Gtk.RadioButton radiobutton2;
    
    private Gtk.RadioButton radTest1;
    
    private Gtk.RadioButton radTest2;
    
    private Gtk.SpinButton spinbuttonTest1;
    
    private Gtk.Entry txtEntry;
    
    private Gtk.VScrollbar vscrollbar1;
    
    private Gtk.Image imgTest1;
    
    private Gtk.Image imgTest2;
    
    private Gtk.Label label1;
    
    private Gtk.Calendar calendar1;
    
    private Gtk.Label label2;
    
    private Gtk.ProgressBar progressbar1;
    
    private Gtk.HScrollbar hscrollbar1;
    
    private Gtk.HBox hbox2;
    
    private Gtk.HPaned hpaned1;
    
    private Gtk.VScale vscale1;
    
    private Gtk.ScrolledWindow GtkScrolledWindow2;
    
    private Gtk.NodeView nodeview1;
    
    private Gtk.ScrolledWindow GtkScrolledWindow1;
    
    private Gtk.TextView txtViewTest;
    
    private Gtk.Frame frame1;
    
    private Gtk.Alignment GtkAlignment;
    
    private Gtk.Label GtkLabel13;
    
    private Gtk.Statusbar statusbar1;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.UIManager = new Gtk.UIManager();
        Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
        this.XFileAction = new Gtk.Action("XFileAction", Mono.Unix.Catalog.GetString("XFile"), null, null);
        this.XFileAction.ShortLabel = Mono.Unix.Catalog.GetString("File");
        w1.Add(this.XFileAction, null);
        this.GimmeHelpAction = new Gtk.Action("GimmeHelpAction", Mono.Unix.Catalog.GetString("GimmeHelp"), null, null);
        this.GimmeHelpAction.ShortLabel = Mono.Unix.Catalog.GetString("Help");
        w1.Add(this.GimmeHelpAction, null);
        this.AboutAction = new Gtk.Action("AboutAction", Mono.Unix.Catalog.GetString("About"), null, null);
        this.AboutAction.ShortLabel = Mono.Unix.Catalog.GetString("About");
        w1.Add(this.AboutAction, null);
        this.QuitAction = new Gtk.Action("QuitAction", Mono.Unix.Catalog.GetString("Quit"), null, null);
        this.QuitAction.ShortLabel = Mono.Unix.Catalog.GetString("Quit");
        w1.Add(this.QuitAction, null);
        this.SomeEditMenuAction = new Gtk.Action("SomeEditMenuAction", Mono.Unix.Catalog.GetString("SomeEditMenu"), null, null);
        this.SomeEditMenuAction.ShortLabel = Mono.Unix.Catalog.GetString("SomeEditMenu");
        w1.Add(this.SomeEditMenuAction, null);
        this.NewAction = new Gtk.Action("NewAction", Mono.Unix.Catalog.GetString("New"), null, null);
        this.NewAction.ShortLabel = Mono.Unix.Catalog.GetString("New");
        w1.Add(this.NewAction, null);
        this.Action1 = new Gtk.Action("Action1", null, null, null);
        w1.Add(this.Action1, null);
        this.indexAction = new Gtk.Action("indexAction", null, Mono.Unix.Catalog.GetString("tooltipText"), "gtk-index");
        w1.Add(this.indexAction, null);
        this.cdromAction = new Gtk.Action("cdromAction", null, null, "gtk-cdrom");
        w1.Add(this.cdromAction, null);
        this.RadioInToolBarTest1Action = new Gtk.RadioAction("RadioInToolBarTest1Action", Mono.Unix.Catalog.GetString("RadioInToolBarTest1"), null, null, 0);
        this.RadioInToolBarTest1Action.Group = new GLib.SList(System.IntPtr.Zero);
        this.RadioInToolBarTest1Action.ShortLabel = Mono.Unix.Catalog.GetString("RadioInToolBarTest1");
        w1.Add(this.RadioInToolBarTest1Action, null);
        this.RadioInToolBarTest2Action = new Gtk.RadioAction("RadioInToolBarTest2Action", Mono.Unix.Catalog.GetString("RadioInToolBarTest2"), null, null, 0);
        this.RadioInToolBarTest2Action.Group = this.RadioInToolBarTest1Action.Group;
        this.RadioInToolBarTest2Action.ShortLabel = Mono.Unix.Catalog.GetString("RadioInToolBarTest2");
        w1.Add(this.RadioInToolBarTest2Action, null);
        this.UIManager.InsertActionGroup(w1, 0);
        this.AddAccelGroup(this.UIManager.AccelGroup);
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("MainWindow");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.vbox1 = new Gtk.VBox();
        this.vbox1.Name = "vbox1";
        this.vbox1.Spacing = 6;
        // Container child vbox1.Gtk.Box+BoxChild
        this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='XFileAction' action='XFileAction'><menuitem name='NewAction' action='NewAction'/><separator/><menuitem name='QuitAction' action='QuitAction'/></menu><menu name='SomeEditMenuAction' action='SomeEditMenuAction'/><menu name='GimmeHelpAction' action='GimmeHelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
        this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
        this.menubar1.Name = "menubar1";
        this.vbox1.Add(this.menubar1);
        Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
        w2.Position = 0;
        w2.Expand = false;
        w2.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.UIManager.AddUiFromString("<ui><toolbar name='toolbar1'><toolitem name='indexAction' action='indexAction'/><toolitem name='RadioInToolBarTest1Action' action='RadioInToolBarTest1Action'/><toolitem name='RadioInToolBarTest2Action' action='RadioInToolBarTest2Action'/></toolbar></ui>");
        this.toolbar1 = ((Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
        this.toolbar1.Name = "toolbar1";
        this.toolbar1.ShowArrow = false;
        this.toolbar1.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
        this.vbox1.Add(this.toolbar1);
        Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.toolbar1]));
        w3.Position = 1;
        w3.Expand = false;
        w3.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.notebook1 = new Gtk.Notebook();
        this.notebook1.CanFocus = true;
        this.notebook1.Name = "notebook1";
        this.notebook1.CurrentPage = 0;
        // Container child notebook1.Gtk.Notebook+NotebookChild
        this.hbox1 = new Gtk.HBox();
        this.hbox1.Name = "hbox1";
        this.hbox1.Spacing = 6;
        // Container child hbox1.Gtk.Box+BoxChild
        this.GtkScrolledWindow = new Gtk.ScrolledWindow();
        this.GtkScrolledWindow.Name = "GtkScrolledWindow";
        this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
        // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
        this.treeview2 = new Gtk.TreeView();
        this.treeview2.CanFocus = true;
        this.treeview2.Name = "treeview2";
        this.GtkScrolledWindow.Add(this.treeview2);
        this.hbox1.Add(this.GtkScrolledWindow);
        Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox1[this.GtkScrolledWindow]));
        w5.Position = 0;
        // Container child hbox1.Gtk.Box+BoxChild
        this.table1 = new Gtk.Table(((uint)(5)), ((uint)(3)), false);
        this.table1.Name = "table1";
        this.table1.RowSpacing = ((uint)(6));
        this.table1.ColumnSpacing = ((uint)(6));
        // Container child table1.Gtk.Table+TableChild
        this.btnTest1 = new Gtk.Button();
        this.btnTest1.CanFocus = true;
        this.btnTest1.Name = "btnTest1";
        this.btnTest1.UseUnderline = true;
        this.btnTest1.Label = Mono.Unix.Catalog.GetString("hey ya");
        this.table1.Add(this.btnTest1);
        Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table1[this.btnTest1]));
        w6.LeftAttach = ((uint)(2));
        w6.RightAttach = ((uint)(3));
        w6.XOptions = ((Gtk.AttachOptions)(4));
        w6.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.btnWithImg = new Gtk.Button();
        this.btnWithImg.CanFocus = true;
        this.btnWithImg.Name = "btnWithImg";
        this.btnWithImg.UseUnderline = true;
        this.btnWithImg.Label = Mono.Unix.Catalog.GetString("IMG");
        this.table1.Add(this.btnWithImg);
        Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table1[this.btnWithImg]));
        w7.TopAttach = ((uint)(3));
        w7.BottomAttach = ((uint)(4));
        w7.XOptions = ((Gtk.AttachOptions)(4));
        w7.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.cbeTest = Gtk.ComboBoxEntry.NewText();
        this.cbeTest.AppendText(Mono.Unix.Catalog.GetString("First element"));
        this.cbeTest.AppendText(Mono.Unix.Catalog.GetString("Second element"));
        this.cbeTest.AppendText(Mono.Unix.Catalog.GetString("Third element"));
        this.cbeTest.Name = "cbeTest";
        this.table1.Add(this.cbeTest);
        Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table1[this.cbeTest]));
        w8.TopAttach = ((uint)(1));
        w8.BottomAttach = ((uint)(2));
        w8.LeftAttach = ((uint)(2));
        w8.RightAttach = ((uint)(3));
        w8.XOptions = ((Gtk.AttachOptions)(4));
        w8.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.cbxTest = Gtk.ComboBox.NewText();
        this.cbxTest.AppendText(Mono.Unix.Catalog.GetString("FirstItem"));
        this.cbxTest.AppendText(Mono.Unix.Catalog.GetString("SecondItem"));
        this.cbxTest.AppendText(Mono.Unix.Catalog.GetString("LastItem"));
        this.cbxTest.Name = "cbxTest";
        this.table1.Add(this.cbxTest);
        Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table1[this.cbxTest]));
        w9.TopAttach = ((uint)(1));
        w9.BottomAttach = ((uint)(2));
        w9.LeftAttach = ((uint)(1));
        w9.RightAttach = ((uint)(2));
        w9.XOptions = ((Gtk.AttachOptions)(4));
        w9.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.checkbutton1 = new Gtk.CheckButton();
        this.checkbutton1.CanFocus = true;
        this.checkbutton1.Name = "checkbutton1";
        this.checkbutton1.Label = Mono.Unix.Catalog.GetString("checkbutton1");
        this.checkbutton1.DrawIndicator = true;
        this.checkbutton1.UseUnderline = true;
        this.table1.Add(this.checkbutton1);
        Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table1[this.checkbutton1]));
        w10.TopAttach = ((uint)(2));
        w10.BottomAttach = ((uint)(3));
        w10.XOptions = ((Gtk.AttachOptions)(4));
        w10.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.chkTest = new Gtk.CheckButton();
        this.chkTest.CanFocus = true;
        this.chkTest.Name = "chkTest";
        this.chkTest.Label = Mono.Unix.Catalog.GetString("checkbutton1");
        this.chkTest.DrawIndicator = true;
        this.chkTest.UseUnderline = true;
        this.table1.Add(this.chkTest);
        Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table1[this.chkTest]));
        w11.TopAttach = ((uint)(1));
        w11.BottomAttach = ((uint)(2));
        w11.XOptions = ((Gtk.AttachOptions)(4));
        w11.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.lblTest1 = new Gtk.Label();
        this.lblTest1.Name = "lblTest1";
        this.lblTest1.LabelProp = Mono.Unix.Catalog.GetString("This is a test message\nin a label");
        this.table1.Add(this.lblTest1);
        Gtk.Table.TableChild w12 = ((Gtk.Table.TableChild)(this.table1[this.lblTest1]));
        w12.XOptions = ((Gtk.AttachOptions)(4));
        w12.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.maskedEntry = new Gtk.Entry();
        this.maskedEntry.CanFocus = true;
        this.maskedEntry.Name = "maskedEntry";
        this.maskedEntry.IsEditable = true;
        this.maskedEntry.InvisibleChar = '●';
        this.table1.Add(this.maskedEntry);
        Gtk.Table.TableChild w13 = ((Gtk.Table.TableChild)(this.table1[this.maskedEntry]));
        w13.TopAttach = ((uint)(4));
        w13.BottomAttach = ((uint)(5));
        w13.LeftAttach = ((uint)(2));
        w13.RightAttach = ((uint)(3));
        w13.XOptions = ((Gtk.AttachOptions)(4));
        w13.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.radiobutton1 = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("radiobutton1"));
        this.radiobutton1.CanFocus = true;
        this.radiobutton1.Name = "radiobutton1";
        this.radiobutton1.DrawIndicator = true;
        this.radiobutton1.UseUnderline = true;
        this.radiobutton1.Group = new GLib.SList(System.IntPtr.Zero);
        this.table1.Add(this.radiobutton1);
        Gtk.Table.TableChild w14 = ((Gtk.Table.TableChild)(this.table1[this.radiobutton1]));
        w14.TopAttach = ((uint)(3));
        w14.BottomAttach = ((uint)(4));
        w14.LeftAttach = ((uint)(1));
        w14.RightAttach = ((uint)(2));
        w14.XOptions = ((Gtk.AttachOptions)(4));
        w14.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.radiobutton2 = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("radiobutton2"));
        this.radiobutton2.CanFocus = true;
        this.radiobutton2.Name = "radiobutton2";
        this.radiobutton2.DrawIndicator = true;
        this.radiobutton2.UseUnderline = true;
        this.radiobutton2.Group = this.radiobutton1.Group;
        this.table1.Add(this.radiobutton2);
        Gtk.Table.TableChild w15 = ((Gtk.Table.TableChild)(this.table1[this.radiobutton2]));
        w15.TopAttach = ((uint)(3));
        w15.BottomAttach = ((uint)(4));
        w15.LeftAttach = ((uint)(2));
        w15.RightAttach = ((uint)(3));
        w15.XOptions = ((Gtk.AttachOptions)(4));
        w15.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.radTest1 = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("rad Opt 0"));
        this.radTest1.CanFocus = true;
        this.radTest1.Name = "radTest1";
        this.radTest1.DrawIndicator = true;
        this.radTest1.UseUnderline = true;
        this.radTest1.Group = new GLib.SList(System.IntPtr.Zero);
        this.table1.Add(this.radTest1);
        Gtk.Table.TableChild w16 = ((Gtk.Table.TableChild)(this.table1[this.radTest1]));
        w16.TopAttach = ((uint)(2));
        w16.BottomAttach = ((uint)(3));
        w16.LeftAttach = ((uint)(1));
        w16.RightAttach = ((uint)(2));
        w16.XOptions = ((Gtk.AttachOptions)(4));
        w16.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.radTest2 = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("rad Opt 1"));
        this.radTest2.CanFocus = true;
        this.radTest2.Name = "radTest2";
        this.radTest2.DrawIndicator = true;
        this.radTest2.UseUnderline = true;
        this.radTest2.Group = this.radTest1.Group;
        this.table1.Add(this.radTest2);
        Gtk.Table.TableChild w17 = ((Gtk.Table.TableChild)(this.table1[this.radTest2]));
        w17.TopAttach = ((uint)(2));
        w17.BottomAttach = ((uint)(3));
        w17.LeftAttach = ((uint)(2));
        w17.RightAttach = ((uint)(3));
        w17.XOptions = ((Gtk.AttachOptions)(4));
        w17.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.spinbuttonTest1 = new Gtk.SpinButton(0, 100, 1);
        this.spinbuttonTest1.CanFocus = true;
        this.spinbuttonTest1.Name = "spinbuttonTest1";
        this.spinbuttonTest1.Adjustment.PageIncrement = 10;
        this.spinbuttonTest1.ClimbRate = 1;
        this.spinbuttonTest1.Numeric = true;
        this.table1.Add(this.spinbuttonTest1);
        Gtk.Table.TableChild w18 = ((Gtk.Table.TableChild)(this.table1[this.spinbuttonTest1]));
        w18.TopAttach = ((uint)(4));
        w18.BottomAttach = ((uint)(5));
        w18.XOptions = ((Gtk.AttachOptions)(4));
        w18.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.txtEntry = new Gtk.Entry();
        this.txtEntry.CanFocus = true;
        this.txtEntry.Name = "txtEntry";
        this.txtEntry.Text = Mono.Unix.Catalog.GetString("test text");
        this.txtEntry.IsEditable = true;
        this.txtEntry.InvisibleChar = '●';
        this.table1.Add(this.txtEntry);
        Gtk.Table.TableChild w19 = ((Gtk.Table.TableChild)(this.table1[this.txtEntry]));
        w19.LeftAttach = ((uint)(1));
        w19.RightAttach = ((uint)(2));
        w19.XOptions = ((Gtk.AttachOptions)(4));
        w19.YOptions = ((Gtk.AttachOptions)(4));
        this.hbox1.Add(this.table1);
        Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox1[this.table1]));
        w20.Position = 1;
        w20.Expand = false;
        w20.Fill = false;
        // Container child hbox1.Gtk.Box+BoxChild
        this.vscrollbar1 = new Gtk.VScrollbar(null);
        this.vscrollbar1.Name = "vscrollbar1";
        this.vscrollbar1.Adjustment.Upper = 100;
        this.vscrollbar1.Adjustment.PageIncrement = 10;
        this.vscrollbar1.Adjustment.PageSize = 10;
        this.vscrollbar1.Adjustment.StepIncrement = 1;
        this.hbox1.Add(this.vscrollbar1);
        Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.hbox1[this.vscrollbar1]));
        w21.Position = 2;
        w21.Expand = false;
        w21.Fill = false;
        // Container child hbox1.Gtk.Box+BoxChild
        this.imgTest1 = new Gtk.Image();
        this.imgTest1.Name = "imgTest1";
        this.hbox1.Add(this.imgTest1);
        Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.hbox1[this.imgTest1]));
        w22.Position = 3;
        w22.Expand = false;
        w22.Fill = false;
        // Container child hbox1.Gtk.Box+BoxChild
        this.imgTest2 = new Gtk.Image();
        this.imgTest2.Name = "imgTest2";
        this.hbox1.Add(this.imgTest2);
        Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.hbox1[this.imgTest2]));
        w23.Position = 5;
        w23.Expand = false;
        w23.Fill = false;
        this.notebook1.Add(this.hbox1);
        // Notebook tab
        this.label1 = new Gtk.Label();
        this.label1.Name = "label1";
        this.label1.LabelProp = Mono.Unix.Catalog.GetString("page1");
        this.notebook1.SetTabLabel(this.hbox1, this.label1);
        this.label1.ShowAll();
        // Container child notebook1.Gtk.Notebook+NotebookChild
        this.calendar1 = new Gtk.Calendar();
        this.calendar1.CanFocus = true;
        this.calendar1.Name = "calendar1";
        this.calendar1.DisplayOptions = ((Gtk.CalendarDisplayOptions)(3));
        this.notebook1.Add(this.calendar1);
        Gtk.Notebook.NotebookChild w25 = ((Gtk.Notebook.NotebookChild)(this.notebook1[this.calendar1]));
        w25.Position = 1;
        // Notebook tab
        this.label2 = new Gtk.Label();
        this.label2.Name = "label2";
        this.label2.LabelProp = Mono.Unix.Catalog.GetString("page2");
        this.notebook1.SetTabLabel(this.calendar1, this.label2);
        this.label2.ShowAll();
        this.vbox1.Add(this.notebook1);
        Gtk.Box.BoxChild w26 = ((Gtk.Box.BoxChild)(this.vbox1[this.notebook1]));
        w26.Position = 2;
        w26.Expand = false;
        w26.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.progressbar1 = new Gtk.ProgressBar();
        this.progressbar1.Name = "progressbar1";
        this.vbox1.Add(this.progressbar1);
        Gtk.Box.BoxChild w27 = ((Gtk.Box.BoxChild)(this.vbox1[this.progressbar1]));
        w27.Position = 3;
        w27.Expand = false;
        w27.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hscrollbar1 = new Gtk.HScrollbar(null);
        this.hscrollbar1.Name = "hscrollbar1";
        this.hscrollbar1.Adjustment.Upper = 100;
        this.hscrollbar1.Adjustment.PageIncrement = 10;
        this.hscrollbar1.Adjustment.PageSize = 10;
        this.hscrollbar1.Adjustment.StepIncrement = 1;
        this.hscrollbar1.Adjustment.Value = 9.28317766722556;
        this.vbox1.Add(this.hscrollbar1);
        Gtk.Box.BoxChild w28 = ((Gtk.Box.BoxChild)(this.vbox1[this.hscrollbar1]));
        w28.Position = 4;
        w28.Expand = false;
        w28.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox2 = new Gtk.HBox();
        this.hbox2.Name = "hbox2";
        this.hbox2.Spacing = 6;
        // Container child hbox2.Gtk.Box+BoxChild
        this.hpaned1 = new Gtk.HPaned();
        this.hpaned1.CanFocus = true;
        this.hpaned1.Name = "hpaned1";
        this.hpaned1.Position = 19;
        // Container child hpaned1.Gtk.Paned+PanedChild
        this.vscale1 = new Gtk.VScale(null);
        this.vscale1.CanFocus = true;
        this.vscale1.Name = "vscale1";
        this.vscale1.Adjustment.Upper = 100;
        this.vscale1.Adjustment.PageIncrement = 10;
        this.vscale1.Adjustment.StepIncrement = 1;
        this.vscale1.DrawValue = true;
        this.vscale1.Digits = 0;
        this.vscale1.ValuePos = ((Gtk.PositionType)(2));
        this.hpaned1.Add(this.vscale1);
        Gtk.Paned.PanedChild w29 = ((Gtk.Paned.PanedChild)(this.hpaned1[this.vscale1]));
        w29.Resize = false;
        // Container child hpaned1.Gtk.Paned+PanedChild
        this.GtkScrolledWindow2 = new Gtk.ScrolledWindow();
        this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
        this.GtkScrolledWindow2.ShadowType = ((Gtk.ShadowType)(1));
        // Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
        this.nodeview1 = new Gtk.NodeView();
        this.nodeview1.CanFocus = true;
        this.nodeview1.Name = "nodeview1";
        this.GtkScrolledWindow2.Add(this.nodeview1);
        this.hpaned1.Add(this.GtkScrolledWindow2);
        this.hbox2.Add(this.hpaned1);
        Gtk.Box.BoxChild w32 = ((Gtk.Box.BoxChild)(this.hbox2[this.hpaned1]));
        w32.Position = 0;
        // Container child hbox2.Gtk.Box+BoxChild
        this.GtkScrolledWindow1 = new Gtk.ScrolledWindow();
        this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
        this.GtkScrolledWindow1.ShadowType = ((Gtk.ShadowType)(1));
        // Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
        this.txtViewTest = new Gtk.TextView();
        this.txtViewTest.CanFocus = true;
        this.txtViewTest.Name = "txtViewTest";
        this.GtkScrolledWindow1.Add(this.txtViewTest);
        this.hbox2.Add(this.GtkScrolledWindow1);
        Gtk.Box.BoxChild w34 = ((Gtk.Box.BoxChild)(this.hbox2[this.GtkScrolledWindow1]));
        w34.Position = 1;
        // Container child hbox2.Gtk.Box+BoxChild
        this.frame1 = new Gtk.Frame();
        this.frame1.Name = "frame1";
        this.frame1.ShadowType = ((Gtk.ShadowType)(0));
        // Container child frame1.Gtk.Container+ContainerChild
        this.GtkAlignment = new Gtk.Alignment(0F, 0F, 1F, 1F);
        this.GtkAlignment.Name = "GtkAlignment";
        this.GtkAlignment.LeftPadding = ((uint)(12));
        this.frame1.Add(this.GtkAlignment);
        this.GtkLabel13 = new Gtk.Label();
        this.GtkLabel13.Name = "GtkLabel13";
        this.GtkLabel13.LabelProp = Mono.Unix.Catalog.GetString("<b>frame1</b>");
        this.GtkLabel13.UseMarkup = true;
        this.frame1.LabelWidget = this.GtkLabel13;
        this.hbox2.Add(this.frame1);
        Gtk.Box.BoxChild w36 = ((Gtk.Box.BoxChild)(this.hbox2[this.frame1]));
        w36.Position = 2;
        w36.Expand = false;
        w36.Fill = false;
        this.vbox1.Add(this.hbox2);
        Gtk.Box.BoxChild w37 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
        w37.Position = 5;
        // Container child vbox1.Gtk.Box+BoxChild
        this.statusbar1 = new Gtk.Statusbar();
        this.statusbar1.Name = "statusbar1";
        this.statusbar1.Spacing = 6;
        this.vbox1.Add(this.statusbar1);
        Gtk.Box.BoxChild w38 = ((Gtk.Box.BoxChild)(this.vbox1[this.statusbar1]));
        w38.Position = 7;
        w38.Expand = false;
        w38.Fill = false;
        this.Add(this.vbox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 757;
        this.DefaultHeight = 516;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
    }
}
