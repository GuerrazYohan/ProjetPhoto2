# ProjetPhoto2

Le projet « PhotoBooth » a pour but de créer une borne photo autonome pour un professionnel situé à Annecy. Cette borne possèdera une interface homme machine permettant de prendre une photo et aura comme particularités :

-	Un site web (client/admin) pour permettre à un utilisateur de consulter les photos prisent 
-	Une application mobile pour permettre de partager ou de télécharger les photos depuis son téléphone 
-	Une base de données comportant les informations des comptes utilisateur, des chemins pour accéder aux photos ainsi que les seuils de luminosité pour contrôler les lumières de la machine.
-	Une interface homme machine pour contrôler l’appareil photo et générer le QR code de la photo 


# Charte graphique 
Lors de réflexions en groupe a la forme de nos applications, le style global de notre projet a été mis en avant : pour pouvoir répondre à ce problème, une charte graphique a été mise en place. Elle nous a permis de nous raccorder sur l’application a une couleur, une police, un logo, et des formes géométriques communes.

-	les couleurs 
Pour concevoir le design du projet nous avons utilisé comme couleur dominante le violet car elle est associée à la créativité. Cette couleur réfère à la connaissance, au fantastique, à l’imaginaire. Elle inspire des valeurs tel que la mélancolie, la solitude, la tristesse et la jalousie. 
Puis nous avons utilisé en couleur secondaire le bleu car cette couleur primaire est le symbole de la confiance. Le bleu est la couleur la plus utilisée pour les identités visuelles d’entreprise car porteuse de confiance, et de rêves. Elle représente le domaine du voyage et de l’évasion mais également celles des hautes technologies, de l’informatique et des réseaux sociaux.

-	Les formes géométriques dominantes 
Nous voulions apporter un sens de stabilité à notre projet, et lors de nos choix de formes, nous nous sommes orientés vers une structure et forme rectangulaire car elle amène un sentiment de stabilité. Cette forme symbolique est paisible, elle rend votre illustration plus statique. Elle repose sur son grand côté et s’étale sur l’horizon comme la mer, le panoramique.
Pour les icones et le logo de notre projet nous avons choisi une forme circulaire car elle représente le monde et l’éternité comme lorsque l’on prend une photo. 

-	Le Logo
Le logo symbolisant un objectif d’appareil photo, porte les initiales du projet. Le logo à du noir car cette couleur en communication permet de provoquer des contrastes et de mettre en valeur les couleurs qui l’accompagnent comme la couleur blanche des initiales qui en communication permet de clarifier un message et d’apporter des zones de repos visuel. Elle a cette force de pouvoir accompagner toutes les couleurs. Le multicolore autour de l’objectif représente toutes les émotions que l’on peut ressentir avec une photo.

# Partie Base de données et contrôle de luminosité (Webservice) Fasano Alexis
Pour le projet de PhotoBooth je suis charge de :
- crée et gérer la base de données.
- crée le web service permettant l’accès à la base de données à tout le monde en utilisant l’api Rest avec le Framework Slim.
- Fournir l’accès à une imprimante.
- Contrôler la luminosité des lumières situez sur la maquette en fonction de la luminosité extérieur.

# Partie Site Web Pougnard Corentin
La partie site web est coder en html/CSS/javascript et PHP le site permettra à l’utilisateur de :
-	Consulter les photos prises et de les récupérer sous forme numérique.
-	Se créer un compte.
-	Pouvoir faire une réservation de l’appareil après s’être connecter.
-	Permettre à un admin définit de gérer les demandes d’événement.
L’utilisateur pourra également : 
-  Modifier son profil
-  Contacter un support technique

# Partie Supervision Marie Teo
Ma partie dans ce projet consiste à créer l’interface Homme machine (IHM) de l’application.
Celle-ci consiste à contrôler l’appareil photo a l’aide de l’application. On doit pouvoir être capable de prendre des photos. De plus, la photo doit ensuite être affichée ce qui permettrai à l’utilisateur de pouvoir soit supprimer la photo ou l’enregistrer ou bien même d’afficher un QR code qui permettrai de télécharger la photo sur son smartphone.  

# Partie Application Mobile Guerraz Yohan
Le but de cette application mobile faite sous langage Xamarin, est de permettre à un utilisateur de :

-	Scanner un QR code pour récupérer une photo 
-	Télécharger la photo dans son téléphone 
-	Partager la photo sur les réseaux sociaux 

       L’utilisateur aura aussi la possibilité de : 

-	S’inscrire sur l’application
-	Modifier son profil 
-	Laisser un commentaire.
