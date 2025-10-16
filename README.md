# 🛍️ Vinted Askov Bot

Un bot en **C# (.NET)** permettant de **sniper automatiquement** des articles sur [Vinted](https://www.vinted.fr/) (UK, FR, …) et d’envoyer les résultats vers un **webhook Discord**.  
L’outil permet de filtrer les articles selon différents critères (genre, prix, taille, etc.) et de recevoir les résultats en temps réel.

---

## ✨ Nouveautés – Version 2.5

- 🔐 **Système de sécurité HWID** pour protéger l’accès et gérer les licences.  
- 🧾 **Sauvegarde de l’historique des recherches** pour éviter les doublons et suivre les articles déjà scannés.  
- 🛒 Préparation de la future fonctionnalité **AutoBuy** (achat automatique).  
- 🐞 Divers **correctifs et améliorations de performance**.

---

## ⚡ Fonctionnalités principales

- 🔎 **Sniper automatique** d’articles Vinted (multi-région : FR, UK, …)  
- 💰 **Filtrage** par prix maximum  
- 🧍 Choix du **genre** (Homme / Femme)  
- 📏 Sélection du **mode de taille** (S, M, L ou sans taille)  
- 🔁 **Sauvegarde du webhook Discord** pour réutilisation  
- 🔔 Notification en temps réel sur Discord  
- ✅ Vérification automatique de la validité du webhook  
- 🧠 Système **HWID** pour sécuriser l’accès  
- 📊 Historique des recherches sauvegardé  
- 📈 Interface console avec compteur :
  - Articles trouvés
  - Articles vérifiés
  - Erreurs détectées

---

## 🧰 Installation

### Prérequis
- [Visual Studio](https://visualstudio.microsoft.com/) **ou** [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- .NET 6 ou supérieur
- Connexion Internet

### Étapes d’installation
1. Clonez le dépôt :
   ```bash
   git clone https://github.com/Den1sMd/VintedBot.git
