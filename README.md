---
title: "README"
author: "matt LAMAM"
date: "2022-10-21"
output: html_document
---
# FORMATION USINE LOGICIELLE

## installation d'une box vagrant[^1]

* installer virtualbox & vagrant
* après redémarrage, ouvrir un powershell et tester: `vagrant --version` 
* installer le Vagrantfile dans le dossier de travail
* lancement de la VM
  1. `vagrant box add mlamamra/myusine`
  2. `vagrant up`
  3. `vagrant ssh`
  4. récupérer l' ip
  5. faire la réslution de nom dans le fichier hosts[^2]

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

```html
<style>
.green {
    color: green;
    font-weight:700;
    font-size: 30px;
}
</style>
```

<div class="green">
    Markdown css styles
</div>

[^1]: après install de virtualbox et vagrant

[^2]: dans `C:\Windows\System32\drivers\etc\hosts`
      ou `/etc/hosts` sous Unix