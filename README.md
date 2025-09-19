🛍️ Vinted Askov Bot

Un bot en C# (.NET) qui permet de sniper automatiquement des articles sur Vinted (UK, FR, …) et d’envoyer les résultats vers un webhook Discord.
Le bot filtre les articles selon le genre, le prix maximum, la taille, et notifie en temps réel.

✨ Nouvelles (commit)

git commit -m "Nouveau systeme de sécurité hwid ainsi que les historique de nos recherches prochainement un autobuy"

Changements récents

Ajout d’un système de sécurité HWID pour protéger le bot et gérer les licences.

Sauvegarde des historiques de recherches, permettant de suivre ce que le bot a déjà scanné.

Préparation pour un futur Autobuy (achat automatique des articles trouvés).

Divers correctifs et améliorations mineures.

✨ Fonctionnalités

🔎 Recherche automatisée d’articles sur Vinted (région configurable : fr, uk, …)

💰 Filtrage par prix maximum

🧍 Choix du genre : Homme ou Femme

📏 Sélection du mode (taille S, M, L ou sans taille)

🔁 Option : sauvegarde du webhook pour réutilisation sans re-saisie

🔔 Envoi des trouvailles directement sur Discord via un webhook

✅ Vérification de validité du webhook

🔐 Système HWID pour sécuriser l’usage du bot

📊 Historique des recherches sauvegardé

📊 Interface console avec compteur :

Articles trouvés

Articles vérifiés

Erreurs détectées

⚙️ Installation
Prérequis

Visual Studio
 ou dotnet SDK

.NET 6 ou supérieur

Une connexion Internet

⚠️ Avertissement
Ce projet est à but éducatif. L’utilisation de bots peut être contraire aux conditions d’utilisation de certaines plateformes.
L’auteur n’est pas responsable de l’usage que vous en ferez.
