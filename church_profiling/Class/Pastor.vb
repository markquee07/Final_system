Public Class Pastor
    Public id As Integer
    Public first_name As String
    Public last_name As String
    Public middle_name As String
    Public address As String
    Public gender As String
    Public date_of_birth As String
    Public concat_number As String
    Public name_of_school_grad As String
    Public address_of_school_graduaterd As String
    Public year_graduated As String
    Public chutch_name As String
    Public church_address As String
    Public years_of_service As String
    Public age As String


    Public Sub displayPastor(ByVal lsv As ListView)
        Dim sql As String = "SELECT id,concat(first_name,' ',last_name,' ',middle_name) as fullname,address,gender,date_format(date_of_birth,'%M %d, %Y') as date_of_birth,concat_number,name_of_school_grad,address_of_school_graduaterd,year_graduated,chutch_name,church_address,years_of_service FROM tbl_host_pastor  "
        GLOBAL_VARS.db.execute(sql)
        lsv.Items.Clear()
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("fullname").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("address").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("gender").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("date_of_birth").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("concat_number").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("name_of_school_grad").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("address_of_school_graduaterd").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("year_graduated").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("chutch_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("church_address").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("years_of_service").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub searchPastor(ByVal lsv As ListView, key As String)
        Dim sql As String = "SELECT id,concat(first_name,' ',last_name,' ',middle_name) as fullname,address,gender,date_format(date_of_birth,'%M %d, %Y') as date_of_birth,concat_number,name_of_school_grad,address_of_school_graduaterd,year_graduated,chutch_name,church_address,years_of_service FROM tbl_host_pastor where first_name like '%" & key & "%' or last_name like '%" & key & "%' or address like '%" & key & "%'"
        GLOBAL_VARS.db.execute(sql)
        lsv.Items.Clear()
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("fullname").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("address").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("gender").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("date_of_birth").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("concat_number").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("name_of_school_grad").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("address_of_school_graduaterd").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("year_graduated").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("chutch_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("church_address").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("years_of_service").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub displayPastorDetails(ByVal p_id As Integer)

        Dim sql As String = "SELECT id,first_name ,last_name,middle_name,address,gender,date_format(date_of_birth,'%M %d, %Y') as date_of_birth,year_graduated,(datediff(date_format(now(),'%Y-%m-%d'),date_format(date_of_birth,'%Y-%m-%d'))/365.25) as Age,concat_number,name_of_school_grad,address_of_school_graduaterd,year_graduated,chutch_name,church_address,years_of_service FROM tbl_host_pastor"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            GLOBAL_VARS.db.reader.Read()
            With Me
                .id = GLOBAL_VARS.db.reader("ID").ToString()
                .first_name = GLOBAL_VARS.db.reader("first_name").ToString()
                .last_name = GLOBAL_VARS.db.reader("last_name").ToString()
                .middle_name = GLOBAL_VARS.db.reader("Middle_name").ToString()
                .date_of_birth = GLOBAL_VARS.db.reader("Date_of_birth").ToString()
                .gender = GLOBAL_VARS.db.reader("Gender").ToString()
                .age = GLOBAL_VARS.db.reader("age").ToString()
                .address = GLOBAL_VARS.db.reader("address").ToString()
                .concat_number = GLOBAL_VARS.db.reader("concat_number").ToString()
                .name_of_school_grad = GLOBAL_VARS.db.reader("name_of_school_grad").ToString()
                .address_of_school_graduaterd = GLOBAL_VARS.db.reader("address_of_school_graduaterd").ToString()
                .chutch_name = GLOBAL_VARS.db.reader("chutch_name").ToString()
                .year_graduated = GLOBAL_VARS.db.reader("year_graduated").ToString()
                .church_address = GLOBAL_VARS.db.reader("church_address").ToString()
                .years_of_service = GLOBAL_VARS.db.reader("years_of_service").ToString()
            End With
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
End Class
