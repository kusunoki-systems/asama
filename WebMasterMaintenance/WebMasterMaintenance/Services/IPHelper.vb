''' <summary>
''' IPHelper IPアドレス取得
''' </summary>
Public Class IPHelper
    ''' <summary>
    ''' Gets the user's IP Address
    ''' </summary>
    ''' <param name="IPAddress">IPAddress</param>
    ''' <param name="HostName">HostName</param>
    ''' <param name="httpVia">HTTP_VIA Server variable</param>
    ''' <param name="httpXForwardedFor">HTTP_X_FORWARDED Server variable</param>
    ''' <param name="RemoteAddr">REMOTE_ADDR Server variable</param>
    Public Sub GetIPAddress(ByRef IPAddress As String, ByRef HostName As String, HttpVia As String, HttpXForwardedFor As String, RemoteAddr As String)
        ' Use a default address if all else fails.
        Dim result As String = "127.0.0.1"

        HostName = System.Net.Dns.GetHostName()

        ' Web user - if using proxy
        Dim tempIP As String = String.Empty
        If HttpVia IsNot Nothing Then
            tempIP = HttpXForwardedFor
        Else
            ' Web user - not using proxy or can't get the Client IP
            tempIP = RemoteAddr
        End If

        ' If we can't get a V4 IP from the above, try host address list for internal users.
        If Not IsIPV4(tempIP) OrElse tempIP = "127.0.0.1 " Then
            Try
                For Each ip As System.Net.IPAddress In System.Net.Dns.GetHostAddresses(HostName)
                    If IsIPV4(ip) Then
                        result = ip.ToString()
                        Exit For
                    End If
                Next
            Catch
            End Try
        Else
            result = tempIP
        End If

        IPAddress = result

        Return

    End Sub

    ''' <summary>
    ''' Determines weather an IP Address is V4
    ''' </summary>
    ''' <param name="input">input string</param>
    ''' <returns>Is IPV4 True or False</returns>
    Private Shared Function IsIPV4(input As String) As Boolean
        Dim result As Boolean = False
        Dim address As System.Net.IPAddress = Nothing

        If System.Net.IPAddress.TryParse(input, address) Then
            result = IsIPV4(address)
        End If

        Return result
    End Function

    ''' <summary>
    ''' Determines weather an IP Address is V4
    ''' </summary>
    ''' <param name="address">input IP address</param>
    ''' <returns>Is IPV4 True or False</returns>
    Private Shared Function IsIPV4(address As System.Net.IPAddress) As Boolean
        Dim result As Boolean = False

        Select Case address.AddressFamily
            Case System.Net.Sockets.AddressFamily.InterNetwork
                ' we have IPv4
                result = True
                Exit Select
            Case System.Net.Sockets.AddressFamily.InterNetworkV6
                ' we have IPv6
                Exit Select
            Case Else
                Exit Select
        End Select

        Return result
    End Function
End Class
