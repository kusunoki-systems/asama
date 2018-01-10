Public Class S_GroupFacilityService

    '''' <summary>
    '''' 施設情報取得
    '''' </summary>
    '''' <param name="db"></param>
    '''' <param name="id"></param>
    '''' <returns></returns>
    'Public Function GetFacilityModel(db As AsamaEntities, id As String) As S_GroupFacility

    '    Dim mdl As S_GroupFacility = (From s As S_GroupFacility In db.S_GroupFacility
    '                                  Where s.SGFA_FacilityID = id And
    '                                     s.SGFA_DelFlag = 0 And
    '                                     s.SGFA_ValidDateFrom <= DateTime.Now And
    '                                     DateTime.Now <= s.SGFA_ValidDateTo
    '                                  Select s).FirstOrDefault

    '    Return mdl

    'End Function
End Class
