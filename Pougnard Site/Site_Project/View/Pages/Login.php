<!DOCTYPE html>
<html lang="en">

<head>
  <link rel="stylesheet" href="../css/materialize.min.css">
  <link rel="stylesheet" href="../css/style.css">
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>Document</title>
</head>

<body id="Body1">
  <a class="btn-floating btn-large waves-effect waves-light purple btn_home" href="../../index.php"><i class="fas fa-home"></i></a>
  <!-- CSS A changer de place  -->
  <div class="row login">
    <div class="col s12 l5 offset-14">
      <div class="card">
        <div class="card-action purple white-text center">
          <h3>Se connecter</h3>
        </div>
        <div class="card-content">
          <div class="form-field">
            <span style="color: #8e24aa;margin-right: 2%;">
              <i class="fas fa-user fa-2x"></i>
            </span>
            <label for="username">Username</label>
            <input type="text" id="username">
          </div>
          <br>
          <div class="form-field">
            <span style="color: #8e24aa;margin-right: 2%;">
              <i class="fas fa-lock fa-2x"></i>
            </span>
            <label for="password">Password</label>
            <input type="text" id="password">
          </div>
          <br>
          <p>
            <label>
              <input type="checkbox" class="checkbox_remember" />
              <span>Remember me</span>
            </label>
          </p>
          <br>
          <div class="form-field center-align">
            <a href="DashBoard.html"><button class="btn-large waves-effect purple">Se connecter</button></a>
          </div>
          <br>
        </div>
      </div>
    </div>
  </div>
  <script src="https://kit.fontawesome.com/f97f9ece59.js" crossorigin="anonymous"></script>
  <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
  <script src="../../Controler/js/materialize.min.js"></script>
</body>

</html>
