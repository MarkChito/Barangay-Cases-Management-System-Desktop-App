﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Main))
        pnl_header = New Panel()
        img_notification = New PictureBox()
        Panel3 = New Panel()
        img_user = New PictureBox()
        btn_account = New Button()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        txt_search = New TextBox()
        btn_toggle_sidebar = New PictureBox()
        pnl_banner = New Panel()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Timer1 = New Timer(components)
        pnl_sidebar = New Panel()
        btn_logout = New Button()
        Panel8 = New Panel()
        Label3 = New Label()
        btn_barangay_news = New Button()
        Panel1 = New Panel()
        btn_temp_notification = New Button()
        btn_temp_account = New Button()
        btn_announcements = New Button()
        Panel10 = New Panel()
        btn_employees = New Button()
        Panel9 = New Panel()
        btn_citizens = New Button()
        pnl_spacer_btn_employees = New Panel()
        btn_pending_cases = New Button()
        Panel6 = New Panel()
        btn_barangay_cases = New Button()
        Panel7 = New Panel()
        btn_dashboard = New Button()
        Panel5 = New Panel()
        Label8 = New Label()
        Panel4 = New Panel()
        btn_temp = New Button()
        Image_Capture = New Image_Capture()
        pnl_footer_outer = New Panel()
        pnl_footer_inner = New Panel()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        Label1 = New Label()
        Announcements = New Announcements()
        Barangay_Cases = New Barangay_Cases()
        Barangay_News = New Barangay_News()
        Employees = New Employees()
        Pending_Cases = New Pending_Cases()
        Profile = New Profile()
        My_Profile = New My_Profile()
        img_loading = New PictureBox()
        Dashboard = New Dashboard()
        pnl_notification = New Panel()
        Label7 = New Label()
        pnl_account_details = New Panel()
        btn_open_website = New Button()
        btn_connect_to_mobile_app = New Button()
        btn_logout_2 = New Button()
        btn_developers = New Button()
        btn_account_settings = New Button()
        btn_my_profile = New Button()
        lbl_account_position = New Button()
        lbl_account_name = New Button()
        pnl_body = New Panel()
        Edit_Barangay_Case = New Edit_Barangay_Case()
        Add_Barangay_Case = New Add_Barangay_Case()
        pnl_header.SuspendLayout()
        CType(img_notification, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_user, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_toggle_sidebar, ComponentModel.ISupportInitialize).BeginInit()
        pnl_banner.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnl_sidebar.SuspendLayout()
        Panel8.SuspendLayout()
        Panel5.SuspendLayout()
        pnl_footer_outer.SuspendLayout()
        pnl_footer_inner.SuspendLayout()
        CType(img_loading, ComponentModel.ISupportInitialize).BeginInit()
        pnl_notification.SuspendLayout()
        pnl_account_details.SuspendLayout()
        pnl_body.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnl_header
        ' 
        pnl_header.BackColor = Color.White
        pnl_header.Controls.Add(img_notification)
        pnl_header.Controls.Add(Panel3)
        pnl_header.Controls.Add(img_user)
        pnl_header.Controls.Add(btn_account)
        pnl_header.Controls.Add(Panel2)
        pnl_header.Controls.Add(pnl_banner)
        pnl_header.Dock = DockStyle.Top
        pnl_header.Location = New Point(0, 0)
        pnl_header.Name = "pnl_header"
        pnl_header.Size = New Size(1334, 33)
        pnl_header.TabIndex = 1
        ' 
        ' img_notification
        ' 
        img_notification.BackColor = Color.Transparent
        img_notification.Cursor = Cursors.Hand
        img_notification.Dock = DockStyle.Right
        img_notification.Image = CType(resources.GetObject("img_notification.Image"), Image)
        img_notification.Location = New Point(1107, 0)
        img_notification.Name = "img_notification"
        img_notification.Size = New Size(33, 33)
        img_notification.SizeMode = PictureBoxSizeMode.CenterImage
        img_notification.TabIndex = 4
        img_notification.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(1140, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(13, 33)
        Panel3.TabIndex = 0
        ' 
        ' img_user
        ' 
        img_user.BackColor = Color.Transparent
        img_user.BorderStyle = BorderStyle.FixedSingle
        img_user.Cursor = Cursors.Hand
        img_user.Dock = DockStyle.Right
        img_user.Image = CType(resources.GetObject("img_user.Image"), Image)
        img_user.Location = New Point(1153, 0)
        img_user.Name = "img_user"
        img_user.Size = New Size(33, 33)
        img_user.SizeMode = PictureBoxSizeMode.StretchImage
        img_user.TabIndex = 3
        img_user.TabStop = False
        ' 
        ' btn_account
        ' 
        btn_account.AutoSize = True
        btn_account.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btn_account.BackColor = Color.Transparent
        btn_account.Cursor = Cursors.Hand
        btn_account.Dock = DockStyle.Right
        btn_account.FlatAppearance.BorderSize = 0
        btn_account.FlatAppearance.MouseDownBackColor = Color.White
        btn_account.FlatAppearance.MouseOverBackColor = Color.White
        btn_account.FlatStyle = FlatStyle.Flat
        btn_account.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_account.ForeColor = Color.FromArgb(CByte(1), CByte(41), CByte(112))
        btn_account.Location = New Point(1186, 0)
        btn_account.Name = "btn_account"
        btn_account.Size = New Size(148, 33)
        btn_account.TabIndex = 2
        btn_account.Text = "S. Administrator"
        btn_account.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(txt_search)
        Panel2.Controls.Add(btn_toggle_sidebar)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(288, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(382, 33)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(356, 6)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(20, 20)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' txt_search
        ' 
        txt_search.AutoCompleteCustomSource.AddRange(New String() {"Dashboard", "Barangay Cases", "New Barangay Case", "Pending Cases", "Employees", "Announcements", "Barangay News", "My Profile"})
        txt_search.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt_search.Cursor = Cursors.IBeam
        txt_search.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_search.Location = New Point(39, 3)
        txt_search.Name = "txt_search"
        txt_search.PlaceholderText = "Search"
        txt_search.Size = New Size(340, 26)
        txt_search.TabIndex = 37
        ' 
        ' btn_toggle_sidebar
        ' 
        btn_toggle_sidebar.Cursor = Cursors.Hand
        btn_toggle_sidebar.Dock = DockStyle.Left
        btn_toggle_sidebar.Image = CType(resources.GetObject("btn_toggle_sidebar.Image"), Image)
        btn_toggle_sidebar.Location = New Point(0, 0)
        btn_toggle_sidebar.Name = "btn_toggle_sidebar"
        btn_toggle_sidebar.Size = New Size(33, 33)
        btn_toggle_sidebar.SizeMode = PictureBoxSizeMode.CenterImage
        btn_toggle_sidebar.TabIndex = 2
        btn_toggle_sidebar.TabStop = False
        ' 
        ' pnl_banner
        ' 
        pnl_banner.BackColor = Color.White
        pnl_banner.Controls.Add(Label4)
        pnl_banner.Controls.Add(PictureBox2)
        pnl_banner.Dock = DockStyle.Left
        pnl_banner.Location = New Point(0, 0)
        pnl_banner.Name = "pnl_banner"
        pnl_banner.Size = New Size(288, 33)
        pnl_banner.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(1), CByte(41), CByte(112))
        Label4.Location = New Point(54, 1)
        Label4.Name = "Label4"
        Label4.Size = New Size(209, 31)
        Label4.TabIndex = 2
        Label4.Text = "Barangay CMS"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(18, 1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 30)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 500
        ' 
        ' pnl_sidebar
        ' 
        pnl_sidebar.BackColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        pnl_sidebar.Controls.Add(btn_logout)
        pnl_sidebar.Controls.Add(Panel8)
        pnl_sidebar.Controls.Add(btn_barangay_news)
        pnl_sidebar.Controls.Add(Panel1)
        pnl_sidebar.Controls.Add(btn_temp_notification)
        pnl_sidebar.Controls.Add(btn_temp_account)
        pnl_sidebar.Controls.Add(btn_announcements)
        pnl_sidebar.Controls.Add(Panel10)
        pnl_sidebar.Controls.Add(btn_employees)
        pnl_sidebar.Controls.Add(Panel9)
        pnl_sidebar.Controls.Add(btn_citizens)
        pnl_sidebar.Controls.Add(pnl_spacer_btn_employees)
        pnl_sidebar.Controls.Add(btn_pending_cases)
        pnl_sidebar.Controls.Add(Panel6)
        pnl_sidebar.Controls.Add(btn_barangay_cases)
        pnl_sidebar.Controls.Add(Panel7)
        pnl_sidebar.Controls.Add(btn_dashboard)
        pnl_sidebar.Controls.Add(Panel5)
        pnl_sidebar.Controls.Add(Panel4)
        pnl_sidebar.Controls.Add(btn_temp)
        pnl_sidebar.Dock = DockStyle.Left
        pnl_sidebar.Location = New Point(0, 33)
        pnl_sidebar.Name = "pnl_sidebar"
        pnl_sidebar.Size = New Size(288, 728)
        pnl_sidebar.TabIndex = 11
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = Color.Transparent
        btn_logout.Cursor = Cursors.Hand
        btn_logout.Dock = DockStyle.Top
        btn_logout.FlatAppearance.BorderSize = 0
        btn_logout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_logout.FlatStyle = FlatStyle.Flat
        btn_logout.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_logout.ForeColor = Color.White
        btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), Image)
        btn_logout.ImageAlign = ContentAlignment.MiddleLeft
        btn_logout.Location = New Point(21, 448)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(267, 44)
        btn_logout.TabIndex = 40
        btn_logout.Text = "      Logout"
        btn_logout.TextAlign = ContentAlignment.MiddleLeft
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(Label3)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(21, 408)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(267, 40)
        Panel8.TabIndex = 39
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlDark
        Label3.Location = New Point(6, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 16)
        Label3.TabIndex = 3
        Label3.Text = "Account"
        ' 
        ' btn_barangay_news
        ' 
        btn_barangay_news.BackColor = Color.Transparent
        btn_barangay_news.Cursor = Cursors.Hand
        btn_barangay_news.Dock = DockStyle.Top
        btn_barangay_news.FlatAppearance.BorderSize = 0
        btn_barangay_news.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_barangay_news.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_barangay_news.FlatStyle = FlatStyle.Flat
        btn_barangay_news.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_barangay_news.ForeColor = Color.White
        btn_barangay_news.Image = CType(resources.GetObject("btn_barangay_news.Image"), Image)
        btn_barangay_news.ImageAlign = ContentAlignment.MiddleLeft
        btn_barangay_news.Location = New Point(21, 364)
        btn_barangay_news.Name = "btn_barangay_news"
        btn_barangay_news.Size = New Size(267, 44)
        btn_barangay_news.TabIndex = 38
        btn_barangay_news.Text = "      Barangay News"
        btn_barangay_news.TextAlign = ContentAlignment.MiddleLeft
        btn_barangay_news.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(21, 354)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(267, 10)
        Panel1.TabIndex = 37
        ' 
        ' btn_temp_notification
        ' 
        btn_temp_notification.Location = New Point(-97, 552)
        btn_temp_notification.Name = "btn_temp_notification"
        btn_temp_notification.Size = New Size(75, 23)
        btn_temp_notification.TabIndex = 36
        btn_temp_notification.Text = "Button1"
        btn_temp_notification.UseVisualStyleBackColor = True
        ' 
        ' btn_temp_account
        ' 
        btn_temp_account.Location = New Point(-92, 689)
        btn_temp_account.Name = "btn_temp_account"
        btn_temp_account.Size = New Size(75, 23)
        btn_temp_account.TabIndex = 35
        btn_temp_account.Text = "Button1"
        btn_temp_account.UseVisualStyleBackColor = True
        ' 
        ' btn_announcements
        ' 
        btn_announcements.BackColor = Color.Transparent
        btn_announcements.Cursor = Cursors.Hand
        btn_announcements.Dock = DockStyle.Top
        btn_announcements.FlatAppearance.BorderSize = 0
        btn_announcements.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_announcements.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_announcements.FlatStyle = FlatStyle.Flat
        btn_announcements.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_announcements.ForeColor = Color.White
        btn_announcements.Image = CType(resources.GetObject("btn_announcements.Image"), Image)
        btn_announcements.ImageAlign = ContentAlignment.MiddleLeft
        btn_announcements.Location = New Point(21, 310)
        btn_announcements.Name = "btn_announcements"
        btn_announcements.Size = New Size(267, 44)
        btn_announcements.TabIndex = 32
        btn_announcements.Text = "      Announcements"
        btn_announcements.TextAlign = ContentAlignment.MiddleLeft
        btn_announcements.UseVisualStyleBackColor = False
        ' 
        ' Panel10
        ' 
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(21, 300)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(267, 10)
        Panel10.TabIndex = 31
        ' 
        ' btn_employees
        ' 
        btn_employees.BackColor = Color.Transparent
        btn_employees.Cursor = Cursors.Hand
        btn_employees.Dock = DockStyle.Top
        btn_employees.FlatAppearance.BorderSize = 0
        btn_employees.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_employees.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_employees.FlatStyle = FlatStyle.Flat
        btn_employees.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_employees.ForeColor = Color.White
        btn_employees.Image = CType(resources.GetObject("btn_employees.Image"), Image)
        btn_employees.ImageAlign = ContentAlignment.MiddleLeft
        btn_employees.Location = New Point(21, 256)
        btn_employees.Name = "btn_employees"
        btn_employees.Size = New Size(267, 44)
        btn_employees.TabIndex = 30
        btn_employees.Text = "      Employees"
        btn_employees.TextAlign = ContentAlignment.MiddleLeft
        btn_employees.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(21, 246)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(267, 10)
        Panel9.TabIndex = 29
        ' 
        ' btn_citizens
        ' 
        btn_citizens.BackColor = Color.Transparent
        btn_citizens.Cursor = Cursors.Hand
        btn_citizens.Dock = DockStyle.Top
        btn_citizens.FlatAppearance.BorderSize = 0
        btn_citizens.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_citizens.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_citizens.FlatStyle = FlatStyle.Flat
        btn_citizens.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_citizens.ForeColor = Color.White
        btn_citizens.Image = CType(resources.GetObject("btn_citizens.Image"), Image)
        btn_citizens.ImageAlign = ContentAlignment.MiddleLeft
        btn_citizens.Location = New Point(21, 202)
        btn_citizens.Name = "btn_citizens"
        btn_citizens.Size = New Size(267, 44)
        btn_citizens.TabIndex = 28
        btn_citizens.Text = "      Citizens"
        btn_citizens.TextAlign = ContentAlignment.MiddleLeft
        btn_citizens.UseVisualStyleBackColor = False
        btn_citizens.Visible = False
        ' 
        ' pnl_spacer_btn_employees
        ' 
        pnl_spacer_btn_employees.Dock = DockStyle.Top
        pnl_spacer_btn_employees.Location = New Point(21, 192)
        pnl_spacer_btn_employees.Name = "pnl_spacer_btn_employees"
        pnl_spacer_btn_employees.Size = New Size(267, 10)
        pnl_spacer_btn_employees.TabIndex = 27
        pnl_spacer_btn_employees.Visible = False
        ' 
        ' btn_pending_cases
        ' 
        btn_pending_cases.BackColor = Color.Transparent
        btn_pending_cases.Cursor = Cursors.Hand
        btn_pending_cases.Dock = DockStyle.Top
        btn_pending_cases.FlatAppearance.BorderSize = 0
        btn_pending_cases.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_pending_cases.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_pending_cases.FlatStyle = FlatStyle.Flat
        btn_pending_cases.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_pending_cases.ForeColor = Color.White
        btn_pending_cases.Image = CType(resources.GetObject("btn_pending_cases.Image"), Image)
        btn_pending_cases.ImageAlign = ContentAlignment.MiddleLeft
        btn_pending_cases.Location = New Point(21, 148)
        btn_pending_cases.Name = "btn_pending_cases"
        btn_pending_cases.Size = New Size(267, 44)
        btn_pending_cases.TabIndex = 26
        btn_pending_cases.Text = "      Pending Cases"
        btn_pending_cases.TextAlign = ContentAlignment.MiddleLeft
        btn_pending_cases.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(21, 138)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(267, 10)
        Panel6.TabIndex = 25
        ' 
        ' btn_barangay_cases
        ' 
        btn_barangay_cases.BackColor = Color.Transparent
        btn_barangay_cases.Cursor = Cursors.Hand
        btn_barangay_cases.Dock = DockStyle.Top
        btn_barangay_cases.FlatAppearance.BorderSize = 0
        btn_barangay_cases.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_barangay_cases.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_barangay_cases.FlatStyle = FlatStyle.Flat
        btn_barangay_cases.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_barangay_cases.ForeColor = Color.White
        btn_barangay_cases.Image = CType(resources.GetObject("btn_barangay_cases.Image"), Image)
        btn_barangay_cases.ImageAlign = ContentAlignment.MiddleLeft
        btn_barangay_cases.Location = New Point(21, 94)
        btn_barangay_cases.Name = "btn_barangay_cases"
        btn_barangay_cases.Size = New Size(267, 44)
        btn_barangay_cases.TabIndex = 24
        btn_barangay_cases.Text = "      Barangay Cases"
        btn_barangay_cases.TextAlign = ContentAlignment.MiddleLeft
        btn_barangay_cases.UseVisualStyleBackColor = False
        ' 
        ' Panel7
        ' 
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(21, 84)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(267, 10)
        Panel7.TabIndex = 23
        ' 
        ' btn_dashboard
        ' 
        btn_dashboard.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_dashboard.Cursor = Cursors.Hand
        btn_dashboard.Dock = DockStyle.Top
        btn_dashboard.FlatAppearance.BorderSize = 0
        btn_dashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_dashboard.FlatStyle = FlatStyle.Flat
        btn_dashboard.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_dashboard.ForeColor = Color.White
        btn_dashboard.Image = CType(resources.GetObject("btn_dashboard.Image"), Image)
        btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft
        btn_dashboard.Location = New Point(21, 40)
        btn_dashboard.Name = "btn_dashboard"
        btn_dashboard.Size = New Size(267, 44)
        btn_dashboard.TabIndex = 15
        btn_dashboard.Text = "      Dashboard"
        btn_dashboard.TextAlign = ContentAlignment.MiddleLeft
        btn_dashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Label8)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(21, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(267, 40)
        Panel5.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlDark
        Label8.Location = New Point(6, 21)
        Label8.Name = "Label8"
        Label8.Size = New Size(40, 16)
        Label8.TabIndex = 3
        Label8.Text = "Main"
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(21, 728)
        Panel4.TabIndex = 13
        ' 
        ' btn_temp
        ' 
        btn_temp.Location = New Point(-94, 484)
        btn_temp.Name = "btn_temp"
        btn_temp.Size = New Size(75, 23)
        btn_temp.TabIndex = 12
        btn_temp.Text = "Button1"
        btn_temp.UseVisualStyleBackColor = True
        ' 
        ' Image_Capture
        ' 
        Image_Capture.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Image_Capture.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Image_Capture.Location = New Point(288, 33)
        Image_Capture.MinimumSize = New Size(1046, 671)
        Image_Capture.Name = "Image_Capture"
        Image_Capture.Size = New Size(1046, 671)
        Image_Capture.TabIndex = 0
        Image_Capture.Visible = False
        ' 
        ' pnl_footer_outer
        ' 
        pnl_footer_outer.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        pnl_footer_outer.Controls.Add(pnl_footer_inner)
        pnl_footer_outer.Dock = DockStyle.Bottom
        pnl_footer_outer.Location = New Point(288, 704)
        pnl_footer_outer.Name = "pnl_footer_outer"
        pnl_footer_outer.Size = New Size(1046, 57)
        pnl_footer_outer.TabIndex = 12
        ' 
        ' pnl_footer_inner
        ' 
        pnl_footer_inner.Controls.Add(Label2)
        pnl_footer_inner.Controls.Add(LinkLabel1)
        pnl_footer_inner.Controls.Add(Label1)
        pnl_footer_inner.Location = New Point(213, 9)
        pnl_footer_inner.Name = "pnl_footer_inner"
        pnl_footer_inner.Size = New Size(620, 39)
        pnl_footer_inner.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(469, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 20)
        Label2.TabIndex = 2
        Label2.Text = "All rights reserved."
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel1.Location = New Point(156, 9)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(318, 20)
        LinkLabel1.TabIndex = 1
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Barangay Cases Management System."
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(14, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 20)
        Label1.TabIndex = 0
        Label1.Text = "Copyright © 2023"
        ' 
        ' Announcements
        ' 
        Announcements.AutoScroll = True
        Announcements.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Announcements.Dock = DockStyle.Fill
        Announcements.Location = New Point(288, 33)
        Announcements.MinimumSize = New Size(1046, 671)
        Announcements.Name = "Announcements"
        Announcements.Size = New Size(1046, 671)
        Announcements.TabIndex = 13
        Announcements.Visible = False
        ' 
        ' Barangay_Cases
        ' 
        Barangay_Cases.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Barangay_Cases.Dock = DockStyle.Fill
        Barangay_Cases.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Barangay_Cases.Location = New Point(288, 33)
        Barangay_Cases.MinimumSize = New Size(1046, 671)
        Barangay_Cases.Name = "Barangay_Cases"
        Barangay_Cases.Size = New Size(1046, 671)
        Barangay_Cases.TabIndex = 14
        ' 
        ' Barangay_News
        ' 
        Barangay_News.AutoScroll = True
        Barangay_News.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Barangay_News.Dock = DockStyle.Fill
        Barangay_News.Location = New Point(288, 33)
        Barangay_News.MinimumSize = New Size(1046, 671)
        Barangay_News.Name = "Barangay_News"
        Barangay_News.Size = New Size(1046, 671)
        Barangay_News.TabIndex = 15
        Barangay_News.Visible = False
        ' 
        ' Employees
        ' 
        Employees.AutoScroll = True
        Employees.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Employees.Dock = DockStyle.Fill
        Employees.Location = New Point(288, 33)
        Employees.MinimumSize = New Size(1046, 671)
        Employees.Name = "Employees"
        Employees.Size = New Size(1046, 671)
        Employees.TabIndex = 16
        Employees.Visible = False
        ' 
        ' Pending_Cases
        ' 
        Pending_Cases.AutoScroll = True
        Pending_Cases.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Pending_Cases.Dock = DockStyle.Fill
        Pending_Cases.Location = New Point(288, 33)
        Pending_Cases.MinimumSize = New Size(1046, 671)
        Pending_Cases.Name = "Pending_Cases"
        Pending_Cases.Size = New Size(1046, 671)
        Pending_Cases.TabIndex = 17
        Pending_Cases.Visible = False
        ' 
        ' Profile
        ' 
        Profile.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Profile.Dock = DockStyle.Fill
        Profile.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Profile.Location = New Point(288, 33)
        Profile.Name = "Profile"
        Profile.Size = New Size(1046, 671)
        Profile.TabIndex = 18
        Profile.Visible = False
        ' 
        ' My_Profile
        ' 
        My_Profile.AutoScroll = True
        My_Profile.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        My_Profile.Dock = DockStyle.Fill
        My_Profile.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        My_Profile.Location = New Point(288, 33)
        My_Profile.MinimumSize = New Size(1046, 671)
        My_Profile.Name = "My_Profile"
        My_Profile.Size = New Size(1046, 671)
        My_Profile.TabIndex = 19
        My_Profile.Visible = False
        ' 
        ' img_loading
        ' 
        img_loading.Dock = DockStyle.Fill
        img_loading.Image = CType(resources.GetObject("img_loading.Image"), Image)
        img_loading.Location = New Point(288, 33)
        img_loading.Name = "img_loading"
        img_loading.Size = New Size(1046, 671)
        img_loading.SizeMode = PictureBoxSizeMode.CenterImage
        img_loading.TabIndex = 21
        img_loading.TabStop = False
        img_loading.Visible = False
        ' 
        ' Dashboard
        ' 
        Dashboard.AutoScroll = True
        Dashboard.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Dashboard.Dock = DockStyle.Fill
        Dashboard.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Dashboard.Location = New Point(288, 33)
        Dashboard.MinimumSize = New Size(1046, 671)
        Dashboard.Name = "Dashboard"
        Dashboard.Size = New Size(1046, 671)
        Dashboard.TabIndex = 22
        ' 
        ' pnl_notification
        ' 
        pnl_notification.BackColor = Color.White
        pnl_notification.Controls.Add(Label7)
        pnl_notification.Location = New Point(879, 33)
        pnl_notification.Name = "pnl_notification"
        pnl_notification.Size = New Size(245, 45)
        pnl_notification.TabIndex = 24
        pnl_notification.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ControlDark
        Label7.Location = New Point(6, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(233, 18)
        Label7.TabIndex = 10
        Label7.Text = "You have no new notifications"
        ' 
        ' pnl_account_details
        ' 
        pnl_account_details.BackColor = Color.White
        pnl_account_details.Controls.Add(btn_open_website)
        pnl_account_details.Controls.Add(btn_connect_to_mobile_app)
        pnl_account_details.Controls.Add(btn_logout_2)
        pnl_account_details.Controls.Add(btn_developers)
        pnl_account_details.Controls.Add(btn_account_settings)
        pnl_account_details.Controls.Add(btn_my_profile)
        pnl_account_details.Controls.Add(lbl_account_position)
        pnl_account_details.Controls.Add(lbl_account_name)
        pnl_account_details.Location = New Point(1127, 33)
        pnl_account_details.Name = "pnl_account_details"
        pnl_account_details.Size = New Size(207, 332)
        pnl_account_details.TabIndex = 23
        pnl_account_details.Visible = False
        ' 
        ' btn_open_website
        ' 
        btn_open_website.AutoSize = True
        btn_open_website.BackColor = Color.Transparent
        btn_open_website.Cursor = Cursors.Hand
        btn_open_website.FlatAppearance.MouseDownBackColor = Color.White
        btn_open_website.FlatAppearance.MouseOverBackColor = Color.White
        btn_open_website.FlatStyle = FlatStyle.Flat
        btn_open_website.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_open_website.ForeColor = Color.Black
        btn_open_website.Image = CType(resources.GetObject("btn_open_website.Image"), Image)
        btn_open_website.ImageAlign = ContentAlignment.MiddleLeft
        btn_open_website.Location = New Point(0, 151)
        btn_open_website.Name = "btn_open_website"
        btn_open_website.Size = New Size(207, 45)
        btn_open_website.TabIndex = 10
        btn_open_website.Text = "      Open Website"
        btn_open_website.TextAlign = ContentAlignment.MiddleLeft
        btn_open_website.UseVisualStyleBackColor = False
        ' 
        ' btn_connect_to_mobile_app
        ' 
        btn_connect_to_mobile_app.AutoSize = True
        btn_connect_to_mobile_app.BackColor = Color.Transparent
        btn_connect_to_mobile_app.Cursor = Cursors.Hand
        btn_connect_to_mobile_app.FlatAppearance.MouseDownBackColor = Color.White
        btn_connect_to_mobile_app.FlatAppearance.MouseOverBackColor = Color.White
        btn_connect_to_mobile_app.FlatStyle = FlatStyle.Flat
        btn_connect_to_mobile_app.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_connect_to_mobile_app.ForeColor = Color.Black
        btn_connect_to_mobile_app.Image = CType(resources.GetObject("btn_connect_to_mobile_app.Image"), Image)
        btn_connect_to_mobile_app.ImageAlign = ContentAlignment.MiddleLeft
        btn_connect_to_mobile_app.Location = New Point(0, 196)
        btn_connect_to_mobile_app.Name = "btn_connect_to_mobile_app"
        btn_connect_to_mobile_app.Size = New Size(207, 45)
        btn_connect_to_mobile_app.TabIndex = 9
        btn_connect_to_mobile_app.Text = "      Connect to Mobile App"
        btn_connect_to_mobile_app.TextAlign = ContentAlignment.MiddleLeft
        btn_connect_to_mobile_app.UseVisualStyleBackColor = False
        ' 
        ' btn_logout_2
        ' 
        btn_logout_2.AutoSize = True
        btn_logout_2.BackColor = Color.Transparent
        btn_logout_2.Cursor = Cursors.Hand
        btn_logout_2.FlatAppearance.MouseDownBackColor = Color.White
        btn_logout_2.FlatAppearance.MouseOverBackColor = Color.White
        btn_logout_2.FlatStyle = FlatStyle.Flat
        btn_logout_2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_logout_2.ForeColor = Color.Black
        btn_logout_2.Image = CType(resources.GetObject("btn_logout_2.Image"), Image)
        btn_logout_2.ImageAlign = ContentAlignment.MiddleLeft
        btn_logout_2.Location = New Point(0, 286)
        btn_logout_2.Name = "btn_logout_2"
        btn_logout_2.Size = New Size(207, 45)
        btn_logout_2.TabIndex = 8
        btn_logout_2.Text = "      Logout"
        btn_logout_2.TextAlign = ContentAlignment.MiddleLeft
        btn_logout_2.UseVisualStyleBackColor = False
        ' 
        ' btn_developers
        ' 
        btn_developers.AutoSize = True
        btn_developers.BackColor = Color.Transparent
        btn_developers.Cursor = Cursors.Hand
        btn_developers.FlatAppearance.MouseDownBackColor = Color.White
        btn_developers.FlatAppearance.MouseOverBackColor = Color.White
        btn_developers.FlatStyle = FlatStyle.Flat
        btn_developers.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_developers.ForeColor = Color.Black
        btn_developers.Image = CType(resources.GetObject("btn_developers.Image"), Image)
        btn_developers.ImageAlign = ContentAlignment.MiddleLeft
        btn_developers.Location = New Point(0, 241)
        btn_developers.Name = "btn_developers"
        btn_developers.Size = New Size(207, 45)
        btn_developers.TabIndex = 7
        btn_developers.Text = "      Developers"
        btn_developers.TextAlign = ContentAlignment.MiddleLeft
        btn_developers.UseVisualStyleBackColor = False
        ' 
        ' btn_account_settings
        ' 
        btn_account_settings.AutoSize = True
        btn_account_settings.BackColor = Color.Transparent
        btn_account_settings.Cursor = Cursors.Hand
        btn_account_settings.FlatAppearance.MouseDownBackColor = Color.White
        btn_account_settings.FlatAppearance.MouseOverBackColor = Color.White
        btn_account_settings.FlatStyle = FlatStyle.Flat
        btn_account_settings.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_account_settings.ForeColor = Color.Black
        btn_account_settings.Image = CType(resources.GetObject("btn_account_settings.Image"), Image)
        btn_account_settings.ImageAlign = ContentAlignment.MiddleLeft
        btn_account_settings.Location = New Point(0, 106)
        btn_account_settings.Name = "btn_account_settings"
        btn_account_settings.Size = New Size(207, 45)
        btn_account_settings.TabIndex = 6
        btn_account_settings.Text = "      Account Settings"
        btn_account_settings.TextAlign = ContentAlignment.MiddleLeft
        btn_account_settings.UseVisualStyleBackColor = False
        ' 
        ' btn_my_profile
        ' 
        btn_my_profile.AutoSize = True
        btn_my_profile.BackColor = Color.Transparent
        btn_my_profile.Cursor = Cursors.Hand
        btn_my_profile.FlatAppearance.MouseDownBackColor = Color.White
        btn_my_profile.FlatAppearance.MouseOverBackColor = Color.White
        btn_my_profile.FlatStyle = FlatStyle.Flat
        btn_my_profile.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_my_profile.ForeColor = Color.Black
        btn_my_profile.Image = CType(resources.GetObject("btn_my_profile.Image"), Image)
        btn_my_profile.ImageAlign = ContentAlignment.MiddleLeft
        btn_my_profile.Location = New Point(0, 61)
        btn_my_profile.Name = "btn_my_profile"
        btn_my_profile.Size = New Size(207, 45)
        btn_my_profile.TabIndex = 5
        btn_my_profile.Text = "      My Profile"
        btn_my_profile.TextAlign = ContentAlignment.MiddleLeft
        btn_my_profile.UseVisualStyleBackColor = False
        ' 
        ' lbl_account_position
        ' 
        lbl_account_position.AutoSize = True
        lbl_account_position.BackColor = Color.Transparent
        lbl_account_position.FlatAppearance.BorderSize = 0
        lbl_account_position.FlatAppearance.MouseDownBackColor = Color.White
        lbl_account_position.FlatAppearance.MouseOverBackColor = Color.White
        lbl_account_position.FlatStyle = FlatStyle.Flat
        lbl_account_position.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_account_position.ForeColor = Color.Black
        lbl_account_position.Location = New Point(0, 29)
        lbl_account_position.Name = "lbl_account_position"
        lbl_account_position.Size = New Size(207, 30)
        lbl_account_position.TabIndex = 4
        lbl_account_position.Text = "Barangay Captain"
        lbl_account_position.UseVisualStyleBackColor = False
        ' 
        ' lbl_account_name
        ' 
        lbl_account_name.AutoSize = True
        lbl_account_name.BackColor = Color.Transparent
        lbl_account_name.FlatAppearance.BorderSize = 0
        lbl_account_name.FlatAppearance.MouseDownBackColor = Color.White
        lbl_account_name.FlatAppearance.MouseOverBackColor = Color.White
        lbl_account_name.FlatStyle = FlatStyle.Flat
        lbl_account_name.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_account_name.ForeColor = Color.Black
        lbl_account_name.Location = New Point(0, 0)
        lbl_account_name.Name = "lbl_account_name"
        lbl_account_name.Size = New Size(207, 35)
        lbl_account_name.TabIndex = 3
        lbl_account_name.Text = "Super Administrator"
        lbl_account_name.UseVisualStyleBackColor = False
        ' 
        ' pnl_body
        ' 
        pnl_body.Controls.Add(Edit_Barangay_Case)
        pnl_body.Controls.Add(Image_Capture)
        pnl_body.Dock = DockStyle.Fill
        pnl_body.Location = New Point(0, 0)
        pnl_body.Name = "pnl_body"
        pnl_body.Size = New Size(1334, 761)
        pnl_body.TabIndex = 25
        ' 
        ' Edit_Barangay_Case
        ' 
        Edit_Barangay_Case.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Edit_Barangay_Case.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Edit_Barangay_Case.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Edit_Barangay_Case.Location = New Point(288, 33)
        Edit_Barangay_Case.Name = "Edit_Barangay_Case"
        Edit_Barangay_Case.Size = New Size(1046, 671)
        Edit_Barangay_Case.TabIndex = 1
        Edit_Barangay_Case.Visible = False
        ' 
        ' Add_Barangay_Case
        ' 
        Add_Barangay_Case.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Add_Barangay_Case.BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        Add_Barangay_Case.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Add_Barangay_Case.Location = New Point(288, 33)
        Add_Barangay_Case.MinimumSize = New Size(1046, 671)
        Add_Barangay_Case.Name = "Add_Barangay_Case"
        Add_Barangay_Case.Size = New Size(1046, 671)
        Add_Barangay_Case.TabIndex = 26
        Add_Barangay_Case.Visible = False
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        ClientSize = New Size(1334, 761)
        Controls.Add(pnl_notification)
        Controls.Add(pnl_account_details)
        Controls.Add(Dashboard)
        Controls.Add(img_loading)
        Controls.Add(My_Profile)
        Controls.Add(Profile)
        Controls.Add(Pending_Cases)
        Controls.Add(Employees)
        Controls.Add(Barangay_News)
        Controls.Add(Barangay_Cases)
        Controls.Add(Announcements)
        Controls.Add(pnl_footer_outer)
        Controls.Add(pnl_sidebar)
        Controls.Add(pnl_header)
        Controls.Add(pnl_body)
        Controls.Add(Add_Barangay_Case)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1350, 800)
        Name = "Main"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        pnl_header.ResumeLayout(False)
        pnl_header.PerformLayout()
        CType(img_notification, ComponentModel.ISupportInitialize).EndInit()
        CType(img_user, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_toggle_sidebar, ComponentModel.ISupportInitialize).EndInit()
        pnl_banner.ResumeLayout(False)
        pnl_banner.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnl_sidebar.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        pnl_footer_outer.ResumeLayout(False)
        pnl_footer_inner.ResumeLayout(False)
        CType(img_loading, ComponentModel.ISupportInitialize).EndInit()
        pnl_notification.ResumeLayout(False)
        pnl_notification.PerformLayout()
        pnl_account_details.ResumeLayout(False)
        pnl_account_details.PerformLayout()
        pnl_body.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnl_header As Panel
    Friend WithEvents pnl_banner As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_toggle_sidebar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_account As Button
    Friend WithEvents img_user As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents img_notification As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnl_sidebar As Panel
    Friend WithEvents btn_logout As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_announcements As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents btn_employees As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btn_citizens As Button
    Friend WithEvents pnl_spacer_btn_employees As Panel
    Friend WithEvents btn_pending_cases As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_barangay_cases As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btn_dashboard As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_temp As Button
    Friend WithEvents pnl_footer_outer As Panel
    Friend WithEvents pnl_footer_inner As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Image_Capture As Image_Capture
    Friend WithEvents Add_Barangay_Case As Add_Barangay_Case
    Friend WithEvents Announcements As Announcements
    Friend WithEvents Barangay_Cases As Barangay_Cases
    Friend WithEvents Barangay_News As Barangay_News
    Friend WithEvents Employees As Employees
    Friend WithEvents Pending_Cases As Pending_Cases
    Friend WithEvents Profile As Profile
    Friend WithEvents My_Profile As My_Profile
    Friend WithEvents img_loading As PictureBox
    Friend WithEvents Dashboard As Dashboard
    Friend WithEvents pnl_notification As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents pnl_account_details As Panel
    Friend WithEvents btn_logout_2 As Button
    Friend WithEvents btn_developers As Button
    Friend WithEvents btn_account_settings As Button
    Friend WithEvents btn_my_profile As Button
    Friend WithEvents lbl_account_position As Button
    Friend WithEvents lbl_account_name As Button
    Friend WithEvents pnl_body As Panel
    Friend WithEvents btn_temp_account As Button
    Friend WithEvents btn_temp_notification As Button
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Edit_Barangay_Case As Edit_Barangay_Case
    Friend WithEvents btn_open_website As Button
    Friend WithEvents btn_connect_to_mobile_app As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_barangay_news As Button
    Friend WithEvents Panel1 As Panel
End Class
