Public Class MsgTextFr
    Public ReadOnly MsgErrServ As String = "Une erreur est survenu durant l'enregistrement sur le serveur!"
    Public ReadOnly MsgErrServFacture As String = "Une erreur est survenu durant l'enregistrement de la facture!"
    Public ReadOnly MsgErrTBVide As String = "Attention vous devez mettre "
    Public ReadOnly MsgErrVersion As String = "La version du programme n'est plus a jour, vous devez le mette à jour pour continuer!"
    Public ReadOnly MsgErrTropCaractere1 As String = "est trop long! Vous ne pouvez pas mettre plus de "
    Public ReadOnly MsgErrTropCaractere2 As String = " caratère dans cet champ!"
    Public ReadOnly MsgSauv As String = "Sauvegarde effectuer"
    Public ReadOnly MsgMissNom As String = "Vous devez rentrer un nom!"
    Public ReadOnly MsgMissPrenom As String = "Vous devez rentrer un prénom!"
    Public ReadOnly MsgMissAddresse As String = "Vous ne pouvez pas rentrer une adresse partielle!"
    Public ReadOnly msgMissTelephone As String = "Vous devez mettre un numéro de téléphone"
    Public ReadOnly MsgSauvServ As String = "Enregistrement effectuer avec succès"
    Public ReadOnly MsgMissModel As String = "Créer un model avant faire vente"
    Public ReadOnly MsgMissCoulModel As String = "Aucune couleur associé à ce model"
    Public ReadOnly MsgAnnulerContrat As String = "Voulez-vous vraiment annuler ce contrat?"
    Public ReadOnly MsgCreationCoul As String = "La création de la nouvelle couleur réussit!"
    Public ReadOnly MsgMissCodeCoul As String = "La couleur doit avoir un code!"
    Public ReadOnly MsgMissNomCoul As String = "La couleur doit avoir un nom!"

    Shared instance As MsgTextFr = Nothing

    Shared Function Getinstance() As MsgTextFr
        If IsNothing(instance) Then
            instance = New MsgTextFr
        End If
        Return instance
    End Function
End Class
