Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.Net
Module Module1

    Public Function connection() As MySqlConnection
        Return New MySqlConnection("server=PTI-032;user id=inventoryf2;password=admin123@;database=trcsystem")
        ' Return New MySqlConnection("server=localhost;user id=momel;password=Magnaye2143@#;database=trcsystem")
    End Function
    Public con As MySqlConnection = connection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable

    'credentials for log in
    Public fname As String
    Public idno As String
    Public userlevel As Integer
    Public designation As String
    Public PCname As String = Environment.MachineName
    Public PCmac As String = GetMacAddress()
    Public PClocation As String
    Public PCip As String = GetLocalIPAddress()

    Public longdate As String = Date.Now.ToString("MMMM dd, yyyy")
    Public datedb As String = Date.Now.ToString("yyyy-MM-dd")
    Public shift1 As String

    Public violation_idno As String
    Public violation_memoid As Integer
    Public violation_date As String
    Function GetMacAddress() As String
        Dim macAddress As String = ""

        ' Get all network interfaces
        Dim networkInterfaces() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()

        ' Loop through each network interface to find the MAC address
        For Each networkInterface As NetworkInterface In networkInterfaces
            ' Check if the network interface is operational and not a loopback or tunnel interface
            If networkInterface.OperationalStatus = OperationalStatus.Up AndAlso
               networkInterface.NetworkInterfaceType <> NetworkInterfaceType.Loopback AndAlso
               networkInterface.NetworkInterfaceType <> NetworkInterfaceType.Tunnel Then
                ' Get the physical address (MAC address) of the network interface
                Dim physicalAddress As PhysicalAddress = networkInterface.GetPhysicalAddress()
                macAddress = physicalAddress.ToString()
                Exit For ' Exit the loop once the MAC address is found
            End If
        Next

        Return macAddress
    End Function

    Function GetLocalIPAddress() As String
        Dim ipAddress As String = String.Empty

        Try
            ' Get the host name of the local machine
            Dim hostName As String = Dns.GetHostName()

            ' Get the IP address list for the local machine
            Dim ipAddresses As IPAddress() = Dns.GetHostAddresses(hostName)

            ' Iterate through the IP address list
            For Each ip As IPAddress In ipAddresses
                ' Check if the IP address is IPv4
                If ip.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                    ipAddress = ip.ToString()
                    Exit For ' Exit the loop once the IP address is found
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error retrieving IP address: " & ex.Message)
        End Try

        Return ipAddress
    End Function


    Public Sub sounderror()
        My.Computer.Audio.Play(My.Resources.errorsound, AudioPlayMode.Background)
    End Sub
    Public Sub soundduplicate()
        My.Computer.Audio.Play(My.Resources.duplicate, AudioPlayMode.Background)
    End Sub



    Public Sub reload(ByVal sql As String, ByVal datagrid As Object)
        Try
            dt = New DataTable
            con.Close()
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            datagrid.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            da.Dispose()
            dt.Dispose()
        End Try
    End Sub

    Public Sub cmb_display(sql As String, column As String, cmb As Guna.UI2.WinForms.Guna2ComboBox)
        Try
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand(sql, con)
            dr = cmdselect.ExecuteReader
            cmb.Items.Clear()
            While (dr.Read())
                cmb.Items.Add(dr.GetString(column))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub logdata(log As String)
        Try
            con.Close()
            con.Open()
            Dim insert As New MySqlCommand("INSERT INTO `trc_logs`(`log`, `date`, `time`) VALUES (@log,@date,@time)", con)
            With insert.Parameters
                .AddWithValue("@log", PCname & "," & idno & "," & log)
                .AddWithValue("@date", datedb)
                .AddWithValue("@time", Date.Now.ToString("HH:mm:ss"))

            End With
            insert.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub display_mainframe(form As Form)
        With form
            .Refresh()
            .TopLevel = False
            Mainframe.Panel1.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub

    Public Sub display_formsub(form As Form, title As String)
        With form
            .Refresh()
            .TopLevel = False
            subframe.Panel1.Controls.Add(form)
            subframe.lbl_tittle.Text = title
            .BringToFront()
            .Show()

        End With
    End Sub
End Module
