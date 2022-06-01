Public Class MsgTextFr
    Public ReadOnly MsgErrConnectionServ As String = "Impossible de se connecter au serveur!"
    Public ReadOnly MsgStillErrConcServ As String = "Toujours impossible de se connecter au serveur!"
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
    Public ReadOnly MsgMissTelephone As String = "Vous devez mettre un numéro de téléphone"
    Public ReadOnly MsgSauvServ As String = "Enregistrement effectuer avec succès"
    Public ReadOnly MsgMissModel As String = "Créer un model avant faire vente"
    Public ReadOnly MsgMissCoulModel As String = "Aucune couleur associé à ce model"
    Public ReadOnly MsgAnnulerContrat As String = "Voulez-vous vraiment annuler ce contrat?"
    Public ReadOnly MsgCreationCoul As String = "La création de la nouvelle couleur réussit!"
    Public ReadOnly MsgMissCodeCoul As String = "La couleur doit avoir un code!"
    Public ReadOnly MsgMissNomCoul As String = "La couleur doit avoir un nom!"
    Public ReadOnly MsgMissNoSerie As String = "Vous devez mettre un numéro de série"
    Public ReadOnly MsgErrOptionPiece As String = "Une erreure est survenue durant l'enregistrement des pièces associer aux option!"
    Public ReadOnly MsgMissIdNom As String = "Le id du nouveau produit et le nom du produit doit être remplie obligatoirement!"
    Public ReadOnly MsgIdExiste As String = "Ce ID de produit existe déjà!"
    Public ReadOnly MsgMissTitre As String = "Vous devez avoir un titre de mit!"
    Public ReadOnly MsgTitreTropLong As String = "Le titre est trop long! (Maximun de 100 caratères)"
    Public ReadOnly MsgSauvItemErrQuantite As String = "Le changement des items pour le model c'est effectué correctement, mais une erreure c'est produit durant le changement des quantités des items"
    Public ReadOnly MsgSauvQuantiteErrItem As String = "Le changement des quantités des items c'est effectué correctement, mais une erreure c'est produit durant l'enregistrement des produits."
    Public ReadOnly MsgConfirSauv As String = "Voulez-vous sauvegarder les modifications que vous avez apporté?"
    Public ReadOnly MsgTousFour As String = "Ce produit a tous les fournisseurs!"
    Public ReadOnly MsgAucunFour As String = "Ce produit n'a pas de fournisseur!"
    Public ReadOnly MsgSupp As String = "La suppression à bien été fait!"
    Public ReadOnly MsgIncorectUserPass As String = "Nom d'utilisatuer ou mot de passe incorrecte!"
    Public ReadOnly MsgExitProg As String = "Voulez-vous vraiment fermer le programme?"
    Public ReadOnly MsgAttention As String = "Attention!"
    Public ReadOnly MsgConfirSupp As String = "Voulez-vous vraiment supprimer "
    Public ReadOnly MsgIrreversible As String = "(Cette action est irréversible)"
    Public ReadOnly MsgConfirSuppFour1 As String = "Voulez-vous vraiment supprimer ce fournisseur: "
    Public ReadOnly MsgConfirSuppFour2 As String = "Êtes-vous sûr que vous voulez vraiment le supprimer: "
    Public ReadOnly MsgErrSupp As String = "Une erreure est survenu durant la suppression"
    Public ReadOnly MsgModServ As String = "La modification à bien été fait"
    Public ReadOnly MsgNoIdProduit As String = "Le numéro d'item n'existe pas!"
    Public ReadOnly MsgChangePrio As String = "Changement des priorité fait avec succès!"
    Public ReadOnly MsgConfirSuppTache As String = "Voulez-vous vraiment supprimer cette tâche?"
    Public ReadOnly MsgErrServCoulSupp As String = "Une erreur est survenu durant l'enregistrement des couleurs supplémentaire!"

    Shared instance As MsgTextFr = Nothing

    Shared Function Getinstance() As MsgTextFr
        If IsNothing(instance) Then
            instance = New MsgTextFr
        End If
        Return instance
    End Function
End Class
