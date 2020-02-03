<!DOCTYPE html>
<?php

$bdd = new PDO('mysql:host=127.0.0.1;dbname=espace_membre', 'root', '');

if(isset($_POST['forminscription']))
{
  /*initialisation des variables*/
  $pseudo = htmlspecialchars($_POST['pseudo']);
  $mail = htmlspecialchars($_POST['mail']);
  $mail2 = htmlspecialchars($_POST['mail2']);
  $mdp = sha1($_POST['mdp']);
  $mdp2 = sha1($_POST['mdp2']);


  if(!empty($_POST['pseudo']) AND !empty($_POST['mail']) AND !empty($_POST['mail2']) AND !empty($_POST['mdp']) AND !empty($_POST['mdp2']))
  {
    $pseudolength = strlen($pseudo);
    if($pseudolength <= 255)
    {
      /*Vérification de la comformiter des deux email*/
            if($mail == $mail2)
            {
              /*On s'assure que l'asdresse mail est valide*/
              if(filter_var($mail, FILTER_VALIDATE_EMAIL))
              {
                /*Vérification de la comformiter des Mot de passe*/
                if($mdp == $mdp2)
                {
                  /*Envoie des données du formulaire à la BDD*/
                    $insertmbr = $bdd->prepare("INSERT INTO membres(pseudo , mail , motdepasse) VALUES(?,?,?)");
                    $insertmbr->execute(array($pseudo, $mail, $mdp));
                    $erreur = "Votre Compte a bien été créer";
                }
                else {
                  $erreur = "Vos mot de passe ne correspondent pas !";
                }
            }
            else {
              $erreur = "Votre Adresse mail n'est pas Valide !";
            }
            }
            else {
              $erreur = "Votre Adresse mail ne correspond pas !";
            }
    }
    else {
      $erreur = "Votre pseudo ne doit pas depasser 255 caractère";
    }
  }
  else {
    $erreur = "Tous les champs doivent etre completer";
  }
}


 ?>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>Document</title>
</head>

<body>

  <div align="center">
    <h3>Inscription</h3>
    <br><br><br>
    <form method="post" action="">
      <table>
        <tr>
          <td align="right">
            <label for="pseudo">Pseudo :</label>
          </td>
          <td align="right">
            <input type="text" placeholder="votre pseudo" id="pseudo" name="pseudo" value="<?php if(isset($pseudo)) { echo $pseudo; } ?>" />
          </td>
        </tr>
        <tr>
          <td align="right">
            <label for="mail">Mail :</label>
          </td>
          <td align="right">
            <input type="email" placeholder="votre mail" id="mail" name="mail" value="<?php if(isset($mail)) { echo $mail; } ?>" />
          </td>
        </tr>
        <tr>
          <td align="right">
            <label for="mail2">Comfirmation du mail :</label>
          </td>
          <td align="right">
            <input type="email" placeholder="votre mail" id="mail2" name="mail2" value="<?php if(isset($mail2)) { echo $mail2; } ?>"/>
          </td>
        </tr>
        <tr>
          <td align="right">
            <label for="mdp">Mot de Passe :</label>
          </td>
          <td align="right">
            <input type="password" placeholder="votre mdp" id="mdp" name="mdp" />
          </td>
        </tr>
        <tr>
          <td align="right">
            <label for="mdp2">Comfirmer Mot de Passe :</label>
          </td>
          <td align="right">
            <input type="password" placeholder="comfirmer votre mdp" id="mdp2" name="mdp2" />
          </td>
        </tr>
      </table>
      <input type="submit" name="forminscription" value="je m'inscris"/>
    </form>
    <?php
    if(isset($erreur))
    {
      echo '<font color="red">'.$erreur.'</font>';
    }
     ?>
  </div>

  </div>
</body>

</html>
