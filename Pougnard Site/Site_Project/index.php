<!doctype html>
<html>

<head>


  <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
<meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>PhotoBooth</title>

  <link rel="stylesheet" href="View/css/materialize.min.css">
  <link rel="stylesheet" href="View/css/style.css">
  <!--Import Google Icon Font-->
  <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
</head>

<body>
  <nav>
    <div class="nav-wrapper deep-purple darken-1">
      <a href="#" class="brand-logo center">PhotoBooth</a>
      <ul id="nav-mobile" class="left hide-on-med-and-down">
        <li><a href="#">Nous contacter</a></li>
      </ul>
      <ul class="right hide-on-med-and-down">
        <li><a class="waves-effect waves-dark deep-purple darken-3 btn" href="View/Pages/Signin.php">S'inscrire</a></li>
        <li><a class="waves-effect waves-dark deep-purple darken-3 btn" href="View/Pages/Login.html">Se connecter</a></li>
      </ul>
    </div>
  </nav>

  <div class="parallax-container">
   <div class="parallax">
     <img src="View/img/Code.jpg" alt="" class="responsive-img">
   </div>
 </div>



  <div class="carousel carousel-slider" data-indicators ="true">
    <div class="carousel-item" href="#one!">
      <img class="img_carousel" src="View/img/img.jpg">
    </div>
    <div class="carousel-item" href="#two!">
      <img src="View/img/img2.jpg">
    </div>
    <div class="carousel-item" href="#three!">
      <img src="View/img/img3.jpg">
    </div>
    <div class="carousel-item" href="#four!">
      <img src="View/img/img4.jpg">
    </div>
    <div class="carousel-item" href="#five!">
      <img src="View/img/img5.jpg">
    </div>
  </div>

 <div class="parallax-container">
  <div class="parallax">
    <img src="View/img/bg_2.jpg" alt="" class="responsive-img">
  </div>
</div>

<footer class="page-footer grey darken-3">
  <div class="container">
    <div class="row">
      <div class="col s12 l8">
        <h5>A propos</h5>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
           quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
           Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
           Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
        </p>
      </div>
      <div class="col s12 l4 offset-12">
        <h5>Réseaux Sociaux</h5>
        <br>
        <div class="row">

        <div class="col s12 l2 offset-12">
          <a href="https://www.facebook.com/" class="btn-floating btn-large purple darken-1 darken-3"><i class="fab fa-facebook"></i></a>
        </div>
        <div class="col s12 l2 offset-12">
          <a href="https://twitter.com/" class="btn-floating btn-large purple darken-1 darken-3"><i class="fab fa-twitter"></i></a>
        </div>
        <div class="col s12 l2 offset-12">
          <a href="https://www.instagram.com/?hl=en" class="btn-floating btn-large purple darken-1 darken-3"><i class="fab fa-instagram"></i></a>
      </div>
      <div class="col s12 l2 offset-12">
          <a href="https://www.linkedin.com/" class="btn-floating btn-large purple darken-1 darken-3"><i class="fab fa-linkedin"></i></a>
      </div>
    </div>
    </div>
  </div>
  <div class="footer-copyright grey darken-4">
    <div class="container center-align">&copy;2020 SaintMichelAnnecy</div>
  </div>
</footer>



  <!-- Compiled and minified JavaScript -->

  <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>

  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
<script src="Controler/js/materialize.min.js"></script>
<script src="https://kit.fontawesome.com/f97f9ece59.js" crossorigin="anonymous"></script>
  <script>
  $(document).ready(function(){
    $('.carousel').carousel({
      indicators:true
    });
      setInterval(function(){
        $('.carousel').carousel('next');
      },6000);
    $('.parallax').parallax();
  });
  </script>

</body>

</html>
