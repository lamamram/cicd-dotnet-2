# FORMATION USINE LOGICIELLE

## installation d'une vagrant box

* installer virtualbox & vagrant
* après redémarrage, ouvrir un powershell et tester: vagrant --version 
* installer le Vagrantfile dans le dossier de travail
* lancement de la VM
  1. vagrant box add mlamamra/myusine
  2. vagrant up
  3. vagrant ssh
  4. récipérer l' ip
  5. faire la réslution de nom dans ke fichier hosts

## commandes vagrant 

|cmd.              |desc.
|:----------------:|---------------------------
| vagrant -v       | affiche la version
| vagrant up       | exécute le Vagrantfile du doss courant
| vagrant halt     | stoppe la vm

## manipulation d'un dépôt local git

1. **initialisation**
  * git init : création du dépôt .git
  * git config : ajout du nom et email utilisateur (local ou global)

2. **créations de commits**
  * git add: ajout de modifs à l'index
  * git commit: validation des modifs de l'index dans le déôt


## Devops

* [voir ici](./parts/devops.md)

## agilité

1. origine: le cycle de développement en cascade
  * travail en silo
  * cycle prédictif
  * effet tunnel


<!-- div class="green">Markdown css styles</div -->
<div style="color: green">Markdown css styles</div>

<!--style>
.green { color: green;font-weight:700;font-size: 30px; }
</style-->