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
  <a class="btn-floating btn-large waves-effect waves-light purple btn_home" href="DashBoard.html"><i class="fas fa-home"></i></a>
  <div class="row Signin">
    <div class="col s12 l5 offset-14">
      <div class="card">
        <div class="card-action purple white-text center">
          <h3>Demande de réservation</h3>
        </div>
        <div class="card-content">
          <form method="post">
          <div class="form-field">
            <span style="color: #8e24aa;margin-right: 2%;">
              <i class="fas fa-star fa-2x"></i>
            </span>
            <label for="pseudo">Nom de l'évenements :</label>
            <input type="text" placeholder="de 0 à 100 caractères..." id="pseudo" name="pseudo">
          </div>
          <br>
          <div class="form-field">
            <span style="color: #8e24aa;margin-right: 2%;">
              <i class="fas fa-lock fa-2x"></i>
            </span>
            <label for="mdp">Mot de passe de l'évenements :</label>
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
          <div class="row">
            <div class="col s12 m6">
              <span style="color: #8e24aa;margin-right: 2%;">
              <i class="fas fa-calendar-alt fa-2x"></i>
            </span>
              <label>Reserver du :</label>
              <input type="text" class="datepicker">
            </div>
            <div class="col s12 m6">
              <span style="color: #8e24aa;margin-right: 2%;">
              <i class="fas fa-calendar-alt fa-2x"></i>
            </span>
              <label>Jusqu'au :</label>
              <input type="text" class="datepicker">
            </div>
          </div>
          </div>
          <br>
          <div class="form-field center-align">
            <label><?php if(isset($erreur)) { echo $erreur; } ?></label><br>
            <input type="submit" class="btn-large purple" name="forminscription" value="Faire la demande"/>
          </form>
          </div>
          <br>
        </div>
      </div>
    </div>
  </div>
  <script src="https://kit.fontawesome.com/f97f9ece59.js" crossorigin="anonymous"></script>
  <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
  <script src="../../Controler/js/materialize.min.js"></script>
  <script>
    $(document).ready(function(){
      $('.datepicker').datepicker();
    });
  </script>
</body>

</html>
