Public Class cart

    'pastor
    Public pstor_name As String

    ''last_id saved in sql
    Public last_id As Integer
    Public member_last_id As Integer

    ''Personal information
    Public id As Integer
    Public Member_id As String
    Public First_name As String
    Public Last_name As String
    Public Middle_name As String
    Public Date_of_birth As String
    Public Gender As String
    Public Province As String
    Public City As String
    Public Barangay As String
    Public Baptized_status As String
    Public Baptized_date As String
    Public Contact_no As String
    Public Email_ad As String
    Public Blood_type As String
    Public Civil_status As String
    Public Church_name As String
    Public Pastor_name As String
    Public Marriage_date As String

    ''Educational Background
    Public HEA As String
    Public Course_graduated As String
    Public Name_of_school_graduated As String
    Public Licensure_passer As String
    Public License_specification As String

    ''Work information
    Public Work_status As String
    Public Work_address As String
    Public Nature_of_work As String
    Public Name_of_company As String
    Public Salary As Double
    Public Self_employed As String
    Public Nature_of_business As String
    Public Name_of_business As String
    Public Business_address As String
    Public Estimated_annual_income As Double

    ''Siblings Information
    Public s_id As Integer
    Public s_siblings_id As String
    Public s_First_name As String
    Public s_Last_name As String
    Public s_Middle_name As String
    Public s_Date_of_birth As String
    Public s_Gender As String
    Public s_Church_member As String


    'Officials 
    Public Position As String
    Public Year As String

    Public Structure Selected_Officials
        Public member As cart
        Public position As String
    End Structure

    Public Sub savePersonalInformation()
        Dim sql As String = "insert into tbl_member_information values (null,'" & Me.Member_id & "','" & Me.First_name & "','" & Me.Last_name & "','" & Me.Middle_name & "','" & Me.Date_of_birth & "','" & Me.Gender & "','" & Me.Province & "','" & Me.City & "','" & Me.Barangay & "','" & Me.Baptized_status & "','" & Me.Baptized_date & "','" & Me.Contact_no & "','" & Me.Email_ad & "','" & Me.Blood_type & "','" & Me.Civil_status & "','" & Me.Church_name & "','" & Me.Pastor_name & "','" & Me.Marriage_date & "');"
        GLOBAL_VARS.db.executeNonReader(sql)
        last_id = GLOBAL_VARS.db.getLastId()
        member_last_id = last_id

        'save educational background
        saveEducationalBackground(member_last_id)

        'MsgBox("Information Successfully Saved", MsgBoxStyle.Information)
    End Sub

    Public Sub saveEducationalBackground(mem_id As Integer)
        Dim sql As String = "insert into tbl_educational_background values (" & mem_id & ",'" & Me.HEA & "','" & Me.Course_graduated & "','" & Me.Name_of_school_graduated & "','" & Me.Licensure_passer & "','" & Me.License_specification & "');"
        GLOBAL_VARS.db.executeNonReader(sql)

        'save work information
        saveOccupatiion(member_last_id)
    End Sub

    Public Sub saveOccupatiion(mem_id As Integer)
        Dim sql As String = "insert into tbl_work_information values (" & mem_id & ",'" & Me.Work_status & "','" & Me.Work_address & "','" & Me.Nature_of_work & "','" & Me.Name_of_company & "','" & Me.Salary & "','" & Me.Self_employed & "','" & Me.Nature_of_business & "','" & Me.Name_of_business & "','" & Me.Business_address & "'," & Me.Estimated_annual_income & ");"
        GLOBAL_VARS.db.executeNonReader(sql)
    End Sub

    Public Sub saveSiblingsInformation(mem_id As Integer)
        Dim sql As String = "insert into tbl_child_information values (null,'" & Me.s_siblings_id & "','" & Me.s_Gender & "','" & Me.s_Date_of_birth & "','" & Me.s_Church_member & "','" & Me.s_First_name & "','" & Me.s_Last_name & "','" & Me.s_Middle_name & "');"
        GLOBAL_VARS.db.executeNonReader(sql)
        last_id = GLOBAL_VARS.db.getLastId()

        member_last_id = mem_id
        saveFamilyDetails(member_last_id, last_id)
    End Sub

    Public Sub saveFamilyDetails(mem_id As Integer, siblings_id As Integer)
        Dim sql As String = "Insert into tbl_family_details values (" & mem_id & "," & siblings_id & ")"
        GLOBAL_VARS.db.executeNonReader(sql)
    End Sub

    Public Sub displayMemberInformation(ByVal lsv As ListView)
        lsv.Items.Clear()
        Dim sql As String = "SELECT m.id,m.member_id,m.first_name,m.last_name,m.middle_name,m.date_of_birth,m.gender,m.province,m.city,m.barangay,m.baptized_status,m.baptized_date,m.contact_no,m.email_ad,m.blood_type,m.civil_status,m.church_name,m.pastor_name,m.marriage_date,e.hea,e.course_graduated,e.name_of_school_graduated,e.licensure_passer,e.license_specification,w.work_status,w.work_address,w.nature_of_work,w.name_of_company,w.salary,w.self_employed,w.nature_of_business,w.name_of_business,w.business_address,w.estimated_annual_income FROM tbl_member_information m inner join tbl_educational_background e on m.id = e.member_id inner join tbl_work_information w on m.id = w.members_id;"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("ID").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("First_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Last_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Middle_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Date_of_birth").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Gender").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Province").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("City").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Barangay").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Baptized_status").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Baptized_date").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Contact_no").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Email_ad").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Blood_type").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Civil_status").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Church_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Pastor_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Marriage_date").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("HEA").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Course_graduated").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Name_of_school_graduated").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Licensure_passer").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("License_specification").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Work_status").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Work_address").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Nature_of_work").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Name_of_company").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Salary").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Self_employed").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Nature_of_business").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Name_of_business").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Business_address").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("Estimated_annual_income").ToString())

                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub displayFamilyDetails(ByVal lsv As ListView, p_id As Integer)
        lsv.Items.Clear()
        Dim sql As String = "SELECT c.id,c.child_id,c.first_name,c.last_name,c.middle_name,date_format(c.birth_date,'%M %d, %Y') as birth_date,c.gender,c.church_member FROM tbl_child_information c inner join tbl_family_details f on c.id= f.child_id inner join tbl_member_information m on m.id=f.parent_id where f.parent_id=" & p_id & ""

        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("child_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("first_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("last_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("middle_name").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("birth_date").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("gender").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("church_member").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub displayMemberDetails(ByVal p_id As Integer)

        Dim sql As String = "SELECT m.id,m.member_id,m.first_name,m.last_name,m.middle_name,date_format(m.date_of_birth, '%M %d, %Y') as date_of_birth,m.gender,m.province,m.city,m.barangay,m.baptized_status,date_format(m.baptized_date, '%M %d,%Y') as baptized_date,m.contact_no,m.email_ad,m.blood_type,m.civil_status,m.church_name,m.pastor_name,date_format(m.marriage_date, '%M %d,%Y') as marriage_date,e.hea,e.course_graduated,e.name_of_school_graduated,e.licensure_passer,e.license_specification,w.work_status,w.work_address,w.nature_of_work,w.name_of_company,w.salary,w.self_employed,w.nature_of_business,w.name_of_business,w.business_address,w.estimated_annual_income FROM tbl_member_information m inner join tbl_educational_background e on m.id = e.member_id inner join tbl_work_information w on m.id = w.members_id where m.id=" & p_id & ";"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            GLOBAL_VARS.db.reader.Read()
            With Me
                .id = GLOBAL_VARS.db.reader("ID").ToString()
                .Member_id = GLOBAL_VARS.db.reader("Member_id").ToString()
                .First_name = GLOBAL_VARS.db.reader("First_name").ToString()
                .Last_name = GLOBAL_VARS.db.reader("Last_name").ToString()
                .Middle_name = GLOBAL_VARS.db.reader("Middle_name").ToString()
                .Date_of_birth = GLOBAL_VARS.db.reader("Date_of_birth").ToString()
                .Gender = GLOBAL_VARS.db.reader("Gender").ToString()
                .Province = GLOBAL_VARS.db.reader("Province").ToString()
                .City = GLOBAL_VARS.db.reader("City").ToString()
                .Barangay = GLOBAL_VARS.db.reader("Barangay").ToString()
                .Baptized_status = GLOBAL_VARS.db.reader("Baptized_status").ToString()
                .Baptized_date = GLOBAL_VARS.db.reader("Baptized_date").ToString()
                .Contact_no = GLOBAL_VARS.db.reader("Contact_no").ToString()
                .Email_ad = GLOBAL_VARS.db.reader("Email_ad").ToString()
                .Blood_type = GLOBAL_VARS.db.reader("Blood_type").ToString()
                .Civil_status = GLOBAL_VARS.db.reader("Civil_status").ToString()
                .Church_name = GLOBAL_VARS.db.reader("Church_name").ToString()
                .Pastor_name = GLOBAL_VARS.db.reader("Pastor_name").ToString()
                .Marriage_date = GLOBAL_VARS.db.reader("Marriage_date").ToString()
                .HEA = GLOBAL_VARS.db.reader("HEA").ToString()
                .Course_graduated = GLOBAL_VARS.db.reader("Course_graduated").ToString()
                .Name_of_school_graduated = GLOBAL_VARS.db.reader("Name_of_school_graduated").ToString()
                .Licensure_passer = GLOBAL_VARS.db.reader("Licensure_passer").ToString()
                .License_specification = GLOBAL_VARS.db.reader("License_specification").ToString()
                .Work_status = GLOBAL_VARS.db.reader("Work_status").ToString()
                .Work_address = GLOBAL_VARS.db.reader("Work_address").ToString()
                .Nature_of_work = GLOBAL_VARS.db.reader("Nature_of_work").ToString()
                .Name_of_company = GLOBAL_VARS.db.reader("Name_of_company").ToString()
                .Salary = GLOBAL_VARS.db.reader("Salary").ToString()
                .Self_employed = GLOBAL_VARS.db.reader("Self_employed").ToString()
                .Nature_of_business = GLOBAL_VARS.db.reader("Nature_of_business").ToString()
                .Name_of_business = GLOBAL_VARS.db.reader("Name_of_business").ToString()
                .Business_address = GLOBAL_VARS.db.reader("Business_address").ToString()
                .Estimated_annual_income = GLOBAL_VARS.db.reader("Estimated_annual_income").ToString()

            End With
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub loadMember(id As Integer)
        Dim sql As String = "SELECT * FROM tbl_member_information where id=" & id & ";"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            GLOBAL_VARS.db.reader.Read()
            Me.id = GLOBAL_VARS.db.reader("id")
            Me.First_name = GLOBAL_VARS.db.reader("First_name")
            Me.Last_name = GLOBAL_VARS.db.reader("Last_name")
            Me.Middle_name = GLOBAL_VARS.db.reader("Middle_name")
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub
    Public Sub displayMemberForChurchOfficial(ByVal lsv As ListView)
        lsv.Items.Clear()
        Dim sql As String = "select id,member_id,concat(first_name,' ',middle_name,' ',Last_name) as fullname from tbl_member_information;"
        GLOBAL_VARS.db.execute(sql)
        If GLOBAL_VARS.db.reader.HasRows Then
            While GLOBAL_VARS.db.reader.Read()
                Dim i As Integer = lsv.Items.Count
                With lsv
                    .Items.Add(GLOBAL_VARS.db.reader("id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("member_id").ToString())
                    .Items(i).SubItems.Add(GLOBAL_VARS.db.reader("fullname").ToString())
                End With
            End While
        End If
        GLOBAL_VARS.db.reader.Close()
    End Sub

    Public Sub savePastorInfo()
        Dim sql As String = "insert into tbl_host_pastor values (null,'" & Me.Pastor_name & "');"
        GLOBAL_VARS.db.executeNonReader(sql)
        Dim id As Integer = GLOBAL_VARS.db.getLastId()
        saveChurchOfficial(id)
    End Sub

    Public Sub saveChurchOfficial(member_id As Integer)
        Dim sql As String = "insert into tbl_church_officials values (" & Me.Member_id & ",'" & Me.Position & "'," & Me.Year & ");"
        GLOBAL_VARS.db.executeNonReader(sql)
    End Sub
   
End Class
