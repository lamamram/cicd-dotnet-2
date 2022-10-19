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

## manipulation d'un dépôt local git

1. initialisation
  1. git init : création du dépôt .git
  2. git config : ajout du nom et email utilisateur (local ou global)