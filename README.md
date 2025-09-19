# 🛍️ Vinted Askov Bot

Un bot en **C# (.NET)** qui permet de **sniper automatiquement des articles sur Vinted** (UK, FR, …) et d’envoyer les résultats vers un **webhook Discord**.  
Le bot filtre les articles selon le **genre, le prix maximum, la taille**, et notifie en temps réel.

---

## ✨ Nouvelles (commit)
`git commit -m "Mise à jour du projet : ajout de la sauvegarde webhook, interface plus simple, a vous de choisir dans quel region le bot va snipe (fr, uk, etc)"`

### Changements récents
- Ajout de la **sauvegarde locale du webhook** (le webhook configuré est conservé pour les sessions suivantes).
- **Interface console simplifiée** (compteurs et messages plus lisibles).
- **Choix de la région** pour sniper : `fr`, `uk`, `de`, etc. — tu choisis la région au démarrage ou via la config.
- Divers correctifs et améliorations mineures.

---

## ✨ Fonctionnalités
- 🔎 Recherche automatisée d’articles sur **Vinted** (région configurable : `fr`, `uk`, …)
- 💰 Filtrage par **prix maximum**
- 🧍 Choix du **genre** : Homme ou Femme
- 📏 Sélection du **mode** (taille S, M, L ou sans taille)
- 🔁 Option : **sauvegarde du webhook** pour réutilisation sans re-saisie
- 🔔 Envoi des trouvailles directement sur **Discord via un webhook**
- ✅ Vérification de validité du webhook
- 📊 Interface console avec compteur :
  - Articles trouvés
  - Articles vérifiés
  - Erreurs détectées

---

## ⚙️ Installation
### Prérequis
- [Visual Studio](https://visualstudio.microsoft.com/) ou [dotnet SDK](https://dotnet.microsoft.com/download)
- .NET 6 ou supérieur
- Une connexion Internet


⚠️ Avertissement

Ce projet est à but éducatif. L’utilisation de bots peut être contraire aux conditions d’utilisation de certaines plateformes.
L’auteur n’est pas responsable de l’usage que vous en ferez.
