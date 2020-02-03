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
    if($pseudolength <= 20)
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
              $erreur = "Vos Adresses mails ne correspondent pas !";
            }
            }
            else {
              $erreur = "Votre Adresse mail ne correspond pas !";
            }
    }
    else {
      $erreur = "Votre pseudo ne doit pas depasser 20 caractère";
    }
  }
  else {
    $erreur = "Tous les champs doivent etre completer";
  }
}


 ?>
<html lang="en">

<head>
  <link rel="stylesheet" href="../css/materialize.min.css">
  <link rel="stylesheet" href="../css/style.css">
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>S'inscrire</title>
</head>

<body id="Body2">
  <a class="btn-floating btn-large waves-effect waves-light purple btn_home" href="../../index.php"><i class="fas fa-home"></i></a>
  <div class="row Signin">
    <div class="col s12 l5 offset-14">
      <div class="card">
        <div class="card-action purple white-text center">
          <h3>S'inscrire</h3>
        </div>
        <div class="card-content">
          <form method="post">
          <div class="form-field">
            <span style="color: #8e24aa;margin-right: 2%;">
              <i class="fas fa-user fa-2x"></i>
            </span>
            <label for="pseudo">Nom d'utilisateur</label>
            <input type="text" placeholder="de 0 à 20 caractères..." id="pseudo" name="pseudo" value="<?php if(isset($pseudo)) { echo $pseudo; } ?>">
          </div>
          <br>
          <div class="form-field">
            <span style="color: #8e24aa;margin-right: 2%;">
              <i class="fas fa-lock fa-2x"></i>
            </span>
            <label for="mdp">Mot de passe</label>
            <input type="password" id="mdp" name="mdp" >
          </div>
          <br>
          <div class="form-field">
            <span style="color: #8e24aa;margin-right: 2%;">
              <i class="fas fa-lock fa-2x"></i>
            </span>
            <label for="mdp2">Comfirmer Mot de passe</label>
            <input type="password" id="mdp2" name="mdp2">
          </div>
          <br>
          <div class="form-field">
            <span style="color: #8e24aa;margin-right: 2%;">
              <i class="fas fa-envelope fa-2x"></i>
            </span>
            <label for="mail">Email</label>
            <input type="email" id="mail" name="mail" value="<?php if(isset($mail)) { echo $mail; } ?>">
          </div>
          <br>
          <div class="form-field">
            <span style="color: #8e24aa;margin-right: 2%;">
              <i class="fas fa-envelope fa-2x"></i>
            </span>
            <label for="mail2">Comfirmer Email</label>
            <input type="email" id="mail2" name="mail2" value="<?php if(isset($mail2)) { echo $mail2; } ?>">
          </div>
          <br>
          <div class="form-field center-align">
            <label><?php if(isset($erreur)) { echo $erreur; } ?></label><br>
            <input type="submit" class="btn-large purple" name="forminscription" value="Je m'inscris !"/>
          </form>
          </div>
          <br>
        </div>
      </div>
    </div>
  </div>
  <script src="https://kit.fontawesome.com/f97f9ece59.js" crossorigin="anonymous"></script>
  <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
  <script src="../js/materialize.min.js"></script>
</body>

</html>
