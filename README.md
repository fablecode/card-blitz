[![NuGet](https://img.shields.io/nuget/v/CardBlitz)](https://www.nuget.org/packages/CardBlitz)
[![License](https://img.shields.io/github/license/fablecode/card-blitz)](LICENSE)
[![Build Status](https://dev.azure.com/fablecode/Yugioh/_apis/build/status%2Ffablecode.card-blitz?branchName=main)](https://dev.azure.com/fablecode/Yugioh/_build/latest?definitionId=22&branchName=main)

# 🎴 Card Blitz

**Card Blitz** is a powerful NuGet package designed to simplify access to **Yu-Gi-Oh! card data** from multiple sources. Whether you’re developing a dueling app, a card management tool, or a fan site, Card Blitz is your go-to solution for fast and accurate card information.

---

## 🚀 Features

- 🔄 Real-time card data from multiple sources.
- 🃏 Access to detailed Yu-Gi-Oh! card information, including names, types, attributes, and more.
- 💡 Easy to integrate with your .NET applications.
- 🔍 Perfect for building card search tools, deck management apps, and more.

---

## 📦 Installation

Install via NuGet Package Manager:

```bash
Install-Package CardBlitz
```

## 🛠️ Usage
Here's how to start using Card Blitz to fetch card data:
1. Initialize the service
```csharp
using CardBlitz;

var cardService = new YugiohCardService(new List<ICardDataSource>
{
    new DataSourceA(), // Replace with actual data sources
    new DataSourceB()
});
```
2. Fetch card data by card number
```csharp
var cardData = cardService.GetCardData("12345");
Console.WriteLine($"Card Name: {cardData.Name}");
```
## 💻 Contributing
We welcome contributions! To contribute:

Fork the repository.
- Create a feature branch (`git checkout -b feature-name`).
- Commit your changes (`git commit -am 'Add new feature'`).
- Push to the branch (`git push origin feature-name`).
- Create a new Pull Request.

## 📄 License
This project is licensed under the MIT License. See the LICENSE file for details.

## 👥 Community & Support
For questions or support, feel free to:
- Open an issue
- Join our discussions

Made with ❤️ by fablecode
