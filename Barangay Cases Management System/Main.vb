﻿Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports ZXing
Imports ZXing.QrCode
Imports ZXing.QrCode.Internal
Imports ZXing.Windows.Compatibility

Public Class Main
    Public sidebar_visible As Boolean = True
    Private pnl_account_details_visible As Boolean = False
    Private pnl_account_notification_visible As Boolean = False
    Private loading_timer As Integer = 0
    Public current_tab As String = ""
    Public employee_primary_key As String = ""
    Public is_image_capture_buttons_moved As Boolean = False

    Private Sub Logout()
        btn_temp.Focus()
        Hide_Account_Details()

        primary_key = Nothing

        Me.Hide()

        pnl_sidebar.Show()
        sidebar_visible = True

        Image_Capture.Stop_Camera()

        With Login
            .is_loading = False

            .check_remember_me.Enabled = True
            .btn_login.Text = "Login"

            If Not .check_remember_me.Checked Then
                .txt_username.Clear()
                .txt_password.Clear()
                .check_remember_me.Checked = False
            End If

            .password_hidden = True
            .txt_password.UseSystemPasswordChar = True
            .img_show_hide_password.Image = Image.FromFile("dist/img/password_show.png")
            .txt_username.Focus()

            With .img_loading
                .Visible = False
                .SendToBack()
            End With
        End With

        MsgBox("You have successfully signed out!", MsgBoxStyle.Information, "Success")

        With Login
            .Show()
            .txt_username.Focus()
        End With
    End Sub

    Public Sub Load_Employees_Data()
        Dim results As DataTable = Get_Employee_Data(primary_key)

        Employees.listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            Dim fullname As String = ""

            If String.IsNullOrWhiteSpace(row("middle_name")) Then
                fullname = row("first_name") & " " & row("last_name")
            Else
                fullname = row("first_name") & " " & row("middle_name")(0) & ". " & row("last_name")
            End If

            With Employees
                Dim lvi As ListViewItem

                lvi = .listview_employees.Items.Add(row("primary_key").ToString())
                lvi.SubItems.Add(fullname)
                lvi.SubItems.Add(row("position").ToString())
                lvi.SubItems.Add(row("mobile_number").ToString())
                lvi.SubItems.Add(row("email").ToString())
                lvi.SubItems.Add(row("address").ToString())
            End With
        Next
    End Sub

    Public Sub Load_Pending_Cases_Data()
        Dim results As DataTable = Get_Pending_Cases_Data()

        Pending_Cases.listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            With Pending_Cases
                Dim lvi As ListViewItem
                Dim parsedDate As DateTime

                Dim inputDate = row("date").ToString()

                DateTime.TryParseExact(inputDate, "yyyy-MM-dd", Nothing, DateTimeStyles.None, parsedDate)

                Dim formattedDate As String = parsedDate.ToString("MMMM d, yyyy")

                lvi = .listview_employees.Items.Add(row("primary_key").ToString())
                lvi.SubItems.Add(formattedDate)
                lvi.SubItems.Add(row("time").ToString())
                lvi.SubItems.Add(row("name").ToString())
                lvi.SubItems.Add(row("mobile_number").ToString())
                lvi.SubItems.Add(row("address").ToString())
                lvi.SubItems.Add(row("nature_of_complaint").ToString())
                lvi.SubItems.Add(row("description").ToString())
                lvi.SubItems.Add(row("image").ToString())
            End With
        Next
    End Sub

    Public Sub Load_Barangay_Cases_Data()
        Dim results As DataTable = Get_Barangay_Cases_Data()

        Barangay_Cases.listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            With Barangay_Cases
                Dim lvi As ListViewItem
                Dim parsedDate As DateTime

                Dim inputDate = row("date").ToString()

                DateTime.TryParseExact(inputDate, "yyyy-MM-dd", Nothing, DateTimeStyles.None, parsedDate)

                Dim formattedDate As String = parsedDate.ToString("MMMM d, yyyy")

                lvi = .listview_employees.Items.Add(row("primary_key").ToString())
                lvi.SubItems.Add(formattedDate)
                lvi.SubItems.Add(row("time").ToString())
                lvi.SubItems.Add(row("name").ToString())
                lvi.SubItems.Add(row("mobile_number").ToString())
                lvi.SubItems.Add(row("address").ToString())
                lvi.SubItems.Add(row("nature_of_complaint").ToString())
                lvi.SubItems.Add(row("description").ToString())
                lvi.SubItems.Add(row("image").ToString())
            End With
        Next
    End Sub

    Public Sub Load_News_Data()
        Dim results As DataTable = Get_Barangay_News_Data()

        Barangay_News.listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            With Barangay_News
                Dim lvi As ListViewItem
                Dim parsedTime As DateTime
                Dim parsedDate As DateTime
                Dim inputDate = row("date").ToString()
                Dim inputTime = row("time").ToString()

                DateTime.TryParseExact(inputDate, "yyyy-MM-dd", Nothing, DateTimeStyles.None, parsedDate)
                DateTime.TryParseExact(inputTime, "HH:mm:ss", Nothing, DateTimeStyles.None, parsedTime)

                Dim formattedDate As String = parsedDate.ToString("MMMM d, yyyy")
                Dim formattedTime As String = parsedTime.ToString("hh:mm tt")

                lvi = .listview_employees.Items.Add(row("primary_key").ToString())
                lvi.SubItems.Add(formattedDate)
                lvi.SubItems.Add(formattedTime)
                lvi.SubItems.Add(row("title").ToString())
                lvi.SubItems.Add(row("body").ToString())
                lvi.SubItems.Add(row("image").ToString())
            End With
        Next
    End Sub

    Public Sub Load_News_Data_2()
        Dim results As DataTable = Get_Barangay_News_Data()

        Dashboard.listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            With Dashboard
                Dim lvi As ListViewItem
                Dim parsedTime As DateTime
                Dim inputDate = row("date").ToString()
                Dim inputTime = row("time").ToString()

                DateTime.TryParseExact(inputDate, "yyyy-MM-dd", Nothing, DateTimeStyles.None, parsedTime)
                DateTime.TryParseExact(inputTime, "HH:mm:ss", Nothing, DateTimeStyles.None, parsedTime)

                Dim formattedDate As String = parsedTime.ToString("MMMM d, yyyy")
                Dim formattedTime As String = parsedTime.ToString("hh:mm tt")

                lvi = .listview_employees.Items.Add(row("primary_key").ToString())
                lvi.SubItems.Add(formattedDate)
                lvi.SubItems.Add(formattedTime)
                lvi.SubItems.Add(row("title").ToString())
                lvi.SubItems.Add(row("body").ToString())
                lvi.SubItems.Add(row("image").ToString())
            End With
        Next
    End Sub

    Public Sub Load_Announcements_Data()
        Dim results As DataTable = Get_Announcements_Data()

        Announcements.listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            With Announcements
                Dim lvi As ListViewItem
                Dim parsedTime As DateTime
                Dim inputDateandTime = row("date_and_time").ToString()

                DateTime.TryParseExact(inputDateandTime, "yyyy-MM-dd HH:mm:ss", Nothing, DateTimeStyles.None, parsedTime)

                Dim formattedDate As String = parsedTime.ToString("MMMM d, yyyy")
                Dim formattedTime As String = parsedTime.ToString("hh:mm tt")

                lvi = .listview_employees.Items.Add(row("primary_key").ToString())
                lvi.SubItems.Add(formattedDate)
                lvi.SubItems.Add(formattedTime)
                lvi.SubItems.Add(row("title").ToString())
                lvi.SubItems.Add(row("body").ToString())
            End With
        Next
    End Sub

    Public Sub Load_Announcements_Data_2()
        Dim results As DataTable = Get_Announcements_Data()

        Dashboard.listview_employees.Items.Clear()

        For Each row As DataRow In results.Rows
            With Dashboard
                Dim lvi As ListViewItem
                Dim parsedTime As DateTime
                Dim inputDateandTime = row("date_and_time").ToString()

                DateTime.TryParseExact(inputDateandTime, "yyyy-MM-dd HH:mm:ss", Nothing, DateTimeStyles.None, parsedTime)

                Dim formattedDate As String = parsedTime.ToString("MMMM d, yyyy")
                Dim formattedTime As String = parsedTime.ToString("hh:mm tt")

                lvi = .listview_employees.Items.Add(row("primary_key").ToString())
                lvi.SubItems.Add(formattedDate)
                lvi.SubItems.Add(formattedTime)
                lvi.SubItems.Add(row("title").ToString())
                lvi.SubItems.Add(row("body").ToString())
            End With
        Next
    End Sub

    Private Function Format_Name(ByVal first_name As String) As String
        Dim nameParts() As String = first_name.Split(" "c)
        Dim firstNameInitials As String = ""

        For Each namePart As String In nameParts
            firstNameInitials &= namePart(0).ToString().ToUpper() & ". "
        Next

        Return firstNameInitials
    End Function

    Private Sub Rounded_Image(image As PictureBox)
        Dim path As New GraphicsPath()

        path.AddEllipse(New Rectangle(0, 0, image.Width - 1, image.Height - 1))

        image.Region = New Region(path)
    End Sub

    Public Sub Load_My_Profile_Data()
        Dim result = Get_User_Data(employee_primary_key)
        Dim fullname As String = ""
        Dim user_image As String

        If Not result("image") = "" Then
            user_image = result("image")
        Else
            user_image = "default_user_image.png"
        End If

        If String.IsNullOrWhiteSpace(result("middle_name")) Then
            fullname = result("first_name") & " " & result("last_name")
        Else
            fullname = result("first_name") & " " & result("middle_name")(0) & ". " & result("last_name")
        End If

        With My_Profile
            .img_user.Image = Image.FromFile("dist/img/user_upload/" & user_image)
            .lbl_user_details_full_name.Text = fullname
            .lbl_user_details_position.Text = result("position")

            With .Overview
                .lbl_full_name.Text = fullname

                If Not result("position") = "" Then
                    .lbl_position.Text = result("position")
                End If

                If Not result("mobile_number") = "" Then
                    .lbl_mobile_number.Text = result("mobile_number")
                End If

                If Not result("email") = "" Then
                    .lbl_email.Text = result("email")
                End If

                If Not result("address") = "" Then
                    .lbl_address.Text = result("address")
                End If
            End With

            With .Update_Profile
                .old_image = user_image
                .selected_image = user_image
                .lbl_primary_key.Text = result("primary_key")
                .txt_first_name.Text = result("first_name")
                .txt_middle_name.Text = result("middle_name")
                .txt_last_name.Text = result("last_name")
                .txt_position.Text = result("position")
                .txt_mobile_number.Text = result("mobile_number")
                .txt_email.Text = result("email")
                .txt_address.Text = result("address")
                .img_user.Image = Image.FromFile("dist/img/user_upload/" & user_image)

                .Center_Object(.img_user)
            End With

            .Center_Object(.lbl_user_details_full_name)
            .Center_Object(.lbl_user_details_position)
            .Center_Object(.img_user)
        End With
    End Sub

    Public Sub Load_Employee_Data()
        Dim result = Get_User_Data(employee_primary_key)
        Dim fullname As String = ""
        Dim user_image As String

        If Not result("image") = "" Then
            user_image = result("image")
        Else
            user_image = "default_user_image.png"
        End If

        If String.IsNullOrWhiteSpace(result("middle_name")) Then
            fullname = result("first_name") & " " & result("last_name")
        Else
            fullname = result("first_name") & " " & result("middle_name")(0) & ". " & result("last_name")
        End If

        With Profile
            .img_user.Image = Image.FromFile("dist/img/user_upload/" & user_image)
            .lbl_user_details_full_name.Text = fullname
            .lbl_user_details_position.Text = result("position")

            With .Overview
                .lbl_full_name.Text = fullname

                If Not result("position") = "" Then
                    .lbl_position.Text = result("position")
                End If

                If Not result("mobile_number") = "" Then
                    .lbl_mobile_number.Text = result("mobile_number")
                End If

                If Not result("email") = "" Then
                    .lbl_email.Text = result("email")
                End If

                If Not result("address") = "" Then
                    .lbl_address.Text = result("address")
                End If
            End With

            With .Update_Profile
                .old_image = user_image
                .selected_image = user_image
                .lbl_primary_key.Text = result("primary_key")
                .txt_first_name.Text = result("first_name")
                .txt_middle_name.Text = result("middle_name")
                .txt_last_name.Text = result("last_name")
                .txt_position.Text = result("position")
                .txt_mobile_number.Text = result("mobile_number")
                .txt_email.Text = result("email")
                .txt_address.Text = result("address")
                .img_user.Image = Image.FromFile("dist/img/user_upload/" & user_image)

                .Center_Object(.img_user)
            End With

            With .Employee_Account_Settings
                .lbl_primary_key.Text = result("primary_key")
                .txt_rfid_number.Text = result("rfid_number")
                .txt_username.Text = result("username")

                .old_rfid_number = result("rfid_number")
                .old_username = result("username")
                .old_password = result("password")
            End With

            .Center_Object(.lbl_user_details_full_name)
            .Center_Object(.lbl_user_details_position)
            .Center_Object(.img_user)
        End With
    End Sub

    Public Sub Mouse_Click(btn_name As Object, Optional initial_data As String = "")
        btn_temp.Focus()

        current_tab = btn_name.Name

        btn_pending_cases.BackColor = Color.Transparent
        btn_employees.BackColor = Color.Transparent
        btn_barangay_cases.BackColor = Color.Transparent
        btn_announcements.BackColor = Color.Transparent
        btn_dashboard.BackColor = Color.Transparent
        btn_citizens.BackColor = Color.Transparent
        btn_barangay_news.BackColor = Color.Transparent
        btn_logout.BackColor = Color.Transparent

        btn_my_profile.BackColor = Color.Transparent
        btn_account_settings.BackColor = Color.Transparent
        btn_developers.BackColor = Color.Transparent
        btn_logout_2.BackColor = Color.Transparent

        Add_Barangay_Case.Hide()
        Announcements.Hide()
        Barangay_Cases.Hide()
        Barangay_News.Hide()
        Dashboard.Hide()
        Edit_Barangay_Case.Hide()
        Employees.Hide()
        Image_Capture.Hide()
        My_Profile.Hide()
        Pending_Cases.Hide()
        Profile.Hide()

        Image_Capture.Stop_Camera()

        If is_image_capture_buttons_moved Then
            With Image_Capture
                With .btn_submit
                    .Text = "&Submit"
                    .Width = 122
                    .Location = New Point(.Location.X + 10, .Location.Y)
                End With

                .btn_reject.Hide()

                .btn_previous.Location = New Point(.btn_submit.Location.X - 138, .btn_previous.Location.Y)

                is_image_capture_buttons_moved = False
            End With
        End If

        If Not current_tab = "btn_new_case" And Not current_tab = "btn_edit_case" And Not current_tab = "btn_next" And Not current_tab = "btn_previous" Then
            btn_name.BackColor = primary

            With img_loading
                .Visible = True
                .BringToFront()
            End With

            employee_primary_key = initial_data

            Timer1.Start()
        Else
            img_loading.Visible = False

            If current_tab = "btn_new_case" Then
                is_edit_pending_case = False

                With Add_Barangay_Case
                    .Show()
                    .BringToFront()
                End With
            End If

            If current_tab = "btn_previous" Then
                If is_edit_pending_case Then
                    With Edit_Barangay_Case
                        .Show()
                        .BringToFront()
                    End With
                Else
                    With Add_Barangay_Case
                        .Show()
                        .BringToFront()
                    End With
                End If
            End If

            If current_tab = "btn_edit_case" Then
                With Edit_Barangay_Case
                    .Show()
                    .BringToFront()
                End With
            End If

            If current_tab = "btn_next" Then
                With Image_Capture
                    If is_edit_pending_case Then
                        With .btn_submit
                            .Text = "&Approve"
                            .Width = 132
                            .Location = New Point(.Location.X - 10, .Location.Y)
                        End With

                        .btn_reject.Show()
                        .btn_reject.Location = New Point(.btn_submit.Location.X - 122, .btn_reject.Location.Y)

                        .btn_previous.Location = New Point(.btn_reject.Location.X - 138, .btn_previous.Location.Y)

                        .lbl_title.Text = "Edit Barangay Case"
                        .lbl_barangay_pending_case.Text = "/ Pending Cases"

                        With .lbl_sub_title
                            .Text = "/ Edit Barangay Case"
                            .Location = New Point(229, 57)
                        End With

                        is_image_capture_buttons_moved = True
                    Else
                        .lbl_title.Text = "New Barangay Case"
                        .lbl_barangay_pending_case.Text = "/ Barangay Cases"

                        With .lbl_sub_title
                            .Text = "/ New Barangay Case"
                            .Location = New Point(239, 57)
                        End With

                        is_image_capture_buttons_moved = False
                    End If

                    .Show()
                    .BringToFront()
                End With
            End If
        End If

        Hide_Account_Details()
        Hide_Notification()
    End Sub

    Public Sub Hide_Account_Details()
        pnl_account_details_visible = False
        pnl_account_details.Visible = False
    End Sub

    Public Sub Hide_Notification()
        pnl_account_notification_visible = False
        pnl_notification.Visible = False
    End Sub

    Public Sub Load_User_Data()
        Dim result = Get_User_Data(primary_key)
        Dim user_image As String = ""

        'If Not result("user_type") = "admin" Then
        '    pnl_spacer_btn_employees.Visible = False
        '    btn_citizens.Visible = False
        'Else
        '    pnl_spacer_btn_employees.Visible = True
        '    btn_citizens.Visible = True
        'End If

        btn_account.Text = Format_Name(result("first_name")) & result("last_name")

        If String.IsNullOrWhiteSpace(result("middle_name")) Then
            lbl_account_name.Text = result("first_name") & " " & result("last_name")
        Else
            lbl_account_name.Text = result("first_name") & " " & result("middle_name")(0) & ". " & result("last_name")
        End If

        lbl_account_position.Text = result("position")

        If Not result("position") = "Employee" Then
            lbl_account_position.Text = "Administrator"
        End If

        With lbl_account_name
            pnl_account_details.Width = .Width
            lbl_account_position.Width = .Width
            btn_my_profile.Width = .Width
            btn_account_settings.Width = .Width
            btn_developers.Width = .Width
            btn_logout_2.Width = .Width
        End With

        If String.IsNullOrWhiteSpace(result("image")) Then
            user_image = "default_user_image.png"
        Else
            user_image = result("image")
        End If

        img_user.Image = Image.FromFile("dist/img/user_upload/" & user_image)
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog_result = MessageBox.Show(Me, "Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog_result = DialogResult.No Then
            e.Cancel = True
        Else
            Image_Capture.Stop_Camera()

            Splash_Screen.Close()
        End If
    End Sub

    Private Sub btn_toggle_sidebar_Click(sender As Object, e As EventArgs) Handles btn_toggle_sidebar.Click
        If sidebar_visible Then
            pnl_sidebar.Hide()
            sidebar_visible = False
        Else
            pnl_sidebar.Show()
            sidebar_visible = True
        End If

        Add_Barangay_Case.Width = pnl_footer_outer.Width
        Add_Barangay_Case.Location = New Point(pnl_footer_outer.Location.X, Image_Capture.Location.Y)

        Image_Capture.Width = pnl_footer_outer.Width
        Image_Capture.Location = New Point(pnl_footer_outer.Location.X, Image_Capture.Location.Y)

        btn_temp.Focus()
    End Sub

    Private Sub img_user_Click(sender As Object, e As EventArgs) Handles img_user.Click
        btn_account.PerformClick()
    End Sub

    Private Sub btn_account_Click(sender As Object, e As EventArgs) Handles btn_account.Click
        Hide_Notification()

        If Not pnl_account_details_visible Then
            pnl_account_details_visible = True

            With pnl_account_details
                .Visible = True
                .Location = New Point(pnl_body.Width - pnl_account_details.Width - 5, btn_account.Location.Y + 35)
                .BringToFront()
            End With
        Else
            Hide_Account_Details()
        End If

        btn_temp.Focus()
    End Sub

    Private Sub pnl_footer_outer_SizeChanged(sender As Object, e As EventArgs) Handles pnl_footer_outer.SizeChanged
        Dim centerX As Integer = (pnl_footer_outer.Width - pnl_footer_inner.Width) / 2
        Dim centerY As Integer = (pnl_footer_outer.Height - pnl_footer_inner.Height) / 2

        pnl_footer_inner.Location = New Point(centerX, centerY)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If current_tab = "btn_dashboard" Then
            With Dashboard
                .Show()
                .btn_announcements.PerformClick()
                .BringToFront()
            End With

            Timer1.Stop()
        End If

        If current_tab = "btn_pending_cases" Then
            Load_Pending_Cases_Data()

            With Pending_Cases
                .Show()
                .BringToFront()
            End With

            Timer1.Stop()
        End If

        If current_tab = "btn_barangay_cases" Then
            Load_Barangay_Cases_Data()

            With Barangay_Cases
                .Show()
                .BringToFront()
            End With

            Timer1.Stop()
        End If

        If current_tab = "btn_employees" Then
            Load_Employees_Data()

            With Employees
                .Show()
                .BringToFront()
            End With

            Timer1.Stop()
        End If

        If current_tab = "btn_announcements" Then
            Load_Announcements_Data()

            With Announcements
                .Show()
                .BringToFront()
            End With

            Timer1.Stop()
        End If

        If current_tab = "btn_barangay_news" Then
            Load_News_Data()

            With Barangay_News
                .Show()
                .BringToFront()
            End With

            Timer1.Stop()
        End If

        If current_tab = "btn_my_profile" Then
            Load_My_Profile_Data()

            With My_Profile
                .Show()
                .btn_overview.PerformClick()
                .BringToFront()
            End With

            Timer1.Stop()
        End If

        If current_tab = "listview_employees" Then
            Load_Employee_Data()

            With Profile
                .Show()
                .btn_overview.PerformClick()
                .BringToFront()
            End With

            Timer1.Stop()
        End If
    End Sub

    Private Sub btn_logout_2_Click(sender As Object, e As EventArgs) Handles btn_logout_2.Click
        Logout()
    End Sub

    Private Sub btn_developers_Click(sender As Object, e As EventArgs) Handles btn_developers.Click
        Hide_Account_Details()
        Developers.ShowDialog()
        btn_temp.Focus()
    End Sub

    Private Sub btn_my_profile_Click(sender As Object, e As EventArgs) Handles btn_my_profile.Click
        Mouse_Click(btn_my_profile, primary_key)
    End Sub

    Private Sub btn_account_settings_Click(sender As Object, e As EventArgs) Handles btn_account_settings.Click
        btn_temp.Focus()

        Hide_Account_Details()

        Dim result = Get_User_Data(primary_key)
        Dim fullname As String = ""

        If String.IsNullOrWhiteSpace(result("middle_name")) Then
            fullname = result("first_name") & " " & result("last_name")
        Else
            fullname = result("first_name") & " " & result("middle_name")(0) & ". " & result("last_name")
        End If

        With Account_Settings
            .txt_fullname.Text = fullname
            .txt_rfid_number.Text = result("rfid_number")
            .txt_username.Text = result("username")

            .old_rfid_number = result("rfid_number")
            .old_username = result("username")
            .old_password = result("password")

            .ShowDialog()
        End With
    End Sub

    Private Sub img_user_Paint(sender As Object, e As PaintEventArgs) Handles img_user.Paint
        Rounded_Image(img_user)
    End Sub

    Private Sub img_notification_Click(sender As Object, e As EventArgs) Handles img_notification.Click
        Hide_Account_Details()
        btn_temp_notification.Focus()

        If Not pnl_account_notification_visible Then
            With pnl_notification
                .Visible = True
                .Location = New Point(img_notification.Location.X - pnl_notification.Width + (5 * 5), pnl_header.Location.Y + 35)
                .BringToFront()
            End With

            pnl_account_notification_visible = True
        Else
            With pnl_notification
                .Visible = False
            End With

            pnl_account_notification_visible = False
        End If
    End Sub

    Private Sub btn_dashboard_Click_1(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        Mouse_Click(btn_dashboard)
    End Sub

    Private Sub btn_barangay_cases_Click(sender As Object, e As EventArgs) Handles btn_barangay_cases.Click
        Mouse_Click(btn_barangay_cases)
    End Sub

    Private Sub btn_pending_cases_Click(sender As Object, e As EventArgs) Handles btn_pending_cases.Click
        Mouse_Click(btn_pending_cases)
    End Sub

    Private Sub btn_citizens_Click(sender As Object, e As EventArgs) Handles btn_citizens.Click, btn_citizens.Click
        Mouse_Click(btn_citizens)
    End Sub

    Private Sub btn_employees_Click(sender As Object, e As EventArgs) Handles btn_employees.Click
        Mouse_Click(btn_employees)
    End Sub

    Private Sub btn_announcements_Click(sender As Object, e As EventArgs) Handles btn_announcements.Click
        Mouse_Click(btn_announcements)
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs)
        Logout()
    End Sub

    Private Sub Main_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        btn_temp.Focus()
    End Sub

    Private Sub btn_temp_notification_LostFocus(sender As Object, e As EventArgs) Handles btn_temp_notification.LostFocus
        Hide_Notification()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "Dashboard" Then
            Mouse_Click(btn_dashboard)

            txt_search.Clear()
        End If

        If txt_search.Text = "Barangay Cases" Then
            Mouse_Click(btn_barangay_cases)

            txt_search.Clear()
        End If

        If txt_search.Text = "New Barangay Case" Then
            Mouse_Click(Barangay_Cases.btn_new_case)

            txt_search.Clear()
        End If

        If txt_search.Text = "Pending Cases" Then
            Mouse_Click(btn_pending_cases)

            txt_search.Clear()
        End If

        If txt_search.Text = "Employees" Then
            Mouse_Click(btn_citizens)

            txt_search.Clear()
        End If

        If txt_search.Text = "Announcements" Then
            Mouse_Click(btn_employees)

            txt_search.Clear()
        End If

        If txt_search.Text = "Barangay News" Then
            Mouse_Click(btn_announcements)

            txt_search.Clear()
        End If

        If txt_search.Text = "My Profile" Then
            Mouse_Click(btn_my_profile, primary_key)

            txt_search.Clear()
        End If
    End Sub

    Private Sub btn_open_website_Click(sender As Object, e As EventArgs) Handles btn_open_website.Click
        Hide_Account_Details()

        Dim chrome_path_x86 As String = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
        Dim chrome_path_x64 As String = "C:\Program Files\Google\Chrome\Application\chrome.exe"

        If IO.File.Exists(chrome_path_x86) Then
            Process.Start(chrome_path_x86, url)
        ElseIf IO.File.Exists(chrome_path_x64) Then
            Process.Start(chrome_path_x64, url)
        Else
            MsgBox("Please install Google Chrome to enable this feature...", MsgBoxStyle.Critical, "No Google Chrome Installed")
        End If

        btn_temp.Focus()
    End Sub

    Private Sub btn_connect_to_mobile_app_Click(sender As Object, e As EventArgs) Handles btn_connect_to_mobile_app.Click
        Hide_Account_Details()

        Dim textToEncode As String = ip_address.ToString()
        Dim qrCodeWriter As New BarcodeWriter(Of Bitmap) With {
            .Format = BarcodeFormat.QR_CODE
        }
        Dim encodingOptions As New QrCodeEncodingOptions With {
            .CharacterSet = "UTF-8",
            .ErrorCorrection = ErrorCorrectionLevel.H
        }

        qrCodeWriter.Options = encodingOptions
        qrCodeWriter.Renderer = New BitmapRenderer()

        Dim qrCodeBitmap As Bitmap = qrCodeWriter.Write(textToEncode)

        With Connect_to_Mobile_App
            .PictureBox1.Image = qrCodeBitmap
            .txt_ipaddress.Text = ip_address.ToString()
            .ShowDialog()
        End With

        btn_temp.Focus()
    End Sub

    Private Sub btn_barangay_news_Click(sender As Object, e As EventArgs) Handles btn_barangay_news.Click
        Mouse_Click(btn_barangay_news)
    End Sub

    Private Sub btn_logout_Click_1(sender As Object, e As EventArgs) Handles btn_logout.Click
        Logout()
    End Sub
End Class